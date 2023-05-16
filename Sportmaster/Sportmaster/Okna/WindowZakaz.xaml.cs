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

namespace Sportmaster.Okna
{
    /// <summary>
    /// Логика взаимодействия для WindowZakaz.xaml
    /// </summary>
    public partial class WindowZakaz : Window
    {
        MainWindow mainWindow;
        List<Tovar> tovar = new List<Tovar>();
        public WindowZakaz(MainWindow main, List<Tovar> zakaz)
        {
            InitializeComponent();
            tovar = zakaz;
            lbTovar.ItemsSource = tovar;
            mainWindow = main;
            decimal summa = 0;
            foreach(var p in tovar)
            {
                summa = p.Cena + summa;
            }
            tbSumma.Text = summa.ToString()+" руб.";
        }

        private void btNazad_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.IsEnabled = true;
            this.Close();
        }

        private void btSohranit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешное сохранение заказа!");
            this.Close();
            mainWindow.IsEnabled = true;
        }

        private void btUdalenieIzZakaza_Click(object sender, RoutedEventArgs e)
        {
            var tovars = (sender as Button).DataContext as Tovar;
            tovar.Remove(tovars);
            lbTovar.ItemsSource = tovar;
            WindowZakaz window = new WindowZakaz(mainWindow, tovar);
            window.Show();
            this.Close();

        }
    }
}
