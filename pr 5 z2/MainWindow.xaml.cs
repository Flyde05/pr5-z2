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

namespace pr_5_z2
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
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(textBoxA.Text);
            int b = Convert.ToInt32(textBoxB.Text);
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            resultTextBlock.Text = $"Количество нечетных чисел на отрезке [{a},{b}]: {count}";
        }
    }
}
    
 