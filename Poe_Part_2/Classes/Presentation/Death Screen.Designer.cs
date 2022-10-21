namespace GoblinSlayer
{
    partial class DeathScreen
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
            this.diedExitButton = new System.Windows.Forms.Button();
            this.diedRestartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winScreenText
            // 
            this.winScreenText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.winScreenText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.winScreenText.Enabled = false;
            this.winScreenText.Font = new System.Drawing.Font("Curlz MT", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.winScreenText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winScreenText.Location = new System.Drawing.Point(127, 150);
            this.winScreenText.Multiline = true;
            this.winScreenText.Name = "winScreenText";
            this.winScreenText.Size = new System.Drawing.Size(721, 241);
            this.winScreenText.TabIndex = 1;
            this.winScreenText.Text = "You Died";
            this.winScreenText.TextChanged += new System.EventHandler(this.winScreenText_TextChanged);
            // 
            // diedExitButton
            // 
            this.diedExitButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.diedExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.diedExitButton.FlatAppearance.BorderSize = 0;
            this.diedExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diedExitButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diedExitButton.Location = new System.Drawing.Point(158, 411);
            this.diedExitButton.Name = "diedExitButton";
            this.diedExitButton.Size = new System.Drawing.Size(99, 68);
            this.diedExitButton.TabIndex = 2;
            this.diedExitButton.Text = "Exit";
            this.diedExitButton.UseVisualStyleBackColor = false;
            this.diedExitButton.Click += new System.EventHandler(this.diedExitButton_Click);
            // 
            // diedRestartButton
            // 
            this.diedRestartButton.Cursor = System.Windows.Forms.Cursors.Help;
            this.diedRestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diedRestartButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.diedRestartButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.diedRestartButton.Location = new System.Drawing.Point(725, 411);
            this.diedRestartButton.Name = "diedRestartButton";
            this.diedRestartButton.Size = new System.Drawing.Size(99, 68);
            this.diedRestartButton.TabIndex = 4;
            this.diedRestartButton.Text = "Restart";
            this.diedRestartButton.UseVisualStyleBackColor = true;
            this.diedRestartButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeathScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.diedRestartButton);
            this.Controls.Add(this.diedExitButton);
            this.Controls.Add(this.winScreenText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeathScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DeathScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox winScreenText;
        private Button diedExitButton;
        private Button diedRestartButton;
    }
}