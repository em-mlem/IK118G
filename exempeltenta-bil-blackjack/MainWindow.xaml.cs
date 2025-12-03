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

namespace exempeltenta_bil_blackjack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] SlumpaRegNr()
        {
            Random r = new();
            int[] resultat = new int[3];

            for (int i = 0; i < resultat.Length; i++)
            {
                resultat[i] = r.Next(0, 10);
            }
            return resultat;
        }

        private int total1 = 0;
        private int total2 = 0;
        private int total3 = 0;

        private CarRegister register = new();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnbet_Click(object sender, RoutedEventArgs e)
        {
            int[] kod = SlumpaRegNr();

            lblCode1.Content = kod[0];
            lblCode2.Content = kod[1];
            lblCode3.Content = kod[2];
            //Uppgift 5 klar
            
            int result1 = int.Parse(lblCode1.Content.ToString());
            int result2 = int.Parse(lblCode2.Content.ToString());
            int result3 = int.Parse(lblCode3.Content.ToString());

            if (chk1.IsChecked != true)
            {
                total1 += result1;
            }

            if (chk2.IsChecked != true)
            {
                total2 += result2;
            }

            if (chk3.IsChecked != true)
            {
                total3 += result3;
            }

            lblTotal1.Content = total1;
            lblTotal2.Content = total2;
            lblTotal3.Content = total3;
            //Uppgift 6 klar
            //Uppgift 7 klar
            
        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            Car newCar = new Car()
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                LicencePlate = txtRegNr.Text,
                Colour = txtColour.Text,
            };

            bool added = register.AddCar(newCar);

            if (added)
            { 
                lblStatus.Content = "Bilen registrerades!";
            }
            else
            {
                lblStatus.Content = "Kunde inte registrera bilen.";
            }
            //Uppgift 9 klar
        }
    }
}