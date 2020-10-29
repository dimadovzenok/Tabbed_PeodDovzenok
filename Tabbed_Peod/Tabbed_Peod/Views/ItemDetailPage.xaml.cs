using System.ComponentModel;
using Xamarin.Forms;
using Tabbed_Peod.ViewModels;

namespace Tabbed_Peod.Views
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