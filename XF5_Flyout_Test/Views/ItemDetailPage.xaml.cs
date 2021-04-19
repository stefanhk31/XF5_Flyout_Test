using System.ComponentModel;
using Xamarin.Forms;
using XF5_Flyout_Test.ViewModels;

namespace XF5_Flyout_Test.Views
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