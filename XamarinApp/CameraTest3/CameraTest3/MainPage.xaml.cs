using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace CameraTest3
{
    public partial class MainPage : ContentPage
    {
        ZXingScannerView zxing;
        ZXingDefaultOverlay overlay;

        public MainPage() : base()
        {
            InitializeComponent();
        }

        private void StartScanBtnClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new NavigationPage(new ScanPage()));
            Navigation.PushModalAsync(new ScanPage());
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            testLabel.Text = PublicVars.DecodedString;
        }

        private void QrGenerationPageBtnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new GenerationPage());

        }

    }
    
}
