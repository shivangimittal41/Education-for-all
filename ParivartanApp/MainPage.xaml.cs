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
            await Navigation.PushAsync(new Courses.MSForms.MSForms());
        }
        async void GoogleMeet_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Courses.GoogleMeet.GoogleMeet());
        }
        async void Wakelet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Courses.Wakelet.Wakelet());
        }
        async void Flipgrid_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Flipgrid", "Coming Soon", "OK");
            //await Navigation.PushAsync(new Courses.Flipgrid.Flipgrid());
        }
        async void Skype_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new Courses.Skype.Skype());
        }
        
        async void Kahoot_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Kahoot", "Coming Soon", "OK");
            //await Navigation.PushAsync(new Courses.Kahoot.Kahoot());
        }
    }
}
