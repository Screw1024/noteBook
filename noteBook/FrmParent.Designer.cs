﻿namespace noteBook
{
    partial class FrmParent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemClose,
            this.ToolStripMenuItemCloseAll,
            this.ToolStripMenuItemExit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(152, 24);
            this.ToolStripMenuItemNew.Text = "新建";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(152, 24);
            this.ToolStripMenuItemClose.Text = "关闭";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuItemClose_Click);
            // 
            // ToolStripMenuItemCloseAll
            // 
            this.ToolStripMenuItemCloseAll.Name = "ToolStripMenuItemCloseAll";
            this.ToolStripMenuItemCloseAll.Size = new System.Drawing.Size(152, 24);
            this.ToolStripMenuItemCloseAll.Text = "关闭全部";
            this.ToolStripMenuItemCloseAll.Click += new System.EventHandler(this.ToolStripMenuItemCloseAll_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(152, 24);
            this.ToolStripMenuItemExit.Text = "退出";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 692);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCloseAll;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
    }
}