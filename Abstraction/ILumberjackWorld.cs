using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberRacer
{
    public interface ILumberjackWorld
    {
        Image ViewCamera();

        void SetMonitorScreen(Image monitorScreen);

        void SendKeyboardCommand(KeyCommand command);
        void SetView(int width, int height);

        void Log(string message);
        event EventHandler OnLog;
    }
}
