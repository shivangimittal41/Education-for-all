using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParivartanApp.Courses.GoogleMeet
{
    public partial class GoogleMeet : ContentPage
    {
        public GoogleMeet()
        {
            InitializeComponent();
        }
        async void Video_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Video());
        }
        async void Material_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Material());
        }
        async void Assessment_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assessment());
        }
    }
}
