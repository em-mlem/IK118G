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

namespace exempeltenta_starwars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //skapa slumpgenerator
        private Random rnd = new Random();
        //sätt string-array
        private string[] colors = { "blå", "gul", "grön", "orange", "lila", "röd" };
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btngetsword_Click(object sender, RoutedEventArgs e)
        {
            //hämta namn från textbox
            string name = txtname.Text;
            //slumpa index
            int index = rnd.Next(colors.Length);
            string rndcolor = colors[index];
            //skapa messagebox
            MessageBox.Show($"{name}, ditt lasersvärd har färgen {rndcolor}");
        }
        private void btntwo_Click(object sender, RoutedEventArgs e)
        {
            string name = txtname.Text;
            //kolla om knapp är checked, isf true
            bool isJedi = btnJedi.IsChecked == true;
            //slumpa force värde
            int force = rnd.Next(1, 101);
            //hämta färg från class (glöm ej inom parentes)
            string color = LightSaberHelper.GetColor(force, isJedi);
            //skapa en string som är antingen bool true : bool false
            string rsltText = isJedi ? "Jedi" : "Sith";
            //skapa messagebox
            MessageBox.Show($"{name}, du är en {rsltText} vars lasersvärd har färgen {color}.");
        }
    }
}