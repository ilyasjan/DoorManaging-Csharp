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
        public Students(System.Data.DataTable dt)
        {
            CARD = dt.Rows[0]["ucard"].ToString();

            INDEX = long.Parse(dt.Rows[0]["id"].ToString());

            SNO = dt.Rows[0]["uxh"].ToString();

            NAME = dt.Rows[0]["uname"].ToString();

            CLASS = dt.Rows[0]["uclass"].ToString();

            ENABLE = bool.Parse(dt.Rows[0]["uena"].ToString());
        }

        public String getSQLString1()
        {
            return String.Format(("'{0}','{1}','{2}','{3}',{4}"), this.CARD, this.SNO, this.NAME, this.CLASS, this.ENABLE);
        }
        public String getSQLString2()
        {
            return String.Format(("ucard='{0}',uxh='{1}',uname='{2}',uclass='{3}',uena={4}"), this.CARD, this.SNO, this.NAME, this.CLASS, this.ENABLE);
        }
    }
}
