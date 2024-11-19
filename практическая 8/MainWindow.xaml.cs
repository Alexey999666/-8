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
using System.Data.Common;
using System.Xml.Linq;
using System;
using Lib_14;


namespace практос_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Prime prime1 = new Prime();
        Prime prime2 = new Prime();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbNext1.Clear();
            tbNext2.Clear();
            tbStartNumber1.Clear();
            tbStartNumber2.Clear();
            tbClone.Clear();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс – серия чисел. Создать класс – простые числа. Класс должен включать конструктор. Сравнение производить по текущему значению.", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Андрианов Алексей Вариант 14.", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Question);
        }

        private void btnStartNumber1_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbStartNumber1.Text, out int number1) && number1 > 0)
            {
                prime1.SetStart(number1);
            }
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void btnReset1_Click(object sender, RoutedEventArgs e)
        {
            prime1.Reset();
            tbNext1.Clear();
        }

        private void btnStartNumber2_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbStartNumber2.Text, out int number2) && number2 > 0)
            {
                prime2.SetStart(number2);
            }
            else MessageBox.Show("Введите правильное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnReset2_Click(object sender, RoutedEventArgs e)
        {
            prime2.Reset();
            tbNext2.Clear();
        }

        private void btnNext1_Click(object sender, RoutedEventArgs e)
        {
            prime1.GetNext();
            tbNext1.Text += " " + Convert.ToString(prime1.val);

        }

        private void btnNext2_Click(object sender, RoutedEventArgs e)
        {
            prime2.GetNext();
            tbNext2.Text += " " + Convert.ToString(prime2.val);
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (prime1.CompareTo(prime2) == 1) MessageBox.Show("Текущее значение первого объекта, больше чем текущее значение второго объекта", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            if (prime1.CompareTo(prime2) == -1) MessageBox.Show("Текущее значение первого объекта, меньше чем текущее значение второго объекта", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
            if (prime1.CompareTo(prime2) == 0) MessageBox.Show("Текущие значения равны", "Результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnClone_Click(object sender, RoutedEventArgs e)
        {

            Prime prime3 = (Prime)prime1.Clone();
            tbClone.Text += Convert.ToString(prime3.Start) + " " + Convert.ToString(prime3.val) + " ";
        }
    }
}

