using System.Windows;
using System.Windows.Controls;

namespace BIO.Part18
{
    /// <summary>
    /// Interaction logic for Part18Page3.xaml
    /// </summary>
    public partial class Part18Page3 : Page
    {
        public Part18Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part18Page2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainMenu mainMenu = Window.GetWindow(this) as MainMenu;
            mainMenu.mainFrame.Navigate(new Part18Page4());
        }
    }
}
