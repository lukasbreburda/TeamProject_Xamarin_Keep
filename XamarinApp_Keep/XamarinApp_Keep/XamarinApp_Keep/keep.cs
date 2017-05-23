using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp_Keep
{
    public class keep
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string text { get; set; }
        public string time { get; set; }
        public int kategory { get; set; }

       
    }
}
