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

namespace BIO.Part18
{
    /// <summary>
    /// Interaction logic for Part18Page5.xaml
    /// </summary>
    public partial class Part18Page5 : Page
    {
        public Part18Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0, b = 0, c = 0, d = 0;
            if (answer1.IsChecked == true)
            {
                a = 5;
            }
            if (answer2.IsChecked == true)
            {
                b = 5;
            }
            if (answer3.IsChecked == true)
            {
                c = 5;
            }
            if (answer4.IsChecked == true)
            {
                d = 5;
            }
         

            resultTestTextBox.Text = "Оценка: " + Math.Round((a + b + c + d) / 4.0).ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new MainPage());
        }
    }
}

