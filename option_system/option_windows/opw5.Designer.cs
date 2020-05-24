namespace option_system.option_windows
{
    partial class opw5
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
            this.button1 = new System.Windows.Forms.Button();
            this.kv51 = new System.Windows.Forms.CheckBox();
            this.kv52 = new System.Windows.Forms.CheckBox();
            this.kv53 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "选项";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kv51
            // 
            this.kv51.AutoSize = true;
            this.kv51.Location = new System.Drawing.Point(37, 85);
            this.kv51.Name = "kv51";
            this.kv51.Size = new System.Drawing.Size(74, 17);
            this.kv51.TabIndex = 30;
            this.kv51.Text = "开机启动";
            this.kv51.UseVisualStyleBackColor = true;
            // 
            // kv52
            // 
            this.kv52.AutoSize = true;
            this.kv52.Location = new System.Drawing.Point(37, 108);
            this.kv52.Name = "kv52";
            this.kv52.Size = new System.Drawing.Size(74, 17);
            this.kv52.TabIndex = 31;
            this.kv52.Text = "托盘运行";
            this.kv52.UseVisualStyleBackColor = true;
            // 
            // kv53
            // 
            this.kv53.AutoSize = true;
            this.kv53.Location = new System.Drawing.Point(37, 131);
            this.kv53.Name = "kv53";
            this.kv53.Size = new System.Drawing.Size(86, 17);
            this.kv53.TabIndex = 32;
            this.kv53.Text = "报警时弹出";
            this.kv53.UseVisualStyleBackColor = true;
            // 
            // opw5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.kv53);
            this.Controls.Add(this.kv52);
            this.Controls.Add(this.kv51);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "opw5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件配置";
            this.Load += new System.EventHandler(this.opw5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox kv51;
        private System.Windows.Forms.CheckBox kv52;
        private System.Windows.Forms.CheckBox kv53;
    }
}