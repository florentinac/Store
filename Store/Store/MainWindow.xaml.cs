using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
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
using StoreCore;
using StoreCore.Repository;

namespace Store
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //var repo = new Repozitory<Product, int>("Test2",@"Florentina-PC\SQLEXPRESS","sa","12345xx**");
            var products = GetAllProduct();
        }

        private List<Product> GetAllProduct()
        {
            var result = new List<Product>();
            using (var db = new StoreDBContext())
            {
                var product = new Product {Category = "Food", Id = 1, Name = "bread", Price = 10, Stock = 2};
                db.Products.Add(product);
                db.SaveChanges();
                var query = from p in db.Products
                            orderby p.Name
                            select p;
                foreach (var item in query)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}

