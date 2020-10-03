using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ParivartanApp.Courses;

namespace ParivartanApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void ICT_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ICT());
        }
        async void MSForms_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MSForms());
        }
        async void GoogleMeet_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GoogleMeet ());
        }
        async void Wakelet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wakelet());
        }
        async void Flipgrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Flipgrid());
        }
        async void Skype_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Skype());
        }
        
        async void Kahoot_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kahoot());
        }
    }
}
