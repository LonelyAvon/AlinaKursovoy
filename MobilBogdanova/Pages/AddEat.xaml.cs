using Helper;

namespace MobilBogdanova;
public partial class AddEat : ContentPage
{
    public int _meal;
	public AddEat(int meal)
	{
		InitializeComponent();
        _meal = meal;
	}
    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

   async void AddEatButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if (ProductNameTextBox.Text == string.Empty)
        {
            await DisplayAlert("Error", "Заполните поле Название продукта", "Ok");
            return;
        }
        if (WeightProductTextBox.Text == string.Empty)
        {
            await DisplayAlert("Error", "Заполните поле Размер порции", "Ok");
            return;
        }
        if (!int.TryParse(WeightProductTextBox.Text,out int ProductTotalWeight))
        {
            await DisplayAlert("Error", "В поле Размер порции должно быть число", "Ok");
            return;
        }

        if (!int.TryParse(CcalTextBox.Text, out int CcalToWeight))
        {
            await DisplayAlert("Error", "В поле Калорийности должно быть число", "Ok");
            return;
        }
        if (!int.TryParse(CarbohydratesTextBox.Text, out int CarbohydratesToWeight))
        {
            await DisplayAlert("Error", "В поле Углеводы должно быть число", "Ok");
            return;
        }
        if (!int.TryParse(FatsTextBox.Text, out int FatsToWeight))
        {
            await DisplayAlert("Error", "В поле Жиры должно быть число", "Ok");
            return;
        }
        if (!int.TryParse(ProteinsTextBox.Text, out int ProteinsToWeight))
        {
            await DisplayAlert("Error", "В поле Белки должно быть число", "Ok");
            return;
        }

        Helper.DiaryeatContext db = Helper.Helper.GetContext();
        var day = db.Days.Where(_day => _day.Datenow == Helper.Helper.CurrentDate && _day.Uuid == Helper.Helper.guid).FirstOrDefault();

        Helper.Eat eat = new Helper.Eat
        {
            IdMeal = _meal,
            Uuid = Helper.Helper.guid,
            IdDay = day.Id,
            Name = ProductNameTextBox.Text,
            Weight = ProductTotalWeight,
            Ccal = ProductTotalWeight / 100 * CcalToWeight,
            Fats = ProductTotalWeight / 100 * FatsToWeight,
            Proteins = ProductTotalWeight / 100 * ProteinsToWeight,
            Carbohydrates = ProductTotalWeight / 100 * CarbohydratesToWeight,
        };

        day.Ccaleat += eat.Ccal;
        day.Carbohydrateseat += eat.Carbohydrates;
        day.Fatseat += eat.Fats;
        day.Proteinseat += eat.Proteins;

        db.Eats.Add(eat);
        db.SaveChanges();
        await Navigation.PopModalAsync();
    }
}
