using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace RKO.Task._5.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                const int N = 10;

                var array = new int[N];

                for (var i = 0; i < array.Length; i++)
                {
                    if(i == 1 || i == 2 || i == 3 || i == 6 || i == 8)
                        array[i] = 1;
                    if (i == 4 || i == 5 || i == 7 || i == 9 || i == 10)
                        array[i] = 0;
                }

                int temp = array[array.Length - 1];
                for (int i = array.Length - 1; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
                array[0] = temp;
                MessageBox.Show($"{A}\n{string.Join("", array)}\nРазность чисел =", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
