using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging
{
    public partial class ViewInformation : Form
    {
        public ViewInformation()
        {
            InitializeComponent();
        }

        private void ViewInformation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBO.getEventLogs(txtCard.Text, txtMC.Text, txtXH.Text, txtBJ.Text);
        }
    }
}
