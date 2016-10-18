using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenShotDemo;

namespace LumberRacer
{
    public partial class LumberRacerForm : Form
    {
        public LumberRacerForm()
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
                        BeamSize = int.Parse(numericUpDownBeamSize.Text)
                    };

                    
                    if (lookForGame)
                    {
                        AnalyzeParts(analyzer);

                        if (analyzer.Leafs.Any() && !gameFound)
                        {
                            gameFound = true;
                            Log("Game found.");
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

                            foreach (var command in commands)
                            {
                                str = $"{str}, {(command == KeyCommand.Left ? "L" : "R")}";
                            }

                            Log(str);
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
                BeamSize = (int)numericUpDownBeamSize.Value
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
