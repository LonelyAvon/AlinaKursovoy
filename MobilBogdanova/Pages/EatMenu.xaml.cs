using Helper;
using MobilBogdanova.Pages;
namespace MobilBogdanova;

public partial class EatMenu : ContentPage
{
    public EatMenu()
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
        await Navigation.PushModalAsync(new AddEat(1));

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var db = Helper.Helper.GetContext();

        var selectedDay = db.Days.Where(day => day.Datenow == Helper.Helper.CurrentDate && day.Uuid == Helper.Helper.guid).FirstOrDefault();

        var eats = db.Eats.Where(_eat => _eat.Uuid == Helper.Helper.guid && _eat.IdDay == selectedDay.Id).ToList();

        RefreshBreakfeast(eats);
        RefreshLunch(eats);
        RefreshDinner(eats);
        RefreshSnack(eats);
    }

    public void RefreshBreakfeast(List<Eat> eats)
    {
        var mealEat = eats.Where(eat => eat.IdMeal == 1).ToList();

        BreakfeastView.ItemsSource = mealEat;

        BreakfeastCcal.Text = SumCcal(mealEat).ToString();
    }

    public void RefreshDinner(List<Eat> eats)
    {
        var mealEat = eats.Where(eat => eat.IdMeal == 3).ToList();

        DinnerView.ItemsSource = mealEat;

        DinnerCcal.Text = SumCcal(mealEat).ToString();
    }

    public void RefreshLunch(List<Eat> eats)
    {
        var mealEat = eats.Where(eat => eat.IdMeal == 2).ToList();

        LunchView.ItemsSource = mealEat;

        LunchCcal.Text = SumCcal(mealEat).ToString();
    }

    public void RefreshSnack(List<Eat> eats)
    {
        var mealEat = eats.Where(eat => eat.IdMeal == 4).ToList();

        SnackView.ItemsSource = mealEat;

        SnackCcal.Text = SumCcal(mealEat).ToString();
    }

    void ContentPage_Loaded(System.Object sender, System.EventArgs e)
    {

    }
    public int SumCcal(List<Eat> eats)
    {
        int sum = 0;
        for(int i=0;i<eats.Count;i++)
        {
            sum += Convert.ToInt32(eats[i].Ccal);
        }
        return sum;
    }

    async void SnackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new AddEat(4));
    }

    async void DinnerButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new AddEat(3));
    }

    async void LunchButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new AddEat(2));
    }

    async void ToSettings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Settings());
    }
}
