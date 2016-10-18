using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LumberRacer
{
    class ImageAnalyzer
    {
        private Bitmap _image;

        public static Color ColorTreeDark = Color.FromArgb(161, 117, 56);
        public static Color ColorBlouse = Color.FromArgb(208, 70, 60);
        public static Color ColorLeaf = Color.FromArgb(159, 208, 109);
        public static Color ColorBread = Color.Black;

        public Bitmap Image
        {
            get { return _image; }
            set
            {
                _image = value;
                Height = _image.Height;
                Width = _image.Width;
            }
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public int StepX { get; set; }
        public int StepY { get; set; }

        public int BeamSize { get; set; } = 5;

        public int GridSize { get; set; } = 2;

        public Point Bread { get; set; }
        public Point TreeRoot { get; set; }

        public List<Point> Leafs { get; set; } = new List<Point>();

        

        public List<KeyCommand> GetKeyCommands()
        {
            var commands = new List<KeyCommand>();

            if (Leafs.Count < 2)
                return new List<KeyCommand>() {KeyCommand.Left};

            var vStep = Leafs[1].Y - Leafs[0].Y;

            var headToFirstLeaf = Bread.Y - Leafs[0].Y;

            var freeSteps = headToFirstLeaf/vStep;

            for (var i = 0 ; i < freeSteps ; i++)
            {
                commands.Add(GetCommandForLeaf(Leafs[0]));
            }

            foreach (var leaf in Leafs)
            {
                commands.Add(GetCommandForLeaf(leaf));
            }

            return commands;
        }

        private KeyCommand GetCommandForLeaf(Point leaf)
        {
            if (leaf.X > TreeRoot.X)
                return KeyCommand.Left;
            else
                return KeyCommand.Right;
        }

        public void LocateParts()
        {
            TreeRoot = new Point(Width, Height);

            for (var x = BeamSize+1; x < Width-BeamSize-1; x += GridSize)
            {

                for (var y = BeamSize + 1; y < Height-BeamSize - 1; y += GridSize)
                {
                    var location = new Point(x, y);
                    var real = RealPoint(location);
                    var color = PickBeamColor(real, BeamSize);

                    if (AreColorsNear(color, ColorBread))
                    {
                        Bread = location;
                    }
                }
            }

            TreeRoot = new Point(Width, Height);
            for (var x = Bread.X; x > BeamSize; x -= GridSize)
            {
                    var y = Bread.Y;

                    var location = new Point(x, y);
                    var real = RealPoint(location);
                    var color = PickBeamColor(real, BeamSize);

                    if (AreColorsNear(color, ColorTreeDark))
                    {
                        TreeRoot = location;
                    }
            }
            TreeRoot = new Point(TreeRoot.X, Bread.Y);

            var leafSeen = false;
            for (var y = TreeRoot.Y; y < Height - BeamSize-1; y += GridSize)
            {
                var found = false;
                Point location = default(Point);
                for (var xOffset = GridSize; TreeRoot.X + xOffset < Width-BeamSize && TreeRoot.X - xOffset > BeamSize; xOffset+=GridSize)
                {
                    var x = TreeRoot.X;
                    var locationLeft = new Point(x-xOffset, y);
                    var realLeft = RealPoint(locationLeft);
                    var colorLeft = PickBeamColor(realLeft, BeamSize);

                    if (AreColorsNear(colorLeft, ColorLeaf))
                    {
                        location = locationLeft;
                        found = true;
                        break;
                    }

                    var locationRight = new Point(x+xOffset, y);
                    var realRight = RealPoint(locationRight);
                    var colorRight = PickBeamColor(realRight, BeamSize);

                    if (AreColorsNear(colorRight, ColorLeaf))
                    {
                        location = locationRight;
                        found = true;
                        break;
                    }
                }

                if (found && !leafSeen)
                    Leafs.Add(location);

                leafSeen = found;
            }
        }

        public Point RealPoint(Point point)
        {
            return new Point(point.X, Height - point.Y);
        }

        public Point NormalPoint(Point point)
        {
            return new Point(point.X, Height - point.Y);
        }

        public bool AreColorsNear(Color left, Color right)
        {
            var dif = (Math.Abs(left.R - right.R) + Math.Abs(left.G - right.G) + Math.Abs(left.B - right.B))/3;
            return dif < 20;
        }

        public Color PickBeamColor(Point location, int radius)
        {
            var colors = new List<Color>();
            
            colors.Add(PickPixelColor(location));
            colors.Add(PickPixelColor(new Point(location.X, location.Y + radius)));
            colors.Add(PickPixelColor(new Point(location.X + radius, location.Y)));
            colors.Add(PickPixelColor(new Point(location.X + radius, location.Y + radius)));

            colors.Add(PickPixelColor(new Point(location.X, location.Y - radius)));
            colors.Add(PickPixelColor(new Point(location.X - radius, location.Y)));
            colors.Add(PickPixelColor(new Point(location.X - radius, location.Y - radius)));

            return Color.FromArgb((int) colors.Average(c => c.R), (int) colors.Average(c => c.G), (int) colors.Average(c => c.B));
        }

        public Color PickPixelColor(Point location)
        {
            //var realPoint = RealPoint(location);
            var pixel = Image.GetPixel(location.X, location.Y);
            return pixel;
        }

    }
}
