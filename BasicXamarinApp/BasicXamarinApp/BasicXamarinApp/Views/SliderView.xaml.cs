using BasicXamarinApp.ViewModels;
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
    public partial class SliderView : ContentPage
    {
        public SliderView()
        {
            InitializeComponent();

            var vm = (SliderViewModel)this.BindingContext;
            vm.LoadData();
            Device.StartTimer(TimeSpan.FromSeconds(2), (Func<bool>)(() =>
            {
                mainSlider.Position = mainSlider.Position < vm.Sliders.Count - 1 ? mainSlider.Position + 1 : 0;
                return true;
            }));
            
        }
    }
}