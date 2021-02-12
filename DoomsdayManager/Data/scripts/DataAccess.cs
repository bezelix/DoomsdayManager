using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DoomsdayManager.Data
{
    public class DataAccess
    {
        public List<User>GetUser(string firstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                return connection.Query<User>($"SELECT * FROM Users WHERE FirstName = '{ firstName }'").ToList();
                //return connection.Query<User>("GetuserByFirstName @FirstName", new { FirstName = firstName }).ToList();
            }
        }
    }
}
