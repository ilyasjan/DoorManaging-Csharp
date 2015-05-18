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

        private HardDeviceManaging hm;
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
            HardDeviceManaging.Open();
        }

        private void 关ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardDeviceManaging.Lock();
        }

        public void RecievedData(string content)
        {
            UpdateReceiveTextBox(content);
        }
        private void UpdateReceiveTextBox(string text)
        {
            //不在同一线程
            if (dataGridView1.InvokeRequired)
            {
                HandleInterfaceUpdateDelegate InterfaceUpdate = new HandleInterfaceUpdateDelegate(UpdateReceiveTextBox);
                Invoke(InterfaceUpdate, new object[] { text });
            }
            //在同一线程
            else
            {
                AddToLog(text);
            }
        }


        private void AddToLog(String ucard)
        {
            try
            {
                Entities.Students stu = DBO.getStudentKH(ucard);
                String dt = DateTime.Today.ToOADate().ToString();
                String evnt = "禁止进门.";
                if (stu.ENABLE)
                {
                    HardDeviceManaging.Open();
                    evnt = "允许进门.";
                }
                DBO.Record(stu, dt, evnt);
            }
            catch (Exception e)
            { 
                
            }
        }
        private void MainWithGrid_Load(object sender, EventArgs e)
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
    }
}
