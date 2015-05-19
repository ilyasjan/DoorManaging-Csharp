using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging.Forms
{
    public partial class MainWithGrid : Form, IHardRecived
    {

        delegate void HandleInterfaceUpdateDelegate(string text);

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
            HardDeviceManaging.OpenTheDoor();
            timer1.Enabled = true;
        }

        private void 关ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardDeviceManaging.LockTheDoor();
        }

        public void RecievedData(string content)
        {
            UpdateReceiveTextBox(content);
        }
        private void UpdateReceiveTextBox(string text)
        {
            //不在同一线程
            if (lbl_sno.InvokeRequired)
            {
                HandleInterfaceUpdateDelegate InterfaceUpdate = new HandleInterfaceUpdateDelegate(UpdateReceiveTextBox);
                Invoke(InterfaceUpdate, text);
            }
            //在同一线程
            else
            {
                AddToLog(text);
                //lbl_sno.Invoke(AddToLog, new object[] { text });
            }
        }


        private void AddToLog(String ucard)
        {
            try
            {
                Entities.Students stu = DBO.getStudentKH(ucard);
                String dt = DateTime.Now.ToString();
                String evnt = "禁止进门.";
                if (stu!=null)
                {
                    if (stu.ENABLE)
                    {
                        HardDeviceManaging.OpenTheDoor();
                        timer1.Enabled = true;
                        evnt = "允许进门.";
                    }

                    lbl_card.Text = stu.CARD;
                    lbl_class.Text = stu.CLASS;
                    lbl_dtime.Text = dt;
                    lbl_name.Text = stu.NAME;
                    lbl_ordre.Text = evnt;
                    lbl_sno.Text = stu.SNO;
                    DBO.Record(stu, dt, evnt);
                }
                else
                {
                    MessageBox.Show("未注册!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                DBO.Err(e);
                MessageBox.Show(e.Message);
            }
        }
        private void MainWithGrid_Load(object sender, EventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            HardDeviceManaging.LockTheDoor();
            timer1.Enabled = false;
        }
    }
}
