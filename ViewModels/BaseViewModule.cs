using CommunityToolkit.Mvvm.ComponentModel;

namespace NWC.ViewModels
{
    public partial class BaseViewModule : ObservableObject
    {
        [ObservableProperty]
        public bool _isBusy;
        [ObservableProperty]
        public string _title;
    }
}
