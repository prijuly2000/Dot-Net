namespace BatchB_Quiz
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
            this.batchB_Login1 = new BatchB_LoginControl.BatchB_Login();
            this.SuspendLayout();
            // 
            // batchB_Login1
            // 
            this.batchB_Login1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchB_Login1.Location = new System.Drawing.Point(2, -1);
            this.batchB_Login1.Margin = new System.Windows.Forms.Padding(5);
            this.batchB_Login1.Name = "batchB_Login1";
            this.batchB_Login1.Password = "Welcome@123";
            this.batchB_Login1.Size = new System.Drawing.Size(286, 160);
            this.batchB_Login1.TabIndex = 0;
            this.batchB_Login1.UserName = "IACSD";
            this.batchB_Login1.loginClk += new System.EventHandler(this.batchB_Login1_loginClk);
            this.batchB_Login1.Load += new System.EventHandler(this.batchB_Login1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 169);
            this.Controls.Add(this.batchB_Login1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BatchB_LoginControl.BatchB_Login batchB_Login1;
    }
}

