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

namespace exempeltenta_starwars_uppg2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //anropa helperklassen
        StormtrooperHelper helper = new StormtrooperHelper();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnaddid_Click(object sender, RoutedEventArgs e)
        {
            string inputId = txtNewId.Text.Trim();

            helper.AddStormtrooperId(inputId);

            txtNewId.Clear();
        }
    }
}