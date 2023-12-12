using CommunityToolkit.Mvvm.ComponentModel;

namespace NWC.ViewModels
{
    public partial class BillBaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title;
    }
}
