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

namespace WpfApp7
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

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
               Slider slider = (Slider)sender;
            int value = (int)slider.Value;
            Label1.Content = value;
            TextBlock1.FontSize = value;
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = Convert.ToInt32(TextBlock1.FontSize);
            Slider1.Minimum = value;
            Label1.Content = value.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!this.IsLoaded)
            {
                return;
            }
         int value = Convert.ToInt32(TextBlock1.FontSize);
            Slider1.Minimum = value;
            Label1.Content = value.ToString();
        }
    }
}
