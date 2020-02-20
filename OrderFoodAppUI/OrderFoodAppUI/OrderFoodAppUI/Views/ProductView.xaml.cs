using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderFoodAppUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
    {
        public ProductView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}