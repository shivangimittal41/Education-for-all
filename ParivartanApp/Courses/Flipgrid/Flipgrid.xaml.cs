using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParivartanApp.Courses.Flipgrid
{
    public partial class Flipgrid : ContentPage
    {
        public Flipgrid()
        {
            InitializeComponent();
        }
        async void Video_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Videos());
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
