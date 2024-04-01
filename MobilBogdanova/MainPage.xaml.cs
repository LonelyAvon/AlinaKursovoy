using MobilBogdanova;
namespace MobilBogdanova
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		public async void ToNext_Clicked(System.Object sender, System.EventArgs e)
        {
			await Navigation.PushModalAsync(new SecondPage());
        }
    }
}


