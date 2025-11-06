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
            int n1, n2, n3, n4, n5, n6, Sum;
            int bonus = 50;
            n1 = int.Parse(textBoxOne.Text);
            if (n1 < 1 || n1 > 5)
            { textBoxOne.Foreground = Brushes.Red; }
            else { textBoxOne.Foreground = Brushes.Black; }
            n2 = int.Parse(textBoxTwo.Text);
            if (n2 < 2 || n2 > 10 || n2 == 3 || n2 == 5 || n2 == 7 || n2 == 9)
            { textBoxTwo.Foreground = Brushes.Red; }
            else { textBoxTwo.Foreground = Brushes.Black; }
            n3 = int.Parse(textBoxThree.Text);
            if (n3 < 3 || n3 > 15 || n3 == 4 || n3 == 5 || n3 == 7 || n3 == 8 || n3 == 10 || n3 == 11 || n3 == 13 || n3 == 14)
            { textBoxThree.Foreground = Brushes.Red; }
            else { textBoxThree.Foreground = Brushes.Black; }
            n4 = int.Parse(textBoxFour.Text);
            if (n4 < 4 || n4 > 20 || n4 == 5 || n4 == 6 || n4 == 7 || n4 == 9 || n4 == 10 || n4 == 11 || n4 == 13 || n4 == 14 || n4 == 15 || n4 == 17 || n4 == 18 || n4 == 19)
            { textBoxFour.Foreground = Brushes.Red; }
            else { textBoxFour.Foreground = Brushes.Black; }
            n5 = int.Parse(textBoxFive.Text);
            if (n5 < 5 || n5 > 25 || n5 == 6 || n5 == 7 || n5 == 8 || n5 == 9 || n5 == 11 || n5 == 12 || n5 == 13 || n5 == 14 || n5 == 16 || n5 == 17 || n5 == 18 || n5 == 19 || n5 == 21 || n5 == 22 || n5 == 23 || n5 == 24)
            { textBoxFive.Foreground = Brushes.Red; }
            else { textBoxFive.Foreground = Brushes.Black; }
            n6 = int.Parse(textBoxSix.Text);
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
            int p2n1, p2n2, p2n3, p2n4, p2n5, p2n6, p2Sum;
            int p2Bonus = 50;
            p2n1 = int.Parse(textBoxOneP2.Text);
            if (p2n1 < 1 || p2n1 > 5)
            { textBoxOneP2.Foreground = Brushes.Red; }
            else { textBoxOneP2.Foreground = Brushes.Black; }
            p2n2 = int.Parse(textBoxTwoP2.Text);
            if (p2n2 < 2 || p2n2 > 10 || p2n2 == 3 || p2n2 == 5 || p2n2 == 7 || p2n2 == 9)
            { textBoxTwoP2.Foreground = Brushes.Red; }
            else { textBoxTwoP2.Foreground = Brushes.Black; }
            p2n3 = int.Parse(textBoxThreeP2.Text);
            if (p2n3 < 3 || p2n3 > 15 || p2n3 == 4 || p2n3 == 5 || p2n3 == 7 || p2n3 == 8 || p2n3 == 10 || p2n3 == 11 || p2n3 == 13 || p2n3 == 14)
            { textBoxThreeP2.Foreground = Brushes.Red; }
            else { textBoxThreeP2.Foreground = Brushes.Black; }
            p2n4 = int.Parse(textBoxFourP2.Text);
            if (p2n4 < 4 || p2n4 > 20 || p2n4 == 5 || p2n4 == 6 || p2n4 == 7 || p2n4 == 9 || p2n4 == 10 || p2n4 == 11 || p2n4 == 13 || p2n4 == 14 || p2n4 == 15 || p2n4 == 17 || p2n4 == 18 || p2n4 == 19)
            { textBoxFourP2.Foreground = Brushes.Red;}
            else { textBoxFourP2.Foreground = Brushes.Black; }
            p2n5 = int.Parse(textBoxFiveP2.Text);
            if (p2n5 < 5 || p2n5 > 25 || p2n5 == 6 || p2n5 == 7 || p2n5 == 8 || p2n5 == 9 || p2n5 == 11 || p2n5 == 12 || p2n5 == 13 || p2n5 == 14 || p2n5 == 16 || p2n5 == 17 || p2n5 == 18 || p2n5 == 19 || p2n5 == 21 || p2n5 == 22 || p2n5 == 23 || p2n5 == 24)
            { textBoxFiveP2.Foreground = Brushes.Red; }
            else { textBoxFiveP2.Foreground = Brushes.Black; }
            p2n6 = int.Parse(textBoxSixP2.Text);
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
            int p3n1, p3n2, p3n3, p3n4, p3n5, p3n6, p3Sum;
            int p3Bonus = 50;
            p3n1 = int.Parse(textBoxOneP3.Text);
            if (p3n1 < 1 || p3n1 > 5)
            { textBoxOneP3.Foreground = Brushes.Red; }
            else { textBoxOneP3.Foreground = Brushes.Black; }
            p3n2 = int.Parse(textBoxTwoP3.Text);
            if (p3n2 < 2 || p3n2 > 10 || p3n2 == 3 || p3n2 == 5 || p3n2 == 7 || p3n2 == 9)
            { textBoxTwoP3.Foreground = Brushes.Red; }
            else { textBoxTwoP3.Foreground = Brushes.Black; }
            p3n3 = int.Parse(textBoxThreeP3.Text);
            if (p3n3 < 3 || p3n3 > 15 || p3n3 == 4 || p3n3 == 5 || p3n3 == 7 || p3n3 == 8 || p3n3 == 10 || p3n3 == 11 || p3n3 == 13 || p3n3 == 14)
            { textBoxThreeP3.Foreground = Brushes.Red; }
            else { textBoxThreeP3.Foreground = Brushes.Black; }
            p3n4 = int.Parse(textBoxFourP3.Text);
            if (p3n4 < 4 || p3n4 > 20 || p3n4 == 5 || p3n4 == 6 || p3n4 == 7 || p3n4 == 9 || p3n4 == 10 || p3n4 == 11 || p3n4 == 13 || p3n4 == 14 || p3n4 == 15 || p3n4 == 17 || p3n4 == 18 || p3n4 == 19)
            { textBoxFourP3.Foreground = Brushes.Red; }
            else { textBoxFourP3.Foreground = Brushes.Black; }
            p3n5 = int.Parse(textBoxFiveP3.Text);
            if (p3n5 < 5 || p3n5 > 25 || p3n5 == 6 || p3n5 == 7 || p3n5 == 8 || p3n5 == 9 || p3n5 == 11 || p3n5 == 12 || p3n5 == 13 || p3n5 == 14 || p3n5 == 16 || p3n5 == 17 || p3n5 == 18 || p3n5 == 19 || p3n5 == 21 || p3n5 == 22 || p3n5 == 23 || p3n5 == 24)
            { textBoxFiveP3.Foreground = Brushes.Red; }
            else { textBoxFiveP3.Foreground = Brushes.Black; }
            p3n6 = int.Parse(textBoxSixP3.Text);
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
            int p4n1, p4n2, p4n3, p4n4, p4n5, p4n6, p4Sum;
            int p4Bonus = 50;
            p4n1 = int.Parse(textBoxOneP4.Text);
            if (p4n1 < 1 || p4n1 > 5)
            { textBoxOneP4.Foreground = Brushes.Red; }
            else { textBoxOneP4.Foreground = Brushes.Black; }
            p4n2 = int.Parse(textBoxTwoP4.Text);
            if (p4n2 < 2 || p4n2 > 10 || p4n2 == 3 || p4n2 == 5 || p4n2 == 7 || p4n2 == 9)
            { textBoxTwoP4.Foreground = Brushes.Red; }
            else { textBoxTwoP4.Foreground = Brushes.Black; }
            p4n3 = int.Parse(textBoxThreeP4.Text);
            if (p4n3 < 3 || p4n3 > 15 || p4n3 == 4 || p4n3 == 5 || p4n3 == 7 || p4n3 == 8 || p4n3 == 10 || p4n3 == 11 || p4n3 == 13 || p4n3 == 14)
            { textBoxThreeP4.Foreground = Brushes.Red; }
            else { textBoxThreeP4.Foreground = Brushes.Black; }
            p4n4 = int.Parse(textBoxFourP4.Text);
            if (p4n4 < 4 || p4n4 > 20 || p4n4 == 5 || p4n4 == 6 || p4n4 == 7 || p4n4 == 9 || p4n4 == 10 || p4n4 == 11 || p4n4 == 13 || p4n4 == 14 || p4n4 == 15 || p4n4 == 17 || p4n4 == 18 || p4n4 == 19)
            { textBoxFourP4.Foreground = Brushes.Red; }
            else { textBoxFourP4.Foreground = Brushes.Black; }
            p4n5 = int.Parse(textBoxFiveP4.Text);
            if (p4n5 < 5 || p4n5 > 25 || p4n5 == 6 || p4n5 == 7 || p4n5 == 8 || p4n5 == 9 || p4n5 == 11 || p4n5 == 12 || p4n5 == 13 || p4n5 == 14 || p4n5 == 16 || p4n5 == 17 || p4n5 == 18 || p4n5 == 19 || p4n5 == 21 || p4n5 == 22 || p4n5 == 23 || p4n5 == 24)
            { textBoxFiveP4.Foreground = Brushes.Red; }
            else { textBoxFiveP4.Foreground = Brushes.Black; }
            p4n6 = int.Parse(textBoxSixP4.Text);
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
            int nPair, nPairs, nThrees, nFours, nHouse, nSLadder, nLLadder, nChance, nYatzy, nEndSum;
            int bonus = 50;
            nPair = int.Parse(textBoxPair.Text);
            nPairs = int.Parse(textBoxTwoPairs.Text);
            nThrees = int. Parse(textBoxThrees.Text);
            nFours = int.Parse(textBoxFours.Text);
            nHouse = int.Parse(textBoxHouse.Text);
            nSLadder = int.Parse(textBoxSmallLadder.Text);
            nLLadder = int.Parse(textBoxLargeLadder.Text);
            nChance = int.Parse(textBoxChance.Text);
            nYatzy = int.Parse(textBoxYatzy.Text);
            if (lblBns.Content != "-")
            { nEndSum = nPair + nPairs + nThrees + nFours + nHouse + nSLadder + nLLadder + nChance + nYatzy + bonus; }
            else { nEndSum = nPair + nPairs + nThrees + nFours + nHouse + nSLadder + nLLadder + nChance + nYatzy; }
            int oldSum;
            if (int.TryParse(lblSum.Content.ToString(), out oldSum))
            lblEndSum.Content = nEndSum + oldSum;

            //Player 2
            int nPair2, nPairs2, nThrees2, nFours2, nHouse2, nSLadder2, nLLadder2, nChance2, nYatzy2, nEndSum2;
            nPair2 = int.Parse(textBoxPairP2.Text);
            nPairs2 = int.Parse(textBoxTwoPairsP2.Text);
            nThrees2 = int.Parse(textBoxThreesP2.Text);
            nFours2 = int.Parse(textBoxFoursP2.Text);
            nHouse2 = int.Parse(textBoxHouseP2.Text);
            nSLadder2 = int.Parse(textBoxSmallLadderP2.Text);
            nLLadder2 = int.Parse(textBoxLargeLadderP2.Text);
            nChance2 = int.Parse(textBoxChanceP2.Text);
            nYatzy2 = int.Parse(textBoxYatzyP2.Text);
            if (lblBnsP2.Content != "-")
            { nEndSum2 = nPair2 + nPairs2 + nThrees2 + nFours2 + nHouse2 + nSLadder2 + nLLadder2 + nChance2 + nYatzy2 + bonus; }
            else { nEndSum2 = nPair2 + nPairs2 + nThrees2 + nFours2 + nHouse2 + nSLadder2 + nLLadder2 + nChance2 + nYatzy2; }
            int oldSum2;
            if (int.TryParse(lblSumP2.Content.ToString(), out oldSum2))
                lblEndSumP2.Content = nEndSum2 + oldSum2;

            //Player 3
            int nPair3, nPairs3, nThrees3, nFours3, nHouse3, nSLadder3, nLLadder3, nChance3, nYatzy3, nEndSum3;
            nPair3 = int.Parse(textBoxPairP3.Text);
            nPairs3 = int.Parse(textBoxTwoPairsP3.Text);
            nThrees3 = int.Parse(textBoxThreesP3.Text);
            nFours3 = int.Parse(textBoxFoursP3.Text);
            nHouse3 = int.Parse(textBoxHouseP3.Text);
            nSLadder3 = int.Parse(textBoxSmallLadderP3.Text);
            nLLadder3 = int.Parse(textBoxLargeLadderP3.Text);
            nChance3 = int.Parse(textBoxChanceP3.Text);
            nYatzy3 = int.Parse(textBoxYatzyP3.Text);
            if (lblBnsP3.Content != "-")
            { nEndSum3 = nPair3 + nPairs3 + nThrees3 + nFours3 + nHouse3 + nSLadder3 + nLLadder3 + nChance3 + nYatzy3 + bonus; }
            else { nEndSum3 = nPair3 + nPairs3 + nThrees3 + nFours3 + nHouse3 + nSLadder3 + nLLadder3 + nChance3 + nYatzy3; }
            int oldSum3;
            if (int.TryParse(lblSumP3.Content.ToString(), out oldSum3))
                lblEndSumP2.Content = nEndSum3 + oldSum3;

            //Player 4
            int nPair4, nPairs4, nThrees4, nFours4, nHouse4, nSLadder4, nLLadder4, nChance4, nYatzy4, nEndSum4;
            nPair4 = int.Parse(textBoxPairP4.Text);
            nPairs4 = int.Parse(textBoxTwoPairsP4.Text);
            nThrees4 = int.Parse(textBoxThreesP4.Text);
            nFours4 = int.Parse(textBoxFoursP4.Text);
            nHouse4 = int.Parse(textBoxHouseP4.Text);
            nSLadder4 = int.Parse(textBoxSmallLadderP4.Text);
            nLLadder4 = int.Parse(textBoxLargeLadderP4.Text);
            nChance4 = int.Parse(textBoxChanceP4.Text);
            nYatzy4 = int.Parse(textBoxYatzyP4.Text);
            if (lblBnsP3.Content != "-")
            { nEndSum4 = nPair4 + nPairs4 + nThrees4 + nFours4 + nHouse4 + nSLadder4 + nLLadder4 + nChance4 + nYatzy4 + bonus; }
            else { nEndSum4 = nPair4 + nPairs4 + nThrees4 + nFours4 + nHouse4 + nSLadder4 + nLLadder4 + nChance4 + nYatzy4; }
            int oldSum4;
            if (int.TryParse(lblSumP4.Content.ToString(), out oldSum4))
                lblEndSumP2.Content = nEndSum4 + oldSum4;
        }
    }
}