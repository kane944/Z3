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

namespace Z3.Pages.AddAndEditPages
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        MordochkaEntities context;
        public AddClient(MordochkaEntities context, Client client)
        {
            InitializeComponent();
            Cmb.ItemsSource = context.Gender.ToList();
            this.context = context;
            this.DataContext = client;
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
