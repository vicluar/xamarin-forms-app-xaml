using BethanysPieShopMobile.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new HomePageView());
        }

        private async void PieOverviewButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new PieOverviewView());
        }

        private async void BasketButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new BasketView());
        }

        private async void ContactUsButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new ContactusView());
        }
    }
}