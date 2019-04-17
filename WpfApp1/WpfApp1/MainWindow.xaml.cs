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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrikaziSpomenikeBTN_Click(object sender, RoutedEventArgs e)
        {
            Prikaz prikazSpomenika = new Prikaz();
            prikazSpomenika.Show();
        }

        private void IzaberiIkonicuSpomenikaBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SacuvajSpomenikBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IzaberiIkonicuTipaBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SacuvajTipBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SacuvajEtiketuBTN_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
