using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noteBook
{
    public partial class FrmParent : Form
    {
        public FrmParent()
        {
            InitializeComponent();
        }

        // 新建
        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            // 实例化一个子窗体对象
            FrmChild child = new FrmChild();
            // 设置子窗体的父窗体
            child.MdiParent = this;
            child.Show();
        }

        // 关闭
        private void ToolStripMenuItemClose_Click(object sender, EventArgs e)
        {
           // 当前处于激活状态的子窗体
           Form frm = this.ActiveMdiChild;

           if (frm != null)
           {
               frm.Close();
           }
           else
           {
               MessageBox.Show("尚未打开文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
                
        }

        // 关闭全部
        private void ToolStripMenuItemCloseAll_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren != null)
            {
                foreach (Form form in this.MdiChildren) 
                {
                    // 当前处于激活状态的子窗体
                    Form frm = this.ActiveMdiChild;
                    if (frm != null)
                    {
                        frm.Close();
                    }
                    else
                    {
                        MessageBox.Show("尚未打开文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }              
            }
        }

        // 退出
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
