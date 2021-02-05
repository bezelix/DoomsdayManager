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
        public void InsertNewItem(string itemName, string quantity, string weightKG, string size, string kcal, string proteins, string carbons, string fats)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Quantity = quantity, WeightKG = weightKG, Size = size, Kcal = kcal, Proteins = proteins, Fats = fats, Carbs = carbons });
                connection.Execute("AddItem @ItemName, @Quantity, @WeightKG, @Size, @Kcal, @Proteins, @Fats, @Carbs", mItems);
            }
        }
        public void InsertNewUser(string itemName, string quantity, string weightKG, string size, string kcal, string proteins, string carbons, string fats)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Quantity = quantity, WeightKG = weightKG, Size = size, Kcal = kcal, Proteins = proteins, Fats = fats, Carbs = carbons });
                connection.Execute("AddItem @ItemName, @Quantity, @WeightKG, @Size, @Kcal, @Proteins, @Fats, @Carbs", mItems);
            }
        }
        public void InsertNewResidents(string itemName, string quantity, string weightKG, string size, string kcal, string proteins, string carbons, string fats)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConString("DMDatabase")))
            {
                List<Item> mItems = new List<Item>();
                mItems.Add(new Item { ItemName = itemName, Quantity = quantity, WeightKG = weightKG, Size = size, Kcal = kcal, Proteins = proteins, Fats = fats, Carbs = carbons });
                connection.Execute("AddItem @ItemName, @Quantity, @WeightKG, @Size, @Kcal, @Proteins, @Fats, @Carbs", mItems);
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
