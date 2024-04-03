
namespace MobilBogdanova;
using Helper;

public partial class ThirdPage : ContentPage
{
    public string info;

	public ThirdPage()
    { 
		InitializeComponent();
	}
    public void ActiveSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var value = (sender as Slider).Value;
		if(value<2)
		{
			SliderText.Text = "Минимальная нагрузка";
            Helper.user.Activity = 1;
		}
		if (value >= 2 && value<4)
		{
			SliderText.Text = "Легкая физическая нагрузка в течении дня";
            Helper.user.Activity = 2;

        }
        if (value>=4 && value<6)
		{
			SliderText.Text = "Тренировки 2-4 раза в неделю (или работа средней тяжести)";
            Helper.user.Activity = 3;

        }
        if (value >= 6 && value < 8)
        {
			SliderText.Text = "Интенсивные тренировки 4-5 раз в неделю";
            Helper.user.Activity = 4;

        }
        if (value >= 8)
        {
			SliderText.Text = "Ежедневные интенсивные тренировки";
            Helper.user.Activity = 5;

        }
    }
    void Sustentaion_Clicked(object sender, EventArgs args)
    {
            
        Sustentaion.BackgroundColor = new Color(187, 204, 204);
        Set.BackgroundColor = new Color(217, 217, 217);
        Slim.BackgroundColor = new Color(217, 217, 217);
        Helper.user.Purpose = 1;
    }
    void Slim_Clicked(object sender, EventArgs args)
    {
        Slim.BackgroundColor = new Color(187, 204, 204);
        Sustentaion.BackgroundColor = new Color(217, 217, 217);
        Set.BackgroundColor = new Color(217, 217, 217);
        Helper.user.Purpose = 2;

    }
    void Set_Clicked(object sender, EventArgs args)
    {
        Set.BackgroundColor = new Color(187, 204, 204);
        Sustentaion.BackgroundColor = new Color(217, 217, 217);
        Slim.BackgroundColor = new Color(217, 217, 217);
        Helper.user.Purpose = 3;

    }

    async void ToNext_Clicked(System.Object sender, System.EventArgs e)
    {
        var context = Helper.GetContext();
        context.Users.Add(Helper.user);
        context.SaveChanges();
        await Navigation.PushModalAsync(new Main());
    }
}
