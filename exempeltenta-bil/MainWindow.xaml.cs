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

namespace exempeltenta_bil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int b = 3500;
        int bPlus = 4250;
        int carweight;
        string lblweight;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateWeight_Click(object sender, RoutedEventArgs e)
        {
            string lblweight = totalVikt.Text;
            int carweight = int.Parse(totalVikt.Text);
            int resultb = b - carweight;
            int resultbplus = bPlus - carweight;

            resultB.Content = $"{resultb} kg";
            resultBPlus.Content = $"{resultbplus} kg";
            // Uppgift 1 klar
        }
    }
}