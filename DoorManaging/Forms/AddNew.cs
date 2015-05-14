using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySQLDriverCS;
namespace DoorManaging
{
    public partial class AddNew : Form, IHardRecived
    {

        private HardDeviceManaging hm;
        delegate void HandleInterfaceUpdateDelegate(string text);
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
                MessageBox.Show(e1.Message, "111!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            try
            {
                hm = new HardDeviceManaging();
                hm.rec = this;
                hm.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "警告!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void AddNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            hm.End();
        }
    }
}
