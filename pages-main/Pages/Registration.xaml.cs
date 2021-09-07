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

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Class1.PageLogin);
        }
        string x, y;

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Class1.password = textbox2.Text;
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Class1.login = textbox1.Text;
        }


    }
}
