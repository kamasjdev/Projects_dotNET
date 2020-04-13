namespace DevKitOknoRS232
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Otwórz";
            this.button1.Click += new System.EventHandler(this.Openn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamknij";
            this.button2.Click += new System.EventHandler(this.Closee);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(83, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.Text = "P1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(434, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.Text = "P2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Location = new System.Drawing.Point(41, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 87);
            this.button3.TabIndex = 8;
            this.button3.Text = "Włącz";
            this.button3.Click += new System.EventHandler(this.P1_On);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(41, 349);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 87);
            this.button4.TabIndex = 9;
            this.button4.Text = "Wyłącz";
            this.button4.Click += new System.EventHandler(this.P1_Off);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(390, 349);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 87);
            this.button5.TabIndex = 11;
            this.button5.Text = "Wyłącz";
            this.button5.Click += new System.EventHandler(this.P2_Off);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.PaleGreen;
            this.button6.Location = new System.Drawing.Point(390, 211);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(161, 87);
            this.button6.TabIndex = 10;
            this.button6.Text = "Włącz";
            this.button6.Click += new System.EventHandler(this.P2_On);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1Port_DataReceived);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(207, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 52);
            this.label4.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.Add("COM1");
            this.comboBox1.Items.Add("COM2");
            this.comboBox1.Items.Add("COM3");
            this.comboBox1.Items.Add("COM4");
            this.comboBox1.Items.Add("COM5");
            this.comboBox1.Items.Add("COM6");
            this.comboBox1.Items.Add("COM7");
            this.comboBox1.Items.Add("COM8");
            this.comboBox1.Items.Add("COM9");
            this.comboBox1.Location = new System.Drawing.Point(83, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.Text = "Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Sterowanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

