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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void menu_workout_button_Clicked(object sender, EventArgs e)
        {

        }

        private void menu_articles_button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserList());
        }

        private void menu_fullprogram_button_Clicked(object sender, EventArgs e)
        {

        }
            
        private void menu_mealplanner_button_Clicked(object sender, EventArgs e)
        {

        }

        private void menu_shop_button_Clicked(object sender, EventArgs e)
        {

        }

        private void menu_recipes_button_Clicked(object sender, EventArgs e)
        {

        }

        private void menu_forums_button_Clicked(object sender, EventArgs e)
        {

        }

        private async void menu_userinfo_button_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new Userinfo());
        }
    }
}