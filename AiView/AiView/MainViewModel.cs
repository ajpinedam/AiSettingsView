using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;

namespace AiView
{
    public class MainViewModel : BaseViewModel
    {
        private IList<SectionItem> _items;
        public IList<SectionItem> Items 
        {
            get => _items;
            set => this.SetProperty(ref _items, value);
        }

        public MainViewModel()
        {
            Items = new List<SectionItem> 
            { 
                new SectionItem { Title = "Montreal" }, 
                new SectionItem { Title = "Quebec City" },
                new SectionItem { Title = "Rosemont" },
                new SectionItem { Title = "Boucherville" },
                new SectionItem { Title = "Laval" }
            };
        }
    }

    public class SectionItem
    {
        public string Title { get; set; }
    }
}
