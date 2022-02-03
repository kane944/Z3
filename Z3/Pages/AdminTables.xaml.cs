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

namespace Z3.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminTables.xaml
    /// </summary>
    public partial class AdminTables : Page
    {
        MordochkaEntities context;
        public AdminTables()
        {
            InitializeComponent();
            context = new MordochkaEntities();
            ShowTable();
        }

        private void ShowTable()
        {
            DGProduct.ItemsSource = context.Product.ToList();
            DGClients.ItemsSource = context.Client.ToList();
            DGService.ItemsSource = context.Service.ToList();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ComBoxTables.SelectedIndex)
            {
                case 0:
                    if (DGClients != null)
                    {
                        DGClients.Visibility = Visibility.Visible;
                        DGProduct.Visibility = Visibility.Hidden;
                        DGService.Visibility = Visibility.Hidden;
                    }
                    break;
                case 1:
                    if (DGProduct != null)
                    {
                        DGClients.Visibility = Visibility.Hidden;
                        DGProduct.Visibility = Visibility.Visible;
                        DGService.Visibility = Visibility.Hidden;
                    }
                    break;
                case 2:
                    if (DGService != null)
                    {
                        DGClients.Visibility = Visibility.Hidden;
                        DGProduct.Visibility = Visibility.Hidden;
                        DGService.Visibility = Visibility.Visible;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
