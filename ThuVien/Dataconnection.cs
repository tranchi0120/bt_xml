using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ThuVien
{
    class Dataconnection
    {
         string conStr;
        public Dataconnection()
        {
             conStr = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True";
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
