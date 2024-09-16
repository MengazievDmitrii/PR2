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

namespace ПР2
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
           double s = Convert.ToDouble(tb1.Text); //колличество суток
            double ch = 24 * s; //колличество часов
            double min =ch*60; //колличество минут
            double sek = 60 * min; //колличество секунд

            lb4.Content = ch.ToString();
            lb5.Content = min.ToString();
            lb6.Content = sek.ToString();


        }
    }
}
