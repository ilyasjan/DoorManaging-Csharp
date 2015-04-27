using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging.Forms
{
    public partial class HardDeviceTest : Form, IHardRecived
    {
        HardDeviceManaging hm;
        public HardDeviceTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                hm.Start();
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message);
            }
        }

        private void HardDeviceTest_Load(object sender, EventArgs e)
        {
            try
            {
                hm = new HardDeviceManaging(serialPort1,this);
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hm.OpenTheDoor();
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                hm.LockTheDoor();
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                hm.End();
            }
            catch (Exception e1)
            {
                ShowErrorMessage(e1.Message);
            }
        }


        private void ShowErrorMessage(String content)
        {
            MessageBox.Show(content, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void ShowInfoMessage(String content)
        {
            MessageBox.Show(content, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void RecievedData(string content)
        {
            ShowInfoMessage(content);
        }
    }
}
