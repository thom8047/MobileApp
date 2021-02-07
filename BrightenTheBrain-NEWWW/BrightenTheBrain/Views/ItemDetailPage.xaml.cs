using BrightenTheBrain.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BrightenTheBrain.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}