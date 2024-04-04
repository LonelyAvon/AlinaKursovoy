namespace MobilBogdanova;

public partial class AddEat : ContentPage
{
	public AddEat()
	{
		InitializeComponent();
	}
    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

   async void AddEatButton_Clicked(System.Object sender, System.EventArgs e)
    {
        if(BrandTextBox.Text == string.Empty)
        {
            await DisplayAlert("Error", "Заполните поле Марка / производитель", "Ok");
            return;
        }
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

        

    }
}
