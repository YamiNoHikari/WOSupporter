using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace werewolf
{
    public partial class AboutForm : Form
    {
        string Version = "0.0.1";
        string Git = "https://github.com/YamiNoHikari/WOSupporter";
        public AboutForm()
        {
            InitializeComponent();
            VNumLable.Text = Version;
            GLinkLabel.Text = Git;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
