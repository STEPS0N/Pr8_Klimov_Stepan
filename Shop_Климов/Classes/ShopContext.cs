using Shop_Климов.Interfaces;
using Shop_Климов.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Classes
{
    public class ShopContext : Shop, IContext
    {
        public ShopContext() { }

        public ShopContext(int Id, string Name, int Price, int Discount, string Image) : base(Id, Name, Price, Discount, Image) { }

        public List<object> All()
        {
            List<object> allShop = new List<object>();

            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader shopData = Common.DBConnection.Query("SELECT * FROM [Товар]", connection);
            while (shopData.Read())
            {
                ShopContext newShop = new ShopContext(
                    shopData.GetInt32(0),
                    shopData.GetString(1),
                    shopData.GetInt32(2),
                    shopData.GetInt32(3),
                    shopData.GetString(4)
                    );
                allShop.Add(newShop);
            }
            Common.DBConnection.CloseConnection(connection);

            return allShop;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Save(bool Update = false)
        {
            throw new NotImplementedException();
        }
    }
}
