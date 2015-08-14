namespace MyApplication
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
            this.myLogin1 = new MyLoginControl.MyLogin();
            this.SuspendLayout();
            // 
            // myLogin1
            // 
            this.myLogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.myLogin1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLogin1.Location = new System.Drawing.Point(-2, 0);
            this.myLogin1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.myLogin1.Name = "myLogin1";
            this.myLogin1.Size = new System.Drawing.Size(267, 132);
            this.myLogin1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 127);
            this.Controls.Add(this.myLogin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyLoginControl.MyLogin myLogin1;
    }
}

