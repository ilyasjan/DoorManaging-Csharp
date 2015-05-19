using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
namespace DoorManaging
{
    public class HardDeviceManaging
    {
        private static SerialPort sPorts;
        private static bool isInit = false;
        /// <summary>
        /// 数据接收接口
        /// </summary>
        public static IHardRecived rec { get; set; }
        private static string msgContent = "";

        private static void Init()
        {
            Config conf = new Config("port.conf");
            sPorts = new SerialPort(conf.getValue("portname"));
            sPorts.WriteTimeout = 5000;
            sPorts.BaudRate = 4800;
            sPorts.DiscardNull = false;
            sPorts.DtrEnable = false;
            sPorts.ParityReplace = 63;
            sPorts.ReadBufferSize = 4096;
            sPorts.ReadTimeout = -1;
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


        public static String byteToString(byte[] bs)
        {
            char[] buff = new char[1];
            sPorts.Read(buff, 0, 1);
            return buff[0].ToString();

        }
        public static string GetDatafromSerial(byte[] sr)
        {
            string kID = "";
            if (sr != null)
            {
                for (int i = 0; i < sr.Length; i++)
                {
                    string H = Convert.ToString(sr[i], 16);
                    if (H.Length == 1)
                        H = "0" + H;
                    kID = kID + H;
                }

            }
            return kID.ToUpper();
        }



       

        private static int counter = 0;
        static void sPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buff = new byte[1];
            sPorts.Read(buff, 0, 1);
            msgContent += Convert.ToString(buff[0], 16);
            counter++;
            if (counter == 4)
            {
                rec.RecievedData(msgContent);
                msgContent = "";
                counter = 0;
            }

            Console.WriteLine(msgContent);
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
