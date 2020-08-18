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
using System.Windows.Shapes;
using static Task1.MainWindow;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для Compare.xaml
    /// </summary>
    public partial class Compare : Window
    {
        public Compare()
        {
            InitializeComponent();
        }

        private void DoCompare(object sender, RoutedEventArgs e)
        {
            try
            {
                TimeSpan timeE;
                TimeSpan timeS;
                GCD.Euclidean(out timeE, Convert.ToInt64(OneE.Text), Convert.ToInt64(TwoE.Text));
                GCD.BinaryEuclidean(out timeS, Convert.ToInt64(OneS.Text), Convert.ToInt64(TwoS.Text));
                string elapsedTimeE = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeE.Hours, timeE.Minutes, timeE.Seconds, timeE.Milliseconds / 10);
                string elapsedTimeS = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeS.Hours, timeS.Minutes, timeS.Seconds, timeS.Milliseconds / 10);
                ResultEuclidean.Text = $"Алгоритм Евклида " + elapsedTimeE;
                ResultStein.Text = $"Алгоритм Стейна " + elapsedTimeS;
            }
            catch { MessageBox.Show("Заполните поля правильно!"); }
        }
    }
}
