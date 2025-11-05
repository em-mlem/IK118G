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

namespace FL2
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            /* string name = "Error";
             name = txtName.Text;
             MessageBox.Show(name);*/

            //eller lite mer simplistiskt nedan

            //för att lyckas med extra text, stränginterpolation

            //eller helt utan string

            // MessageBox.Show(txtName.Text);
            //obs, går ej att lägga till extra text med denna

            string name = txtName.Text;
            string message = $"Hej {name}-bumbum, love you lots!";
            MessageBox.Show(message); 

            

        }
    }
}