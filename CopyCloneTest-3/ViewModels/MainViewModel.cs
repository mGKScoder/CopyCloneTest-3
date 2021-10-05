using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace CopyCloneTest_3.ViewModels
{
    public class MainViewModel :ReactiveObject
    {
        private ItemsViewModel[] _items = Array.Empty<ItemsViewModel>();
        public ItemsViewModel[] Items
        {
            get => _items;
            set => this.RaiseAndSetIfChanged(ref _items, value);
        }
        public MainViewModel()
        {
            var item = new ItemsViewModel();
            Items = Items.Concat(new[] { item }).ToArray();
        }

        public void Copy()
        {
            var page = new ItemsViewModel();
        }
        public void Clone()
        {
            var page = new ItemsViewModel();

        }

      

    }
}
