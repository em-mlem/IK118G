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

namespace exempeltenta_nöjesfält
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string peoplebalance = txtpeople.Text;
            int people = int.Parse(peoplebalance);

            if (people % 2 == 0)
            {
                MessageBox.Show("Karusellen är i balans");
            }
            else
            {
                MessageBox.Show("Karusellen är i obalans");
            }
        }
    }
}