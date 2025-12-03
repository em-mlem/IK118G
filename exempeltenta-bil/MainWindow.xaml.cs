using System.Diagnostics.Eventing.Reader;
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
        public bool KontrolleraRegnummer(string regNr)
        {
            if (regNr.Length != 7)
                return false;

            if (!char.IsLetter(regNr[0]) || !char.IsLetter(regNr[1]) || !char.IsLetter(regNr[2]))
                return false;

            if (regNr[3] != ' ')
                return false;

            if (!char.IsDigit(regNr[4]) || !char.IsDigit(regNr[5]) || !char.IsDigit(regNr[6]))
                return false;

            return true;
        }

        private int currentNumber = 0;
        private Random r = new();

        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateWeight_Click(object sender, RoutedEventArgs e)
        {
            int b = 3500;
            int bPlus = 4250;
            string lblweight = totalVikt.Text;
            int carweight = int.Parse(totalVikt.Text);
            int resultb = b - carweight;
            int resultbplus = bPlus - carweight;

            resultB.Content = $"{resultb} kg";
            resultBPlus.Content = $"{resultbplus} kg";
            // Uppgift 1 klar
        }

        private void regCtrl_Click(object sender, RoutedEventArgs e)
        {
            string regInput = regNr.Text;

            if (KontrolleraRegnummer(regInput))
            {
                return;
            }
            else
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken");
            }
            //Uppgift 2 klar
        }

        private void platespotting_Click(object sender, RoutedEventArgs e)
        {
            string letters = GetRandomLetters();

            int number = r.Next(1, 1000);

            string plateNr = $"{letters} {number:000}";

            labelPlatespot.Content = plateNr;

            if (number == currentNumber+1)
            {
                currentNumber = number;

                labelPlatespotHistory.Content = regNr;

                if (currentNumber == 999)
                {
                    MessageBox.Show("Grattis! Du har nått 999!");
                }
            }
            //Uppgift 3 klar
        }
    }
}