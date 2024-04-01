
namespace MobilBogdanova;

public partial class ThirdPage : ContentPage
{
    public string info;

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
            
        Sustentaion.BackgroundColor = new Color(187, 204, 204);
        Set.BackgroundColor = new Color(217, 217, 217);
        Slim.BackgroundColor = new Color(217, 217, 217);
        info = Sustentaion.Text;
    }
    void Slim_Clicked(object sender, EventArgs args)
    {
        Slim.BackgroundColor = new Color(187, 204, 204);
        Sustentaion.BackgroundColor = new Color(217, 217, 217);
        Set.BackgroundColor = new Color(217, 217, 217);
        info = Slim.Text;

    }
    void Set_Clicked(object sender, EventArgs args)
    {
        Set.BackgroundColor = new Color(187, 204, 204);
        Sustentaion.BackgroundColor = new Color(217, 217, 217);
        Slim.BackgroundColor = new Color(217, 217, 217);
        info = Set.Text;

    }
}
