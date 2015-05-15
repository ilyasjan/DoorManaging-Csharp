using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging.Forms
{
    public partial class MainWithGrid : Form
    {
        public MainWithGrid()
        {
            InitializeComponent();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Forms.AboutApp();
            frm.ShowDialog();
        }

        private void 添加新用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddNew();
            form.ShowDialog();
        }

        private void 维护用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UserInfos();
            form.ShowDialog();
        }

        private void 查询所有的记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ViewInformation();
            form.ShowDialog();
        }

        private void 开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardDeviceManaging.Open();
        }

        private void 关ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardDeviceManaging.Lock();
        }
    }
}
