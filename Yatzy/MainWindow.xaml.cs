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

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            lblP1.Content = textBoxP1.Text;
            lblP2.Content = textBoxP2.Text;
            lblP3.Content = textBoxP3.Text;
            lblP4.Content = textBoxP4.Text;
        }

        private void btnResultat_Click(object sender, RoutedEventArgs e)
        {
            string namep1 = textBoxP1.Text;
            string namep2 = textBoxP2.Text;
            string namep3 = textBoxP3.Text;
            string namep4 = textBoxP4.Text;

            //Player 1
            double n1, n2, n3, n4, n5, n6, Sum;
            int bonus = 50;
            double.TryParse(textBoxOne.Text, out n1);
            if (n1 < 1 || n1 > 5)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina ettor är felaktigt."); }
            double.TryParse(textBoxTwo.Text, out n2);
            if (n2 < 2 || n2 > 10 || n2 == 3 || n2 == 5 || n2 == 7 || n2 == 9)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina tvåor är felaktigt."); }
            double.TryParse(textBoxThree.Text, out n3);
            if (n3 < 3 || n3 > 15 || n3 == 4 || n3 == 5 || n3 == 7 || n3 == 8 || n3 == 10 || n3 == 11 || n3 == 13 || n3 == 14)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina treor är felaktigt."); }
            double.TryParse(textBoxFour.Text, out n4);
            if (n4 < 4 || n4 > 20 || n4 == 5 || n4 == 6 || n4 == 7 || n4 == 9 || n4 == 10 || n4 == 11 || n4 == 13 || n4 == 14 || n4 == 15 || n4 == 17 || n4 == 18 || n4 == 19)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina fyror är felaktigt."); }
            double.TryParse(textBoxFive.Text, out n5);
            if (n5 < 5 || n5 > 25 || n5 == 6 || n5 == 7 || n5 == 8 || n5 == 9 || n5 == 11 || n5 == 12 || n5 == 13 || n5 == 14 || n5 == 16 || n5 == 17 || n5 == 18 || n5 == 19 || n5 == 21 || n5 == 22 || n5 == 23 || n5 == 24)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina femmor är felaktigt."); }
            double.TryParse(textBoxSix.Text, out n6);
            if (n6 < 6 || n6 > 30 || n6 == 7 || n6 == 8 || n6 == 9 || n6 == 10 || n6 == 11 || n6 == 13 || n6 == 14 || n6 == 15 || n6 == 16 || n6 == 17 || n6 == 19 || n6 == 20 || n6 == 21 || n6 == 22 || n6 == 23 || n6 == 25 || n6 == 26 || n6 == 27 || n6 == 28 || n6 == 29)
            { MessageBox.Show($"Ursäkta {namep1}, resultatet för dina sexor är felaktigt."); }
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
            if (p2n1 < 1 || p2n1 > 5)
            { MessageBox.Show($"Ursäkta, {namep2}, resultatet för dina ettor är felaktigt."); }
            double.TryParse(textBoxTwoP2.Text, out p2n2);
            if (p2n2 < 2 || p2n2 > 10 || p2n2 == 3 || p2n2 == 5 || p2n2 == 7 || p2n2 == 9)
            { MessageBox.Show($"Ursäkta {namep2}, resultatet för dina tvåor är felaktigt."); }
            double.TryParse(textBoxThreeP2.Text, out p2n3);
            if (p2n3 < 3 || p2n3 > 15 || p2n3 == 4 || p2n3 == 5 || p2n3 == 7 || p2n3 == 8 || p2n3 == 10 || p2n3 == 11 || p2n3 == 13 || p2n3 == 14)
            { MessageBox.Show($"Ursäkta {namep2}, resultatet för dina treor är felaktigt."); }
            double.TryParse(textBoxFourP2.Text, out p2n4);
            if (p2n4 < 4 || p2n4 > 20 || p2n4 == 5 || p2n4 == 6 || p2n4 == 7 || p2n4 == 9 || p2n4 == 10 || p2n4 == 11 || p2n4 == 13 || p2n4 == 14 || p2n4 == 15 || p2n4 == 17 || p2n4 == 18 || p2n4 == 19)
            { MessageBox.Show($"Ursäkta {namep2}, resultatet för dina fyror är felaktigt."); }
            double.TryParse(textBoxFiveP2.Text, out p2n5);
            if (p2n5 < 5 || p2n5 > 25 || p2n5 == 6 || p2n5 == 7 || p2n5 == 8 || p2n5 == 9 || p2n5 == 11 || p2n5 == 12 || p2n5 == 13 || p2n5 == 14 || p2n5 == 16 || p2n5 == 17 || p2n5 == 18 || p2n5 == 19 || p2n5 == 21 || p2n5 == 22 || p2n5 == 23 || p2n5 == 24)
            { MessageBox.Show($"Ursäkta {namep2}, resultatet för dina femmor är felaktigt."); }
            double.TryParse(textBoxSixP2.Text, out p2n6);
            if (p2n6 < 6 || p2n6 > 30 || p2n6 == 7 || p2n6 == 8 || p2n6 == 9 || p2n6 == 10 || p2n6 == 11 || p2n6 == 13 || p2n6 == 14 || p2n6 == 15 || p2n6 == 16 || p2n6 == 17 || p2n6 == 19 || p2n6 == 20 || p2n6 == 21 || p2n6 == 22 || p2n6 == 23 || p2n6 == 25 || p2n6 == 26 || p2n6 == 27 || p2n6 == 28 || p2n6 == 29)
            { MessageBox.Show($"Ursäkta {namep2}, resultatet för dina sexor är felaktigt."); }
            p2Sum = p2n1 + p2n2 + p2n3 + p2n4 + p2n5 + p2n6;
            lblSumP2.Content = p2Sum;
            if (p2Sum > 62)
            { lblBnsP2.Content = p2Sum + p2Bonus; }
            else
            { lblBnsP2.Content = "-"; }

            //Player 3
            double p3n1, p3n2, p3n3, p3n4, p3n5, p3n6, p3Sum;
            int p3Bonus = 50;
            double.TryParse(textBoxOneP3.Text, out p3n1);
            if (p3n1 < 1 || p3n1 > 5)
            { MessageBox.Show($"Ursäkta, {namep3}, resultatet för dina ettor är felaktigt."); }
            double.TryParse(textBoxTwoP3.Text, out p3n2);
            if (p3n2 < 2 || p3n2 > 10 || p3n2 == 3 || p3n2 == 5 || p3n2 == 7 || p3n2 == 9)
            { MessageBox.Show($"Ursäkta {namep3}, resultatet för dina tvåor är felaktigt."); }
            double.TryParse(textBoxThreeP3.Text, out p3n3);
            if (p3n3 < 3 || p3n3 > 15 || p3n3 == 4 || p3n3 == 5 || p3n3 == 7 || p3n3 == 8 || p3n3 == 10 || p3n3 == 11 || p3n3 == 13 || p3n3 == 14)
            { MessageBox.Show($"Ursäkta {namep3}, resultatet för dina treor är felaktigt."); }
            double.TryParse(textBoxFourP3.Text, out p3n4);
            if (p3n4 < 4 || p3n4 > 20 || p3n4 == 5 || p3n4 == 6 || p3n4 == 7 || p3n4 == 9 || p3n4 == 10 || p3n4 == 11 || p3n4 == 13 || p3n4 == 14 || p3n4 == 15 || p3n4 == 17 || p3n4 == 18 || p3n4 == 19)
            { MessageBox.Show($"Ursäkta {namep3}, resultatet för dina fyror är felaktigt."); }
            double.TryParse(textBoxFiveP3.Text, out p3n5);
            if (p3n5 < 5 || p3n5 > 25 || p3n5 == 6 || p3n5 == 7 || p3n5 == 8 || p3n5 == 9 || p3n5 == 11 || p3n5 == 12 || p3n5 == 13 || p3n5 == 14 || p3n5 == 16 || p3n5 == 17 || p3n5 == 18 || p3n5 == 19 || p3n5 == 21 || p3n5 == 22 || p3n5 == 23 || p3n5 == 24)
            { MessageBox.Show($"Ursäkta {namep3}, resultatet för dina femmor är felaktigt."); }
            double.TryParse(textBoxSixP3.Text, out p3n6);
            if (p3n6 < 6 || p3n6 > 30 || p3n6 == 7 || p3n6 == 8 || p3n6 == 9 || p3n6 == 10 || p3n6 == 11 || p3n6 == 13 || p3n6 == 14 || p3n6 == 15 || p3n6 == 16 || p3n6 == 17 || p3n6 == 19 || p3n6 == 20 || p3n6 == 21 || p3n6 == 22 || p3n6 == 23 || p3n6 == 25 || p3n6 == 26 || p3n6 == 27 || p3n6 == 28 || p3n6 == 29)
            { MessageBox.Show($"Ursäkta {namep3}, resultatet för dina sexor är felaktigt."); }
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
            if (p4n1 < 1 || p4n1 > 5)
            { MessageBox.Show($"Ursäkta, {namep4}, resultatet för dina ettor är felaktigt."); }
            double.TryParse(textBoxTwoP4.Text, out p4n2);
            if (p4n2 < 2 || p4n2 > 10 || p4n2 == 3 || p4n2 == 5 || p4n2 == 7 || p4n2 == 9)
            { MessageBox.Show($"Ursäkta {namep4}, resultatet för dina tvåor är felaktigt."); }
            double.TryParse(textBoxThreeP4.Text, out p4n3);
            if (p4n3 < 3 || p4n3 > 15 || p4n3 == 4 || p4n3 == 5 || p4n3 == 7 || p4n3 == 8 || p4n3 == 10 || p4n3 == 11 || p4n3 == 13 || p4n3 == 14)
            { MessageBox.Show($"Ursäkta {namep4}, resultatet för dina treor är felaktigt."); }
            double.TryParse(textBoxFourP4.Text, out p4n4);
            if (p4n4 < 4 || p4n4 > 20 || p4n4 == 5 || p4n4 == 6 || p4n4 == 7 || p4n4 == 9 || p4n4 == 10 || p4n4 == 11 || p4n4 == 13 || p4n4 == 14 || p4n4 == 15 || p4n4 == 17 || p4n4 == 18 || p4n4 == 19)
            { MessageBox.Show($"Ursäkta {namep4}, resultatet för dina fyror är felaktigt."); }
            double.TryParse(textBoxFiveP4.Text, out p4n5);
            if (p4n5 < 5 || p4n5 > 25 || p4n5 == 6 || p4n5 == 7 || p4n5 == 8 || p4n5 == 9 || p4n5 == 11 || p4n5 == 12 || p4n5 == 13 || p4n5 == 14 || p4n5 == 16 || p4n5 == 17 || p4n5 == 18 || p4n5 == 19 || p4n5 == 21 || p4n5 == 22 || p4n5 == 23 || p4n5 == 24)
            { MessageBox.Show($"Ursäkta {namep4}, resultatet för dina femmor är felaktigt."); }
            double.TryParse(textBoxSixP4.Text, out p4n6);
            if (p4n6 < 6 || p4n6 > 30 || p4n6 == 7 || p4n6 == 8 || p4n6 == 9 || p4n6 == 10 || p4n6 == 11 || p4n6 == 13 || p4n6 == 14 || p4n6 == 15 || p4n6 == 16 || p4n6 == 17 || p4n6 == 19 || p4n6 == 20 || p4n6 == 21 || p4n6 == 22 || p4n6 == 23 || p4n6 == 25 || p4n6 == 26 || p4n6 == 27 || p4n6 == 28 || p4n6 == 29)
            { MessageBox.Show($"Ursäkta {namep4}, resultatet för dina sexor är felaktigt."); }
            p4Sum = p4n1 + p4n2 + p4n3 + p4n4 + p4n5 + p4n6;
            lblSumP4.Content = p4Sum;
            if (p4Sum > 62)
            { lblBnsP4.Content = p4Sum + p4Bonus; }
            else
            { lblBnsP4.Content = "-"; }

        }
    }
}