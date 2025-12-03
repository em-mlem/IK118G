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

namespace FL_figurer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new(4, 12);

            Triangle triangle = new(12, 2);

            double area = rectangle.GetArea();
            double area2 = triangle.GetArea();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rectangle = new(4, 12);
            Triangle triangle = new(baselength: 12, height: 2);
            Square square = new(5);

            List<Shape> shapes = new();
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);

            double area = 0;

            foreach (Shape shape in shapes)
            {
                area += shape.GetArea();
            }
        }
    }
}