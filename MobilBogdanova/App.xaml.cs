namespace MobilBogdanova;
using Helper;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		if(!Preferences.ContainsKey("guid"))
		{
			string id = Guid.NewGuid().ToString();
			Preferences.Set("guid", id);
            Helper.guid = Preferences.Get("guid", "error");
			Helper.user.Uuid = id;
            MainPage = new NavigationPage(new MainPage());

        }
        else
		{
			Helper.guid = Preferences.Get("guid", "error");
			MainPage = new NavigationPage(new Main());
        }


	}
}

