using BasicXamarinApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace BasicXamarinApp.ViewModels
{
    public interface IMainViewModel
    {

    }
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        public ICommand NextPageCommand { get; set; }
        [Preserve]
        public MainViewModel()
        {
            NextPageCommand = new Command<string>(NextPage);
        }

        public async void NextPage(string param)
        {
            switch (param)
            {
                case "0": await App.Current.MainPage.Navigation.PushAsync(new ExpandedListView(), true);
                    break;
                case "1":
                    await App.Current.MainPage.Navigation.PushAsync(new StyleAndCustomFontView(), true);
                    break;
                case "2":
                    await App.Current.MainPage.Navigation.PushAsync(new AlertAndPopup(), true);
                    break;
                case "3":
                    await App.Current.MainPage.Navigation.PushAsync(new SliderView(), true);
                    break;

            }
        }
    }
}
