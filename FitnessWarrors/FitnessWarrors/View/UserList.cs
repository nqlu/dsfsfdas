using FitnessWarrors.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FitnessWarrors.View
{
	public class UserList : ContentPage
	{
        private ListView _listView;
        string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "myDB.db3");
		public UserList ()
		{
            this.Title = "List of User ";
            var db = new SQLiteConnection(dbPath);
            StackLayout stackLayout = new StackLayout();
            _listView = new ListView();
            _listView.ItemsSource = db.Table<UserInfo>().OrderBy(x => x.Name).ToList();
            stackLayout.Children.Add(_listView);

            Content = stackLayout;
		}

		
	}
}