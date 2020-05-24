namespace option_system.option_windows
{
    partial class opw4
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
            this.label1 = new System.Windows.Forms.Label();
            this.kv41 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kv42 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kv48 = new System.Windows.Forms.TextBox();
            this.kv47 = new System.Windows.Forms.TextBox();
            this.kv46 = new System.Windows.Forms.TextBox();
            this.kv45 = new System.Windows.Forms.TextBox();
            this.kv44 = new System.Windows.Forms.TextBox();
            this.kv43 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED屏幕IP";
            // 
            // kv41
            // 
            this.kv41.Location = new System.Drawing.Point(130, 32);
            this.kv41.Name = "kv41";
            this.kv41.Size = new System.Drawing.Size(100, 20);
            this.kv41.TabIndex = 1;
            this.kv41.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "监听端口";
            // 
            // kv42
            // 
            this.kv42.Location = new System.Drawing.Point(130, 61);
            this.kv42.Name = "kv42";
            this.kv42.Size = new System.Drawing.Size(46, 20);
            this.kv42.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "放行文字语音配置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kv42);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.kv41);
            this.groupBox1.Controls.Add(this.kv48);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kv47);
            this.groupBox1.Controls.Add(this.kv46);
            this.groupBox1.Controls.Add(this.kv45);
            this.groupBox1.Controls.Add(this.kv44);
            this.groupBox1.Controls.Add(this.kv43);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 368);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kv48
            // 
            this.kv48.Location = new System.Drawing.Point(130, 287);
            this.kv48.Multiline = true;
            this.kv48.Name = "kv48";
            this.kv48.Size = new System.Drawing.Size(207, 44);
            this.kv48.TabIndex = 15;
            // 
            // kv47
            // 
            this.kv47.Location = new System.Drawing.Point(130, 252);
            this.kv47.Name = "kv47";
            this.kv47.Size = new System.Drawing.Size(187, 20);
            this.kv47.TabIndex = 14;
            // 
            // kv46
            // 
            this.kv46.Location = new System.Drawing.Point(130, 215);
            this.kv46.Name = "kv46";
            this.kv46.Size = new System.Drawing.Size(187, 20);
            this.kv46.TabIndex = 13;
            // 
            // kv45
            // 
            this.kv45.Location = new System.Drawing.Point(130, 176);
            this.kv45.Name = "kv45";
            this.kv45.Size = new System.Drawing.Size(187, 20);
            this.kv45.TabIndex = 12;
            // 
            // kv44
            // 
            this.kv44.Location = new System.Drawing.Point(130, 143);
            this.kv44.Name = "kv44";
            this.kv44.Size = new System.Drawing.Size(187, 20);
            this.kv44.TabIndex = 11;
            // 
            // kv43
            // 
            this.kv43.Location = new System.Drawing.Point(130, 105);
            this.kv43.Name = "kv43";
            this.kv43.Size = new System.Drawing.Size(187, 20);
            this.kv43.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "等待检测显示文字";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "文字显示时长";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "语音播报时长";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "异常文字语音配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "搜查文字语音配置";
            // 
            // opw4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.groupBox1);
            this.Name = "opw4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LED屏幕配置";
            this.Load += new System.EventHandler(this.opw4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kv41;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kv42;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kv48;
        private System.Windows.Forms.TextBox kv47;
        private System.Windows.Forms.TextBox kv46;
        private System.Windows.Forms.TextBox kv45;
        private System.Windows.Forms.TextBox kv44;
        private System.Windows.Forms.TextBox kv43;
        private System.Windows.Forms.Button button1;
    }
}