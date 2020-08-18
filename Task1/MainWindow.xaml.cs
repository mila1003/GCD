using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Task1
{
    public partial class MainWindow : Window
    {
        public static class GCD
        {
            public static long Euclidean(out TimeSpan time, long a, long b)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                try
                {
                    if (a > 0 && b > 0)
                    {
                        if (a == b)
                        {
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return a;
                        }
                        else
                        {
                            while ((a != 0) && (b != 0))
                            {
                                if (a > b)
                                    a = a % b;
                                else
                                    b = b % a;
                            }
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return Math.Max(a, b);
                        }
                    }
                    else { throw new Exception(); }
                }
                catch { MessageBox.Show("Числа должны быть больше нуля!"); }
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return 0;
            }

            public static long Euclidean(out TimeSpan time, long a, long b, long c)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                try
                {
                    if (a > 0 && b > 0)
                    {
                        if (a == b)
                        {
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return a;
                        }
                        else
                        {
                            long Nod = 0;
                            if (a < b) { Nod = a; } else { Nod = b; }
                            //= Math.Min(a, Math.Min(a, b));
                            for (; Nod > 1; Nod--)
                            {
                                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0)
                                    break;
                            }
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return Nod;
                        }
                    }
                    else { throw new Exception(); }
                }
                catch { MessageBox.Show("Числа должны быть больше нуля!"); }
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return 0;
            }

            public static long Euclidean(out TimeSpan time, long a, long b, long c, long d)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                try
                {
                    if (a > 0 && b > 0)
                    {
                        if (a == b)
                        {
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return a;
                        }
                        else
                        {
                            long Nod = 0;
                            if (a < b) { Nod = a; } else { Nod = b; }
                            //int Nod = Math.Min(a, Math.Min(a, b));
                            for (; Nod > 1; Nod--)
                            {
                                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0 && d % Nod == 0)
                                    break;
                            }
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return Nod;
                        }
                    }
                    else { throw new Exception(); }
                }
                catch { MessageBox.Show("Числа должны быть больше нуля!"); }
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return 0;
            }

            public static long Euclidean(out TimeSpan time, long a, long b, long c, long d, long e)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                try
                {
                    if (a > 0 && b > 0)
                    {
                        if (a == b)
                        {
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return a;
                        }
                        else
                        {
                            long Nod = 0;
                            if (a < b) { Nod = a; } else { Nod = b; }
                            //int Nod = Math.Min(a, Math.Min(a, b));
                            for (; Nod > 1; Nod--)
                            {
                                if (a % Nod == 0 && b % Nod == 0 && c % Nod == 0 && d % Nod == 0 && e % Nod == 0)
                                    break;
                            }
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return Nod;
                        }
                    }
                    else { throw new Exception(); }
                }
                catch { MessageBox.Show("Числа должны быть больше нуля!"); }
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return 0;
            }

            public static long BinaryEuclidean(out TimeSpan time, long a, long b)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                try
                {
                    if (a > 0 && b > 0)
                    {
                        if (a == b)
                        {
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return a;
                        }
                        else
                        {
                            long temp = 0;
                            while (a != b)
                            {
                                if ((a % 2 == 0) && (b % 2 == 0))
                                {
                                    a = a / 2;
                                    b = b / 2;
                                }
                                else if ((a % 2 == 0) && (b % 2 > 0))
                                {
                                    a = a / 2;
                                }
                                else if ((a % 2 > 0) && (b % 2 == 0))
                                {
                                    if (b > a)
                                        b = b - a;
                                    else
                                        b = a - b;
                                }
                                else if ((a % 2 > 0) && (b % 2 > 0))
                                {
                                    temp = b;
                                    if (b > a)
                                        b = b - a;
                                    else
                                        b = a - b;
                                    a = temp;
                                }
                            }
                            stopWatch.Stop();
                            time = stopWatch.Elapsed;
                            return b;
                        }
                    }
                    else { throw new Exception(); }
                }
                catch { MessageBox.Show("Числа должны быть больше нуля!"); }
                stopWatch.Stop();
                time = stopWatch.Elapsed;
                return 0;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoB(object sender, RoutedEventArgs e)
        {
            TimeSpan time;
            long result = 0;
            try
            {
                result = GCD.BinaryEuclidean(out time, Convert.ToInt64(oneB.Text), Convert.ToInt64(twoB.Text));
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds);
                if (result != 0)
                {
                    MessageBox.Show($"НОД чисел является число {result}. Время выполнения: {elapsedTime}");
                }
            }
            catch { MessageBox.Show("Заполните поля правильно!"); }
        }

        private void Do(object sender, RoutedEventArgs e)
        {
            TimeSpan time;
            long result = 0;
            try
            {
                List<long> numbers = new List<long>();
                if (one.Text != "") { numbers.Add(Convert.ToInt64(one.Text)); };
                if (two.Text != "") { numbers.Add(Convert.ToInt64(two.Text)); };
                if (three.Text != "") { numbers.Add(Convert.ToInt64(three.Text)); };
                if (four.Text != "") { numbers.Add(Convert.ToInt64(four.Text)); };
                if (five.Text != "") { numbers.Add(Convert.ToInt64(five.Text)); };

                switch (numbers.Count)
                {
                    case 2: result = GCD.Euclidean(out time, numbers[0], numbers[1]); break;
                    case 3: result = GCD.Euclidean(out time, numbers[0], numbers[1], numbers[2]); break;
                    case 4: result = GCD.Euclidean(out time, numbers[0], numbers[1], numbers[2], numbers[3]); break;
                    case 5: result = GCD.Euclidean(out time, numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]); break;
                    default: throw new Exception();
                }
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);
                if (result != 0)
                {
                    MessageBox.Show($"НОД чисел является число {result}. Время выполнения: {elapsedTime}");
                }
            }
            catch { MessageBox.Show("Заполните поля правильно!"); }
        }


        private void OnCompare(object sender, RoutedEventArgs e)
        {
            Compare c = new Compare(); c.Show();
        }
    }
}
