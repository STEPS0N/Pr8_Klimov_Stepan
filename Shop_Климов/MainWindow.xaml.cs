using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Shop_Климов
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<object> AllItems = Classes.RepoItems.AllItems();

        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }
        
        public void CreateUI()
        {
            foreach (object Item in AllItems)
            {
                parent.Children.Add(new Elements.Item(Item));
            }
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string search = Search.Text.Trim().ToLower();

            parent.Children.Clear();

            if (string.IsNullOrWhiteSpace(search))
            {
                CreateUI();
                return;
            }

            foreach (object item in AllItems)
            {
                if (item is Classes.Shop shopItem)
                {
                    bool found = shopItem.Name.ToLower().Contains(search);

                    if (!found && item is Classes.Children childrenItem)
                        found = childrenItem.Age.ToString().Contains(search);

                    if (!found && item is Classes.Sport sportItem)
                        found = sportItem.Size.ToLower().Contains(search);

                    if (!found && item is Classes.Electronics electronicsItem)
                        found = electronicsItem.Battery_capacity.ToString().Contains(search) ||
                               electronicsItem.Processor.ToLower().Contains(search);

                    if (found)
                    {
                        parent.Children.Add(new Elements.Item(item));
                    }
                }
            }
        }
    }
}