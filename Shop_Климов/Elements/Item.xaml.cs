using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_Климов.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object ItemData)
        {
            InitializeComponent();
            Models.Shop ShopData = ItemData as Models.Shop;
            tb_Name.Content = ShopData.Name;
            tb_Discount.Content = "Скидка: " + ShopData.Discount + " %";
            int discount = ShopData.Price * (100 - ShopData.Discount) / 100;
            tb_Price.Content = "Цена: " + discount + $" руб. Без скидки: {ShopData.Price} руб.";
            if (ItemData is Models.Children)
            {
                Models.Children ChildrenData = ItemData as Models.Children;
                tb_Characteristic1.Content = "Возраст: " + ChildrenData.Age;
            }
            if (ItemData is Models.Sport)
            {
                Models.Sport SportData = ItemData as Models.Sport;
                tb_Characteristic1.Content = "Размер: " + SportData.Size;
            }
            if (ItemData is Models.Electronics)
            {
                Models.Electronics ElectronicsData = ItemData as Models.Electronics;
                tb_Characteristic1.Content = "Ёмкость АКБ: " + ElectronicsData.Battery_capacity + " мАч";
                tb_Characteristic2.Content = "Процессор: " + ElectronicsData.Processor;
            }

            if (!string.IsNullOrEmpty(ShopData.Image))
            {
                try
                {
                    BitmapImage bitmap = new BitmapImage();
                    bitmap.BeginInit();
                    bitmap.UriSource = new Uri(ShopData.Image, UriKind.RelativeOrAbsolute);
                    bitmap.EndInit();
                    itemImage.Source = bitmap;
                }
                catch (Exception ex)
                {
                    itemImage.Source = new BitmapImage(new Uri("/Images/ic_item.png", UriKind.RelativeOrAbsolute));
                }
            }
        }
    }
}
