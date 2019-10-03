using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void addViews(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap1()));
        }

        private void arrayMarkup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_1()));
        }

        private void referenceMarkup(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_2()));
        }

        private void xamlConstructors(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_3()));
        }

        private void settingProperty(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Chap2_4()));
        }
    }
}
