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
using Z3.Pages;





namespace Z3
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Window
    {
        
        public AddEdit(PP042022Entities context, Vegatables Vegatable)
        {
            InitializeComponent();
            //AddEditManager.AddEditFrame = AddEditFrame;
            //AddEditFrame.Navigate(new AddClient(Vegatable));
        }

        private void AddEditFrame_ContentRendered(object sender, EventArgs e)
        {

        }

        private void ComBoxChooseAdd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
