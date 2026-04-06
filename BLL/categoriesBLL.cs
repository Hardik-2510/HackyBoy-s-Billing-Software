using System;
using System.Collections.Generic;
using System.Text;

namespace Billing_Software.BLL
{
    internal class categoriesBLL
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Description { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }
    }
}
