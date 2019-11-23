/*
 * ADC GUI
 * Author: Christian Arevalo
 * Date: 09/24/2018
 * */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace ADC_Serial_Timer_Integer
{
    public partial class Form1 : Form
    {
        Graphics DrawArea;
        public Form1()
        {
            InitializeComponent();
            DrawArea = ledArrayBox.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = true;

            string [] ports = SerialPort.GetPortNames();
            comNames.Items.AddRange(ports);
            devicesNames.Items.Add("MEMHUD Voltage Reader");

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
           
            try
            {
                serialPort1.PortName = comNames.Text;
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }

            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            startButton.Enabled = true;
            stopButton.Enabled = false;

            try
            {
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string intConvert;
            try
            {
                if (serialPort1.IsOpen)
                {
                   
                    
                    string readingL = serialPort1.ReadExisting();
                    decimal readVoltage = 2.7m;
                    if ((readingL.Length < 5) || (readingL.Length > 5))
                    {
                        
                    }
                    else
                    {
                        
                        voltageReading.Text = readingL + "";
                        string s = readingL;
                        decimal convertDecimals = Convert.ToDecimal(s);
                        decimal rangex = 1.260m;
                        decimal rangey = 1.360m;
                        decimal ilDownx = 2.63m;
                        decimal ilDowny = 2.73m;
                        decimal infox = 4.315m;
                        decimal infoy = 4.498m;
                        decimal hudx = 3.470m;
                        decimal hudy = 3.576m;
                        decimal huddx = 3.95m;
                        decimal huddy = 4.10m;

                        if ((convertDecimals > rangex) && (convertDecimals < rangey))
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            intVoltage.Text = intConvert;
                            SolidBrush sbrush4 = new SolidBrush(Color.LightGreen);
                            DrawArea.FillEllipse(sbrush4, 10, 100, 15, 15);

                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                        }
                        else if((convertDecimals > ilDownx) && (convertDecimals < ilDowny))
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            intVoltage.Text = intConvert;
                            SolidBrush sbrush5 = new SolidBrush(Color.LightGreen);
                            DrawArea.FillEllipse(sbrush5, 10, 125, 15, 15);

                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                        }
                        else if((convertDecimals > infox) && (convertDecimals < infoy))
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            intVoltage.Text = intConvert;
                            SolidBrush sbrush7 = new SolidBrush(Color.LightGreen);
                            DrawArea.FillEllipse(sbrush7, 10, 75, 15, 15);

                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                        }
                         else if((convertDecimals > huddx) && (convertDecimals < huddy))
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            intVoltage.Text = intConvert;
                            SolidBrush sbrush8 = new SolidBrush(Color.LightGreen);
                            DrawArea.FillEllipse(sbrush8, 10, 50, 15, 15);

                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                        }
                        else if((convertDecimals > hudx) && (convertDecimals < hudy))
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            intVoltage.Text = intConvert;
                            SolidBrush sbrush9 = new SolidBrush(Color.LightGreen);
                            DrawArea.FillEllipse(sbrush9, 10, 25, 15, 15);

                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                        }
                        else
                        {
                            intConvert = Convert.ToString(convertDecimals);
                            int strlenght = intConvert.Length;
                            string strlconv = Convert.ToString(strlenght);
                            intVoltage.Text = strlconv;
                            //intVoltage.Text = "FAIL";
                            SolidBrush sbrush0 = new SolidBrush(Color.DarkGreen);
                            DrawArea.FillEllipse(sbrush0, 10, 25, 15, 15);

                            SolidBrush sbrush1 = new SolidBrush(Color.DarkGreen);
                            DrawArea.FillEllipse(sbrush1, 10, 50, 15, 15);

                            SolidBrush sbrush2 = new SolidBrush(Color.DarkGreen);
                            DrawArea.FillEllipse(sbrush2, 10, 75, 15, 15);

                            SolidBrush sbrush3 = new SolidBrush(Color.DarkGreen);
                            DrawArea.FillEllipse(sbrush3, 10, 100, 15, 15);

                            SolidBrush sbrush4 = new SolidBrush(Color.DarkGreen);
                            DrawArea.FillEllipse(sbrush4, 10, 125, 15, 15);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Stop();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                timer1.Stop();
            }
        }

        private void ledArrayBox_Click(object sender, EventArgs e)
        {
           
        }

        private void devicesNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void setUpButton_Click(object sender, EventArgs e)
        {
            string dNames = devicesNames.Text;
            if(dNames == "MEMHUD Voltage Reader")
            {
                SolidBrush sbrush0 = new SolidBrush(Color.DarkGreen);
                DrawArea.FillEllipse(sbrush0, 10, 25, 15, 15);

                SolidBrush sbrush1 = new SolidBrush(Color.DarkGreen);
                DrawArea.FillEllipse(sbrush1, 10, 50, 15, 15);

                SolidBrush sbrush2 = new SolidBrush(Color.DarkGreen);
                DrawArea.FillEllipse(sbrush2, 10, 75, 15, 15);

                SolidBrush sbrush3 = new SolidBrush(Color.DarkGreen);
                DrawArea.FillEllipse(sbrush3, 10, 100, 15, 15);

                SolidBrush sbrush4 = new SolidBrush(Color.DarkGreen);
                DrawArea.FillEllipse(sbrush4, 10, 125, 15, 15);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}

