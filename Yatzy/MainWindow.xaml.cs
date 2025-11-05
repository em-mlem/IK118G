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
using System.Xml.Schema;

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

            string namep1 = textBoxP1.Text;
            string namep2 = textBoxP2.Text;
            string namep3 = textBoxP3.Text;
            string namep4 = textBoxP4.Text;
        }

        private void btnResultat_Click(object sender, RoutedEventArgs e)
        {
            //Player 1
            double n1, n2, n3, n4, n5, n6, Sum;
            int bonus = 50;
            double.TryParse(textBoxOne.Text, out n1);
            if (n1 < 1 || n1 > 5)
            { textBoxOne.Foreground = Brushes.Red; }
            else { textBoxOne.Foreground = Brushes.Black; }
                double.TryParse(textBoxTwo.Text, out n2);
            if (n2 < 2 || n2 > 10 || n2 == 3 || n2 == 5 || n2 == 7 || n2 == 9)
            { textBoxTwo.Foreground = Brushes.Red; }
            else { textBoxTwo.Foreground = Brushes.Black; }
                double.TryParse(textBoxThree.Text, out n3);
            if (n3 < 3 || n3 > 15 || n3 == 4 || n3 == 5 || n3 == 7 || n3 == 8 || n3 == 10 || n3 == 11 || n3 == 13 || n3 == 14)
            { textBoxThree.Foreground = Brushes.Red; }
            else { textBoxThree.Foreground = Brushes.Black; }
                double.TryParse(textBoxFour.Text, out n4);
            if (n4 < 4 || n4 > 20 || n4 == 5 || n4 == 6 || n4 == 7 || n4 == 9 || n4 == 10 || n4 == 11 || n4 == 13 || n4 == 14 || n4 == 15 || n4 == 17 || n4 == 18 || n4 == 19)
            { textBoxFour.Foreground = Brushes.Red; }
            else { textBoxFour.Foreground = Brushes.Black; }
                double.TryParse(textBoxFive.Text, out n5);
            if (n5 < 5 || n5 > 25 || n5 == 6 || n5 == 7 || n5 == 8 || n5 == 9 || n5 == 11 || n5 == 12 || n5 == 13 || n5 == 14 || n5 == 16 || n5 == 17 || n5 == 18 || n5 == 19 || n5 == 21 || n5 == 22 || n5 == 23 || n5 == 24)
            { textBoxFive.Foreground = Brushes.Red; }
            else { textBoxFive.Foreground = Brushes.Black; }
            double.TryParse(textBoxSix.Text, out n6);
            if (n6 < 6 || n6 > 30 || n6 == 7 || n6 == 8 || n6 == 9 || n6 == 10 || n6 == 11 || n6 == 13 || n6 == 14 || n6 == 15 || n6 == 16 || n6 == 17 || n6 == 19 || n6 == 20 || n6 == 21 || n6 == 22 || n6 == 23 || n6 == 25 || n6 == 26 || n6 == 27 || n6 == 28 || n6 == 29)
            { textBoxSix.Foreground = Brushes.Red; }
            else { textBoxSix.Foreground = Brushes.Black; }
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
            { textBoxOneP2.Foreground = Brushes.Red; }
            else { textBoxOneP2.Foreground = Brushes.Black; }
            double.TryParse(textBoxTwoP2.Text, out p2n2);
            if (p2n2 < 2 || p2n2 > 10 || p2n2 == 3 || p2n2 == 5 || p2n2 == 7 || p2n2 == 9)
            { textBoxTwoP2.Foreground = Brushes.Red; }
            else { textBoxTwoP2.Foreground = Brushes.Black; }
            double.TryParse(textBoxThreeP2.Text, out p2n3);
            if (p2n3 < 3 || p2n3 > 15 || p2n3 == 4 || p2n3 == 5 || p2n3 == 7 || p2n3 == 8 || p2n3 == 10 || p2n3 == 11 || p2n3 == 13 || p2n3 == 14)
            { textBoxThreeP2.Foreground = Brushes.Red; }
            else { textBoxThreeP2.Foreground = Brushes.Black; }
            double.TryParse(textBoxFourP2.Text, out p2n4);
            if (p2n4 < 4 || p2n4 > 20 || p2n4 == 5 || p2n4 == 6 || p2n4 == 7 || p2n4 == 9 || p2n4 == 10 || p2n4 == 11 || p2n4 == 13 || p2n4 == 14 || p2n4 == 15 || p2n4 == 17 || p2n4 == 18 || p2n4 == 19)
            { textBoxFourP2.Foreground = Brushes.Red;}
            else { textBoxFourP2.Foreground = Brushes.Black; }
            double.TryParse(textBoxFiveP2.Text, out p2n5);
            if (p2n5 < 5 || p2n5 > 25 || p2n5 == 6 || p2n5 == 7 || p2n5 == 8 || p2n5 == 9 || p2n5 == 11 || p2n5 == 12 || p2n5 == 13 || p2n5 == 14 || p2n5 == 16 || p2n5 == 17 || p2n5 == 18 || p2n5 == 19 || p2n5 == 21 || p2n5 == 22 || p2n5 == 23 || p2n5 == 24)
            { textBoxFiveP2.Foreground = Brushes.Red; }
            else { textBoxFiveP2.Foreground = Brushes.Black; }
            double.TryParse(textBoxSixP2.Text, out p2n6);
            if (p2n6 < 6 || p2n6 > 30 || p2n6 == 7 || p2n6 == 8 || p2n6 == 9 || p2n6 == 10 || p2n6 == 11 || p2n6 == 13 || p2n6 == 14 || p2n6 == 15 || p2n6 == 16 || p2n6 == 17 || p2n6 == 19 || p2n6 == 20 || p2n6 == 21 || p2n6 == 22 || p2n6 == 23 || p2n6 == 25 || p2n6 == 26 || p2n6 == 27 || p2n6 == 28 || p2n6 == 29)
            { textBoxSixP2.Foreground = Brushes.Red; }
            else { textBoxSixP2.Foreground = Brushes.Black; }
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
            { textBoxOneP3.Foreground = Brushes.Red; }
            else { textBoxOneP3.Foreground = Brushes.Black; }
            double.TryParse(textBoxTwoP3.Text, out p3n2);
            if (p3n2 < 2 || p3n2 > 10 || p3n2 == 3 || p3n2 == 5 || p3n2 == 7 || p3n2 == 9)
            { textBoxTwoP3.Foreground = Brushes.Red; }
            else { textBoxTwoP3.Foreground = Brushes.Black; }
            double.TryParse(textBoxThreeP3.Text, out p3n3);
            if (p3n3 < 3 || p3n3 > 15 || p3n3 == 4 || p3n3 == 5 || p3n3 == 7 || p3n3 == 8 || p3n3 == 10 || p3n3 == 11 || p3n3 == 13 || p3n3 == 14)
            { textBoxThreeP3.Foreground = Brushes.Red; }
            else { textBoxThreeP3.Foreground = Brushes.Black; }
            double.TryParse(textBoxFourP3.Text, out p3n4);
            if (p3n4 < 4 || p3n4 > 20 || p3n4 == 5 || p3n4 == 6 || p3n4 == 7 || p3n4 == 9 || p3n4 == 10 || p3n4 == 11 || p3n4 == 13 || p3n4 == 14 || p3n4 == 15 || p3n4 == 17 || p3n4 == 18 || p3n4 == 19)
            { textBoxFourP3.Foreground = Brushes.Red; }
            else { textBoxFourP3.Foreground = Brushes.Black; }
            double.TryParse(textBoxFiveP3.Text, out p3n5);
            if (p3n5 < 5 || p3n5 > 25 || p3n5 == 6 || p3n5 == 7 || p3n5 == 8 || p3n5 == 9 || p3n5 == 11 || p3n5 == 12 || p3n5 == 13 || p3n5 == 14 || p3n5 == 16 || p3n5 == 17 || p3n5 == 18 || p3n5 == 19 || p3n5 == 21 || p3n5 == 22 || p3n5 == 23 || p3n5 == 24)
            { textBoxFiveP3.Foreground = Brushes.Red; }
            else { textBoxFiveP3.Foreground = Brushes.Black; }
            double.TryParse(textBoxSixP3.Text, out p3n6);
            if (p3n6 < 6 || p3n6 > 30 || p3n6 == 7 || p3n6 == 8 || p3n6 == 9 || p3n6 == 10 || p3n6 == 11 || p3n6 == 13 || p3n6 == 14 || p3n6 == 15 || p3n6 == 16 || p3n6 == 17 || p3n6 == 19 || p3n6 == 20 || p3n6 == 21 || p3n6 == 22 || p3n6 == 23 || p3n6 == 25 || p3n6 == 26 || p3n6 == 27 || p3n6 == 28 || p3n6 == 29)
            { textBoxSixP3.Foreground = Brushes.Red; }
            else { textBoxSixP3.Foreground = Brushes.Black; }
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
            { textBoxOneP4.Foreground = Brushes.Red; }
            else { textBoxOneP4.Foreground = Brushes.Black; }
            double.TryParse(textBoxTwoP4.Text, out p4n2);
            if (p4n2 < 2 || p4n2 > 10 || p4n2 == 3 || p4n2 == 5 || p4n2 == 7 || p4n2 == 9)
            { textBoxTwoP4.Foreground = Brushes.Red; }
            else { textBoxTwoP4.Foreground = Brushes.Black; }
            double.TryParse(textBoxThreeP4.Text, out p4n3);
            if (p4n3 < 3 || p4n3 > 15 || p4n3 == 4 || p4n3 == 5 || p4n3 == 7 || p4n3 == 8 || p4n3 == 10 || p4n3 == 11 || p4n3 == 13 || p4n3 == 14)
            { textBoxThreeP4.Foreground = Brushes.Red; }
            else { textBoxThreeP4.Foreground = Brushes.Black; }
            double.TryParse(textBoxFourP4.Text, out p4n4);
            if (p4n4 < 4 || p4n4 > 20 || p4n4 == 5 || p4n4 == 6 || p4n4 == 7 || p4n4 == 9 || p4n4 == 10 || p4n4 == 11 || p4n4 == 13 || p4n4 == 14 || p4n4 == 15 || p4n4 == 17 || p4n4 == 18 || p4n4 == 19)
            { textBoxFourP4.Foreground = Brushes.Red; }
            else { textBoxFourP4.Foreground = Brushes.Black; }
            double.TryParse(textBoxFiveP4.Text, out p4n5);
            if (p4n5 < 5 || p4n5 > 25 || p4n5 == 6 || p4n5 == 7 || p4n5 == 8 || p4n5 == 9 || p4n5 == 11 || p4n5 == 12 || p4n5 == 13 || p4n5 == 14 || p4n5 == 16 || p4n5 == 17 || p4n5 == 18 || p4n5 == 19 || p4n5 == 21 || p4n5 == 22 || p4n5 == 23 || p4n5 == 24)
            { textBoxFiveP4.Foreground = Brushes.Red; }
            else { textBoxFiveP4.Foreground = Brushes.Black; }
            double.TryParse(textBoxSixP4.Text, out p4n6);
            if (p4n6 < 6 || p4n6 > 30 || p4n6 == 7 || p4n6 == 8 || p4n6 == 9 || p4n6 == 10 || p4n6 == 11 || p4n6 == 13 || p4n6 == 14 || p4n6 == 15 || p4n6 == 16 || p4n6 == 17 || p4n6 == 19 || p4n6 == 20 || p4n6 == 21 || p4n6 == 22 || p4n6 == 23 || p4n6 == 25 || p4n6 == 26 || p4n6 == 27 || p4n6 == 28 || p4n6 == 29)
            { textBoxSixP4.Foreground = Brushes.Red; }
            else { textBoxSixP4.Foreground = Brushes.Black; }
            p4Sum = p4n1 + p4n2 + p4n3 + p4n4 + p4n5 + p4n6;
            lblSumP4.Content = p4Sum;
            if (p4Sum > 62)
            { lblBnsP4.Content = p4Sum + p4Bonus; }
            else
            { lblBnsP4.Content = "-"; }

        }

        private void btnEndResult_Click(object sender, RoutedEventArgs e)
        {
            //Player 1
            double nPair, nPairs, nThrees, nFours, nHouse, nSLadder, nLLadder, nChance, nYatzy, nEndSum;
            int bonus = 50;
            double.TryParse(textBoxPair.Text, out nPair);
            double.TryParse(textBoxTwoPairs.Text, out nPairs);
            double.TryParse(textBoxThrees.Text, out nThrees);
            double.TryParse(textBoxFours.Text, out nFours);
            double.TryParse(textBoxHouse.Text, out nHouse);
            double.TryParse(textBoxSmallLadder.Text, out nSLadder);
            double.TryParse(textBoxLargeLadder.Text, out nLLadder);
            double.TryParse(textBoxChance.Text, out nChance);
            double.TryParse(textBoxYatzy.Text, out nYatzy);
            if (lblBns.Content != "-")
            { nEndSum = nPair + nPairs + nThrees + nFours + nHouse + nSLadder + nLLadder + nChance + nYatzy + bonus; }
            else { nEndSum = nPair + nPairs + nThrees + nFours + nHouse + nSLadder + nLLadder + nChance + nYatzy; }
            lblEndSum.Content = nEndSum;

            //Player 2
            double nPair2, nPairs2, nThrees2, nFours2, nHouse2, nSLadder2, nLLadder2, nChance2, nYatzy2, nEndSum2;
            double.TryParse(textBoxPairP2.Text, out nPair2);
            double.TryParse(textBoxTwoPairsP2.Text, out nPairs2);
            double.TryParse(textBoxThreesP2.Text, out nThrees2);
            double.TryParse(textBoxFoursP2.Text, out nFours2);
            double.TryParse(textBoxHouseP2.Text, out nHouse2);
            double.TryParse(textBoxSmallLadderP2.Text, out nSLadder2);
            double.TryParse(textBoxLargeLadderP2.Text, out nLLadder2);
            double.TryParse(textBoxChanceP2.Text, out nChance2);
            double.TryParse(textBoxYatzyP2.Text, out nYatzy2);
            if (lblBnsP2.Content != "-")
            { nEndSum2 = nPair2 + nPairs2 + nThrees2 + nFours2 + nHouse2 + nSLadder2 + nLLadder2 + nChance2 + nYatzy2 + bonus; }
            else { nEndSum2 = nPair2 + nPairs2 + nThrees2 + nFours2 + nHouse2 + nSLadder2 + nLLadder2 + nChance2 + nYatzy2; }
            lblEndSumP2.Content = nEndSum2;

            //Player 3
            double nPair3, nPairs3, nThrees3, nFours3, nHouse3, nSLadder3, nLLadder3, nChance3, nYatzy3, nEndSum3;
            double.TryParse(textBoxPairP3.Text, out nPair3);
            double.TryParse(textBoxTwoPairsP3.Text, out nPairs3);
            double.TryParse(textBoxThreesP3.Text, out nThrees3);
            double.TryParse(textBoxFoursP3.Text, out nFours3);
            double.TryParse(textBoxHouseP3.Text, out nHouse3);
            double.TryParse(textBoxSmallLadderP3.Text, out nSLadder3);
            double.TryParse(textBoxLargeLadderP3.Text, out nLLadder3);
            double.TryParse(textBoxChanceP3.Text, out nChance3);
            double.TryParse(textBoxYatzyP3.Text, out nYatzy3);
            if (lblBnsP3.Content != "-")
            { nEndSum3 = nPair3 + nPairs3 + nThrees3 + nFours3 + nHouse3 + nSLadder3 + nLLadder3 + nChance3 + nYatzy3 + bonus; }
            else { nEndSum3 = nPair3 + nPairs3 + nThrees3 + nFours3 + nHouse3 + nSLadder3 + nLLadder3 + nChance3 + nYatzy3; }
            lblEndSumP2.Content = nEndSum3;

            //Player 4
            double nPair4, nPairs4, nThrees4, nFours4, nHouse4, nSLadder4, nLLadder4, nChance4, nYatzy4, nEndSum4;
            double.TryParse(textBoxPairP4.Text, out nPair4);
            double.TryParse(textBoxTwoPairsP4.Text, out nPairs4);
            double.TryParse(textBoxThreesP4.Text, out nThrees4);
            double.TryParse(textBoxFoursP4.Text, out nFours4);
            double.TryParse(textBoxHouseP4.Text, out nHouse4);
            double.TryParse(textBoxSmallLadderP4.Text, out nSLadder4);
            double.TryParse(textBoxLargeLadderP4.Text, out nLLadder4);
            double.TryParse(textBoxChanceP4.Text, out nChance4);
            double.TryParse(textBoxYatzyP4.Text, out nYatzy4);
            if (lblBnsP3.Content != "-")
            { nEndSum4 = nPair4 + nPairs4 + nThrees4 + nFours4 + nHouse4 + nSLadder4 + nLLadder4 + nChance4 + nYatzy4 + bonus; }
            else { nEndSum4 = nPair4 + nPairs4 + nThrees4 + nFours4 + nHouse4 + nSLadder4 + nLLadder4 + nChance4 + nYatzy4; }
            lblEndSumP2.Content = nEndSum4;
        }
    }
}