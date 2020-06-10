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
        public UC_Yan( int sayim)
        {
            InitializeComponent();
            sayi = sayim;

        }
        public int sayi { get; set; }
        BitmapImage resim;
        public void resimdegistir()
        {
            if (sayi % 4 == 0)
            {
                resim = new BitmapImage(new Uri("https://st1.myideasoft.com/idea/bd/02/myassets/slider_pictures/pictures_2_1.png?revision=1584082159"));
                YanResim.Source = resim;


            }

            if (sayi % 4 == 1)
            {
                resim = new BitmapImage(new Uri("https://st2.myideasoft.com/idea/bd/02/myassets/slider_pictures/pictures_2_2.png?revision=1584082159"));
                YanResim.Source = resim;

            }
            if (sayi % 4 == 2)
            {
                resim = new BitmapImage(new Uri("https://st1.myideasoft.com/idea/bd/02/myassets/slider_pictures/pictures_2_5.png?revision=1584082159"));

                YanResim.Source = resim;



            }
            if (sayi % 4 == 3)
            {

                resim = new BitmapImage(new Uri("https://st2.myideasoft.com/idea/bd/02/myassets/slider_pictures/pictures_2_7.png?revision=1584082159"));

                YanResim.Source = resim;

            }

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            resimdegistir();

        }
    }
}
