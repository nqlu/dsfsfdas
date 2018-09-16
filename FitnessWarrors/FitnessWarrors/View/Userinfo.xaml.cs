using FitnessWarrors.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
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
        string _dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDb.db3");
        public Userinfo()
        {
            InitializeComponent();
        }

        private async void Confirm_Userdetails_Button_Clicked(object sender, EventArgs e)
        {
            var db = new SQLiteConnection(_dbPath);
            db.CreateTable<UserInfo>();

            var maxPk = db.Table<UserInfo>().OrderByDescending(c => c.Id).FirstOrDefault();

            UserInfo userinfo = new UserInfo()
            {
                Id = (maxPk == null ? 1 : maxPk.Id + 1),
                Name = Entry_Userinfo_Name.Text,
                Age = Entry_Userinfo_Age.Text,
                Weight = Entry_Userinfo_Weight.Text,
                Height = Entry_Userinfo_Height.Text,
                Wake = Entry_Userinfo_Waketime.Text,
                Sleep = Entry_Userinfo_Sleeptime.Text,
                Train = Entry_Userinfo_Trainingtime.Text,
                Job = Entry_Userinfo_Occupation.Text,


            };
            db.Insert(userinfo);
            await DisplayAlert(null, userinfo.Name + "Saved", "Ok");
            await Navigation.PushAsync(new Menu());
        }


    }
}