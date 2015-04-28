using System;
using System.Collections.Generic;
using System.Text;

namespace DoorManaging
{
    public sealed class Config
    {
        public String FileName { get; set; }
        private Dictionary<String, String> KeyValue;
        public Config(String FileName)
        {
            this.FileName = FileName;
            init();
        }

        public Config()
        {

        }

        public void init()
        {
            KeyValue = new Dictionary<string, string>();
            String FContent = System.IO.File.ReadAllText(FileName, Encoding.Default);
            String[] KVList = FContent.Split(';');
            foreach (String KV in KVList)
            {
                try
                {
                    String K = KV.Split('=')[0];
                    String V = KV.Split('=')[1];
                    KeyValue.Add(K, V);
                }
                catch (Exception e)
                {
                   // throw e;
                }
            }
        }

        public String getValue(String Key)
        {
            return KeyValue[Key];
        }
    }
}
