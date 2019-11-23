/*
 * ADC GUI
 * Author: Christian Arevalo
 * Date: 09/24/2018
 * */

namespace ADC_Serial_Timer_Integer
{
    partial class Form1
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
            this.comNames = new System.Windows.Forms.ComboBox();
            this.voltageReading = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.intVoltage = new System.Windows.Forms.Label();
            this.ledArrayBox = new System.Windows.Forms.PictureBox();
            this.devicesNames = new System.Windows.Forms.ComboBox();
            this.setUpButton = new System.Windows.Forms.Button();
            this.hudUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ledArrayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ports:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comNames
            // 
            this.comNames.FormattingEnabled = true;
            this.comNames.Location = new System.Drawing.Point(201, 120);
            this.comNames.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.comNames.Name = "comNames";
            this.comNames.Size = new System.Drawing.Size(65, 21);
            this.comNames.TabIndex = 1;
            // 
            // voltageReading
            // 
            this.voltageReading.AutoSize = true;
            this.voltageReading.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageReading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voltageReading.Location = new System.Drawing.Point(131, 194);
            this.voltageReading.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.voltageReading.Name = "voltageReading";
            this.voltageReading.Size = new System.Drawing.Size(82, 27);
            this.voltageReading.TabIndex = 2;
            this.voltageReading.Text = "2.751";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(102, 249);
            this.startButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(92, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(212, 248);
            this.stopButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(95, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(117, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Voltage Reader";
            // 
            // intVoltage
            // 
            this.intVoltage.AutoSize = true;
            this.intVoltage.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intVoltage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.intVoltage.Location = new System.Drawing.Point(215, 191);
            this.intVoltage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.intVoltage.Name = "intVoltage";
            this.intVoltage.Size = new System.Drawing.Size(26, 27);
            this.intVoltage.TabIndex = 6;
            this.intVoltage.Text = "V";
            // 
            // ledArrayBox
            // 
            this.ledArrayBox.BackColor = System.Drawing.Color.SlateGray;
            this.ledArrayBox.Location = new System.Drawing.Point(338, 126);
            this.ledArrayBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ledArrayBox.Name = "ledArrayBox";
            this.ledArrayBox.Size = new System.Drawing.Size(37, 146);
            this.ledArrayBox.TabIndex = 7;
            this.ledArrayBox.TabStop = false;
            this.ledArrayBox.Click += new System.EventHandler(this.ledArrayBox_Click);
            // 
            // devicesNames
            // 
            this.devicesNames.FormattingEnabled = true;
            this.devicesNames.Location = new System.Drawing.Point(334, 61);
            this.devicesNames.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.devicesNames.Name = "devicesNames";
            this.devicesNames.Size = new System.Drawing.Size(131, 21);
            this.devicesNames.TabIndex = 8;
            this.devicesNames.SelectedIndexChanged += new System.EventHandler(this.devicesNames_SelectedIndexChanged);
            // 
            // setUpButton
            // 
            this.setUpButton.Location = new System.Drawing.Point(334, 88);
            this.setUpButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.setUpButton.Name = "setUpButton";
            this.setUpButton.Size = new System.Drawing.Size(129, 29);
            this.setUpButton.TabIndex = 9;
            this.setUpButton.Text = "Set Up Device";
            this.setUpButton.UseVisualStyleBackColor = true;
            this.setUpButton.Click += new System.EventHandler(this.setUpButton_Click);
            // 
            // hudUp
            // 
            this.hudUp.AutoSize = true;
            this.hudUp.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hudUp.Location = new System.Drawing.Point(378, 148);
            this.hudUp.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.hudUp.Name = "hudUp";
            this.hudUp.Size = new System.Drawing.Size(56, 17);
            this.hudUp.TabIndex = 10;
            this.hudUp.Text = "HUD Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(378, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(378, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "HUD Down";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(378, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ilumination Up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(378, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ilumination Down";
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(545, 338);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hudUp);
            this.Controls.Add(this.setUpButton);
            this.Controls.Add(this.devicesNames);
            this.Controls.Add(this.ledArrayBox);
            this.Controls.Add(this.intVoltage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.voltageReading);
            this.Controls.Add(this.comNames);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Voltage Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ledArrayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comNames;
        private System.Windows.Forms.Label voltageReading;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label intVoltage;
        private System.Windows.Forms.PictureBox ledArrayBox;
        private System.Windows.Forms.ComboBox devicesNames;
        private System.Windows.Forms.Button setUpButton;
        private System.Windows.Forms.Label hudUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
    }
}

