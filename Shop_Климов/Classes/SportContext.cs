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
    public class SportContext : Sport, IContext
    {
        public SportContext() { }
        public SportContext(int Id, string Name, int Price, string Size, int IdShop) : base(Id, Name, Price, Size, IdShop)
        {
            this.Size = Size;
            this.IdShop = IdShop;
        }
        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allSport = new List<object>();
            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader sportData = Common.DBConnection.Query("SELECT * FROM [Спортивные вещи]", connection);
            while (sportData.Read())
            {
                ShopContext shopElement = allShop.Find(
                    x => (x as ShopContext).Id == sportData.GetInt32(2)) as ShopContext;
                SportContext newSport = new SportContext(
                    shopElement.Id,
                    shopElement.Name,
                    shopElement.Price,
                    sportData.GetString(1),
                    sportData.GetInt32(2))
                {
                    Image = shopElement.Image
                };
                allSport.Add(newSport);
            }

            Common.DBConnection.CloseConnection(connection);

            return allSport;
        }

        public void Save(bool Update = false)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
