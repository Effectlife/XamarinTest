using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace CameraTest3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenerationPage : ContentPage
    {
        ZXingBarcodeImageView barcode;

        public GenerationPage()
        {
            InitializeComponent();
        }

        private void GenerateQrCode(string code)
        {
            barcode = new ZXingBarcodeImageView
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };
            barcode.BarcodeFormat = ZXing.BarcodeFormat.QR_CODE;
            barcode.BarcodeOptions.Width = 300;
            barcode.BarcodeOptions.Height = 300;
            barcode.BarcodeOptions.Margin = 10;
            barcode.BarcodeValue = code;
            Content = barcode;
        }

        private void GenerateCodeBtnClicked(object sender, EventArgs e)
        {
            if (!codeEntry.Text.Equals(""))
            {
                GenerateQrCode(codeEntry.Text);
            }
        }
    }
}