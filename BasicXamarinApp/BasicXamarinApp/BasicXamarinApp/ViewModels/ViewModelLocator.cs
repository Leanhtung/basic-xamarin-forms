using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace BasicXamarinApp.ViewModels
{
    public class ViewModelLocator
    {
        private IContainer _container;

        [Preserve]
        public ViewModelLocator()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MainViewModel>().As<IMainViewModel>().SingleInstance();
            builder.RegisterType<ExpandedListViewModel>().As<IExpandedListViewModel>().SingleInstance();
            builder.RegisterType<SliderViewModel>().As<ISliderViewModel>().SingleInstance();

            _container = builder.Build();
        }
        public ISliderViewModel Slider
        {
            get { return _container.Resolve<ISliderViewModel>(); }
        }
        public IMainViewModel Main
        {
            get
            {
                return _container.Resolve<IMainViewModel>();
            }
        }

        public IExpandedListViewModel ExpandListView
        {
            get { return _container.Resolve<IExpandedListViewModel>(); }
        }
    }
}
