﻿using FitnessWarriors.Model;
using FitnessWarrors.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//h
namespace FitnessWarriors.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            loginLogo.Source = ImageSource.FromFile("fwlogo.png");

        }
        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Okay");
                Navigation.PushAsync(new FitnessWarrors.View.Menu());
            }
            else
            {
                DisplayAlert("Login", "Login Failed", "Okay");
            }
        }

    }
}