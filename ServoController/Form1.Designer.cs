
namespace robyTestApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1_servoPosition = new System.Windows.Forms.GroupBox();
            this.label1_servo1Degree = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1_servo1Degree = new System.Windows.Forms.TrackBar();
            this.label4_servo2Degree = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar2_servo2Degree = new System.Windows.Forms.TrackBar();
            this.label7_servo3Degree = new System.Windows.Forms.Label();
            this.label8_servo4Degree = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar3_servo3Degree = new System.Windows.Forms.TrackBar();
            this.trackBar4_servo4Degree = new System.Windows.Forms.TrackBar();
            this.label13_servo5Degree = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.trackBar5_servo5Degree = new System.Windows.Forms.TrackBar();
            this.checkBox_simultaneous = new System.Windows.Forms.CheckBox();
            this.button_sendSimultaneous = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox_portLists = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1_servoPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_servo1Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_servo2Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3_servo3Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4_servo4Degree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5_servo5Degree)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_servoPosition
            // 
            this.groupBox1_servoPosition.Controls.Add(this.button_sendSimultaneous);
            this.groupBox1_servoPosition.Controls.Add(this.checkBox_simultaneous);
            this.groupBox1_servoPosition.Controls.Add(this.trackBar5_servo5Degree);
            this.groupBox1_servoPosition.Controls.Add(this.trackBar4_servo4Degree);
            this.groupBox1_servoPosition.Controls.Add(this.trackBar2_servo2Degree);
            this.groupBox1_servoPosition.Controls.Add(this.trackBar3_servo3Degree);
            this.groupBox1_servoPosition.Controls.Add(this.trackBar1_servo1Degree);
            this.groupBox1_servoPosition.Controls.Add(this.label15);
            this.groupBox1_servoPosition.Controls.Add(this.label12);
            this.groupBox1_servoPosition.Controls.Add(this.label6);
            this.groupBox1_servoPosition.Controls.Add(this.label11);
            this.groupBox1_servoPosition.Controls.Add(this.label3);
            this.groupBox1_servoPosition.Controls.Add(this.label14);
            this.groupBox1_servoPosition.Controls.Add(this.label10);
            this.groupBox1_servoPosition.Controls.Add(this.label5);
            this.groupBox1_servoPosition.Controls.Add(this.label9);
            this.groupBox1_servoPosition.Controls.Add(this.label2);
            this.groupBox1_servoPosition.Controls.Add(this.label13_servo5Degree);
            this.groupBox1_servoPosition.Controls.Add(this.label8_servo4Degree);
            this.groupBox1_servoPosition.Controls.Add(this.label4_servo2Degree);
            this.groupBox1_servoPosition.Controls.Add(this.label7_servo3Degree);
            this.groupBox1_servoPosition.Controls.Add(this.label1_servo1Degree);
            this.groupBox1_servoPosition.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1_servoPosition.Location = new System.Drawing.Point(12, 12);
            this.groupBox1_servoPosition.Name = "groupBox1_servoPosition";
            this.groupBox1_servoPosition.Size = new System.Drawing.Size(490, 450);
            this.groupBox1_servoPosition.TabIndex = 0;
            this.groupBox1_servoPosition.TabStop = false;
            this.groupBox1_servoPosition.Text = "SERVO POSITION";
            // 
            // label1_servo1Degree
            // 
            this.label1_servo1Degree.AutoSize = true;
            this.label1_servo1Degree.Location = new System.Drawing.Point(132, 46);
            this.label1_servo1Degree.Name = "label1_servo1Degree";
            this.label1_servo1Degree.Size = new System.Drawing.Size(95, 19);
            this.label1_servo1Degree.TabIndex = 0;
            this.label1_servo1Degree.Text = "Servo 1 Degree = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(450, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "180°";
            // 
            // trackBar1_servo1Degree
            // 
            this.trackBar1_servo1Degree.Location = new System.Drawing.Point(31, 79);
            this.trackBar1_servo1Degree.Maximum = 180;
            this.trackBar1_servo1Degree.Name = "trackBar1_servo1Degree";
            this.trackBar1_servo1Degree.Size = new System.Drawing.Size(413, 45);
            this.trackBar1_servo1Degree.TabIndex = 3;
            this.trackBar1_servo1Degree.Scroll += new System.EventHandler(this.trackBar1_servo1Degree_Scroll);
            // 
            // label4_servo2Degree
            // 
            this.label4_servo2Degree.AutoSize = true;
            this.label4_servo2Degree.Location = new System.Drawing.Point(132, 120);
            this.label4_servo2Degree.Name = "label4_servo2Degree";
            this.label4_servo2Degree.Size = new System.Drawing.Size(97, 19);
            this.label4_servo2Degree.TabIndex = 0;
            this.label4_servo2Degree.Text = "Servo 2 Degree = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "0°";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(450, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "180°";
            // 
            // trackBar2_servo2Degree
            // 
            this.trackBar2_servo2Degree.Location = new System.Drawing.Point(31, 151);
            this.trackBar2_servo2Degree.Maximum = 180;
            this.trackBar2_servo2Degree.Name = "trackBar2_servo2Degree";
            this.trackBar2_servo2Degree.Size = new System.Drawing.Size(413, 45);
            this.trackBar2_servo2Degree.TabIndex = 3;
            this.trackBar2_servo2Degree.Scroll += new System.EventHandler(this.trackBar2_servo2Degree_Scroll);
            // 
            // label7_servo3Degree
            // 
            this.label7_servo3Degree.AutoSize = true;
            this.label7_servo3Degree.Location = new System.Drawing.Point(132, 193);
            this.label7_servo3Degree.Name = "label7_servo3Degree";
            this.label7_servo3Degree.Size = new System.Drawing.Size(97, 19);
            this.label7_servo3Degree.TabIndex = 0;
            this.label7_servo3Degree.Text = "Servo 3 Degree = ";
            // 
            // label8_servo4Degree
            // 
            this.label8_servo4Degree.AutoSize = true;
            this.label8_servo4Degree.Location = new System.Drawing.Point(132, 268);
            this.label8_servo4Degree.Name = "label8_servo4Degree";
            this.label8_servo4Degree.Size = new System.Drawing.Size(98, 19);
            this.label8_servo4Degree.TabIndex = 0;
            this.label8_servo4Degree.Text = "Servo 4 Degree = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "0°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "0°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(450, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "180°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(450, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "180°";
            // 
            // trackBar3_servo3Degree
            // 
            this.trackBar3_servo3Degree.Location = new System.Drawing.Point(31, 226);
            this.trackBar3_servo3Degree.Maximum = 180;
            this.trackBar3_servo3Degree.Name = "trackBar3_servo3Degree";
            this.trackBar3_servo3Degree.Size = new System.Drawing.Size(413, 45);
            this.trackBar3_servo3Degree.TabIndex = 3;
            this.trackBar3_servo3Degree.Scroll += new System.EventHandler(this.trackBar3_servo3Degree_Scroll);
            // 
            // trackBar4_servo4Degree
            // 
            this.trackBar4_servo4Degree.Location = new System.Drawing.Point(31, 298);
            this.trackBar4_servo4Degree.Maximum = 180;
            this.trackBar4_servo4Degree.Name = "trackBar4_servo4Degree";
            this.trackBar4_servo4Degree.Size = new System.Drawing.Size(413, 45);
            this.trackBar4_servo4Degree.TabIndex = 3;
            this.trackBar4_servo4Degree.Scroll += new System.EventHandler(this.trackBar4_servo4Degree_Scroll);
            // 
            // label13_servo5Degree
            // 
            this.label13_servo5Degree.AutoSize = true;
            this.label13_servo5Degree.Location = new System.Drawing.Point(132, 339);
            this.label13_servo5Degree.Name = "label13_servo5Degree";
            this.label13_servo5Degree.Size = new System.Drawing.Size(98, 19);
            this.label13_servo5Degree.TabIndex = 0;
            this.label13_servo5Degree.Text = "Servo 5 Degree = ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "0°";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(450, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 23);
            this.label15.TabIndex = 2;
            this.label15.Text = "180°";
            // 
            // trackBar5_servo5Degree
            // 
            this.trackBar5_servo5Degree.Location = new System.Drawing.Point(31, 372);
            this.trackBar5_servo5Degree.Maximum = 180;
            this.trackBar5_servo5Degree.Name = "trackBar5_servo5Degree";
            this.trackBar5_servo5Degree.Size = new System.Drawing.Size(413, 45);
            this.trackBar5_servo5Degree.TabIndex = 3;
            this.trackBar5_servo5Degree.Scroll += new System.EventHandler(this.trackBar5_servo5Degree_Scroll);
            // 
            // checkBox_simultaneous
            // 
            this.checkBox_simultaneous.AutoSize = true;
            this.checkBox_simultaneous.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_simultaneous.Location = new System.Drawing.Point(10, 413);
            this.checkBox_simultaneous.Name = "checkBox_simultaneous";
            this.checkBox_simultaneous.Size = new System.Drawing.Size(167, 23);
            this.checkBox_simultaneous.TabIndex = 4;
            this.checkBox_simultaneous.Text = "SIMULTANEOUS MOVEMENT";
            this.checkBox_simultaneous.UseVisualStyleBackColor = true;
            this.checkBox_simultaneous.CheckedChanged += new System.EventHandler(this.checkBox_simultaneous_CheckedChanged);
            // 
            // button_sendSimultaneous
            // 
            this.button_sendSimultaneous.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sendSimultaneous.Location = new System.Drawing.Point(183, 405);
            this.button_sendSimultaneous.Name = "button_sendSimultaneous";
            this.button_sendSimultaneous.Size = new System.Drawing.Size(301, 39);
            this.button_sendSimultaneous.TabIndex = 5;
            this.button_sendSimultaneous.Text = "SEND ALL DATA";
            this.button_sendSimultaneous.UseVisualStyleBackColor = true;
            this.button_sendSimultaneous.Click += new System.EventHandler(this.button_sendSimultaneous_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Close);
            this.groupBox2.Controls.Add(this.button_Open);
            this.groupBox2.Controls.Add(this.comboBox_baudRate);
            this.groupBox2.Controls.Add(this.comboBox_portLists);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMMUNICATION";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 23);
            this.label16.TabIndex = 2;
            this.label16.Text = "COM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 23);
            this.label17.TabIndex = 3;
            this.label17.Text = "BAUD";
            // 
            // comboBox_portLists
            // 
            this.comboBox_portLists.FormattingEnabled = true;
            this.comboBox_portLists.Location = new System.Drawing.Point(71, 29);
            this.comboBox_portLists.Name = "comboBox_portLists";
            this.comboBox_portLists.Size = new System.Drawing.Size(146, 31);
            this.comboBox_portLists.TabIndex = 4;
            this.comboBox_portLists.DropDown += new System.EventHandler(this.comboBox_portLists_DropDown);
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "38400\t",
            "57600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(71, 83);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(146, 31);
            this.comboBox_baudRate.TabIndex = 5;
            this.comboBox_baudRate.Text = "57600";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(223, 26);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 35);
            this.button_Open.TabIndex = 6;
            this.button_Open.Text = "OPEN";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(223, 80);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 35);
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "CLOSE";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-21, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 192);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(1, 475);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 10);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "ROBY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(27, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Servomotor Controller";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(824, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1_servoPosition);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "robyTestApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_servoPosition.ResumeLayout(false);
            this.groupBox1_servoPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_servo1Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_servo2Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3_servo3Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4_servo4Degree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5_servo5Degree)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_servoPosition;
        private System.Windows.Forms.Button button_sendSimultaneous;
        private System.Windows.Forms.CheckBox checkBox_simultaneous;
        private System.Windows.Forms.TrackBar trackBar5_servo5Degree;
        private System.Windows.Forms.TrackBar trackBar4_servo4Degree;
        private System.Windows.Forms.TrackBar trackBar2_servo2Degree;
        private System.Windows.Forms.TrackBar trackBar3_servo3Degree;
        private System.Windows.Forms.TrackBar trackBar1_servo1Degree;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13_servo5Degree;
        private System.Windows.Forms.Label label8_servo4Degree;
        private System.Windows.Forms.Label label4_servo2Degree;
        private System.Windows.Forms.Label label7_servo3Degree;
        private System.Windows.Forms.Label label1_servo1Degree;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ComboBox comboBox_portLists;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

