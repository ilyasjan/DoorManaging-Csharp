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
    }
}
