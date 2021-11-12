using Lect7.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lect7.Views
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