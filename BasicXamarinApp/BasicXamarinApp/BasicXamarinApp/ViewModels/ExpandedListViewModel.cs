using BasicXamarinApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace BasicXamarinApp.ViewModels
{
    public interface IExpandedListViewModel
    {

    }
   public class ExpandedListViewModel : BaseViewModel, IExpandedListViewModel
    {
        private ObservableCollection<Items> _items;
        public ObservableCollection<Items> Items
        {
            get { return _items; }
            set { _items = value;OnPropertyChanged(nameof(Items)); }
        }

        public ICommand ActiveItemCommand { get; set; }
        public ICommand DeleteItemCommand { get; set; }
        [Preserve]
        public ExpandedListViewModel()
        {
            LoadData();
            ActiveItemCommand = new Command<int>(ActiveItem);
            DeleteItemCommand = new Command<Items>(DeleteItem);
        }

        public void DeleteItem(Items item)
        {
            var items = Items;
            items.Remove(item);
            Items = new ObservableCollection<Items>(items);
        }
        public void ActiveItem(int id)
        {
            var items = Items;
            var item = items.FirstOrDefault(x => x.ID == id);
            if (item != null)
            {
                item.Active = !item.Active;
            }
            Items = new ObservableCollection<Items>(items);
        }
        public void LoadData()
        {
            List<Items> items = new List<Items> { new Items { ID=0,Name="Lê Anh Tùng",Desc="Mô tả",Active=true},
               new Items { ID = 0, Name = "Trần Bá Thanh", Desc = "Mô tả", Active = true },
            new Items { ID=1,Name="Lê Mạnh Đạt",Desc="Mô tả",Active=true},
            new Items { ID=2,Name="Dương Công Thắng",Desc="Mô tả",Active=false},
            new Items { ID=3,Name="Lê Anh Tùng",Desc="Mô tả",Active=true},
            new Items { ID=4,Name="Lê Anh Tùng",Desc="Mô tả",Active=false},
            new Items { ID=5,Name="Lê Anh Tùng",Desc="Mô tả",Active=true},};

            Items = new ObservableCollection<Items>(items);
        }
    }
}
