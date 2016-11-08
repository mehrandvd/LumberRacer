using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace LumberRacer.SimpleRacer
{
    public class SimplePlayer : ILumberjackPlayerAlgorithm
    {
        private ILumberjackWorld world;
        private readonly Timer _decisionerTimer;

        public Image RequestedMonitorImage { get; private set; }
        public bool IsGameStarted { get; set; } = false;
        public bool IsGameFound { get; set; } = false;
        public bool IsPlayStarted { get; set; } = false;

        public SimplePlayer()
        {
            _decisionerTimer = new Timer
            {
                Interval = 1
            };
            _decisionerTimer.Tick += DecisionerTimerOnTick;
        }

        private void DecisionerTimerOnTick(object sender, EventArgs eventArgs)
        {
            _decisionerTimer.Enabled = false;
            var algorimConfig = (SimpleRacerConfig)AlgorithmConfig;
            var img = world.ViewCamera();

            var analyzer = new ImageAnalyzer()
            {
                Image = new Bitmap(img),
                BeamSize = algorimConfig.BeamSize,
                ColorPrecision =algorimConfig.ColorPrecision,
                GridSize = algorimConfig.GrdidingSize
            };

            using (var graphics = Graphics.FromImage(img))
            {
                var centerLocation = new Point(analyzer.Width / 2, analyzer.Height / 2);
                graphics.DrawString("X", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), new SolidBrush(Color.Black), centerLocation);

                if (IsGameStarted)
                {
                    analyzer.LocateParts();

                    if (analyzer.Leafs.Any() && !IsGameFound)
                    {
                        IsGameFound = true;

                        Log("Game found.");
                        var commands = analyzer.GetKeyCommands();
                        Log($"Free Steps: {analyzer.FreeSteps}");
                        var str = string.Empty;
                        var lowRiskCommandCount = commands.Count>0 ? commands.Count-1 : 0;
                        foreach (var command in commands.Take(lowRiskCommandCount))
                        {
                            str = $"{str}, {(command == KeyCommand.Left ? "L" : "R")}";
                        }
                        Log(str);
                        Application.DoEvents();
                    }

                    if (!analyzer.Leafs.Any() && IsGameFound)
                    {
                        IsGameFound = false;
                        Log("Game lost.");

                    }

                    var leafPen = new Pen(Color.Orange, 10);
                    var brush = new SolidBrush(Color.Black);
                    foreach (var p in analyzer.Leafs.Select(p => analyzer.NormalPoint(p)))
                    {
                        graphics.DrawString("Leaf", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, p);
                    }

                    var bread = analyzer.RealPoint(analyzer.Bread);
                    var tree = analyzer.RealPoint(analyzer.TreeRoot);

                    graphics.DrawString("Head", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, bread);
                    graphics.DrawString("Tree", new Font(FontFamily.GenericMonospace, 10, FontStyle.Bold), brush, tree);
                    if (IsGameFound && IsPlayStarted)
                    {
                        var commands = analyzer.GetKeyCommands();
                        var str = string.Empty;
                        RequestedMonitorImage = img;
                        foreach (var command in commands)
                        {
                            if (CommandCount >= algorimConfig.RequiredScore)
                                break;

                            world.SendKeyboardCommand(command);
                            CommandCount++;
                            Thread.Sleep(10);
                        }
                        Thread.Sleep(300);
                    }
                }
                RequestedMonitorImage = img;
                Application.DoEvents();

            }
            

            _decisionerTimer.Interval = AlgorithmConfig?.RefreshRate ?? 1;
            _decisionerTimer.Enabled = true;
        }

        public int CommandCount { get; set; } = 0;

        private void Log(string message)
        {
            world.Log(message);
        }

        public void StartGame(ILumberjackWorld world)
        {
            this.world = world;
            IsGameStarted = true;
            _decisionerTimer.Enabled = true;
        }

        public void StopGame()
        {
            IsGameStarted = false;
        }

        public IAlgorithmConfig AlgorithmConfig { get; } = new SimpleRacerConfig();
        
    }
}
