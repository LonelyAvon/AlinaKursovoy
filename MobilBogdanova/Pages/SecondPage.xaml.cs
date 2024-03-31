namespace MobilBogdanova;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}
    public async void ToNext_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PushModalAsync(new ThirdPage());
    }
}
