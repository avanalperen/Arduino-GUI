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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // onButton
            // 
            this.onButton.AutoSize = true;
            this.onButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onButton.Location = new System.Drawing.Point(30, 37);
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
            this.offButton.Location = new System.Drawing.Point(134, 37);
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
            this.servoAngleButton.Location = new System.Drawing.Point(291, 39);
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
            this.textBoxAngle.Location = new System.Drawing.Point(429, 41);
            this.textBoxAngle.Name = "textBoxAngle";
            this.textBoxAngle.Size = new System.Drawing.Size(100, 31);
            this.textBoxAngle.TabIndex = 3;
            // 
            // trackBarRedValue
            // 
            this.trackBarRedValue.Location = new System.Drawing.Point(30, 167);
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
            this.sendRedValue.Location = new System.Drawing.Point(276, 167);
            this.sendRedValue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sendRedValue.Name = "sendRedValue";
            this.sendRedValue.Size = new System.Drawing.Size(133, 35);
            this.sendRedValue.TabIndex = 5;
            this.sendRedValue.Text = "Send Value";
            this.sendRedValue.UseVisualStyleBackColor = true;
            this.sendRedValue.Click += new System.EventHandler(this.sendRedValue_Click);
            // 
            // ArduinoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

