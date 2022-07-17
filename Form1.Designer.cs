namespace My_Resume_Json_to_PDF
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
            this.JsonButton1 = new System.Windows.Forms.Button();
            this.ResumeLabel1 = new System.Windows.Forms.Label();
            this.ResumeTextbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // JsonButton1
            // 
            this.JsonButton1.Location = new System.Drawing.Point(406, 604);
            this.JsonButton1.Name = "JsonButton1";
            this.JsonButton1.Size = new System.Drawing.Size(154, 38);
            this.JsonButton1.TabIndex = 0;
            this.JsonButton1.Text = "Convert to Json";
            this.JsonButton1.UseVisualStyleBackColor = true;
            this.JsonButton1.Click += new System.EventHandler(this.JsonButton1_Click);
            // 
            // ResumeLabel1
            // 
            this.ResumeLabel1.AutoSize = true;
            this.ResumeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResumeLabel1.Location = new System.Drawing.Point(207, 81);
            this.ResumeLabel1.Name = "ResumeLabel1";
            this.ResumeLabel1.Size = new System.Drawing.Size(235, 39);
            this.ResumeLabel1.TabIndex = 1;
            this.ResumeLabel1.Text = "MY RESUME";
            // 
            // ResumeTextbox1
            // 
            this.ResumeTextbox1.Location = new System.Drawing.Point(12, 151);
            this.ResumeTextbox1.Multiline = true;
            this.ResumeTextbox1.Name = "ResumeTextbox1";
            this.ResumeTextbox1.Size = new System.Drawing.Size(609, 447);
            this.ResumeTextbox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 654);
            this.Controls.Add(this.ResumeTextbox1);
            this.Controls.Add(this.ResumeLabel1);
            this.Controls.Add(this.JsonButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JsonButton1;
        private System.Windows.Forms.Label ResumeLabel1;
        private System.Windows.Forms.TextBox ResumeTextbox1;
    }
}

