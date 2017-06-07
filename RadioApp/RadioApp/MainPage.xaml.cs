using System;
using Plugin.MediaManager;
using Xamarin.Forms;

namespace RadioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Play("http://www.montemagno.com/sample.mp3");
        }
    }
}
