namespace TI3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.TextBox();
            this.CreateEDS = new System.Windows.Forms.Button();
            this.edstext = new System.Windows.Forms.TextBox();
            this.Verification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(12, 12);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(410, 163);
            this.text.TabIndex = 0;
            // 
            // CreateEDS
            // 
            this.CreateEDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CreateEDS.Location = new System.Drawing.Point(12, 192);
            this.CreateEDS.Name = "CreateEDS";
            this.CreateEDS.Size = new System.Drawing.Size(410, 42);
            this.CreateEDS.TabIndex = 1;
            this.CreateEDS.Text = "Сгенерировать подпись";
            this.CreateEDS.UseVisualStyleBackColor = false;
            this.CreateEDS.Click += new System.EventHandler(this.CreateEDS_Click);
            // 
            // edstext
            // 
            this.edstext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edstext.Location = new System.Drawing.Point(12, 276);
            this.edstext.Multiline = true;
            this.edstext.Name = "edstext";
            this.edstext.Size = new System.Drawing.Size(410, 49);
            this.edstext.TabIndex = 2;
            // 
            // Verification
            // 
            this.Verification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Verification.Location = new System.Drawing.Point(12, 342);
            this.Verification.Name = "Verification";
            this.Verification.Size = new System.Drawing.Size(410, 42);
            this.Verification.TabIndex = 3;
            this.Verification.Text = "Произвести проверку";
            this.Verification.UseVisualStyleBackColor = false;
            this.Verification.Click += new System.EventHandler(this.Verification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сгенерированная подпись";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(434, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verification);
            this.Controls.Add(this.edstext);
            this.Controls.Add(this.CreateEDS);
            this.Controls.Add(this.text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЭЦП";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button CreateEDS;
        private System.Windows.Forms.TextBox edstext;
        private System.Windows.Forms.Button Verification;
        private System.Windows.Forms.TextBox eds;
        private System.Windows.Forms.Label label1;
    }
}

