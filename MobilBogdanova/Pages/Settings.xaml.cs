using Helper;
namespace MobilBogdanova.Pages;

public partial class Settings : ContentPage
{
    List<Gender> _genders = new List<Gender>();
    
	public Settings()
	{
		InitializeComponent();
        var genders = Helper.Helper.GetContext().Genders.ToList();
        _genders = genders;
    }


    protected override void OnAppearing()
    {
        base.OnAppearing();

        var db = Helper.Helper.GetContext();

        var user = db.Users.Where(user => user.Uuid == Helper.Helper.guid).FirstOrDefault();
        var gender = _genders.Where(g => g.Id == user.Gender).FirstOrDefault();
        var activity = db.Activities.Where(ac => ac.Id == user.Activity).FirstOrDefault();
        var purpose = db.Purposes.Where(p => p.Id == user.Purpose).FirstOrDefault();
        GenderTextBox.Text = gender.Name;
        HeightTextBox.Text = user.Height.ToString();
        WeightTextBox.Text = user.Weight.ToString();
        AgeTextBox.Date = DateTime.Parse(user.Birthday.Value.ToString());
        ActivityTextBox.Text = activity.Name;
        PurposeTextBox.Text = purpose.Name;
    }
    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

    async void ToEat_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new EatMenu());
    }

    async void ToDiary_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Main());
    }

    async void UploadButton_Clicked(System.Object sender, System.EventArgs e)
    {
        switch (GenderTextBox.Text)
        {
            case "Мужской":
                Helper.Helper.user.Gender = 1;
                break;
            case "Женский":
                Helper.Helper.user.Gender = 2;
                break;
            default:
                await DisplayAlert("Error", "Нужно ввести Мужской или Женский", "Ok");
                return;
        }
        if (!int.TryParse(HeightTextBox.Text, out int Height))
        {
            await DisplayAlert("Error", "В поле Рост должно быть число", "Ok");
            return;
        }

        if (!int.TryParse(WeightTextBox.Text, out int Weight))
        {
            await DisplayAlert("Error", "В поле Вес должно быть число", "Ok");
            return;
        }


        var db = Helper.Helper.GetContext();

        var user = db.Users.Where(user => user.Uuid == Helper.Helper.guid).FirstOrDefault();
        var gender = _genders.Where(g => g.Name == GenderTextBox.Text).FirstOrDefault();

        user.Birthday = DateOnly.FromDateTime(AgeTextBox.Date);

        user.Height = Height;
        user.Weight = Weight;
        user.Gender = gender.Id;

        db.SaveChanges();

        await DisplayAlert("Luck", "Данные обновлены", "Ok");

    }
}
