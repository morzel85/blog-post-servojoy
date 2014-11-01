namespace ServoJoyApp
{
    partial class CommandWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gbZAxis = new System.Windows.Forms.GroupBox();
            this.lblZAxisPercent = new System.Windows.Forms.Label();
            this.lblZAxisMax = new System.Windows.Forms.Label();
            this.pnlZAxisPercent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblZAxisValue = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbYAxis = new System.Windows.Forms.GroupBox();
            this.lblYAxisPercent = new System.Windows.Forms.Label();
            this.lblYAxisMax = new System.Windows.Forms.Label();
            this.pnlYAxisPercent = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblYAxisValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbTiltServo = new System.Windows.Forms.GroupBox();
            this.lblTiltServoMax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTiltServoMin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTiltServoPosition = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPanServo = new System.Windows.Forms.GroupBox();
            this.rbPanOnZAxis = new System.Windows.Forms.RadioButton();
            this.rbPanOnXAxis = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPanServoMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblPanServoMin = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPanServoPosition = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.rbXAxis = new System.Windows.Forms.GroupBox();
            this.lblXAxisPercent = new System.Windows.Forms.Label();
            this.lblXAxisMax = new System.Windows.Forms.Label();
            this.pnlXAxisPercent = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblXAxisValue = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtJoystickName = new System.Windows.Forms.TextBox();
            this.btnJoystickMonitorStart = new System.Windows.Forms.Button();
            this.btnJoystickMonitorStop = new System.Windows.Forms.Button();
            this.gbJoystickMonitoring = new System.Windows.Forms.GroupBox();
            this.gbArduinoConnection = new System.Windows.Forms.GroupBox();
            this.txtPortName = new System.Windows.Forms.TextBox();
            this.btnArduinoConnectionToggle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBaudRate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.tmServoPosition = new System.Windows.Forms.Timer(this.components);
            this.chkPanInvert = new System.Windows.Forms.CheckBox();
            this.chkTiltInvert = new System.Windows.Forms.CheckBox();
            this.gbZAxis.SuspendLayout();
            this.pnlZAxisPercent.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbYAxis.SuspendLayout();
            this.pnlYAxisPercent.SuspendLayout();
            this.panel7.SuspendLayout();
            this.gbTiltServo.SuspendLayout();
            this.gbPanServo.SuspendLayout();
            this.rbXAxis.SuspendLayout();
            this.pnlXAxisPercent.SuspendLayout();
            this.panel9.SuspendLayout();
            this.gbJoystickMonitoring.SuspendLayout();
            this.gbArduinoConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current value:";
            // 
            // gbZAxis
            // 
            this.gbZAxis.Controls.Add(this.lblZAxisPercent);
            this.gbZAxis.Controls.Add(this.lblZAxisMax);
            this.gbZAxis.Controls.Add(this.pnlZAxisPercent);
            this.gbZAxis.Controls.Add(this.label5);
            this.gbZAxis.Controls.Add(this.lblZAxisValue);
            this.gbZAxis.Controls.Add(this.label1);
            this.gbZAxis.Controls.Add(this.panel3);
            this.gbZAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbZAxis.Location = new System.Drawing.Point(777, 8);
            this.gbZAxis.Name = "gbZAxis";
            this.gbZAxis.Size = new System.Drawing.Size(165, 96);
            this.gbZAxis.TabIndex = 4;
            this.gbZAxis.TabStop = false;
            this.gbZAxis.Text = "Z-axis";
            // 
            // lblZAxisPercent
            // 
            this.lblZAxisPercent.AutoSize = true;
            this.lblZAxisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZAxisPercent.Location = new System.Drawing.Point(123, 22);
            this.lblZAxisPercent.Name = "lblZAxisPercent";
            this.lblZAxisPercent.Size = new System.Drawing.Size(19, 13);
            this.lblZAxisPercent.TabIndex = 11;
            this.lblZAxisPercent.Text = "---";
            // 
            // lblZAxisMax
            // 
            this.lblZAxisMax.AutoSize = true;
            this.lblZAxisMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZAxisMax.Location = new System.Drawing.Point(105, 68);
            this.lblZAxisMax.Name = "lblZAxisMax";
            this.lblZAxisMax.Size = new System.Drawing.Size(16, 13);
            this.lblZAxisMax.TabIndex = 10;
            this.lblZAxisMax.Text = "---";
            // 
            // pnlZAxisPercent
            // 
            this.pnlZAxisPercent.BackColor = System.Drawing.Color.Blue;
            this.pnlZAxisPercent.Controls.Add(this.panel2);
            this.pnlZAxisPercent.Location = new System.Drawing.Point(16, 20);
            this.pnlZAxisPercent.Name = "pnlZAxisPercent";
            this.pnlZAxisPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlZAxisPercent.Size = new System.Drawing.Size(49, 16);
            this.pnlZAxisPercent.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(100, 18);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Max value:";
            // 
            // lblZAxisValue
            // 
            this.lblZAxisValue.AutoSize = true;
            this.lblZAxisValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZAxisValue.Location = new System.Drawing.Point(105, 49);
            this.lblZAxisValue.Name = "lblZAxisValue";
            this.lblZAxisValue.Size = new System.Drawing.Size(19, 13);
            this.lblZAxisValue.TabIndex = 6;
            this.lblZAxisValue.Text = "---";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(15, 19);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(102, 18);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(3, 24);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel4.Size = new System.Drawing.Size(100, 18);
            this.panel4.TabIndex = 4;
            // 
            // gbYAxis
            // 
            this.gbYAxis.Controls.Add(this.lblYAxisPercent);
            this.gbYAxis.Controls.Add(this.lblYAxisMax);
            this.gbYAxis.Controls.Add(this.pnlYAxisPercent);
            this.gbYAxis.Controls.Add(this.label6);
            this.gbYAxis.Controls.Add(this.lblYAxisValue);
            this.gbYAxis.Controls.Add(this.label10);
            this.gbYAxis.Controls.Add(this.panel7);
            this.gbYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbYAxis.Location = new System.Drawing.Point(606, 8);
            this.gbYAxis.Name = "gbYAxis";
            this.gbYAxis.Size = new System.Drawing.Size(165, 96);
            this.gbYAxis.TabIndex = 12;
            this.gbYAxis.TabStop = false;
            this.gbYAxis.Text = "Y-axis";
            // 
            // lblYAxisPercent
            // 
            this.lblYAxisPercent.AutoSize = true;
            this.lblYAxisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYAxisPercent.Location = new System.Drawing.Point(123, 22);
            this.lblYAxisPercent.Name = "lblYAxisPercent";
            this.lblYAxisPercent.Size = new System.Drawing.Size(19, 13);
            this.lblYAxisPercent.TabIndex = 11;
            this.lblYAxisPercent.Text = "---";
            // 
            // lblYAxisMax
            // 
            this.lblYAxisMax.AutoSize = true;
            this.lblYAxisMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYAxisMax.Location = new System.Drawing.Point(105, 67);
            this.lblYAxisMax.Name = "lblYAxisMax";
            this.lblYAxisMax.Size = new System.Drawing.Size(16, 13);
            this.lblYAxisMax.TabIndex = 10;
            this.lblYAxisMax.Text = "---";
            // 
            // pnlYAxisPercent
            // 
            this.pnlYAxisPercent.BackColor = System.Drawing.Color.Blue;
            this.pnlYAxisPercent.Controls.Add(this.panel6);
            this.pnlYAxisPercent.Location = new System.Drawing.Point(16, 20);
            this.pnlYAxisPercent.Name = "pnlYAxisPercent";
            this.pnlYAxisPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlYAxisPercent.Size = new System.Drawing.Size(49, 16);
            this.pnlYAxisPercent.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(3, 24);
            this.panel6.Name = "panel6";
            this.panel6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel6.Size = new System.Drawing.Size(100, 18);
            this.panel6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max value:";
            // 
            // lblYAxisValue
            // 
            this.lblYAxisValue.AutoSize = true;
            this.lblYAxisValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYAxisValue.Location = new System.Drawing.Point(105, 48);
            this.lblYAxisValue.Name = "lblYAxisValue";
            this.lblYAxisValue.Size = new System.Drawing.Size(19, 13);
            this.lblYAxisValue.TabIndex = 6;
            this.lblYAxisValue.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Current value:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(15, 19);
            this.panel7.Name = "panel7";
            this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel7.Size = new System.Drawing.Size(102, 18);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Location = new System.Drawing.Point(3, 24);
            this.panel8.Name = "panel8";
            this.panel8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel8.Size = new System.Drawing.Size(100, 18);
            this.panel8.TabIndex = 4;
            // 
            // gbTiltServo
            // 
            this.gbTiltServo.Controls.Add(this.chkTiltInvert);
            this.gbTiltServo.Controls.Add(this.lblTiltServoMax);
            this.gbTiltServo.Controls.Add(this.label7);
            this.gbTiltServo.Controls.Add(this.lblTiltServoMin);
            this.gbTiltServo.Controls.Add(this.label11);
            this.gbTiltServo.Controls.Add(this.lblTiltServoPosition);
            this.gbTiltServo.Controls.Add(this.label13);
            this.gbTiltServo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbTiltServo.Location = new System.Drawing.Point(727, 123);
            this.gbTiltServo.Name = "gbTiltServo";
            this.gbTiltServo.Size = new System.Drawing.Size(215, 113);
            this.gbTiltServo.TabIndex = 12;
            this.gbTiltServo.TabStop = false;
            this.gbTiltServo.Text = "Tilt servo";
            // 
            // lblTiltServoMax
            // 
            this.lblTiltServoMax.AutoSize = true;
            this.lblTiltServoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTiltServoMax.Location = new System.Drawing.Point(116, 71);
            this.lblTiltServoMax.Name = "lblTiltServoMax";
            this.lblTiltServoMax.Size = new System.Drawing.Size(16, 13);
            this.lblTiltServoMax.TabIndex = 10;
            this.lblTiltServoMax.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Max position:";
            // 
            // lblTiltServoMin
            // 
            this.lblTiltServoMin.AutoSize = true;
            this.lblTiltServoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTiltServoMin.Location = new System.Drawing.Point(116, 56);
            this.lblTiltServoMin.Name = "lblTiltServoMin";
            this.lblTiltServoMin.Size = new System.Drawing.Size(16, 13);
            this.lblTiltServoMin.TabIndex = 8;
            this.lblTiltServoMin.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(11, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Min position:";
            // 
            // lblTiltServoPosition
            // 
            this.lblTiltServoPosition.AutoSize = true;
            this.lblTiltServoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTiltServoPosition.Location = new System.Drawing.Point(116, 33);
            this.lblTiltServoPosition.Name = "lblTiltServoPosition";
            this.lblTiltServoPosition.Size = new System.Drawing.Size(19, 13);
            this.lblTiltServoPosition.TabIndex = 6;
            this.lblTiltServoPosition.Text = "---";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(11, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Current position:";
            // 
            // gbPanServo
            // 
            this.gbPanServo.Controls.Add(this.chkPanInvert);
            this.gbPanServo.Controls.Add(this.rbPanOnZAxis);
            this.gbPanServo.Controls.Add(this.rbPanOnXAxis);
            this.gbPanServo.Controls.Add(this.label2);
            this.gbPanServo.Controls.Add(this.lblPanServoMax);
            this.gbPanServo.Controls.Add(this.label16);
            this.gbPanServo.Controls.Add(this.lblPanServoMin);
            this.gbPanServo.Controls.Add(this.label18);
            this.gbPanServo.Controls.Add(this.lblPanServoPosition);
            this.gbPanServo.Controls.Add(this.label20);
            this.gbPanServo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPanServo.Location = new System.Drawing.Point(435, 123);
            this.gbPanServo.Name = "gbPanServo";
            this.gbPanServo.Size = new System.Drawing.Size(217, 113);
            this.gbPanServo.TabIndex = 12;
            this.gbPanServo.TabStop = false;
            this.gbPanServo.Text = "Pan servo";
            // 
            // rbPanOnZAxis
            // 
            this.rbPanOnZAxis.AutoSize = true;
            this.rbPanOnZAxis.Checked = true;
            this.rbPanOnZAxis.Location = new System.Drawing.Point(162, 20);
            this.rbPanOnZAxis.Name = "rbPanOnZAxis";
            this.rbPanOnZAxis.Size = new System.Drawing.Size(33, 17);
            this.rbPanOnZAxis.TabIndex = 13;
            this.rbPanOnZAxis.TabStop = true;
            this.rbPanOnZAxis.Text = "Z";
            this.rbPanOnZAxis.UseVisualStyleBackColor = true;
            this.rbPanOnZAxis.CheckedChanged += new System.EventHandler(this.rbPanOnZAxis_CheckedChanged);
            // 
            // rbPanOnXAxis
            // 
            this.rbPanOnXAxis.AutoSize = true;
            this.rbPanOnXAxis.Location = new System.Drawing.Point(120, 20);
            this.rbPanOnXAxis.Name = "rbPanOnXAxis";
            this.rbPanOnXAxis.Size = new System.Drawing.Size(33, 17);
            this.rbPanOnXAxis.TabIndex = 12;
            this.rbPanOnXAxis.Text = "X";
            this.rbPanOnXAxis.UseVisualStyleBackColor = true;
            this.rbPanOnXAxis.CheckedChanged += new System.EventHandler(this.rbPanOnXAxis_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bound to axis:";
            // 
            // lblPanServoMax
            // 
            this.lblPanServoMax.AutoSize = true;
            this.lblPanServoMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPanServoMax.Location = new System.Drawing.Point(118, 86);
            this.lblPanServoMax.Name = "lblPanServoMax";
            this.lblPanServoMax.Size = new System.Drawing.Size(16, 13);
            this.lblPanServoMax.TabIndex = 10;
            this.lblPanServoMax.Text = "---";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(12, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Max position:";
            // 
            // lblPanServoMin
            // 
            this.lblPanServoMin.AutoSize = true;
            this.lblPanServoMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPanServoMin.Location = new System.Drawing.Point(118, 71);
            this.lblPanServoMin.Name = "lblPanServoMin";
            this.lblPanServoMin.Size = new System.Drawing.Size(16, 13);
            this.lblPanServoMin.TabIndex = 8;
            this.lblPanServoMin.Text = "---";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.Location = new System.Drawing.Point(12, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Min position:";
            // 
            // lblPanServoPosition
            // 
            this.lblPanServoPosition.AutoSize = true;
            this.lblPanServoPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPanServoPosition.Location = new System.Drawing.Point(117, 48);
            this.lblPanServoPosition.Name = "lblPanServoPosition";
            this.lblPanServoPosition.Size = new System.Drawing.Size(19, 13);
            this.lblPanServoPosition.TabIndex = 6;
            this.lblPanServoPosition.Text = "---";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.Location = new System.Drawing.Point(12, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Current position:";
            // 
            // rbXAxis
            // 
            this.rbXAxis.Controls.Add(this.lblXAxisPercent);
            this.rbXAxis.Controls.Add(this.lblXAxisMax);
            this.rbXAxis.Controls.Add(this.pnlXAxisPercent);
            this.rbXAxis.Controls.Add(this.label9);
            this.rbXAxis.Controls.Add(this.lblXAxisValue);
            this.rbXAxis.Controls.Add(this.label17);
            this.rbXAxis.Controls.Add(this.panel9);
            this.rbXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbXAxis.Location = new System.Drawing.Point(435, 8);
            this.rbXAxis.Name = "rbXAxis";
            this.rbXAxis.Size = new System.Drawing.Size(165, 96);
            this.rbXAxis.TabIndex = 12;
            this.rbXAxis.TabStop = false;
            this.rbXAxis.Text = "X-axis";
            // 
            // lblXAxisPercent
            // 
            this.lblXAxisPercent.AutoSize = true;
            this.lblXAxisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXAxisPercent.Location = new System.Drawing.Point(123, 22);
            this.lblXAxisPercent.Name = "lblXAxisPercent";
            this.lblXAxisPercent.Size = new System.Drawing.Size(19, 13);
            this.lblXAxisPercent.TabIndex = 11;
            this.lblXAxisPercent.Text = "---";
            // 
            // lblXAxisMax
            // 
            this.lblXAxisMax.AutoSize = true;
            this.lblXAxisMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXAxisMax.Location = new System.Drawing.Point(105, 68);
            this.lblXAxisMax.Name = "lblXAxisMax";
            this.lblXAxisMax.Size = new System.Drawing.Size(16, 13);
            this.lblXAxisMax.TabIndex = 10;
            this.lblXAxisMax.Text = "---";
            // 
            // pnlXAxisPercent
            // 
            this.pnlXAxisPercent.BackColor = System.Drawing.Color.DarkGray;
            this.pnlXAxisPercent.Controls.Add(this.panel5);
            this.pnlXAxisPercent.Location = new System.Drawing.Point(16, 20);
            this.pnlXAxisPercent.Name = "pnlXAxisPercent";
            this.pnlXAxisPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlXAxisPercent.Size = new System.Drawing.Size(49, 16);
            this.pnlXAxisPercent.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(3, 24);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel5.Size = new System.Drawing.Size(100, 18);
            this.panel5.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Max value:";
            // 
            // lblXAxisValue
            // 
            this.lblXAxisValue.AutoSize = true;
            this.lblXAxisValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblXAxisValue.Location = new System.Drawing.Point(105, 49);
            this.lblXAxisValue.Name = "lblXAxisValue";
            this.lblXAxisValue.Size = new System.Drawing.Size(19, 13);
            this.lblXAxisValue.TabIndex = 6;
            this.lblXAxisValue.Text = "---";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(12, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Current value:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(15, 19);
            this.panel9.Name = "panel9";
            this.panel9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel9.Size = new System.Drawing.Size(102, 18);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Location = new System.Drawing.Point(3, 24);
            this.panel10.Name = "panel10";
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel10.Size = new System.Drawing.Size(100, 18);
            this.panel10.TabIndex = 4;
            // 
            // txtJoystickName
            // 
            this.txtJoystickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtJoystickName.Location = new System.Drawing.Point(11, 24);
            this.txtJoystickName.Name = "txtJoystickName";
            this.txtJoystickName.Size = new System.Drawing.Size(194, 20);
            this.txtJoystickName.TabIndex = 16;
            this.txtJoystickName.Text = "Logitech Extreme 3D Pro USB";
            // 
            // btnJoystickMonitorStart
            // 
            this.btnJoystickMonitorStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJoystickMonitorStart.Location = new System.Drawing.Point(221, 22);
            this.btnJoystickMonitorStart.Name = "btnJoystickMonitorStart";
            this.btnJoystickMonitorStart.Size = new System.Drawing.Size(75, 23);
            this.btnJoystickMonitorStart.TabIndex = 17;
            this.btnJoystickMonitorStart.Text = "Start";
            this.btnJoystickMonitorStart.UseVisualStyleBackColor = true;
            this.btnJoystickMonitorStart.Click += new System.EventHandler(this.btnJoystickMonitorStart_Click);
            // 
            // btnJoystickMonitorStop
            // 
            this.btnJoystickMonitorStop.Enabled = false;
            this.btnJoystickMonitorStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnJoystickMonitorStop.Location = new System.Drawing.Point(309, 22);
            this.btnJoystickMonitorStop.Name = "btnJoystickMonitorStop";
            this.btnJoystickMonitorStop.Size = new System.Drawing.Size(75, 23);
            this.btnJoystickMonitorStop.TabIndex = 17;
            this.btnJoystickMonitorStop.Text = "Stop";
            this.btnJoystickMonitorStop.UseVisualStyleBackColor = true;
            this.btnJoystickMonitorStop.Click += new System.EventHandler(this.btnJoystickMonitorStop_Click);
            // 
            // gbJoystickMonitoring
            // 
            this.gbJoystickMonitoring.Controls.Add(this.txtJoystickName);
            this.gbJoystickMonitoring.Controls.Add(this.btnJoystickMonitorStop);
            this.gbJoystickMonitoring.Controls.Add(this.btnJoystickMonitorStart);
            this.gbJoystickMonitoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbJoystickMonitoring.Location = new System.Drawing.Point(12, 93);
            this.gbJoystickMonitoring.Name = "gbJoystickMonitoring";
            this.gbJoystickMonitoring.Size = new System.Drawing.Size(400, 59);
            this.gbJoystickMonitoring.TabIndex = 18;
            this.gbJoystickMonitoring.TabStop = false;
            this.gbJoystickMonitoring.Text = "Joystick monitoring";
            // 
            // gbArduinoConnection
            // 
            this.gbArduinoConnection.Controls.Add(this.txtPortName);
            this.gbArduinoConnection.Controls.Add(this.btnArduinoConnectionToggle);
            this.gbArduinoConnection.Controls.Add(this.label3);
            this.gbArduinoConnection.Controls.Add(this.nudBaudRate);
            this.gbArduinoConnection.Controls.Add(this.label4);
            this.gbArduinoConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbArduinoConnection.Location = new System.Drawing.Point(12, 12);
            this.gbArduinoConnection.Name = "gbArduinoConnection";
            this.gbArduinoConnection.Size = new System.Drawing.Size(400, 74);
            this.gbArduinoConnection.TabIndex = 19;
            this.gbArduinoConnection.TabStop = false;
            this.gbArduinoConnection.Text = "Arduino connection";
            // 
            // txtPortName
            // 
            this.txtPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPortName.Location = new System.Drawing.Point(11, 39);
            this.txtPortName.Name = "txtPortName";
            this.txtPortName.Size = new System.Drawing.Size(86, 20);
            this.txtPortName.TabIndex = 6;
            this.txtPortName.Text = "COM3";
            // 
            // btnArduinoConnectionToggle
            // 
            this.btnArduinoConnectionToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnArduinoConnectionToggle.Location = new System.Drawing.Point(242, 36);
            this.btnArduinoConnectionToggle.Name = "btnArduinoConnectionToggle";
            this.btnArduinoConnectionToggle.Size = new System.Drawing.Size(129, 23);
            this.btnArduinoConnectionToggle.TabIndex = 5;
            this.btnArduinoConnectionToggle.Text = "Connect";
            this.btnArduinoConnectionToggle.UseVisualStyleBackColor = true;
            this.btnArduinoConnectionToggle.Click += new System.EventHandler(this.btnArduinoConnectionToggle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(123, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Baud rate:";
            // 
            // nudBaudRate
            // 
            this.nudBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudBaudRate.Location = new System.Drawing.Point(126, 39);
            this.nudBaudRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBaudRate.Minimum = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            this.nudBaudRate.Name = "nudBaudRate";
            this.nudBaudRate.Size = new System.Drawing.Size(86, 20);
            this.nudBaudRate.TabIndex = 7;
            this.nudBaudRate.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port name:";
            // 
            // tmServoPosition
            // 
            this.tmServoPosition.Enabled = true;
            this.tmServoPosition.Interval = 10;
            this.tmServoPosition.Tick += new System.EventHandler(this.tmServoPosition_Tick);
            // 
            // chkPanInvert
            // 
            this.chkPanInvert.AutoSize = true;
            this.chkPanInvert.Checked = true;
            this.chkPanInvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPanInvert.Location = new System.Drawing.Point(151, 47);
            this.chkPanInvert.Name = "chkPanInvert";
            this.chkPanInvert.Size = new System.Drawing.Size(59, 17);
            this.chkPanInvert.TabIndex = 14;
            this.chkPanInvert.Text = "Invert";
            this.chkPanInvert.UseVisualStyleBackColor = true;
            // 
            // chkTiltInvert
            // 
            this.chkTiltInvert.AutoSize = true;
            this.chkTiltInvert.Location = new System.Drawing.Point(147, 33);
            this.chkTiltInvert.Name = "chkTiltInvert";
            this.chkTiltInvert.Size = new System.Drawing.Size(59, 17);
            this.chkTiltInvert.TabIndex = 15;
            this.chkTiltInvert.Text = "Invert";
            this.chkTiltInvert.UseVisualStyleBackColor = true;
            // 
            // CommandWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 251);
            this.Controls.Add(this.gbArduinoConnection);
            this.Controls.Add(this.gbJoystickMonitoring);
            this.Controls.Add(this.rbXAxis);
            this.Controls.Add(this.gbPanServo);
            this.Controls.Add(this.gbTiltServo);
            this.Controls.Add(this.gbYAxis);
            this.Controls.Add(this.gbZAxis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CommandWindow";
            this.Text = "ServoJoyApp (morzel.net blog post code sample)";
            this.Load += new System.EventHandler(this.CommandWindow_Load);
            this.gbZAxis.ResumeLayout(false);
            this.gbZAxis.PerformLayout();
            this.pnlZAxisPercent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbYAxis.ResumeLayout(false);
            this.gbYAxis.PerformLayout();
            this.pnlYAxisPercent.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.gbTiltServo.ResumeLayout(false);
            this.gbTiltServo.PerformLayout();
            this.gbPanServo.ResumeLayout(false);
            this.gbPanServo.PerformLayout();
            this.rbXAxis.ResumeLayout(false);
            this.rbXAxis.PerformLayout();
            this.pnlXAxisPercent.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.gbJoystickMonitoring.ResumeLayout(false);
            this.gbJoystickMonitoring.PerformLayout();
            this.gbArduinoConnection.ResumeLayout(false);
            this.gbArduinoConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaudRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbZAxis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlZAxisPercent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblZAxisValue;
        private System.Windows.Forms.Label lblZAxisMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblZAxisPercent;
        private System.Windows.Forms.GroupBox gbYAxis;
        private System.Windows.Forms.Label lblYAxisPercent;
        private System.Windows.Forms.Label lblYAxisMax;
        private System.Windows.Forms.Panel pnlYAxisPercent;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblYAxisValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox gbTiltServo;
        private System.Windows.Forms.Label lblTiltServoMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTiltServoMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTiltServoPosition;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbPanServo;
        private System.Windows.Forms.Label lblPanServoMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPanServoMin;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblPanServoPosition;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox rbXAxis;
        private System.Windows.Forms.Label lblXAxisPercent;
        private System.Windows.Forms.Label lblXAxisMax;
        private System.Windows.Forms.Panel pnlXAxisPercent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblXAxisValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton rbPanOnZAxis;
        private System.Windows.Forms.RadioButton rbPanOnXAxis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJoystickName;
        private System.Windows.Forms.Button btnJoystickMonitorStart;
        private System.Windows.Forms.Button btnJoystickMonitorStop;
        private System.Windows.Forms.GroupBox gbJoystickMonitoring;
        private System.Windows.Forms.GroupBox gbArduinoConnection;
        private System.Windows.Forms.TextBox txtPortName;
        private System.Windows.Forms.Button btnArduinoConnectionToggle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudBaudRate;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.Timer tmServoPosition;
        private System.Windows.Forms.CheckBox chkTiltInvert;
        private System.Windows.Forms.CheckBox chkPanInvert;
    }
}

