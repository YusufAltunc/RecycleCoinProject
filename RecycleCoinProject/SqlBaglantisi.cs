using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecycleCoinProject
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=YUSUF\\SQLEXPRESS;Initial Catalog=RecycleCoin;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
