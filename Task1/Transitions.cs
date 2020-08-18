using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task1
{
    public partial class MainWindow : Window
    {

        private void OnEvclid(object sender, RoutedEventArgs e)
        {
            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(1, GridUnitType.Star);
            ColumnDefinition c2 = new ColumnDefinition();
            c2.Width = new GridLength(0, GridUnitType.Star);
            Algoritms.ColumnDefinitions.RemoveAt(0);
            Algoritms.ColumnDefinitions.RemoveAt(0);
            Algoritms.ColumnDefinitions.Add(c1);
            Algoritms.ColumnDefinitions.Add(c2);
            Evclid.Background = new SolidColorBrush(Colors.Violet);
            Stain.Background = new SolidColorBrush(Colors.Plum);
        }
        private void OnStain(object sender, RoutedEventArgs e)
        {
            ColumnDefinition c1 = new ColumnDefinition();
            c1.Width = new GridLength(0, GridUnitType.Star);
            ColumnDefinition c2 = new ColumnDefinition();
            c2.Width = new GridLength(1, GridUnitType.Star);
            Algoritms.ColumnDefinitions.RemoveAt(0);
            Algoritms.ColumnDefinitions.RemoveAt(0);
            Algoritms.ColumnDefinitions.Add(c1);
            Algoritms.ColumnDefinitions.Add(c2);
            Evclid.Background = new SolidColorBrush(Colors.Plum);
            Stain.Background = new SolidColorBrush(Colors.Violet);
        }
    }
}
