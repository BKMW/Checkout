using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Checkout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Step3 : ContentPage
	{
        public List<Product> ProdList;

        public Step3 ()
		{
			InitializeComponent ();
            GetProduct();
            ProductsList.ItemsSource = ProdList;
            BindingContext = this;
        }


        void GetProduct()
        {
            ProdList = new List<Product>
            {

                new Product
                {
                    Name = "Gucci er",
                    Status = "Almost New",
                    Price = "3000.00 SAR",
                    Image = "Pic1.png"
                },
                new Product
                {
                    Name = "Gucci Hand Bag Light Brown",
                    Status = "Almost New",
                    Price = "3000.00 SAR",
                    Image = "Pic1.png"
                },

                new Product
                {
                    Name = "Gucci er",
                    Status = "Almost New",
                    Price = "3000.00 SAR",
                    Image = "Pic1.png"
                }
            };
        }
    }
}
