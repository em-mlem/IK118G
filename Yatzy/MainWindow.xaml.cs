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

namespace Yatzy
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

        private void btnResultat_Click(object sender, RoutedEventArgs e)
        {
            //Player 1
            double n1, n2, n3, n4, n5, n6, Sum;
            int bonus = 50;            
            double.TryParse(textBoxOne.Text, out n1);
            double.TryParse(textBoxTwo.Text, out n2);
            double.TryParse(textBoxThree.Text, out n3);
            double.TryParse(textBoxFour.Text, out n4);
            double.TryParse(textBoxFive.Text, out n5);
            double.TryParse(textBoxSix.Text, out n6);
            Sum = n1 + n2 + n3 + n4 + n5 + n6;
            lblSum.Content = Sum;
            if (Sum > 62)
            { lblBns.Content = Sum + bonus; }
            else
            { lblBns.Content = "-"; }

            //Player 2
            double p2n1, p2n2, p2n3, p2n4, p2n5, p2n6, p2Sum;
            int p2Bonus = 50;
            double.TryParse(textBoxOneP2.Text, out p2n1);
            double.TryParse(textBoxTwoP2.Text, out p2n2);
            double.TryParse(textBoxThreeP2.Text, out p2n3);
            double.TryParse(textBoxFourP2.Text, out p2n4);
            double.TryParse(textBoxFiveP2.Text, out p2n5);
            double.TryParse(textBoxSixP2.Text, out p2n6);
            p2Sum = p2n1 + p2n2 + p2n3 + p2n4 + p2n5 + p2n6;
            lblSumP2.Content = p2Sum;
            if (p2Sum > 62)
            { lblBnsP2.Content = p2Sum + p2Bonus;}
            else
            { lblBnsP2.Content = "-"; }

            //Player 3
            double p3n1, p3n2, p3n3, p3n4, p3n5, p3n6, p3Sum;
            int p3Bonus = 50;
            double.TryParse(textBoxOneP3.Text, out p3n1);
            double.TryParse(textBoxTwoP3.Text, out p3n2);
            double.TryParse(textBoxThreeP3.Text, out p3n3);
            double.TryParse(textBoxFourP3.Text, out p3n4);
            double.TryParse(textBoxFiveP3.Text, out p3n5);
            double.TryParse(textBoxSixP3.Text, out p3n6);
            p3Sum = p3n1 + p3n2 + p3n3 + p3n4 + p3n5 + p3n6;
            lblSumP3.Content = p3Sum;
            if (p3Sum > 62)
            { lblBnsP3.Content = p3Sum + p3Bonus; }
            else
            { lblBnsP3.Content = "-"; }

            //Player 4
            double p4n1, p4n2, p4n3, p4n4, p4n5, p4n6, p4Sum;
            int p4Bonus = 50;
            double.TryParse(textBoxOneP4.Text, out p4n1);
            double.TryParse(textBoxTwoP4.Text, out p4n2);
            double.TryParse(textBoxThreeP4.Text, out p4n3);
            double.TryParse(textBoxFourP4.Text, out p4n4);
            double.TryParse(textBoxFiveP4.Text, out p4n5);
            double.TryParse(textBoxSixP4.Text, out p4n6);
            p4Sum = p4n1 + p4n2 + p4n3 + p4n4 + p4n5 + p4n6;
            lblSumP4.Content = p4Sum;
            if (p4Sum > 62)
            { lblBnsP4.Content = p4Sum + p4Bonus; }
            else
            { lblBnsP4.Content = "-"; }

        }
        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            lblP1.Content = textBoxP1.Text;
            lblP2.Content = textBoxP2.Text;
            lblP3.Content = textBoxP3.Text;
            lblP4.Content = textBoxP4.Text;
        }
    }
}