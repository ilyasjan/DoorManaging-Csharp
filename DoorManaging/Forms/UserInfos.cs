﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging
{
    public partial class UserInfos : Form
    {
        public UserInfos()
        {
            InitializeComponent();
        }

        private void ViewInformation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBO.getStudents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DBO.getStudents(txtCard.Text, txtMC.Text, txtXH.Text, txtBJ.Text);
        }
    }
}
