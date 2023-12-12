namespace NWC.Views;

public partial class SigninPage : ContentPage
{
	public SigninPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SigninPage());
    }
}