using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace werewolf
{
    public partial class WOSupporter : Form
    {
        string YName = "";//你的名字
        string YChar = "";//你的角色
        string HName = "";//苦主的名字
        string HChar = "";//苦主的角色
        string TimeString = "";//時間標記
        int YCharStat = 0;//用於標示各項可用性狀態
        int YCharID = 0;//用於表示偽裝的第幾種角色
        public WOSupporter()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            YCharID = YCharCombo.SelectedIndex;//對你的角色賦值
            YChar = YCharCombo.SelectedItem.ToString();
            YCharBox.Text = "你的身份是" + YChar + "（详细）";
            switch (YCharID)
            {
                case 0://尚未分配
                case 1://村人   
                    YCharStat = 0;
                    break;
                case 2://人狼
                    YCharStat = 1;
                    break;
                case 3://占卜师
                case 4://灵能者
                    YCharStat = 2;
                    break;
                case 5://狂人
                    YCharStat = 0;
                    break;
                case 6://猎人
                    YCharStat = 1;
                    break;
                case 7://共有者
                case 8://妖狐
                case 9://埋毒者
                    YCharStat = 0;
                    break;
                case 10://陷阱师
                    YCharStat = 1;
                    break;
                case 11://超常现象研究者
                    YCharStat = 2;
                    break;
                case 12://策士
                    YCharStat = 1;
                    break;
                case 13://骗子
                    YCharStat = 2;
                    break;
            }
            switch (YCharStat)
            {
                case 0://類似村民，妖狐等無第二人相關的職業
                    {
                        HNameBox.Enabled = false;
                        HCharCombo.Enabled = false;
                        CreateActButton.Enabled = false;
                        CopyActButton.Enabled = false;
                        TimeBox.Enabled = false;
                        HunterBox.Enabled = false;
                        DivinationFailed.Enabled = false;
                    }
                    break;
                case 1://人狼、獵人等存在第二人，但無關第二人職業的職業
                    {
                        HNameBox.Enabled = true;
                        HCharCombo.Enabled = false;
                        CreateActButton.Enabled = true;
                        CopyActButton.Enabled = true;
                        TimeBox.Enabled = true;
                        if (YCharID == 6) HunterBox.Enabled = true;//判斷是否為獵人
                        else HunterBox.Enabled = false;
                        DivinationFailed.Enabled = false;
            }
                    break;
                case 2://占卜師、靈能等和第二人有職業相關的角色
                    {
                        HNameBox.Enabled = true;
                        HCharCombo.Enabled = true;
                        CreateActButton.Enabled = true;
                        CopyActButton.Enabled = true;
                        TimeBox.Enabled = true;
                        HunterBox.Enabled = false;
                        if (YCharID == 3) DivinationFailed.Enabled = true;//判斷是否是占卜師
                        else DivinationFailed.Enabled = false;
            }
                    break;
        }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void YNameBox_TextChanged(object sender, EventArgs e)
        {
            YName = YNameBox.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(YCharBox.Text);
        }

        private void CreateActButton_Click(object sender, EventArgs e)
        {
            TimeString="\r\n"+ DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss");
            HChar = HCharCombo.SelectedItem.ToString();
            switch (YCharID)
            {
                case 2://人狼
                    ActBox.Text = "以 " + YName + " 为首的人狼们决定今晚袭击 " + HName +"。";
                    break;
                case 3://占卜師
                    {
                        if (DivinationFailed.Checked == false)
                            ActBox.Text = YName + " 占卜了 " + HName + " 的身份，他是 " + HChar + "。";
                        else
                            ActBox.Text = YName + " 占卜了 " + HName + " 的身份，但是被不知道什么人妨碍了。";
                    }
                    break;
                case 4:
                    ActBox.Text = "根据 " + YName + " 的灵能结论，被处刑的 " + HName + " 是 " + HChar + "。";
                    break;
                case 6://獵人
                    {
                        if (HunterBox.Checked == false)
                            ActBox.Text = YName + " 守护了 " + HName+"。";
                        else
                            ActBox.Text = YName + " 成功的守护了 " + HName + "。";
                    }
                    break;
                case 10://陷阱师
                    ActBox.Text = YName + " 的陷阱守护了 " + HName +"。";
                    break;
                case 11://超常现象研究者
                    {
                        if (HCharCombo.SelectedIndex == 0)
                            ActBox.Text = YName + " 调查了 " + HName + " 的周边，发现全员都是村人。";
                        else
                            ActBox.Text = YName + " 调查了 " + HName + " 的周边，发现了 "+HChar+ " 活动的迹象。";
                    }
                    break;
                case 12://策士
                    ActBox.Text = YName + " 尝试了策反 " + HName + "。";
                    break;
                case 13://骗子
                    ActBox.Text = "虽然不是很自信，根据骗子占卜的结果 " + HName + " 大概是 "+HChar+ "，大概。";
                    break;
            }
            if (TimeBox.Checked == true)//檢查是否添加時間戳
                ActBox.Text = ActBox.Text + TimeString;
        }

        private void HNameBox_TextChanged(object sender, EventArgs e)
        {
            HName = HNameBox.Text.ToString();
        }

        private void CopyActButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(ActBox.Text);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Werewolf_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    }
