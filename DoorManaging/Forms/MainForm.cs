using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DoorManaging
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new AddNew()).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new ViewInformation()).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Managing()).ShowDialog();
        }



        //try
        //            {
        //                Database db = Database.getInstanse();
        //                db.init();
        //                var list = db.getaRow<string>("select user from user");
        //                foreach (string st in list)
        //                {
        //                    listBox1.Items.Add(st);
        //                }
        //            }
        //            catch (Exception e1)
        //            {
        //                MessageBox.Show(e1.Message);
        //            }
    }
}