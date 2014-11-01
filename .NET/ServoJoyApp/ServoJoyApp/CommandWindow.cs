using SharpDX.DirectInput;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoJoyApp
{
    public partial class CommandWindow : Form
    {
        private const int XAxisMax = 65535;
        private const int YAxisMax = 65535;
        private const int ZAxisMax = 65535;

        private const byte PanServoMin = 0;
        private const byte PanServoMax = 180;
        private const byte TiltServoMin = 0;
        private const byte TiltServoMax = 180;

        private const byte SerialPackagesSeparator = 255;
        
        private byte _panServoPosition = 0;
        private byte _tiltServoPosition = 0;

        CancellationTokenSource _joystickMonitorCancellation;

        public CommandWindow()
        {
            InitializeComponent();
        }

        private void CommandWindow_Load(object sender, EventArgs e)
        {
            lblXAxisMax.Text = XAxisMax.ToString();
            lblYAxisMax.Text = YAxisMax.ToString();
            lblZAxisMax.Text = ZAxisMax.ToString();

            lblPanServoMin.Text = PanServoMin.ToString();
            lblPanServoMax.Text = PanServoMax.ToString();
            lblTiltServoMin.Text = TiltServoMin.ToString();
            lblTiltServoMax.Text = TiltServoMax.ToString();
        }

        private void btnArduinoConnectionToggle_Click(object sender, EventArgs e)
        {
            try
            {
                if (spArduino.IsOpen)
                {
                    spArduino.Close();

                    btnArduinoConnectionToggle.Text = "Connect";
                }
                else
                {
                    spArduino.BaudRate = (int)nudBaudRate.Value;
                    spArduino.PortName = txtPortName.Text;

                    spArduino.Open();
                    btnArduinoConnectionToggle.Text = "Disconnect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oh no :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnJoystickMonitorStart_Click(object sender, EventArgs e)
        {
            try
            {
                btnJoystickMonitorStart.Enabled = false;
                btnJoystickMonitorStop.Enabled = true;

                var joystickMonitor = new JoystickMonitor(txtJoystickName.Text.Trim());

                _joystickMonitorCancellation = new CancellationTokenSource();
                var progress = new Progress<JoystickUpdate>(s => ProcessJoystickUpdate(s));
                await Task.Run(() => joystickMonitor.PollJoystick(progress, _joystickMonitorCancellation.Token), _joystickMonitorCancellation.Token);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oh no :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJoystickMonitorStop_Click(object sender, EventArgs e)
        {
            _joystickMonitorCancellation.Cancel();

            btnJoystickMonitorStart.Enabled = true;
            btnJoystickMonitorStop.Enabled = false;
        }

        private void tmServoPosition_Tick(object sender, EventArgs e)
        {
            if (spArduino.IsOpen)
            {
                spArduino.Write(new byte[] { _panServoPosition, _tiltServoPosition, SerialPackagesSeparator }, 0, 3);
            }
        }

        private void ProcessJoystickUpdate(JoystickUpdate state)
        {
            if (state.Offset == JoystickOffset.X)
            {
                int xAxisPercent = GetAxisValuePercentage(XAxisMax, state.Value);
                pnlXAxisPercent.Width = (int)xAxisPercent;
                lblXAxisPercent.Text = xAxisPercent + "%";
                lblXAxisValue.Text = state.Value.ToString();

                if (rbPanOnXAxis.Checked)
                {
                    _panServoPosition = MapAxisValueToPanServoPosition(state.Value, XAxisMax);         
                    lblPanServoPosition.Text = _panServoPosition.ToString();
                }
            }
            if (state.Offset == JoystickOffset.Y)
            {
                int yAxisPercent = GetAxisValuePercentage(YAxisMax, state.Value);
                pnlYAxisPercent.Width = (int)yAxisPercent;
                lblYAxisPercent.Text = yAxisPercent + "%";
                lblYAxisValue.Text = state.Value.ToString();

                _tiltServoPosition = MapAxisValueToTiltServoPosition(state.Value);
                lblTiltServoPosition.Text = _tiltServoPosition.ToString();
            }
            else if (state.Offset == JoystickOffset.RotationZ)
            {
                int zAxisPercent = GetAxisValuePercentage(ZAxisMax, state.Value);
                pnlZAxisPercent.Width = zAxisPercent;
                lblZAxisPercent.Text = zAxisPercent + "%";
                lblZAxisValue.Text = state.Value.ToString();

                if (rbPanOnZAxis.Checked)
                {
                    _panServoPosition = MapAxisValueToPanServoPosition(state.Value, ZAxisMax);
                    lblPanServoPosition.Text = _panServoPosition.ToString();
                }
            }            
        }

        private int GetAxisValuePercentage(double maxValue, double currentValue)
        {
            return (int)Math.Round(currentValue * 100 / maxValue);
        }

        private byte MapAxisValueToPanServoPosition(double axisValue, double axisMax)
        {            
            byte servoValue = (byte)Math.Round((axisValue / axisMax) * (PanServoMax - PanServoMin) + PanServoMin);
            return chkPanInvert.Checked ? (byte)(PanServoMax - servoValue) : servoValue;
        }

        private byte MapAxisValueToTiltServoPosition(double axisValue)
        {
            byte servoValue = (byte)Math.Round((axisValue / YAxisMax) * (TiltServoMax - TiltServoMin) + TiltServoMin);
            return chkTiltInvert.Checked ? (byte)(TiltServoMax - servoValue) : servoValue;
        }
    
        private void rbPanOnZAxis_CheckedChanged(object sender, EventArgs e)
        {
            pnlXAxisPercent.BackColor = Color.DarkGray;
            pnlZAxisPercent.BackColor = Color.Blue;
        }

        private void rbPanOnXAxis_CheckedChanged(object sender, EventArgs e)
        {
            pnlXAxisPercent.BackColor = Color.Blue;
            pnlZAxisPercent.BackColor = Color.DarkGray;
        }
    }    
}
