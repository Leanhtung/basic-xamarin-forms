using BasicXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms.Internals;

namespace BasicXamarinApp.ViewModels
{
    public interface ISliderViewModel { }
    public class SliderViewModel :BaseViewModel,ISliderViewModel
    {
        private ObservableCollection<SliderModel> _sliders;
        public ObservableCollection<SliderModel> Sliders
        {
            get { return _sliders; }
            set { _sliders = value;OnPropertyChanged(nameof(Sliders)); }
        }
        [Preserve]
        public SliderViewModel()
        {
            LoadData();
            Sliders = new ObservableCollection<SliderModel>();
        }

        public void LoadData()
        {
            var sliders = new List<SliderModel>
            {
                new SliderModel { ID=1,Uri= "https://cityapartment.com.vn/wp-content/uploads/2018/07/ra-mat-du-an-eco-green-saigon-cua-xuan-mai-corp-cityapartmentcomvn3-1200x500.jpg" },
           new SliderModel{ID=1,Uri="https://gftart.com/wp-content/uploads/2019/10/dividendstock_CanbanchonguoiViet-1200x500.jpg" },
            new SliderModel{ID=2,Uri="https://chuyenbannhadat.com/wp-content/uploads/2019/10/hinh-thuc-te-phuc-an-garden-1200x500.jpg" }
            };
            Sliders = new ObservableCollection<SliderModel>(sliders);
        }
    }
}
