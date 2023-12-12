using NWC.ViewModels;

namespace NWC.Views;

public partial class BillPage : ContentPage
{
    private readonly BillPageViewModel billPageViewModel;

    public BillPage(BillPageViewModel billPageViewModel)
    {
        InitializeComponent();
        BindingContext = billPageViewModel;
        this.billPageViewModel = billPageViewModel;
    }

    protected override void OnAppearing()
    {
        billPageViewModel.LoadBillsCommand.Execute(this);
    }
}