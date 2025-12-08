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

        private void btnqueue_Click(object sender, RoutedEventArgs e)
        {
            string peoplequeue = txtpeople.Text;
            int CanRideOnNextRound = int.Parse(peoplequeue);

            if(CanRideOnNextRound>=48)
            {
                MessageBox.Show("Du får vänta en runda till innan du kan åka");
            }
            else
            {
                MessageBox.Show("Nu är det din tur att åka!");
            }

        }

        private void btnwait_Click(object sender, RoutedEventArgs e)
        {
            string peoplewait = txtpeople.Text;
            int queue = int.Parse(peoplewait);
            int CalculateWaitingTime;

            if (queue>=48)
            {
                CalculateWaitingTime = 5;
                MessageBox.Show($"Det är {queue} före dig i kön, det är {CalculateWaitingTime} minuters väntetid");
            }
            else if (queue>=102)
            { 
                CalculateWaitingTime = 10;
                MessageBox.Show($"Det är {queue} före dig i kön, det är {CalculateWaitingTime} minuters väntetid");
            }

        }
    }
}