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
                    String K = KV.Split('=')[0].Trim();
                    if (K.Contains("#"))
                    {
                        continue;
                    }
                    String V = KV.Split('=')[1].Trim();
                    KeyValue.Add(K, V);
                }
                catch (Exception)
                {
                   // throw e;
                }
            }
        }

        public string getValue(string Key)
        {
            return KeyValue[Key];
        }
    }
}
