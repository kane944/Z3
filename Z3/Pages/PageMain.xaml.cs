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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }


        private void BtnPnating_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdminTables());
        }

        private void BtnWorkers_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new PageAuthotization());
        }
    }
}
