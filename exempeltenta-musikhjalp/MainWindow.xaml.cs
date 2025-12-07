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

namespace exempeltenta_musikhjalp
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

        private void btnOnska_Click(object sender, RoutedEventArgs e)
        {
            string originalText = txtOnskatNummer.Text.Trim();

            if (string.IsNullOrWhiteSpace(originalText))
            {
                MessageBox.Show("Du måste skriva in ett nummer.", "Fel",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 1. Leta efter decimaltecken (både . och ,)
            int punktIndex = originalText.IndexOf('.');
            int kommaIndex = originalText.IndexOf(',');

            int splitIndex = -1;

            // Hitta första förekomsten av decimaltecken om det finns
            if (punktIndex >= 0 && kommaIndex >= 0)
                splitIndex = Math.Min(punktIndex, kommaIndex);
            else if (punktIndex >= 0)
                splitIndex = punktIndex;
            else if (kommaIndex >= 0)
                splitIndex = kommaIndex;

            string heltalsText = originalText;

            // 2. Skär av decimalerna
            if (splitIndex >= 0)
                heltalsText = originalText.Substring(0, splitIndex);

            // 3. Kontrollera att återstående del är ett heltal
            if (!int.TryParse(heltalsText, out int resultat))
            {
                MessageBox.Show("Du måste skriva ett tal, exempel: 12 eller 12.5", "Fel",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // 4. Visa originalet och det "rensade" värdet
            MessageBox.Show($"Du röstade på låt nummer: {resultat}");
        }
    }
}