using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
namespace DoorManaging
{
    public class HardDeviceManaging
    {
        private static SerialPort sPorts;
        /// <summary>
        /// 数据接收接口
        /// </summary>
        public static IHardRecived rec { get; set; }

        private static void Init()
        {
            Config conf = new Config("port.conf");
            sPorts = new SerialPort(conf.getValue("portname"));
            sPorts.WriteTimeout = 2000;
            sPorts.BaudRate = 4800;
            sPorts.DiscardNull = false;
            sPorts.DtrEnable = false;
            sPorts.ParityReplace = 63;
            sPorts.ReadBufferSize = 4096;
            sPorts.ReadTimeout = 2000;
            sPorts.ReceivedBytesThreshold = 1;
            sPorts.RtsEnable = false;
            sPorts.StopBits = StopBits.One;
            sPorts.WriteBufferSize = 2048;
            sPorts.DataReceived += new SerialDataReceivedEventHandler(sPorts_DataReceived);
            sPorts.Open();
        }


        /// <summary>
        /// 使用前必须实现IHardRecived,并付给hm.rec属性
        /// </summary>
        public static void Initial()
        {
            if (sPorts == null)
            {
                Init();
            }
        }


        static void sPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string text = "";
            int length = sPorts.BytesToRead;
            byte[] RevData = new byte[length];
            sPorts.Read(RevData, 0, length);//读串口接收缓冲区中的数据到RevData中
            for (int i = 0; i < length; i++)
            {
                text += Convert.ToString(RevData[i], 16);
            }
            rec.RecievedData(text);
            //UpdateReceiveTextBox(text);//在接收文本框中显示            

        }


        public static void OpenTheDoor()
        {
            try
            {

                sPorts.Write(new byte[] { 0xf0 }, 0, 1);
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public static void LockTheDoor()
        {
            try
            {
                sPorts.Write(new byte[] { 0xff }, 0, 1);
            }

            catch (Exception e)
            {
                throw e;
            }
        }


        public static void PortClose()
        {
            if (sPorts != null)
                sPorts.Close();
        }
    }
}
