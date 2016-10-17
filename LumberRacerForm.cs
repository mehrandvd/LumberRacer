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


        private void pictureBoxEye_MouseClick(object sender, MouseEventArgs e)
        {
            var position = new Point(e.X, e.Y);
            var analyzer = new ImageAnalyzer()
            {
                Image = new Bitmap(pictureBoxEye.Image),
                BeamSize = trackBarBeamSize.Value
            };

            //var position = pictureBoxEye.PointToClient(new Point(e.X, e.Y));
            var point = analyzer.RealPoint(position);


            //var color = analyzer.PickPixelColor(position);
            var color = analyzer.PickBeamColor(position, trackBarBeamSize.Value);

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

        private void AnalyzeParts(ImageAnalyzer analyzer)
        {
            analyzer.LocateParts();

            var bread = analyzer.RealPoint(analyzer.Bread);
            var tree = analyzer.RealPoint(analyzer.TreeRoot);


            panelHead.Left = bread.X;
            panelHead.Top = bread.Y;

            panelTree.Left = tree.X;
            panelTree.Top = tree.Y;

            foreach (var p in analyzer.Leafs)
            {
                Log(p.X < analyzer.TreeRoot.X ? "Left" : "Right");
            }
        }


        public void Log(string text)
        {
            listLog.Items.Insert(0, text);
        }

        private void btnStartEye_Click(object sender, EventArgs e)
        {
            Timer t = new Timer()
            {
                Interval = 200
            };

            t.Tick += (o, args) =>
            {
                ScreenCapture sc = new ScreenCapture();
                // capture entire screen, and save it to a file

                Image img = sc.CaptureScreen();

                //Image img = sc.SaveScreen(
                //    Cursor.Position.X,
                //    Cursor.Position.Y,
                //    400,
                //    400);


                // display image in a Picture control named imageDisplay
                pictureBoxEye.Image = img;
                // capture this window, and save it
                //sc.CaptureWindowToFile(this.Handle, "C:\\temp2.bmp", ImageFormat.Bmp);

                var analyzer = new ImageAnalyzer()
                {
                    Image = new Bitmap(pictureBoxEye.Image),
                    BeamSize = trackBarBeamSize.Value
                };

                AnalyzeParts(analyzer);

            };

            t.Start();
        }
    }
}
