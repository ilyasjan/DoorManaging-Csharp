using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging
{
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Database db = new Database();
            //db.init();
            
            foreach (Control ct in this.Controls)
            {
                if (ct is TextBox)
                    if (((TextBox)ct).Text.Trim().Length < 1)
                    {
                        MessageBox.Show("不能为空!", "警告!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            try
            {
                var st = new Entities.Students();
                st.CARD = txtCard.Text;
                st.CLASS = txtCLASS.Text;
                st.SNO = txtSNO.Text;
                st.ENABLE = chkEnable.Checked;
                int i = DBO.AddStudent(st);
                MessageBox.Show(String.Format("{0}个信息已被添加!", i), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
