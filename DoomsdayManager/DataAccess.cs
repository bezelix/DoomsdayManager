using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Dapper;

namespace DoomsdayManager.Data
{
    public class DataAccess
    {
        public List<User>GetUser(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                return connection.Query<User>("GetUserByLastName @LastName", new { LastName = lastName }).ToList();
            }
        }

        internal void InsertNewUser(string firstName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<User> mUsers = new List<User>();
                mUsers.Add(new User { FirstName = firstName });
                connection.Execute("InsertNewUser @FirstName", mUsers);
            }
        }
        public void InsertNewItem(string itemName, Category category, Unit unit, float quantity, string description, float weight, string size, string productionDate, string expirationDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Category = category, Unit = unit, Quantity = quantity, Description = description, Weight = weight, Size = size, ProductionDate = productionDate, ExpirationDate = expirationDate  });
                connection.Execute("AddItem @ItemName, @Category, @Unit, @Quantity, @Description, @Weight, @Size, @ProductionDate, @ExpirationDate", mItems);
            }
        }
    }
}
