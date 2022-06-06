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

namespace BIO.Part1
{
    /// <summary>
    /// Логика взаимодействия для Part1Page1.xaml
    /// </summary>
    public partial class Part1Page1 : Page
    {
        public Part1Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new MainPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part1Page2());
        }
    }
}
