namespace MobilBogdanova;
using Helper;

public partial class App : Application
{
	public App()
	{
	//Preferences.Clear();
		InitializeComponent();
		Preferences.Clear();
		if(!Preferences.ContainsKey("guid"))
		{
			string id = Guid.NewGuid().ToString();
			Preferences.Set("guid", id);
            Helper.guid = Preferences.Get("guid", "error");
            MainPage = new NavigationPage(new MainPage());

        }
        else
		{
			 Helper.guid=Preferences.Get("guid", "error");
			MainPage = new NavigationPage(new Main());
        }


	}
}

