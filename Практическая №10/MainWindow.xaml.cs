using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая__10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<int> firstList = new List<int>(5);
        List<int> secondList = new List<int>(5);

        private void FillList_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            firstListBox.Items.Clear();
            secondListBox.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                firstList.Add(random.Next(-100, 100));
                firstListBox.Items.Add(firstList[i]);
                secondList.Add(random.Next(-100, 100));
                secondListBox.Items.Add(secondList[i]);
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            int kol = 0;
            for (int i = 0; i < firstList.Count && i < secondList.Count; i++)
            {
                if (firstList[i] > secondList[i])
                {
                    kol++;
                }
            }
            result.Text = kol.ToString();
        }

        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заданы два массива. Проверить, сколько элементов первого массива превосходят " +
              "соответствующие элементы второго массива.", "Задание");
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
