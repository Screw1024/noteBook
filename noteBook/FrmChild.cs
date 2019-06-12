using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// 添加字体相关的命令空间
using System.Drawing.Text;
using System.Collections;
using System.IO;

namespace noteBook
{
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }

        // 窗体加载事件，加载系统字体
        private void FrmChild_Load(object sender, EventArgs e)
        {
            // 系统已经安装的字体
            InstalledFontCollection myFonts = new InstalledFontCollection();
            // 获取InstalleFontCollection对象的数组
            FontFamily[] ff = myFonts.Families;
            // 声明一个ArrayList变量，为了动态增加
            ArrayList list = new ArrayList();

            int count = ff.Length;
            for (int i = 0; i < count; i++)
            {
                string  FontName = ff[i].Name;
                toolStripComboBoxFonts.Items.Add(FontName);
                
            }
        }

        // 文字加粗功能
        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Bold == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Bold);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }

        }

        // 倾斜功能
        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            if (textBoxNote.Font.Italic == false)
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Italic);
            }
            else
            {
                textBoxNote.Font = new Font(textBoxNote.Font, FontStyle.Regular);
            }
        }

        // 修改字体样式功能
        private void toolStripComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFonts.Text;
            float fontSize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontSize);
        }

        // 修改字体大小功能
        private void toolStripComboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = toolStripComboBoxFonts.Text;
            float fontSize = float.Parse(toolStripComboBoxSize.Text);
            textBoxNote.Font = new Font(fontName, fontSize);
        }

        // 打开文档
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("文本文档(*.txt)|*.txt");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                string text = sr.ReadToEnd();
                textBoxNote.Text = text;
                this.Text = path;
                // 打开文件时，将标识设置为空
                toolStripLabelMarke.Text = "";
                sr.Close();
            }
        }

        // 保存功能
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            // 首先判断当前文件对话框是否已经打开,打开功能保存的路径值
            if (this.Text == "")
            {
                if (textBoxNote.Text.Trim() != "")
                {
                    saveFileDialog1.Filter = ("文本文档（*.txt)|*.txt");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog1.FileName;
                        StreamWriter sw = new StreamWriter(path, false);
                        sw.WriteLine(textBoxNote.Text.Trim());
                        this.Text = path;
                        // 清理缓存并关闭
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    MessageBox.Show("无内容不能被保存", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                string path = this.Text;
                StreamWriter sw = new StreamWriter(path, false);
                sw.WriteLine(textBoxNote.Text.Trim());
                // 清理缓存并关闭
                sw.Flush();
                MessageBox.Show("已保存");
                sw.Close();
            }
        }

        // 修改标识
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            toolStripLabelMarke.Text = "已修改";
        }

        // 窗体关闭事件
        private void FrmChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (toolStripLabelMarke.Text == "已修改") 
            {
                DialogResult dr = MessageBox.Show("内容未被保存，是否退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    this.Dispose();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            textBoxNote.Text = "";
            toolStripLabelMarke.Text = "";
            this.Text = "";
        }
    }
}
