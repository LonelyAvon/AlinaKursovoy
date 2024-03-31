using MobilBogdanova;
namespace MobilBogdanova
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

		public void ToNext_Clicked(System.Object sender, System.EventArgs e)
        {
			Navigation.PushModalAsync(new SecondPage());
        }
    }
}


