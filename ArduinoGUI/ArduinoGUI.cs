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
        private string gray;
        private string blue;

        //A bridge that is need between the two threads
        public delegate void d1(string indata);

        //A counter that is indicating how many times button is pushed
        private static int counter = 0;

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
            red = "R" + trackBarRedValue.Value;
        }

        private void sendRedValue_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(red))
            {
                red = "R0";
            }
            serialPort1.Write(red);

        }
        private void trackBarGreyValue_Scroll(object sender, EventArgs e)
        {
            gray = "G" + trackBarGreyValue.Value;
        }

        private void sendGreyValue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gray))
            {
                gray = "G0";
            }
            serialPort1.Write(gray);
        }

        private void trackBarBlueValue_Scroll(object sender, EventArgs e)
        {
            blue = "B" + trackBarBlueValue.Value;
        }

        private void sendBlueValue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(blue))
            {
                blue = "B0";
            }
            serialPort1.Write(blue);
        }

        //This function receive data from Arduino
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string inData = serialPort1.ReadLine();
            d1 writeIt = new d1(writeToForm);
            Invoke(writeIt, inData);
        }

        //This function handles about data receiving from Arduino
        public void writeToForm(string inData)
        {
            
            char firstChar;
            

            //Holds the actual data of potentiometer converted to voltage
            Single volts;

            //Counts
            Single numData;

            firstChar = inData[0];
            
            switch(firstChar)
            {
                case 'p': //'p' means pushbutton
                    counter++;
                    textBoxCounter.Text = Convert.ToString(counter);
                break;

                case 'v': //'v' indicates its a potentiometer data

                    //Convert data to single in numData var
                    numData = Convert.ToSingle(inData.Substring(1));

                    //Amount of voltage per step to get the voltage value at the potentiometer
                    volts = numData * 5 / 1024;

                    //Defining text format function to show the volts data in our potvalue as text
                    textBoxPotValue.Text = String.Format("{0:0.00}", volts);

                    //Show value as integer
                    progressBarPotValue.Value = Convert.ToInt16(inData.Substring(1));
                break;
            }
        }

        private void buttonStartPot_Click(object sender, EventArgs e)
        {
            //Start potentiometer 
            serialPort1.Write("O");
        }

        private void buttonStopPot_Click(object sender, EventArgs e)
        {
            //Stop potentiometer
            serialPort1.Write("o");
        }
    }
}
