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
            this.开机启动 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 开机启动
            // 
            this.开机启动.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.开机启动.BackColor = System.Drawing.SystemColors.Control;
            this.开机启动.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.开机启动.FormattingEnabled = true;
            this.开机启动.Items.AddRange(new object[] {
            "开机启动",
            "托盘运行",
            "报警时弹出"});
            this.开机启动.Location = new System.Drawing.Point(37, 79);
            this.开机启动.Margin = new System.Windows.Forms.Padding(10);
            this.开机启动.Name = "开机启动";
            this.开机启动.Size = new System.Drawing.Size(511, 77);
            this.开机启动.TabIndex = 0;
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
            // opw5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.开机启动);
            this.Name = "opw5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件配置";
            this.Load += new System.EventHandler(this.opw5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox 开机启动;
        private System.Windows.Forms.Label label1;
    }
}