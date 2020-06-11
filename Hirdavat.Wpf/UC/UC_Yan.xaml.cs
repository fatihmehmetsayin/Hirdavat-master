using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hirdavat.Wpf.UC
{
    /// <summary>
    /// Interaction logic for UC_Yan.xaml
    /// </summary>
    public partial class UC_Yan : UserControl
    {
        public int sayi { get; set; }
        public UC_Yan(int sayim)
        {
            InitializeComponent();
            sayi = sayim;

        }

        BitmapImage resim;
        public void resimdegistir()
        {
            if (sayi % 4 == 0)
            {
                resim = new BitmapImage(new Uri("https://st2.myideasoft.com/idea/bd/02/myassets/products/773/75476hmgms002_min.png?revision=1587125070"));
                YanResim.Source = resim;


            }

            if (sayi % 4 == 1)
            {
                resim = new BitmapImage(new Uri("https://st1.myideasoft.com/idea/bd/02/myassets/products/686/261538_min.png?revision=1587124650"));
                YanResim.Source = resim;

            }
            if (sayi % 4 == 2)
            {
                resim = new BitmapImage(new Uri("https://st1.myideasoft.com/idea/bd/02/myassets/products/664/06033c6001-1_min.png?revision=1587111386"));

                YanResim.Source = resim;



            }
            if (sayi % 4 == 3)
            {

                resim = new BitmapImage(new Uri("https://st1.myideasoft.com/idea/bd/02/myassets/products/631/ls1140-01_min.jpg?revision=1522247627"));

                YanResim.Source = resim;

            }

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            resimdegistir();

        }
    }
}
