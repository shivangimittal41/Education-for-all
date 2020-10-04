using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ParivartanApp.Courses.MSForms
{
    public partial class MSForms : ContentPage
    {
        public MSForms()
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
