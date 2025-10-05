using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Климов.Classes
{
    public class RepoItems
    {
        public static List<object> AllItems()
        {
            List<object> allItems = new List<object>();
            allItems.Add(new Children("Игрушка интерактивная", 2200, "/Images/Robot.png", 3));
            allItems.Add(new Children("Кактус танцующий", 894, "/Images/Cactus.png", 6));
            allItems.Add(new Children("Мягкая игрушка кошка подушка", 1754, "/Images/Cat.png", 6));
            allItems.Add(new Sport("Спортивный мужской костюм", 4913, "/Images/Costume.png", "S"));
            allItems.Add(new Sport("Мяч для водного поло", 812, "/Images/Ball.png", "61-63 см"));
            allItems.Add(new Sport("Набор для гольфа Partida", 3950, "/Images/Golf.png", "600*800 мм"));
            allItems.Add(new Electronics("Samsung Galaxy S25 Ultra", 88999, "/Images/S25.png", 5000, "Snapdragon 8"));
            allItems.Add(new Electronics("Honor MagicBook X16", 59498, "/Images/MagicBook.png", 6000, "Intel Core i5"));
            allItems.Add(new Electronics("Samsung Galaxy Tab S10 Ultra", 98490, "/Images/Tab.png", 11200, "MediaTek"));
            return allItems;
        }
    }
}
