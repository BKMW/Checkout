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
	public partial class Step2 : ContentPage
	{
        private List<CurrentUser> AdressShipping;

        public Step2 ()
		{
			InitializeComponent ();
            AdressShipping = new List<CurrentUser>()
            {
                new CurrentUser()
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

        }

	   
	   /* private void ShippingAdress_ItemTapped(object sender, ItemTappedEventArgs e)
	    {
            AdressShipping[0].IsVisible = true;

        }
        */
	  

    }
}