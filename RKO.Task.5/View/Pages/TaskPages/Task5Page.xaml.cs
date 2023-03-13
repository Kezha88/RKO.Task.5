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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RKO.Task._5.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int A = Convert.ToInt32(TbA.Text);
                int[] N = new int[15];
                int[] M = new int[15];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 99);
                    M[i] = k;
                    int T = int.Parse(new string(k.ToString().OrderByDescending(x => x).ToArray()));
                    N[i] = T;
                }

                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\nРезультат=\n{string.Join(", ", N)}", "Системное сообщение",
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
