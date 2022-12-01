using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtOtomasyanSistemi
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-GPMKKC5N\\SQLEXPRESS;Initial Catalog=YurtOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
