using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitnessWarrors.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Userinfo : ContentPage
	{
		public Userinfo ()
		{
			InitializeComponent ();
		}

        private void Confirm_Userdetails_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}