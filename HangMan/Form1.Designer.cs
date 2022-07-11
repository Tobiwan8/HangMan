namespace HangMan
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
            this.WelcomeSign = new System.Windows.Forms.TextBox();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeSign
            // 
            this.WelcomeSign.BackColor = System.Drawing.SystemColors.Control;
            this.WelcomeSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeSign.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeSign.Location = new System.Drawing.Point(94, 51);
            this.WelcomeSign.Name = "WelcomeSign";
            this.WelcomeSign.Size = new System.Drawing.Size(204, 19);
            this.WelcomeSign.TabIndex = 0;
            this.WelcomeSign.Text = "Welcome to HangMan!";
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartGame.Location = new System.Drawing.Point(154, 144);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(75, 23);
            this.btn_StartGame.TabIndex = 1;
            this.btn_StartGame.Text = "New Game";
            this.btn_StartGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.WelcomeSign);
            this.Name = "Form1";
            this.Text = "HangMan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeSign;
        private System.Windows.Forms.Button btn_StartGame;
    }
}

