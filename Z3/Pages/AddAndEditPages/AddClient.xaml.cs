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
        private Vegatables currentVegatable = new Vegatables();
        private Vegatables Client { get; set; }

        public AddClient(Vegatables vegatables)
        {
            InitializeComponent();
            Vegatables = vegatables;
            DataContext = currentVegatable;
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            currentVegatable.ID = PP042022Entities.GetContext().Vegatables.ToArray()[PP042022Entities.GetContext().Vegatables.ToArray().Length - 1].ID + 1;
            PP042022Entities.GetContext().Vegatables.Add(currentVegatable);
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
