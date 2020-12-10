using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AiView
{
    public partial class Settings : ContentView
    {
        public Settings()
        {
            InitializeComponent();
        }

        public IList<SectionItem> Items 
        {
            get => (IList<SectionItem>)this.GetValue(ItemsProperty);
            set => this.SetValue(ItemsProperty, value);
        }

        public static BindableProperty ItemsProperty = BindableProperty.Create(nameof(Items),
            typeof(IList<SectionItem>), typeof(Settings), null);

            
    }
}