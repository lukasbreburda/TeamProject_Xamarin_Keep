using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp_Keep
{
    public class user
    {
        [PrimaryKey,]
        public int ID { get; set; }
        public string email { get; set; }
        public int type_pasword { get; set; }


        public user() {

        }
    }
}
