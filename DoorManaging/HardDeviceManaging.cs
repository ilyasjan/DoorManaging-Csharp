using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
namespace DoorManaging
{
    public class HardDeviceManaging
    {
        SerialPort sPorts;
        IHardRecived rec;
        public HardDeviceManaging(SerialPort port, IHardRecived r)
        {
            sPorts = port;
            //sPorts.DataReceived += new SerialDataReceivedEventHandler(sPorts_DataReceived);
            rec = r;
        }

        void sPorts_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte firstByte = Convert.ToByte(sPorts.ReadByte());
            int bytesRead = sPorts.BytesToRead;
            String buff = String.Format("First One :{0}\t Size:{1}", firstByte.ToString(), bytesRead);
            rec.RecievedData(buff);
        }

        public void Start(String portName)
        {
            try
            {
                sPorts.Encoding = Encoding.Default;
                sPorts.PortName = portName;
                sPorts.Open();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void Start()
        {
            try
            {
                sPorts.Open();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void OpenTheDoor()
        {
            try
            {
                
                sPorts.Write(new byte[]{255}, 0, 1);
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void LockTheDoor()
        {
            try
            {
                sPorts.Write(new byte[] { 1 }, 0, 1);
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public void End()
        {
            try
            {
                sPorts.Close();
            }

            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
