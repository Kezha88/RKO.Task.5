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

namespace RKO.Task._5.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(TbN.Text);
                string[] A = new string[N];
                Random ran = new Random();
                int k, max = 0, min = 21;
                for (int i = 0; i < A.Length; i++)
                {
                    k = ran.Next(1, 20);
                    if(k > max)
                    {
                        max = k;
                    }
                    if (k < min)
                    {
                        min = k;
                    }
                    string B = Convert.ToString(k, 2);
                    A[i] = B;
                }
                string S = Convert.ToString(max, 2);
                string L = Convert.ToString(min, 2);

                MessageBox.Show($"{string.Join(", ", A)}\n max ={S}, min ={L}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
