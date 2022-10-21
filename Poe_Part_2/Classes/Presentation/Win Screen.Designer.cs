namespace GoblinSlayer
{
    partial class WinScreen
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
            this.winScreenText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // winScreenText
            // 
            this.winScreenText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.winScreenText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winScreenText.Font = new System.Drawing.Font("Curlz MT", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winScreenText.ForeColor = System.Drawing.SystemColors.Window;
            this.winScreenText.Location = new System.Drawing.Point(77, 144);
            this.winScreenText.Multiline = true;
            this.winScreenText.Name = "winScreenText";
            this.winScreenText.Size = new System.Drawing.Size(811, 241);
            this.winScreenText.TabIndex = 0;
            this.winScreenText.Text = "You Won!";
            this.winScreenText.TextChanged += new System.EventHandler(this.winScreenText_TextChanged);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.winScreenText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox winScreenText;
    }
}