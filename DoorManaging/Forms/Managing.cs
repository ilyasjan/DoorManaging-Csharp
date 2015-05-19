using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging
{
    public partial class Managing : Form, IHardRecived
    {
        private Entities.Students oldST, newST;
        delegate void HandleInterfaceUpdateDelegate(string text);
        public Managing()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RecievedData(string content)
        {
            UpdateReceiveTextBox(content);
        }

        private void UpdateReceiveTextBox(string text)
        {
            //不在同一线程
            if (txtCard.InvokeRequired)
            {
                HandleInterfaceUpdateDelegate InterfaceUpdate = new HandleInterfaceUpdateDelegate(UpdateReceiveTextBox);
                Invoke(InterfaceUpdate, new object[] { text });
            }
            //在同一线程
            else
            {
                txtCard.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.init();

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
                newST.CARD = txtCard.Text;
                newST.NAME = txtName.Text;
                newST.CLASS = txtCLASS.Text;
                newST.SNO = txtSNO.Text;
                newST.ENABLE = chkEnable.Checked;
                int i = DBO.UpdateStudent(oldST, newST);
                MessageBox.Show(String.Format("{0}个信息已被更新!", i), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e1)
            {
                DBO.Err(e1);
                MessageBox.Show(e1.Message, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //MessageBox.Show(oldST.ID.ToString());
        }

        private void Managing_Load(object sender, EventArgs e)
        {
            oldST = DBO.getStudent(this.Tag.ToString());

            txtCard.Text = oldST.CARD;
            txtCLASS.Text = oldST.CLASS;

            txtName.Text = oldST.NAME;
            txtSNO.Text = oldST.SNO;
            chkEnable.Checked = oldST.ENABLE;
            newST = new Entities.Students();
            try
            {
                
                HardDeviceManaging.rec = this;
            }
            catch (Exception ex)
            {
                DBO.Err(ex);
                MessageBox.Show(ex.Message, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
