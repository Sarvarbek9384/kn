using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }

        private void _1_click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "x";
            (sender as Button).IsEnabled = false;



            Random random = new Random();
            int nomerknopki = random.Next(0,9);


            while (buttons[nomerknopki].IsEnabled == false)
                nomerknopki = random.Next(0,9) ;


            buttons[nomerknopki].Content = "0";
            buttons[nomerknopki].IsEnabled = false;


        }
    }
}