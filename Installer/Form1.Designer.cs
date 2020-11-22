namespace Installer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeviceID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Serial_Number = new System.Windows.Forms.Label();
            this.Setup = new System.Windows.Forms.Button();
            this.label_test = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logpath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(455, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Физический диск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DeviceID
            // 
            this.DeviceID.AutoSize = true;
            this.DeviceID.Location = new System.Drawing.Point(206, 118);
            this.DeviceID.Name = "DeviceID";
            this.DeviceID.Size = new System.Drawing.Size(76, 17);
            this.DeviceID.TabIndex = 3;
            this.DeviceID.Text = "Device ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Serial Number:";
            // 
            // Serial_Number
            // 
            this.Serial_Number.AutoSize = true;
            this.Serial_Number.Location = new System.Drawing.Point(206, 159);
            this.Serial_Number.Name = "Serial_Number";
            this.Serial_Number.Size = new System.Drawing.Size(102, 17);
            this.Serial_Number.TabIndex = 5;
            this.Serial_Number.Text = "Serial Number:";
            // 
            // Setup
            // 
            this.Setup.Location = new System.Drawing.Point(253, 240);
            this.Setup.Name = "Setup";
            this.Setup.Size = new System.Drawing.Size(132, 45);
            this.Setup.TabIndex = 6;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            this.Setup.Click += new System.EventHandler(this.Setup_Click);
            // 
            // label_test
            // 
            this.label_test.AutoSize = true;
            this.label_test.Location = new System.Drawing.Point(30, 319);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(177, 17);
            this.label_test.TabIndex = 7;
            this.label_test.Text = "Записанный серийный №";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Логический путь установки:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логический путь:";
            // 
            // logpath
            // 
            this.logpath.AutoSize = true;
            this.logpath.Location = new System.Drawing.Point(209, 201);
            this.logpath.Name = "logpath";
            this.logpath.Size = new System.Drawing.Size(46, 17);
            this.logpath.TabIndex = 11;
            this.logpath.Text = "label6";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logpath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.Setup);
            this.Controls.Add(this.Serial_Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeviceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DeviceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Serial_Number;
        private System.Windows.Forms.Button Setup;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logpath;
        private System.Windows.Forms.TextBox textBox1;
    }
}

