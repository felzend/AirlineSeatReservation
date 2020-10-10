using System.ComponentModel;
using Xamarin.Forms;
using AirlineSeatReservation.ViewModels;

namespace AirlineSeatReservation.Views
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