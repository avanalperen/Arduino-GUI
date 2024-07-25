using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoGUI
{
    public partial class ArduinoGUI : Form
    {

        //String value to hold the red LED intensity
        private string red;

        public ArduinoGUI()
        {
            InitializeComponent();

            //Opening the Serial Port communication with Arduino (COM5 is set in properties already.).
            serialPort1.Open();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            //Send command to Arduino to turn pin 13 on
            serialPort1.Write("A");
        }

        private void ofButton_Click(object sender, EventArgs e)
        {
            //Send command to Arduino to turn pin 13 off
            serialPort1.Write("a");
        }

        private void servoAngle_Click(object sender, EventArgs e)
        {
            string m1;

            //Set 0 again every click time
            m1 = "S";

            //Send angle value to servo
            //Create a string that will have the value or the letter 'S'
            m1 = "S" + textBoxAngle.Text;
            serialPort1.Write(m1);
        }

        private void trackBarRedValue_Scroll(object sender, EventArgs e)
        {

            red = "R" + trackBarRedValue.Text;

        }

        private void sendRedValue_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(red))
            {
                red = "R0";
            }

            serialPort1.Write(red);

        }

        
    }
}
