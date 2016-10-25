using System;
using System.Drawing;
using System.Windows.Forms;
using ScreenShotDemo;

namespace LumberRacer
{
    public class SimpleWorld : ILumberjackWorld
    {
        public SimpleWorld()
        {
           Camera = new ScreenCapture();
        }

        private ScreenCapture Camera { get; set; }
        public int ViewWidth { get; set; } = 600;
        public int ViewHeight { get; set; } = 800;

        private Image _monitorScreen;

        public void SetView(int width, int height)
        {
            ViewWidth = width;
            ViewHeight = height;
        }

        public Image ViewCamera()
        {
            return _monitorScreen ?? Camera.SeeHere(ViewWidth, ViewHeight);
        }

        public void SetMonitorScreen(Image monitorScreen)
        {
            this._monitorScreen = monitorScreen;
        }

        public void SendKeyboardCommand(KeyCommand command)
        {
            if (command == KeyCommand.Left)
                SendKeys.Send("{LEFT}");
            if (command == KeyCommand.Right)
                SendKeys.Send("{RIGHT}");
        }

        public void Log(string message)
        {
            OnLog?.Invoke(message, null);
        }

        public event EventHandler OnLog;
    }
}
