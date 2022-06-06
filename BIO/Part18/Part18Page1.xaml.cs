using System.Windows;
using System.Windows.Controls;

namespace BIO.Part18
{
    /// <summary>
    /// Interaction logic for Part18Page1.xaml
    /// </summary>
    public partial class Part18Page1 : Page
    {
        public Part18Page1()
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
            mainMenu.mainFrame.Navigate(new Part18Page2());
        }
    }
}
