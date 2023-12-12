using NWC.ViewModels;

namespace NWC.Views;

public partial class UpdateBillPage : ContentPage
{
    private readonly UpdateBillPageViewModel updateBillPageViewModel;

    public UpdateBillPage(UpdateBillPageViewModel updateBillPageViewModel)
    {
        InitializeComponent();
        BindingContext = updateBillPageViewModel;
        this.updateBillPageViewModel = updateBillPageViewModel;
    }

    protected override void OnAppearing()
    {
        updateBillPageViewModel.LoadPeriodsCommand.Execute(this);
    }
}