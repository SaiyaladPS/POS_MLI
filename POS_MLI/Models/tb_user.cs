using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MLI.Models
{
    class tb_user
    {
        public int user_id { get; set; }
        public string user_fname { get; set; }
        public string user_lname { get; set; }
        public string user_username { get; set; }
        public string user_password { get; set; }
        public string user_created { get; set; }
        public string user_updated { get; set; }
        public int user_type_id { get; set; }
    }
}
