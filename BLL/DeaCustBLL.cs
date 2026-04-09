using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_Software.BLL
{
    internal class DeaCustBLL
    {
        public int id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
