using System;
using System.Collections.Generic;
using System.Text;

namespace DoorManaging.Entities
{
    public sealed class Students
    {

        private long INDEX = -1;
        public long ID { get { return INDEX; } }
        public String CARD { get; set; }
        public Boolean ENABLE { get; set; }
        public String NAME { get; set; }
        public String SNO { get; set; }
        public String CLASS { get; set; }
        public Students()
        {
            INDEX = -1;
        }

        public Students(long index, String card, String sno, String name, String classs, Boolean enable)
        {
            CARD = card;
            INDEX = index;
            SNO = sno;
            NAME = name;
            CLASS = classs;
            ENABLE = enable;
        }

        public String getSQLString1()
        {
            return String.Format(("'{0}','{1}','{2}','{3}','{4}'"),this.CARD, this.SNO, this.NAME, this.CLASS, this.ENABLE);
        }
        public String getSQLString2()
        {
            return String.Format(("card='{0}',sno='{1}',name='{2}',classs='{3}',enable='{4}'"), this.CARD,this.SNO, this.NAME, this.CLASS, this.ENABLE);
        }
    }
}
