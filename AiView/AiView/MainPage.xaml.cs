using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AiView
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            BindingContext = ViewModel;
            InitializeComponent();
        }
    }
}
