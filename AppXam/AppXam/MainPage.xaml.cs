using AppXam.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppXam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ApiPersonas _apiPersonas;
        public MainPage()
        {
            InitializeComponent();
            _apiPersonas = new ApiPersonas();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = await _apiPersonas.ObtenerPersonas();
        }
    }
}
