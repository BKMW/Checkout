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
	public partial class Step1 : ContentPage
	{
		public Step1 ()
		{
			InitializeComponent ();
		}
        private void FrameTapGestureRecognizer_OnTapped(object sender, EventArgs e)

        {

            Frame senderFrame = (Frame)sender;


            senderFrame.OutlineColor = Color.Red;

        }
    }
}