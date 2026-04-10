using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Billing_Software.DAL
{
    internal class DeaCustDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method For Dealer/Customer

        public DataTable Select()
        {
            DataTable dt = new DataTable();


            return dt;
        }

        #endregion
        #region Insert Method For Dealer/Customer
        #endregion
        #region Update Method For Dealer/Customer
        #endregion
        #region Delete Method For Dealer/Customer
        #endregion
    }
}
