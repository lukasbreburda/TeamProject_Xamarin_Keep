using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp_Keep
{
   public class text_password
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int id_user { get; set; }
        public int password { get; set; }
    }
}
