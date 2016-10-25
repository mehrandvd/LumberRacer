using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenShotDemo;
using Timer = System.Windows.Forms.Timer;

namespace LumberRacer
{
    public partial class LumberRacerFormOld : Form
    {
        public LumberRacerFormOld()
        {
            InitializeComponent();
        }

        private bool lookForGame = false;
        private bool gameFound = false;
        private bool playGame = false;
        Timer timer;



        private void AnalyzeParts(ImageAnalyzer analyzer)
        {
            analyzer.LocateParts();
        }

        public void Log(string text)
        {
            listLog.Items.Insert(0, text);
        }

        private void btnStartEye_Click(object sender, EventArgs e)
        {
            lookForGame = !lookForGame;
            btnStartEye.Text = lookForGame ? "Stop looking" : "Look for game";
        }

        private void StartWatching()
        {
            timer = new Timer()
            {
                Interval = (int) numericUpDownRefreshRate.Value
            };

            timer.Tick += (o, args) =>
            {
                timer.Stop();
                Image img;
                using (ScreenCapture sc = new ScreenCapture())
                {
                    img = sc.SeeHere(trackBarHorizontal.Value, trackBarVertical.Value);

                    var analyzer = new ImageAnalyzer()
                    {
                        Image = new Bitmap(img),
                        BeamSize = (int)numericUpDownBeamSize.Value,
                        ColorPrecision = (int)numericUpDownColorPrecision.Value,
                        GridSize = (int)numericUpDownGridSize.Value
                    };

                    var location = new Point(analyzer.Width/2, analyzer.Height/2);
                    sc.Graphics.DrawString("X", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), new SolidBrush(Color.Black), location);
                    var centerColor = analyzer.PickBeamColor(location, analyzer.BeamSize);
                    panelSelectedColor.BackColor = centerColor;
                    textBoxR.Text = analyzer.GetColorDistance(ImageAnalyzer.ColorTreeDark, centerColor).ToString();
                    //textBoxG.Text = centerColor.G.ToString(); ;
                    //textBoxB.Text = centerColor.B.ToString(); ;

                    if (lookForGame)
                    {
                        AnalyzeParts(analyzer);

                        if (analyzer.Leafs.Any() && !gameFound)
                        {
                            gameFound = true;

                            Log("Game found.");
                            var commands = analyzer.GetKeyCommands();
                            Log($"Free Steps: {analyzer.FreeSteps}");
                            var str = string.Empty;
                            foreach (var command in commands)
                            {
                                str = $"{str}, {(command == KeyCommand.Left ? "L" : "R")}";
                            }
                            Log(str);
                            Application.DoEvents();
                        }

                        if (!analyzer.Leafs.Any() && gameFound)
                        {
                            gameFound = false;
                            Log("Game lost.");
                            
                        }

                        var leafPen = new Pen(Color.Orange, 10);
                        var brush = new SolidBrush(Color.Black);
                        foreach (var p in analyzer.Leafs.Select(p => analyzer.NormalPoint(p)))
                        {
                            sc.Graphics.DrawString("Leaf", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, p);
                        }

                        var bread = analyzer.RealPoint(analyzer.Bread);
                        var tree = analyzer.RealPoint(analyzer.TreeRoot);

                        sc.Graphics.DrawString("Head", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, bread);
                        sc.Graphics.DrawString("Tree", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, tree);

                        if (gameFound && playGame)
                        {
                            var commands = analyzer.GetKeyCommands();
                            var str = string.Empty;
                            pictureBoxLost.Image = img;
                            foreach (var command in commands)
                            {
                                if (command == KeyCommand.Left)
                                    SendKeys.Send("{LEFT}");
                                if (command == KeyCommand.Right)
                                    SendKeys.Send("{RIGHT}");
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(300);
                        }


                    }
                    pictureBoxEye.Image = img;
                    Application.DoEvents();


                }

                timer.Interval = (int) numericUpDownRefreshRate.Value;
                timer.Start();
            };

            timer.Start();
        }

        private void LumberRacerForm_Load(object sender, EventArgs e)
        {
            StartWatching();
        }

        private void pictureBoxEye_MouseClick(object sender, MouseEventArgs e)
        {
            var position = new Point(e.X, e.Y);
            var analyzer = new ImageAnalyzer()
            {
                Image = new Bitmap(pictureBoxEye.Image),
                BeamSize = (int)numericUpDownBeamSize.Value,
                ColorPrecision = (int)numericUpDownColorPrecision.Value,
                GridSize = (int)numericUpDownGridSize.Value
            };

            //var position = pictureBoxEye.PointToClient(new Point(e.X, e.Y));
            var point = analyzer.RealPoint(position);


            //var color = analyzer.PickPixelColor(position);
            var color = analyzer.PickBeamColor(position, (int)numericUpDownBeamSize.Value);

            panelSelectedColor.BackColor = color;

            textBoxR.Text = color.R.ToString();
            textBoxG.Text = color.G.ToString();
            textBoxB.Text = color.B.ToString();

            if (analyzer.AreColorsNear(color, ImageAnalyzer.ColorTreeDark))
                Log("Tree");

            if (analyzer.AreColorsNear(color, ImageAnalyzer.ColorBlouse))
                Log("Blouse");

            if (analyzer.AreColorsNear(color, ImageAnalyzer.ColorBread))
                Log("Bread");

            if (analyzer.AreColorsNear(color, ImageAnalyzer.ColorLeaf))
                Log("Leaf");

            AnalyzeParts(analyzer);
        }

        private void LumberRacerForm_Deactivate(object sender, EventArgs e)
        {
            playGame = true;
        }

        private void LumberRacerForm_Activated(object sender, EventArgs e)
        {
            playGame = false;
        }
    }
}
