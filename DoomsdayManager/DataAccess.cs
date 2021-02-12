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
        public List<Item>GetItemList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                return connection.Query<Item>("GetItemList").ToList();
            }
        }
        public void InsertNewItem(string itemName, string quantity, string weightKG, string productionDate, string expirationDate, string size, string kcal, string proteins, string carbons, string fats)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Quantity = quantity, WeightKG = weightKG, ProductionDate = productionDate, ExpirationDate = expirationDate, Size = size, Kcal = kcal, Proteins = proteins, Fats = fats, Carbs = carbons });
                connection.Execute("AddItem @ItemName, @Quantity, @WeightKG, @ProductionDate, @ExpirationDate, @Size, @Kcal, @Proteins, @Fats, @Carbs", mItems);
            }
        }
        public void InsertNewResidents(string firstName, string lastName, string gender, string weight, string height, string bithDate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<User> mItems = new List<User>();
                mItems.Add(new User { FirstName = firstName, LastName = lastName, Gender = gender , Weight = weight, Height = height, BithDate = bithDate });
                connection.Execute("AddNewUser @FirstName, @LastName, @Gender, @Weight, @Height, @BithDate", mItems);
            }
        } 
        public void InsertNewTask(string itemName, string quantity, string weightKG, string size, string kcal, string proteins, string carbons, string fats)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Quantity = quantity, WeightKG = weightKG, Size = size, Kcal = kcal, Proteins = proteins, Fats = fats, Carbs = carbons });
                connection.Execute("AddItem @ItemName, @Quantity, @WeightKG, @Size, @Kcal, @Proteins, @Fats, @Carbs", mItems);
            }
        }
    }
}
