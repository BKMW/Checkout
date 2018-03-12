using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Checkout
{
	public partial class MainPage : ContentPage
	{
        // public List<Product> products;
        private List<User> AdressShipping;
        private ObservableCollection<Product> products { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Step1Layout.IsVisible = true;
            Step3Layout.IsVisible = false;
            Step2Layout.IsVisible = false;
            Data();
            ListProducts.ItemsSource = products;


            // form data  => step2 
            AdressShipping = new List<User>()
            {
                new User()
                {
                    Title= "Please Enter Shipping Adress",
                    IsVisible = false
                }

             };



            Name.Text = "Mohammed Nasser M";
            City.Text = "Riyadh";
            ShippingAdress.Text = "13 Darb Street";
            HouseNumber.Text = "12A";
            StreetName.Text = "Al Dar Reea";
            // end form data => step 2
        }
        void Data()
        {
            //products = new List <Product> 
            products = new ObservableCollection<Product>
            {
                new Product
                {
                    ID =1,
                    Name = "BROWNIE HIP SUNGLASSES",
                    Status = "Almost New",
                    Price = "770.00 SAR",
                    Image = "Pic1.png"
                },
                new Product
                {
                    ID =2,
                    Name = "BROWNIE GLASSES HOLDER",
                    Status = "Acceptable",
                    Price = "3000 SAR",
                    Image = "Pic2.png"
                },
                new Product
                {
                    ID =3,
                    Name = "HANDBAG NATURAL LEATHER",
                    Status = "New",
                    Price = "3000.00 SAR",
                    Image = "Pic3.png"
                }
            };
        }

        // start function button next  and back 
        private void Button_OnBackStep3Clicked(object sender, EventArgs e)
        {
            INStep2.BackgroundColor = Color.White;
            EXStep2.BackgroundColor = Color.FromHex("#443e42");
            EXStep3.BackgroundColor = Color.Silver;
            stepConfirm.TextColor = Color.Silver;
            Step2Layout.IsVisible = true;
            Step3Layout.IsVisible = false;
            Step1Layout.IsVisible = false;
        }
        private void Button_OnNextStep3Clicked(object sender, EventArgs e)
        {

        }
        private void Button_OnBackStep2Clicked(object sender, EventArgs e)
        {
            INStep1.BackgroundColor = Color.White;
            EXStep1.BackgroundColor = Color.FromHex("#443e42");
            EXStep2.BackgroundColor = Color.Silver;
            step2.TextColor = Color.Silver;
            Step2Layout.IsVisible = false;
            Step3Layout.IsVisible = false;
            Step1Layout.IsVisible = true;
        }
        private void Button_OnNextStep2Clicked(object sender, EventArgs e)
        {
            INStep2.BackgroundColor = Color.FromHex("#443e42");
            EXStep3.BackgroundColor = Color.FromHex("#443e42");
            stepConfirm.TextColor = Color.FromHex("#443e42");
            Step2Layout.IsVisible = false;
            Step3Layout.IsVisible = true;
            Step1Layout.IsVisible = false;
        }
        private void Button_OnBackStep1Clicked(object sender, EventArgs e)
        {
        }
        private void Button_OnNextStep1Clicked(object sender, EventArgs e)
        {
            INStep1.BackgroundColor = Color.FromHex("#443e42");
            EXStep2.BackgroundColor = Color.FromHex("#443e42");
            step2.TextColor = Color.FromHex("#443e42");
            Step2Layout.IsVisible = true;
            Step3Layout.IsVisible = false;
            Step1Layout.IsVisible = false;
        }
        // end fun button next and back
        private void TapGestureRecognizer_OnCreditCardTapped(object sender, EventArgs e)
        {
            CreditCardFrame.BackgroundColor = Color.Black;
            BankTransferFrame.BackgroundColor = Color.Gainsboro;
        }
        private void TapGestureRecognizer_OnBankTransferTapped(object sender, EventArgs e)
        {
            CreditCardFrame.BackgroundColor = Color.Gainsboro;
            BankTransferFrame.BackgroundColor = Color.Black;
        }

        private void TapGestureRecognizer_OnExpressShippingTapped(object sender, EventArgs e)
        {
            ExpressShippingFrame.BackgroundColor = Color.Black;
            NormalShippingFrame.BackgroundColor = Color.Gainsboro;
        }
        private void TapGestureRecognizer_OnNormalShippingTapped(object sender, EventArgs e)
        {
            ExpressShippingFrame.BackgroundColor = Color.Gainsboro;
            NormalShippingFrame.BackgroundColor = Color.Black;
        }
        public void RemoveProduct(object sender, EventArgs e)
        {
            // var button = sender as Button;
            var remove = sender as Image;
            var product = remove.BindingContext as Product;
            products.Remove(product);
            
           
        }

    }
}