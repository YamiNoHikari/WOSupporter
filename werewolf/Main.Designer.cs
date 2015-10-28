namespace werewolf
{
    partial class WOSupporter
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.YNameLabel = new System.Windows.Forms.Label();
            this.YNameBox = new System.Windows.Forms.TextBox();
            this.YCharLabel = new System.Windows.Forms.Label();
            this.YCharCombo = new System.Windows.Forms.ComboBox();
            this.HNameLabel = new System.Windows.Forms.Label();
            this.YCharBox = new System.Windows.Forms.TextBox();
            this.HNameBox = new System.Windows.Forms.TextBox();
            this.HCharCombo = new System.Windows.Forms.ComboBox();
            this.HCharLabel = new System.Windows.Forms.Label();
            this.ActBox = new System.Windows.Forms.TextBox();
            this.CopyCharButton = new System.Windows.Forms.Button();
            this.CreateActButton = new System.Windows.Forms.Button();
            this.CopyActButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.HunterBox = new System.Windows.Forms.CheckBox();
            this.DivinationFailed = new System.Windows.Forms.CheckBox();
            this.TimeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // YNameLabel
            // 
            this.YNameLabel.AutoSize = true;
            this.YNameLabel.Location = new System.Drawing.Point(16, 14);
            this.YNameLabel.Name = "YNameLabel";
            this.YNameLabel.Size = new System.Drawing.Size(65, 12);
            this.YNameLabel.TabIndex = 0;
            this.YNameLabel.Text = "你的名字：";
            // 
            // YNameBox
            // 
            this.YNameBox.Location = new System.Drawing.Point(84, 10);
            this.YNameBox.Name = "YNameBox";
            this.YNameBox.Size = new System.Drawing.Size(128, 21);
            this.YNameBox.TabIndex = 1;
            this.YNameBox.TextChanged += new System.EventHandler(this.YNameBox_TextChanged);
            // 
            // YCharLabel
            // 
            this.YCharLabel.AutoSize = true;
            this.YCharLabel.Location = new System.Drawing.Point(224, 13);
            this.YCharLabel.Name = "YCharLabel";
            this.YCharLabel.Size = new System.Drawing.Size(65, 12);
            this.YCharLabel.TabIndex = 2;
            this.YCharLabel.Text = "偽裝角色：";
            // 
            // YCharCombo
            // 
            this.YCharCombo.FormattingEnabled = true;
            this.YCharCombo.Items.AddRange(new object[] {
            "尚未分配",
            "村人",
            "人狼",
            "占卜师",
            "灵能者",
            "狂人",
            "猎人",
            "共有者",
            "妖狐",
            "埋毒者",
            "陷阱师",
            "超常现象研究者",
            "策士",
            "骗子"});
            this.YCharCombo.Location = new System.Drawing.Point(295, 10);
            this.YCharCombo.Name = "YCharCombo";
            this.YCharCombo.Size = new System.Drawing.Size(121, 20);
            this.YCharCombo.TabIndex = 3;
            this.YCharCombo.Text = "尚未分配";
            this.YCharCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HNameLabel
            // 
            this.HNameLabel.AutoSize = true;
            this.HNameLabel.Location = new System.Drawing.Point(16, 70);
            this.HNameLabel.Name = "HNameLabel";
            this.HNameLabel.Size = new System.Drawing.Size(65, 12);
            this.HNameLabel.TabIndex = 4;
            this.HNameLabel.Text = "目標名字：";
            // 
            // YCharBox
            // 
            this.YCharBox.Location = new System.Drawing.Point(18, 37);
            this.YCharBox.Name = "YCharBox";
            this.YCharBox.ReadOnly = true;
            this.YCharBox.Size = new System.Drawing.Size(194, 21);
            this.YCharBox.TabIndex = 5;
            this.YCharBox.Text = "你的身份是尚未分配（详细）";
            this.YCharBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HNameBox
            // 
            this.HNameBox.Enabled = false;
            this.HNameBox.Location = new System.Drawing.Point(84, 67);
            this.HNameBox.Name = "HNameBox";
            this.HNameBox.Size = new System.Drawing.Size(128, 21);
            this.HNameBox.TabIndex = 6;
            this.HNameBox.TextChanged += new System.EventHandler(this.HNameBox_TextChanged);
            // 
            // HCharCombo
            // 
            this.HCharCombo.Enabled = false;
            this.HCharCombo.FormattingEnabled = true;
            this.HCharCombo.Items.AddRange(new object[] {
            "村人",
            "人狼",
            "吸血鬼"});
            this.HCharCombo.Location = new System.Drawing.Point(295, 67);
            this.HCharCombo.Name = "HCharCombo";
            this.HCharCombo.Size = new System.Drawing.Size(121, 20);
            this.HCharCombo.TabIndex = 7;
            this.HCharCombo.Text = "人狼";
            // 
            // HCharLabel
            // 
            this.HCharLabel.AutoSize = true;
            this.HCharLabel.Location = new System.Drawing.Point(224, 70);
            this.HCharLabel.Name = "HCharLabel";
            this.HCharLabel.Size = new System.Drawing.Size(65, 12);
            this.HCharLabel.TabIndex = 8;
            this.HCharLabel.Text = "指定結果：";
            // 
            // ActBox
            // 
            this.ActBox.Location = new System.Drawing.Point(18, 116);
            this.ActBox.Multiline = true;
            this.ActBox.Name = "ActBox";
            this.ActBox.ReadOnly = true;
            this.ActBox.Size = new System.Drawing.Size(398, 67);
            this.ActBox.TabIndex = 9;
            // 
            // CopyCharButton
            // 
            this.CopyCharButton.Location = new System.Drawing.Point(226, 35);
            this.CopyCharButton.Name = "CopyCharButton";
            this.CopyCharButton.Size = new System.Drawing.Size(190, 23);
            this.CopyCharButton.TabIndex = 10;
            this.CopyCharButton.Text = "複製偽裝角色";
            this.CopyCharButton.UseVisualStyleBackColor = true;
            this.CopyCharButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateActButton
            // 
            this.CreateActButton.Enabled = false;
            this.CreateActButton.Location = new System.Drawing.Point(18, 189);
            this.CreateActButton.Name = "CreateActButton";
            this.CreateActButton.Size = new System.Drawing.Size(93, 23);
            this.CreateActButton.TabIndex = 11;
            this.CreateActButton.Text = "生成文本";
            this.CreateActButton.UseVisualStyleBackColor = true;
            this.CreateActButton.Click += new System.EventHandler(this.CreateActButton_Click);
            // 
            // CopyActButton
            // 
            this.CopyActButton.Enabled = false;
            this.CopyActButton.Location = new System.Drawing.Point(125, 189);
            this.CopyActButton.Name = "CopyActButton";
            this.CopyActButton.Size = new System.Drawing.Size(87, 23);
            this.CopyActButton.TabIndex = 12;
            this.CopyActButton.Text = "複製文本";
            this.CopyActButton.UseVisualStyleBackColor = true;
            this.CopyActButton.Click += new System.EventHandler(this.CopyActButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(226, 189);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(87, 23);
            this.AboutButton.TabIndex = 13;
            this.AboutButton.Text = "關於程式";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(327, 189);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 23);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "退出程式";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HunterBox
            // 
            this.HunterBox.AutoSize = true;
            this.HunterBox.Enabled = false;
            this.HunterBox.Location = new System.Drawing.Point(18, 94);
            this.HunterBox.Name = "HunterBox";
            this.HunterBox.Size = new System.Drawing.Size(96, 16);
            this.HunterBox.TabIndex = 15;
            this.HunterBox.Text = "獵人守護成功";
            this.HunterBox.UseVisualStyleBackColor = true;
            // 
            // DivinationFailed
            // 
            this.DivinationFailed.AutoSize = true;
            this.DivinationFailed.Enabled = false;
            this.DivinationFailed.Location = new System.Drawing.Point(128, 94);
            this.DivinationFailed.Name = "DivinationFailed";
            this.DivinationFailed.Size = new System.Drawing.Size(84, 16);
            this.DivinationFailed.TabIndex = 16;
            this.DivinationFailed.Text = "占卜被妨礙";
            this.DivinationFailed.UseVisualStyleBackColor = true;
            // 
            // TimeBox
            // 
            this.TimeBox.AutoSize = true;
            this.TimeBox.Location = new System.Drawing.Point(226, 94);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(84, 16);
            this.TimeBox.TabIndex = 17;
            this.TimeBox.Text = "增加時間戳";
            this.TimeBox.UseVisualStyleBackColor = true;
            // 
            // WOSupporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 219);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.DivinationFailed);
            this.Controls.Add(this.HunterBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.CopyActButton);
            this.Controls.Add(this.CreateActButton);
            this.Controls.Add(this.CopyCharButton);
            this.Controls.Add(this.ActBox);
            this.Controls.Add(this.HCharLabel);
            this.Controls.Add(this.HCharCombo);
            this.Controls.Add(this.HNameBox);
            this.Controls.Add(this.YCharBox);
            this.Controls.Add(this.HNameLabel);
            this.Controls.Add(this.YCharCombo);
            this.Controls.Add(this.YCharLabel);
            this.Controls.Add(this.YNameBox);
            this.Controls.Add(this.YNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "WOSupporter";
            this.Text = "【見習】人狼偽裝師 - 徵求共有者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label YNameLabel;
        private System.Windows.Forms.TextBox YNameBox;
        private System.Windows.Forms.Label YCharLabel;
        private System.Windows.Forms.ComboBox YCharCombo;
        private System.Windows.Forms.Label HNameLabel;
        private System.Windows.Forms.TextBox YCharBox;
        private System.Windows.Forms.TextBox HNameBox;
        private System.Windows.Forms.ComboBox HCharCombo;
        private System.Windows.Forms.Label HCharLabel;
        private System.Windows.Forms.TextBox ActBox;
        private System.Windows.Forms.Button CopyCharButton;
        private System.Windows.Forms.Button CreateActButton;
        private System.Windows.Forms.Button CopyActButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox HunterBox;
        private System.Windows.Forms.CheckBox DivinationFailed;
        private System.Windows.Forms.CheckBox TimeBox;
    }
}

