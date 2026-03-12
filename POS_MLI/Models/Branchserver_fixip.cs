using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_MLI.Models
{
    class Branchserver_fixip
    {
        public int fix_ip_id { get; set; }
        public string ip_address { get; set; }
        public string database_name { get; set; }
        public string branchcode { get; set; }
        public string branchname { get; set; }
        public string branchcode_short { get; set; }

        internal bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
