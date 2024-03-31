
namespace MobilBogdanova;

public partial class ThirdPage : ContentPage
{
	public int k = 0;

	public ThirdPage()
	{
		InitializeComponent();
	}
    void ActiveSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var value = (sender as Slider).Value;
		if(value<2)
		{
			SliderText.Text = "Минимальная нагрузка";
		}
		if (value >= 2 && value<4)
		{
			SliderText.Text = "Легкая физическая нагрузка в течении дня";
        }
		if(value>=4 && value<6)
		{
			SliderText.Text = "Тренировки 2-4 раза в неделю (или работа средней тяжести)";
        }
        if (value >= 6 && value < 8)
        {
			SliderText.Text = "Интенсивные тренировки 4-5 раз в неделю";
        }
        if (value >= 8)
        {
			SliderText.Text = "Ежедневные интенсивные тренировки";
        }
    }
     void Sustentaion_Clicked(object sender, EventArgs args)
    {
        if (Slim.IsEnabled)
        {
            Slim.IsEnabled = false;
            Set.IsEnabled = false;
            Sustentaion.BackgroundColor = new Color(187, 204, 204);
        }
        else
        {
            Slim.IsEnabled = true;
            Set.IsEnabled = true;
            Sustentaion.BackgroundColor = new Color(217, 217, 217);
        }
       
    }
     void Slim_Clicked(object sender, EventArgs args)
    {
        if (Sustentaion.IsEnabled)
        {
            Sustentaion.IsEnabled = false;
            Set.IsEnabled = false;
            Slim.BackgroundColor = new Color(187, 204, 204);
        }
        else
        {
            Sustentaion.IsEnabled = true;
            Set.IsEnabled = true;
            Slim.BackgroundColor = new Color(217, 217, 217);
        }
    }
    void Set_Clicked(object sender, EventArgs args)
    {
        if (Sustentaion.IsEnabled)
        {
            Sustentaion.IsEnabled = false;
            Slim.IsEnabled = false;
            Set.BackgroundColor = new Color(187, 204, 204);
        }
        else
        {
            Sustentaion.IsEnabled = true;
            Slim.IsEnabled = true;
            Set.BackgroundColor = new Color(217, 217, 217);
        }
    }
}
