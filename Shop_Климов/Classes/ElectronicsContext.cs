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
    public class ElectronicsContext : Electronics, IContext
    {
        public ElectronicsContext() { }
        public ElectronicsContext(int Id, string Name, int Price, int Battery_capacity, string Processor, int IdShop) : 
            base(Id, Name, Price, Battery_capacity, Processor, IdShop)
        {
            this.Battery_capacity = Battery_capacity;
            this.Processor = Processor;
            this.IdShop = IdShop;
        }
        public List<object> All()
        {
            List<object> allShop = new ShopContext().All();
            List<object> allElectronics = new List<object>();
            OleDbConnection connection = Common.DBConnection.Connection();
            OleDbDataReader electronicsData = Common.DBConnection.Query("SELECT * FROM [Электроника]", connection);
            while (electronicsData.Read())
            {
                ShopContext shopElement = allShop.Find(
                    x => (x as ShopContext).Id == electronicsData.GetInt32(3)) as ShopContext;
                ElectronicsContext newElectronics = new ElectronicsContext(
                    shopElement.Id,
                    shopElement.Name,
                    shopElement.Price,
                    electronicsData.GetInt32(1),
                    electronicsData.GetString(2),
                    electronicsData.GetInt32(3))
                {
                    Image = shopElement.Image
                };
                allElectronics.Add(newElectronics);
            }

            Common.DBConnection.CloseConnection(connection);

            return allElectronics;
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
