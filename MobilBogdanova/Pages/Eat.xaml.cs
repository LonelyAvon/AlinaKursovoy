namespace MobilBogdanova;

public partial class Eat : ContentPage
{
    public Eat()
	{
        InitializeComponent();
    }
    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {

        await Navigation.PopModalAsync();
    }
    async void ToDiary_Clicked(System.Object sender, System.EventArgs e)
    {

        await Navigation.PopModalAsync();

    }
    async void BreakfeastAddButton_Clicked(System.Object sender, System.EventArgs e)
    {

        await Navigation.PushModalAsync(new AddEat());

    }
}
