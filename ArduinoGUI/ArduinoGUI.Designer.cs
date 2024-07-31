namespace ArduinoGUI
{
    partial class ArduinoGUI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.servoAngleButton = new System.Windows.Forms.Button();
            this.textBoxAngle = new System.Windows.Forms.TextBox();
            this.trackBarRedValue = new System.Windows.Forms.TrackBar();
            this.sendRedValue = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textBoxPotValue = new System.Windows.Forms.TextBox();
            this.progressBarPotValue = new System.Windows.Forms.ProgressBar();
            this.trackBarGreyValue = new System.Windows.Forms.TrackBar();
            this.trackBarBlueValue = new System.Windows.Forms.TrackBar();
            this.sendGreyValue = new System.Windows.Forms.Button();
            this.sendBlueValue = new System.Windows.Forms.Button();
            this.pushButtonCounter = new System.Windows.Forms.Label();
            this.potValueShow = new System.Windows.Forms.Label();
            this.ledControl = new System.Windows.Forms.Label();
            this.embedLedControl = new System.Windows.Forms.Label();
            this.servoAngle = new System.Windows.Forms.Label();
            this.buttonStopPot = new System.Windows.Forms.Button();
            this.buttonStartPot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueValue)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // onButton
            // 
            this.onButton.AutoSize = true;
            this.onButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onButton.Location = new System.Drawing.Point(90, 107);
            this.onButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(100, 35);
            this.onButton.TabIndex = 0;
            this.onButton.Text = "Turn On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.AutoSize = true;
            this.offButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.offButton.Location = new System.Drawing.Point(195, 107);
            this.offButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(100, 35);
            this.offButton.TabIndex = 1;
            this.offButton.Text = "Turn Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.ofButton_Click);
            // 
            // servoAngleButton
            // 
            this.servoAngleButton.AutoSize = true;
            this.servoAngleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servoAngleButton.Location = new System.Drawing.Point(463, 107);
            this.servoAngleButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.servoAngleButton.Name = "servoAngleButton";
            this.servoAngleButton.Size = new System.Drawing.Size(133, 35);
            this.servoAngleButton.TabIndex = 2;
            this.servoAngleButton.Text = "Send Angle";
            this.servoAngleButton.UseVisualStyleBackColor = true;
            this.servoAngleButton.Click += new System.EventHandler(this.servoAngle_Click);
            // 
            // textBoxAngle
            // 
            this.textBoxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAngle.Location = new System.Drawing.Point(601, 107);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(133, 31);
            this.textBoxAngle.TabIndex = 3;
            // 
            // trackBarRedValue
            // 
            this.trackBarRedValue.Location = new System.Drawing.Point(54, 268);
            this.trackBarRedValue.Maximum = 255;
            this.trackBarRedValue.Name = "trackBarRedValue";
            this.trackBarRedValue.Size = new System.Drawing.Size(241, 45);
            this.trackBarRedValue.TabIndex = 4;
            this.trackBarRedValue.TickFrequency = 10;
            this.trackBarRedValue.Scroll += new System.EventHandler(this.trackBarRedValue_Scroll);
            // 
            // sendRedValue
            // 
            this.sendRedValue.AutoSize = true;
            this.sendRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendRedValue.ForeColor = System.Drawing.Color.Red;
            this.sendRedValue.Location = new System.Drawing.Point(300, 268);
            this.sendRedValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendRedValue.Name = "sendRedValue";
            this.sendRedValue.Size = new System.Drawing.Size(133, 35);
            this.sendRedValue.TabIndex = 5;
            this.sendRedValue.Text = "Send Value";
            this.sendRedValue.UseVisualStyleBackColor = true;
            this.sendRedValue.Click += new System.EventHandler(this.sendRedValue_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCounter.Location = new System.Drawing.Point(601, 219);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(100, 31);
            this.textBoxCounter.TabIndex = 6;
            // 
            // textBoxPotValue
            // 
            this.textBoxPotValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPotValue.Location = new System.Drawing.Point(614, 381);
            this.textBoxPotValue.Name = "textBoxPotValue";
            this.textBoxPotValue.Size = new System.Drawing.Size(100, 31);
            this.textBoxPotValue.TabIndex = 7;
            // 
            // progressBarPotValue
            // 
            this.progressBarPotValue.Location = new System.Drawing.Point(566, 332);
            this.progressBarPotValue.Maximum = 1023;
            this.progressBarPotValue.Name = "progressBarPotValue";
            this.progressBarPotValue.Size = new System.Drawing.Size(200, 43);
            this.progressBarPotValue.TabIndex = 8;
            // 
            // trackBarGreyValue
            // 
            this.trackBarGreyValue.Location = new System.Drawing.Point(54, 340);
            this.trackBarGreyValue.Maximum = 255;
            this.trackBarGreyValue.Name = "trackBarGreyValue";
            this.trackBarGreyValue.Size = new System.Drawing.Size(241, 45);
            this.trackBarGreyValue.TabIndex = 9;
            this.trackBarGreyValue.TickFrequency = 10;
            this.trackBarGreyValue.Scroll += new System.EventHandler(this.trackBarGreyValue_Scroll);
            // 
            // trackBarBlueValue
            // 
            this.trackBarBlueValue.Location = new System.Drawing.Point(54, 407);
            this.trackBarBlueValue.Maximum = 255;
            this.trackBarBlueValue.Name = "trackBarBlueValue";
            this.trackBarBlueValue.Size = new System.Drawing.Size(241, 45);
            this.trackBarBlueValue.TabIndex = 10;
            this.trackBarBlueValue.TickFrequency = 10;
            this.trackBarBlueValue.Scroll += new System.EventHandler(this.trackBarBlueValue_Scroll);
            // 
            // sendGreyValue
            // 
            this.sendGreyValue.AutoSize = true;
            this.sendGreyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendGreyValue.ForeColor = System.Drawing.Color.Gray;
            this.sendGreyValue.Location = new System.Drawing.Point(300, 340);
            this.sendGreyValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendGreyValue.Name = "sendGreyValue";
            this.sendGreyValue.Size = new System.Drawing.Size(133, 35);
            this.sendGreyValue.TabIndex = 11;
            this.sendGreyValue.Text = "Send Value";
            this.sendGreyValue.UseVisualStyleBackColor = true;
            this.sendGreyValue.Click += new System.EventHandler(this.sendGreyValue_Click);
            // 
            // sendBlueValue
            // 
            this.sendBlueValue.AutoSize = true;
            this.sendBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sendBlueValue.ForeColor = System.Drawing.Color.Blue;
            this.sendBlueValue.Location = new System.Drawing.Point(300, 407);
            this.sendBlueValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendBlueValue.Name = "sendBlueValue";
            this.sendBlueValue.Size = new System.Drawing.Size(133, 35);
            this.sendBlueValue.TabIndex = 12;
            this.sendBlueValue.Text = "Send Value";
            this.sendBlueValue.UseVisualStyleBackColor = true;
            this.sendBlueValue.Click += new System.EventHandler(this.sendBlueValue_Click);
            // 
            // pushButtonCounter
            // 
            this.pushButtonCounter.AutoSize = true;
            this.pushButtonCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pushButtonCounter.Location = new System.Drawing.Point(578, 191);
            this.pushButtonCounter.Name = "pushButtonCounter";
            this.pushButtonCounter.Size = new System.Drawing.Size(156, 25);
            this.pushButtonCounter.TabIndex = 13;
            this.pushButtonCounter.Text = "Button Counter";
            this.pushButtonCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // potValueShow
            // 
            this.potValueShow.AutoSize = true;
            this.potValueShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.potValueShow.Location = new System.Drawing.Point(609, 304);
            this.potValueShow.Name = "potValueShow";
            this.potValueShow.Size = new System.Drawing.Size(105, 25);
            this.potValueShow.TabIndex = 14;
            this.potValueShow.Text = "Pot Value";
            this.potValueShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledControl
            // 
            this.ledControl.AutoSize = true;
            this.ledControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ledControl.Location = new System.Drawing.Point(190, 219);
            this.ledControl.Name = "ledControl";
            this.ledControl.Size = new System.Drawing.Size(128, 25);
            this.ledControl.TabIndex = 15;
            this.ledControl.Text = "LED Control";
            this.ledControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // embedLedControl
            // 
            this.embedLedControl.AutoSize = true;
            this.embedLedControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.embedLedControl.Location = new System.Drawing.Point(137, 55);
            this.embedLedControl.Name = "embedLedControl";
            this.embedLedControl.Size = new System.Drawing.Size(120, 25);
            this.embedLedControl.TabIndex = 16;
            this.embedLedControl.Text = "LED Pin 13";
            this.embedLedControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // servoAngle
            // 
            this.servoAngle.AutoSize = true;
            this.servoAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.servoAngle.Location = new System.Drawing.Point(561, 55);
            this.servoAngle.Name = "servoAngle";
            this.servoAngle.Size = new System.Drawing.Size(129, 25);
            this.servoAngle.TabIndex = 17;
            this.servoAngle.Text = "Servo Angle";
            this.servoAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStopPot
            // 
            this.buttonStopPot.AutoSize = true;
            this.buttonStopPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStopPot.Location = new System.Drawing.Point(666, 418);
            this.buttonStopPot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonStopPot.Name = "buttonStopPot";
            this.buttonStopPot.Size = new System.Drawing.Size(100, 35);
            this.buttonStopPot.TabIndex = 19;
            this.buttonStopPot.Text = "Stop";
            this.buttonStopPot.UseVisualStyleBackColor = true;
            this.buttonStopPot.Click += new System.EventHandler(this.buttonStopPot_Click);
            // 
            // buttonStartPot
            // 
            this.buttonStartPot.AutoSize = true;
            this.buttonStartPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStartPot.Location = new System.Drawing.Point(561, 418);
            this.buttonStartPot.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonStartPot.Name = "buttonStartPot";
            this.buttonStartPot.Size = new System.Drawing.Size(100, 35);
            this.buttonStartPot.TabIndex = 18;
            this.buttonStartPot.Text = "Start";
            this.buttonStartPot.UseVisualStyleBackColor = true;
            this.buttonStartPot.Click += new System.EventHandler(this.buttonStartPot_Click);
            // 
            // ArduinoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.buttonStopPot);
            this.Controls.Add(this.buttonStartPot);
            this.Controls.Add(this.servoAngle);
            this.Controls.Add(this.embedLedControl);
            this.Controls.Add(this.ledControl);
            this.Controls.Add(this.potValueShow);
            this.Controls.Add(this.pushButtonCounter);
            this.Controls.Add(this.sendBlueValue);
            this.Controls.Add(this.sendGreyValue);
            this.Controls.Add(this.trackBarBlueValue);
            this.Controls.Add(this.trackBarGreyValue);
            this.Controls.Add(this.progressBarPotValue);
            this.Controls.Add(this.textBoxPotValue);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.sendRedValue);
            this.Controls.Add(this.trackBarRedValue);
            this.Controls.Add(this.textBoxAngle);
            this.Controls.Add(this.servoAngleButton);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ArduinoGUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreyValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlueValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Button servoAngleButton;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.TrackBar trackBarRedValue;
        private System.Windows.Forms.Button sendRedValue;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textBoxPotValue;
        private System.Windows.Forms.ProgressBar progressBarPotValue;
        private System.Windows.Forms.TrackBar trackBarGreyValue;
        private System.Windows.Forms.TrackBar trackBarBlueValue;
        private System.Windows.Forms.Button sendGreyValue;
        private System.Windows.Forms.Button sendBlueValue;
        private System.Windows.Forms.Label pushButtonCounter;
        private System.Windows.Forms.Label potValueShow;
        private System.Windows.Forms.Label ledControl;
        private System.Windows.Forms.Label embedLedControl;
        private System.Windows.Forms.Label servoAngle;
        private System.Windows.Forms.Button buttonStopPot;
        private System.Windows.Forms.Button buttonStartPot;
    }
}

