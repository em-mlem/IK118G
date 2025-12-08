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

namespace exempeltenta_squidgame
{
    public partial class MainWindow : Window
    {
        public List<int> Numbers { get; set; }
        public bool IsUnique (List<int> list, int number)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == number)
                {
                    return false;
                }
            }
            return true;
        }
        public List<int> FindCommonMultiples()
        {
            List<int> result = new();
            for (int i = 0; i <= 456; i++)
            {
                if (i % 4 == 0 && i % 5 == 0 && i % 6 == 0)
                { 
                    result.Add(i);
                }
            }
            return result;
        }
        public int TotalDigitSum(List<int> numbers)
        {
            int total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                total += SumDigits(numbers[i]);
            }
            return total;
        }
        static int SumDigits (int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        public List<int> DivideGuardsByRank(int totalGuards)
        {
            int circles = (int)Math.Round(totalGuards * 0.60);
            int triangles = (int)Math.Round(totalGuards * 0.30);
            int squares = (int)Math.Round(totalGuards * 0.10);
            int sum = circles + triangles + squares;

            if (sum!= totalGuards)
            {
                int diff = totalGuards - sum;
                circles += diff;
            }
            return new List<int> { circles, triangles, squares };
        }
        public Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            Numbers = new List<int>();
        }

        private void btnchknumbers_Click(object sender, RoutedEventArgs e)
        {
            string numtxt = txtNumbers.Text;
            int num = int.Parse(numtxt);
            if (num < 1 || num > 456)
            {
                MessageBox.Show("Numret måste vara mellan 1 och 456, försök igen.");
                return;
            }
            if (!IsUnique(Numbers, num))
            {
                MessageBox.Show($"{num} är redan upptaget, välj ett nytt nummer.");
                return;
            }
            MessageBox.Show("Numret har lagts till. Tack!");
            Numbers.Add(num);
                
        }

        private void btnmagicnumber_Click(object sender, RoutedEventArgs e)
        {
            List<int> magicNumbers = FindCommonMultiples();
            int totalDigitSum = TotalDigitSum(magicNumbers);
            MessageBox.Show("Magiska nummer: " + string.Join(", ", magicNumbers));
            MessageBox.Show($"Summan av alla siffror i listan är: {totalDigitSum}");
        }

        private void btnguards_Click(object sender, RoutedEventArgs e)
        {
            string input = txtNumbers.Text;
            int totalGuards;

            if (!int.TryParse(input, out totalGuards) || totalGuards < 1)
            {
                MessageBox.Show("Var vänlig ange ett giltigt heltal för antal vakter.");
                return;
            }
            List<int> result = DivideGuardsByRank(totalGuards);
            MessageBox.Show(
                 $"Cirklar (O): {result[0]}\n" + $"Trianglar (△): {result[1]}\n" + $"Fyrkanter (□): {result[2]}");
        }
        private void btntugofwar_Click(object sender, RoutedEventArgs e)
        {
            int[] teamA = new int[5];
            int[] teamB = new int[5];

            int sumA = 0;
            int sumB = 0;

            for (int i = 0; i< 5; i++)
            {
                teamA[i] = _random.Next(1, 11);
                teamB[i] = _random.Next(1, 11);

                sumA += teamA[i];
                sumB += teamB[i];
            }
            string winnerText;
            if (sumA > sumB)
            {
                winnerText = "Lag A vann!";
            }
            else if (sumB > sumA)
            {
                winnerText = "Lag B vann!";
            }
            else
            {
                int winsA = 0;
                int winsB = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (teamA[i] > teamB[i])
                    {
                        winsA++;
                    }
                    else if (teamB[i] > teamA[i])
                    {
                        winsB++;
                    }
                }
                if (winsA > winsB)
                {
                    winnerText = "Lag A vann på flest individuella segrar!";
                }
                else if (winsB > winsA)
                {
                    winnerText = "Lag B vann på flest individuella segrar!";
                }
                else
                {
                    int randomWinner = _random.Next(0, 2);
                    if (randomWinner == 0)
                    {
                        winnerText = "Det var helt jämnt – slumpen avgjorde: Lag A vann!";
                    }
                    else
                    {
                        winnerText = "Det var helt jämnt – slumpen avgjorde: Lag B vann!";
                    }
                }


            }
            MessageBox.Show($"Lag A: {string.Join(", ", teamA)} (summa: {sumA})\n" + $"Lag B: {string.Join(", ", teamB)} (summa: {sumB})\n\n" + winnerText);

        }
    }
}