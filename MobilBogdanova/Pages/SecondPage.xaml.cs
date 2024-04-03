namespace MobilBogdanova;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
    }
    public async void ToNext_Clicked(System.Object sender, System.EventArgs e)
    {
        if(GenderTextBox.Text == string.Empty)
        {
            await DisplayAlert("Error", "Заполните поле Пол", "Ok");
            return;
        }
        switch(GenderTextBox.Text)
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
        if(HeightTextBox.Text== string.Empty)
        {
            await DisplayAlert("Error", "Заполните поле Рост", "Ok");
            return;
        }
        int height = 150;
        if(!int.TryParse(HeightTextBox.Text,out height))
        {
            await DisplayAlert("Error", "Введите число", "Ok");
            return;
        }
        Helper.Helper.user.Height = height;
        int weight = 150;
        if (!int.TryParse(WeightTextBox.Text, out weight))
        {
            await DisplayAlert("Error", "Введите число", "Ok");
            return;
        }
        Helper.Helper.user.Weight = weight;
        Helper.Helper.user.Birthday =  DateOnly.FromDateTime(BirthdayDatePicker.Date);
        await Navigation.PushModalAsync(new ThirdPage());
    }
}
