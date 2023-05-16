using Sportmaster.Okna;
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

namespace Sportmaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tovar> tovars;
        List<Tovar> zakaz = new List<Tovar>();
        
        public MainWindow()
        {
            InitializeComponent();
            tovars = DB.GetContext().Tovar.ToList();
            lbTovar.ItemsSource = tovars;

        }

        private void btDobavlenieVZakaz_Click(object sender, RoutedEventArgs e)
        {
            var tovar = (sender as Button).DataContext as Tovar;
            zakaz.Add(tovar);
        }

        private void btZakaz_Click(object sender, RoutedEventArgs e)
        {
            WindowZakaz windowZakaz = new WindowZakaz(this, zakaz);
            windowZakaz.Show();
            this.IsEnabled = false;
        }
    }
}
