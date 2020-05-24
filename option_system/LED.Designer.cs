namespace option_system
{
    partial class LED
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            // 
            // Pic
            // 
            this.Pic.Image = global::option_system.Properties.Resources.green;
            this.Pic.Location = new System.Drawing.Point(0, 0);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(100, 50);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.pictureBox1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic;
    }
}
