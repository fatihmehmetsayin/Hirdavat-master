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
    /// Interaction logic for UC_UrunGoster.xaml
    /// </summary>
    public partial class UC_UrunGoster : UserControl
    {BitmapImage resim;
        public ProductsModel PM { get; set; }
        public UC_UrunGoster(ProductsModel pm)
        {
            Uri r = new Uri(pm.Url);
            
            InitializeComponent();
            PM = pm;
            resim = new BitmapImage(r);
            UrunGosterResim.Source = resim;
         UrunAdi.Text = pm.Name;
            FiyatBilgisi.Text = Convert.ToString( pm.Price)+"  TL";
            stok.Text = Convert.ToString( pm.Stok) +" Adet Stokta Var";
        }
    }
}
