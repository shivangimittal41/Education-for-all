using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParivartanApp.Courses.Skype
{
    public partial class Skype : ContentPage
    {
        public Skype()
        {
            InitializeComponent();
        }
        async void Video_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Skype Video Tutorial", "Coming Soon", "OK");
            //await Navigation.PushAsync(new Video());
        }
        async void Material_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Material());
        }
        async void Assessment_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Skype Assessment", "Coming Soon", "OK");
            //await Navigation.PushAsync(new Assessment());
        }
    }
}
