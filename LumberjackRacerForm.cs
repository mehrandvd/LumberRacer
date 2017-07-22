using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LumberRacer.SimpleRacer;
using ScreenShotDemo;
using Timer = System.Windows.Forms.Timer;

namespace LumberRacer
{
    public partial class LumberjackRacerForm : Form
    {
        public LumberjackRacerForm()
        {
            InitializeComponent();

            world = new SimpleWorld();
            world.OnLog += (sender, args) =>
            {
                Log(sender.ToString());
            };

            algorithm = new SimplePlayer();
            cameraTimer = new Timer();
            InitForm();
        }

        private ILumberjackWorld world;
        private ILumberjackPlayerAlgorithm algorithm;
        private Timer cameraTimer;
        public void InitForm()
        {
            InitConfigUI();
            InitCamera();
            ToggleStartGame();
        }

        private void InitConfigUI()
        {
            var config = algorithm.AlgorithmConfig;
            var props = config?.GetType().GetProperties();

            foreach (var propertyInfo in props)
            {
                var displayAttribute = propertyInfo.GetCustomAttribute<NumericConfigAttribute>();
                var label = new Label()
                {
                    Text = ((displayAttribute?.DisplayText) ?? propertyInfo.Name) + @":",
                    TextAlign = ContentAlignment.BottomLeft
                };

                


                var textbox = new NumericUpDown
                {
                    Maximum = displayAttribute?.Max ?? 1000,
                    Value = displayAttribute?.DefaultValue ?? 0
                };



                propertyInfo.SetValue(config, displayAttribute?.DefaultValue);
                textbox.ValueChanged += (sender, args) =>
                {
                    propertyInfo.SetValue(config, (int)textbox.Value);
                };
                flowLayoutPanelAlgorithmConfig.Controls.AddRange(new Control[] {label, textbox});
            }

        }

        private void InitCamera()
        {
            cameraTimer.Interval = algorithm?.AlgorithmConfig?.RefreshRate ?? 1;

            cameraTimer.Tick += CameraTimerOnTick;

            cameraTimer.Enabled = true;
        }

        private void CameraTimerOnTick(object sender, EventArgs eventArgs)
        {
            cameraTimer.Enabled = false;
            world.SetView(trackBarHorizontal.Value, trackBarVertical.Value);
            var oldImage = pictureMonitor.Image;
            oldImage?.Dispose();

            if (algorithm.CommandCount >= algorithm.AlgorithmConfig.RequiredScore)
            {
                ToggleStartGame();
                algorithm.CommandCount = 0;
                Activate();
                MessageBox.Show($"Congratulations, you just got your requested score: {algorithm.AlgorithmConfig.RequiredScore}");
            }

            try
            {
                pictureMonitor.Image = algorithm?.RequestedMonitorImage ?? world.ViewCamera();
            }
            catch (Exception)
            {
            }
            cameraTimer.Enabled = true;
        }

        public void Log(string text)
        {
            listLog.Items.Insert(0, text);

            if (text.StartsWith("Game found"))
            {
                panelCameraStatus.BackColor = Color.LawnGreen;
            }
            else if (text.StartsWith("Game lost"))
            {
                panelCameraStatus.BackColor = Color.Red;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    trackBarHorizontal.Value -= trackBarHorizontal.SmallChange;
                    break;

                case Keys.Right:
                    trackBarHorizontal.Value += trackBarHorizontal.SmallChange;
                    break;

                case Keys.Up:
                    trackBarVertical.Value += trackBarVertical.SmallChange;
                    break;

                case Keys.Down:
                    trackBarVertical.Value -= trackBarVertical.SmallChange;
                    break;

                case Keys.Space:
                    ToggleStartGame();
                    break;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }

            return true;
        }

        private void btnStartEye_Click(object sender, EventArgs e)
        {
            ToggleStartGame();
        }

        private void ToggleStartGame()
        {
            if (algorithm?.IsGameStarted ?? false)
            {
                btnStartEye.Text = @"Start Eye";
                algorithm?.StopGame();
            }
            else
            {
                btnStartEye.Text = @"Stop Eye";
                algorithm?.StartGame(world);
            }
        }

        private void LumberjackRacerForm_Activated(object sender, EventArgs e)
        {
            if (algorithm != null)
                algorithm.IsPlayStarted = false;
        }

        private void LumberjackRacerForm_Deactivate(object sender, EventArgs e)
        {
            if (algorithm != null)
                algorithm.IsPlayStarted = true;
        }

        private void richTextBoxHelp_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
