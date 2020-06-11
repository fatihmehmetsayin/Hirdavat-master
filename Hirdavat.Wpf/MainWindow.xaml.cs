using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.Net.Http.Headers;
using Hirdavat.Wpf.UC;
using System.Windows.Threading;

namespace Hirdavat.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static HttpClient HttpClient = new HttpClient();


        public MainWindow()
        {
            InitializeComponent();

            getmekanikelaletleri();
            getelektriklielaletleri();
            getakulualetler();
            gethavalialetler();
            getolcumcihazlari();
            bahcemakineleri();
            hobialetleri();
            kategoriygetir();
            TimerStartAna();
            TimerStartyan();
        }
        public int sayac = 0;
        public int sayacyan = 0;

        DispatcherTimer dt = new DispatcherTimer();

        public void TimerStartAna()
        {



            dt.Interval = TimeSpan.FromSeconds(5);

            dt.Tick += Dt_Tick;
            dt.Start();


        }
        DispatcherTimer dy = new DispatcherTimer();
        public void TimerStartyan()
        {



            dy.Interval = TimeSpan.FromSeconds(3);

            dy.Tick += Dy_Tick;
            dy.Start();


        }

        private void Dy_Tick(object sender, EventArgs e)
        {
            Uc_getirYan(gridyan, new UC_Yan(sayacyan));
            sayacyan++;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            Uc_getirAna(anasayfagrid, new UC_Anasayfa(sayac));
            sayac++;



        }

        public void Uc_getirAna(Grid grd, UserControl userControl)
        {

            if (grd.Children.Count > 0)
            {

                grd.Children.Clear();

                grd.Children.Add(userControl);
            }
            else
            {
                grd.Children.Add(userControl);
            }


        }
        public void Uc_getirYan(Grid grd, UserControl userControl)
        {

            if (grd.Children.Count > 0)
            {

                grd.Children.Clear();

                grd.Children.Add(userControl);
            }
            else
            {
                grd.Children.Add(userControl);
            }


        }
        private async void kategoriygetir()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category").Result;
            if (response.IsSuccessStatusCode)
            {

                var categorymodel = await HttpClient.GetStringAsync("http://localhost:59949/api/category");

                CategoryModel categoryModel = new CategoryModel();

                cmbxcategory.ItemsSource = JsonConvert.DeserializeObject<List<CategoryModel>>(categorymodel);

                // List<ProductsModel> productsModels = categoryModel.Products;

                //  cmbxcategory.ItemsSource = (System.Collections.IEnumerable)categoryModel;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void hobialetleri()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/7/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/7/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx7.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void bahcemakineleri()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/6/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/6/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx6.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void getolcumcihazlari()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/5/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/5/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx5.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void gethavalialetler()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/4/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/4/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx4.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void getakulualetler()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/3/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/3/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx3.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void getelektriklielaletleri()
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/2/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/2/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx2.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private async void getmekanikelaletleri()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59949/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/category/1/product").Result;
            if (response.IsSuccessStatusCode)
            {

                var products = await HttpClient.GetStringAsync("http://localhost:59949/api/category/1/product");

                CategoryModel categoryModel = new CategoryModel();

                categoryModel = JsonConvert.DeserializeObject<CategoryModel>(products);

                List<ProductsModel> productsModels = categoryModel.Products;

                cmbx1.ItemsSource = productsModels;
            }

            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }







        private void cmbx1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx1.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx2.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void labelsag_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Uc_getirAna(anasayfagrid, new UC_Anasayfa(sayac));
            sayac++;

        }

        private void labelsol_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uc_getirAna(anasayfagrid, new UC_Anasayfa(sayac));
            sayac--;
        }

        private void labelsag_MouseEnter(object sender, MouseEventArgs e)
        {
            labelsag.FontSize = 60;
        }

        private void labelsag_MouseLeave(object sender, MouseEventArgs e)
        {
            labelsag.FontSize = 50;
        }

        private void labelsol_MouseEnter(object sender, MouseEventArgs e)
        {
            labelsol.FontSize = 60;

        }

        private void labelsol_MouseLeave(object sender, MouseEventArgs e)
        {
            labelsol.FontSize = 50;

        }

        private void labelsol_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Yan_labelsol_MouseEnter(object sender, MouseEventArgs e)
        {
            Yan_labelsol.FontSize = 35;
        }

        private void Yan_labelsol_MouseLeave(object sender, MouseEventArgs e)
        {
            Yan_labelsol.FontSize = 30;

        }

        private void Yan_labelsol_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uc_getirYan(gridyan, new UC_Yan(sayacyan));
            sayacyan--;
        }

        private void Yan_labelsag_MouseLeave(object sender, MouseEventArgs e)
        {
            Yan_labelsag.FontSize = 30;
        }

        private void Yan_labelsag_MouseEnter(object sender, MouseEventArgs e)
        {
            Yan_labelsag.FontSize = 35;
        }

        private void Yan_labelsag_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uc_getirYan(gridyan, new UC_Yan(sayacyan));
            sayacyan++;
        }

        private void cmbx3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx3.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx4.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx5.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx6.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx7.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void cmbx8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm = (ProductsModel)cmbx3.SelectedItem;

            Uc_getirAna(UrunGoster, new UC_UrunGoster(pm));
            dt.Stop();
            dy.Stop();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left || e.ChangedButton == MouseButton.Right)

            {
                UrunGoster.Children.Clear();
                dy.Start();
                dt.Start();


            }
        }
    }
}
