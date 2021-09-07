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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == Class1.login && textbox2.Text == Class1.password)
            {
                NavigationService.Navigate(Class1.PageMain2);
            }
            else
            {
                MessageBox.Show("Неправильно введены данные");
            }
           
        }

        private void textbox1_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
