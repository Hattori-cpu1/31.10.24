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

namespace _31._10._24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random _random= new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BMouseEnter(object sender, MouseEventArgs e)
        {
            double maxWidth = this.ActualWidth - boba.ActualWidth;
            double maxHeight = this.ActualHeight - boba.ActualHeight;

            double newX = _random.NextDouble()*maxWidth;
            double newY = _random.NextDouble() * maxHeight;

            boba.Margin = new Thickness(newX, newY, 0, 0);
        }
    }
}