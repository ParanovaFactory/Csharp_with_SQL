using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_withSQL
{
    public class SQLConnection
    {
        SqlConnection connenct = new SqlConnection(@"Data Source=PREDATOR;Initial Catalog=DbVisit;Integrated Security=True;TrustServerCertificate=True");
    }
}
