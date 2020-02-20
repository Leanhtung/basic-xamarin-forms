using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertAndPopup : ContentPage
    {
        public AlertAndPopup()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            AnimateCloseButton(CloseBtn, false);
            await popupDemo.FadeTo(0, 400);
            popupDemo.IsVisible = false;
        }

        private void btnPopup_Clicked(object sender, EventArgs e)
        {
            popupDemo.Opacity = 0;
            popupDemo.IsVisible = true;
            _ = popupDemo.FadeTo(1, 400);
            AnimateCloseButton(CloseBtn, true);
        }

        private void AnimateCloseButton(VisualElement element, bool entering)
        {
            var startTranslation = entering ? 100 : 0;
            var endTranslation = entering ? 0 : 100;
            var translationEasing = entering ? Easing.SinInOut : Easing.SinIn;

            var startOpacity = entering ? 0 : 1;
            var endOpacity = entering ? 1 : 0;

            var startRotation = entering ? -90 : 0;
            var endRotation = entering ? 0 : 180;

            element.TranslationY = startTranslation;
            element.Opacity = startOpacity;
            element.Rotation = startRotation;

            element.FadeTo(endOpacity, 400);
            element.RotateTo(endRotation, 700, Easing.SinInOut);
            element.TranslateTo(0, endTranslation, 600, translationEasing);


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await AlertDemo.FadeTo(0, 400);
            AlertDemo.IsVisible = false;
        }

        private void btnAlert_Clicked(object sender, EventArgs e)
        {
            AlertDemo.Opacity = 0;
            AlertDemo.IsVisible = true;
            _ = AlertDemo.FadeTo(1, 400);
        }
    }
}