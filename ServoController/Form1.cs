using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace robyTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1_servoPosition.Enabled = false;
            button_Close.Enabled = false;
            button_Open.Enabled = true;
            button_sendSimultaneous.Enabled = false;
        }

        private void comboBox_portLists_DropDown(object sender, EventArgs e)  //DROPDOWN TERM
        {
            string[] portLists = SerialPort.GetPortNames();
            comboBox_portLists.Items.Clear();
            comboBox_portLists.Items.AddRange(portLists);
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_portLists.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();

                MessageBox.Show("Success Connection to Controller");
                
                groupBox1_servoPosition.Enabled = true;
                button_Close.Enabled = true;
                button_Open.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("Disconnected from Controller");
                }

                groupBox1_servoPosition.Enabled = false;
                button_Close.Enabled = false;
                button_Open.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void trackBar1_servo1Degree_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar1_servo1Degree.Value;
            label1_servo1Degree.Text = "Servo 1 Degree = " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                if (!checkBox_simultaneous.Checked)
                {
                    serialPort1.Write(degree + "A" + "\n");
                }
            }
        }

        private void trackBar2_servo2Degree_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar2_servo2Degree.Value;
            label4_servo2Degree.Text = "Servo 2 Degree = " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                if (!checkBox_simultaneous.Checked)
                {
                    serialPort1.Write(degree + "B" + "\n");
                }
            }
        }

        private void trackBar3_servo3Degree_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar3_servo3Degree.Value;
            label7_servo3Degree.Text = "Servo 3 Degree = " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                if (!checkBox_simultaneous.Checked)
                {
                    serialPort1.Write(degree + "C" + "\n");
                }
            }
        }

        private void trackBar4_servo4Degree_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar4_servo4Degree.Value;
            label8_servo4Degree.Text = "Servo 4 Degree = " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                if (!checkBox_simultaneous.Checked)
                {
                    serialPort1.Write(degree + "D" + "\n");
                }
            }
        }

        private void trackBar5_servo5Degree_Scroll(object sender, EventArgs e)
        {
            int degree = trackBar5_servo5Degree.Value;
            label13_servo5Degree.Text = "Servo 5 Degree = " + degree.ToString();
            if (serialPort1.IsOpen)
            {
                if (!checkBox_simultaneous.Checked)
                {
                    serialPort1.Write(degree + "E" + "\n");
                }
            }
        }

        private void checkBox_simultaneous_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_simultaneous.Checked)
            {
                button_sendSimultaneous.Enabled = true;
            }
            else
            {
                button_sendSimultaneous.Enabled = false;
            }
        }

        private void button_sendSimultaneous_Click(object sender, EventArgs e)
        {
            int servo1Degree = 0, servo2Degree = 0, servo3Degree = 0, servo4Degree = 0, servo5Degree = 0;

            if (serialPort1.IsOpen)
            {
                servo1Degree = trackBar1_servo1Degree.Value;
                servo2Degree = trackBar2_servo2Degree.Value;
                servo3Degree = trackBar3_servo3Degree.Value;
                servo4Degree = trackBar4_servo4Degree.Value;
                servo5Degree = trackBar5_servo5Degree.Value;

                serialPort1.Write(servo1Degree + "A" + servo2Degree + "B" + servo3Degree + "C" + servo4Degree + "D" + servo5Degree + "E" + "\n");
            } 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
