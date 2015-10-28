namespace werewolf
{
    partial class AboutForm
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
            this.VTextLabel = new System.Windows.Forms.Label();
            this.GTextLabel = new System.Windows.Forms.Label();
            this.VNumLable = new System.Windows.Forms.Label();
            this.GLinkLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VTextLabel
            // 
            this.VTextLabel.AutoSize = true;
            this.VTextLabel.Location = new System.Drawing.Point(9, 13);
            this.VTextLabel.Name = "VTextLabel";
            this.VTextLabel.Size = new System.Drawing.Size(53, 12);
            this.VTextLabel.TabIndex = 0;
            this.VTextLabel.Text = "Version:";
            // 
            // GTextLabel
            // 
            this.GTextLabel.AutoSize = true;
            this.GTextLabel.Location = new System.Drawing.Point(33, 37);
            this.GTextLabel.Name = "GTextLabel";
            this.GTextLabel.Size = new System.Drawing.Size(29, 12);
            this.GTextLabel.TabIndex = 1;
            this.GTextLabel.Text = "Git:";
            // 
            // VNumLable
            // 
            this.VNumLable.AutoSize = true;
            this.VNumLable.Location = new System.Drawing.Point(68, 13);
            this.VNumLable.Name = "VNumLable";
            this.VNumLable.Size = new System.Drawing.Size(0, 12);
            this.VNumLable.TabIndex = 2;
            // 
            // GLinkLabel
            // 
            this.GLinkLabel.AutoSize = true;
            this.GLinkLabel.Location = new System.Drawing.Point(68, 37);
            this.GLinkLabel.Name = "GLinkLabel";
            this.GLinkLabel.Size = new System.Drawing.Size(0, 12);
            this.GLinkLabel.TabIndex = 3;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(143, 62);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "關閉";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 97);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GLinkLabel);
            this.Controls.Add(this.VNumLable);
            this.Controls.Add(this.GTextLabel);
            this.Controls.Add(this.VTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutForm";
            this.Text = "關於程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VTextLabel;
        private System.Windows.Forms.Label GTextLabel;
        private System.Windows.Forms.Label VNumLable;
        private System.Windows.Forms.Label GLinkLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}