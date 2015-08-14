namespace InventoryMS
{
    partial class Form4
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
            this.mySearch1 = new FileReadControl.MySearch();
            this.SuspendLayout();
            // 
            // mySearch1
            // 
            this.mySearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mySearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mySearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mySearch1.Location = new System.Drawing.Point(0, 0);
            this.mySearch1.Margin = new System.Windows.Forms.Padding(4);
            this.mySearch1.Name = "mySearch1";
            this.mySearch1.Size = new System.Drawing.Size(324, 109);
            this.mySearch1.TabIndex = 0;
            this.mySearch1.fileDemo += new System.EventHandler(this.mySearch1_fileDemo);
            this.mySearch1.fileError += new System.EventHandler(this.mySearch1_fileError);
            this.mySearch1.Load += new System.EventHandler(this.mySearch1_Load);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 108);
            this.Controls.Add(this.mySearch1);
            this.Name = "Form4";
            this.Text = "Search";
            this.ResumeLayout(false);

        }

        #endregion

        private FileReadControl.MySearch mySearch1;
    }
}