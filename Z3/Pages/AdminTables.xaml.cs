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
using Z3.Pages.AddAndEditPages;

namespace Z3.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminTables.xaml
    /// </summary>
    public partial class AdminTables : Page
    {
        PP042022Entities context;
        public AdminTables()
        {
            InitializeComponent();
            context = new PP042022Entities();
            ShowTable();
        }

        private void ShowTable()
        {
            DGVegetable.ItemsSource = context.Vegatables.ToList();
            DGGreenhousss.ItemsSource = context.Greenhouses.ToList();
            DGGHPlanting.ItemsSource = context.GreenhousePlanting.ToList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComBoxTables.SelectedIndex)
            {
                case 0:
                    if (DGVegetable != null)
                    {
                        DGVegetable.Visibility = Visibility.Visible;
                        DGGreenhousss.Visibility = Visibility.Hidden;
                        DGGHPlanting.Visibility = Visibility.Hidden;
                    }
                    break;
                case 1:
                    if (DGGreenhousss != null)
                    {
                        DGVegetable.Visibility = Visibility.Hidden;
                        DGGreenhousss.Visibility = Visibility.Visible;
                        DGGHPlanting.Visibility = Visibility.Hidden;
                    }
                    break;
                case 2:
                    if (DGGHPlanting != null)
                    {
                        DGVegetable.Visibility = Visibility.Hidden;
                        DGGreenhousss.Visibility = Visibility.Hidden;
                        DGGHPlanting.Visibility = Visibility.Visible;
                    }
                    break;
                default:
                    break;
            }
        }

        private void AddDataBtn_Click(object sender, RoutedEventArgs e)
        {
            //Manager.MainFrame.Navigate(new AddClient(new Client()));

            var Add = new AddEdit(context, new Vegatables());
            Add.Show();
            ShowTable();
        }
    }
}
