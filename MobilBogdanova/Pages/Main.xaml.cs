namespace MobilBogdanova;
using Helper;

public partial class Main : ContentPage
{
	public string path = "AppIcon/Glasses/";
    public double water = 0.25;
    public double zif = 0.1;

    public User _user { get; set; }
    
	public Main()
	{
		InitializeComponent();
        
	}

    void Glass1_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water*1}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path+"Emptyglass.png";
        Glass3.Source = path + "Emptyglass.png";
        Glass4.Source = path + "Emptyglass.png";
        Glass5.Source = path + "Emptyglass.png";
        Glass6.Source = path + "Emptyglass.png";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";

    }

    void Glass2_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 2}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Emptyglass.png";
        Glass4.Source = path + "Emptyglass.png";
        Glass5.Source = path + "Emptyglass.png";
        Glass6.Source = path + "Emptyglass.png";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass3_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 3}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Emptyglass.png";
        Glass5.Source = path + "Emptyglass.png";
        Glass6.Source = path + "Emptyglass.png";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass4_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 4}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Emptyglass.png";
        Glass6.Source = path + "Emptyglass.png";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass5_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 5}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Emptyglass.png";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass6_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 6}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Emptyglass.png";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass7_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 7}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Emptyglass.png";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass8_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 8}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Fullglass.PNG";
        Glass9.Source = path + "Emptyglass.png";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass9_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 9}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Fullglass.PNG";
        Glass9.Source = path + "Fullglass.PNG";
        Glass10.Source = path + "Emptyglass.png";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass10_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 10}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Fullglass.PNG";
        Glass9.Source = path + "Fullglass.PNG";
        Glass10.Source = path + "Fullglass.PNG";
        Glass11.Source = path + "Emptyglass.png";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass11_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 11}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Fullglass.PNG";
        Glass9.Source = path + "Fullglass.PNG";
        Glass10.Source = path + "Fullglass.PNG";
        Glass11.Source = path + "Fullglass.PNG";
        Glass12.Source = path + "Emptyglass.png";
    }

    void Glass12_Clicked(System.Object sender, System.EventArgs e)
    {
        ResultWater.Text = $"{water * 12}";
        Glass1.Source = path + "Fullglass.PNG";
        Glass2.Source = path + "Fullglass.PNG";
        Glass3.Source = path + "Fullglass.PNG";
        Glass4.Source = path + "Fullglass.PNG";
        Glass5.Source = path + "Fullglass.PNG";
        Glass6.Source = path + "Fullglass.PNG";
        Glass7.Source = path + "Fullglass.PNG";
        Glass8.Source = path + "Fullglass.PNG";
        Glass9.Source = path + "Fullglass.PNG";
        Glass10.Source = path + "Fullglass.PNG";
        Glass11.Source = path + "Fullglass.PNG";
        Glass12.Source = path + "Fullglass.PNG";
    }

    void PlusWeightButton_Clicked(System.Object sender, System.EventArgs e)
    {
        double res = double.Parse(WeightLabel.Text) + 0.1;
        string result = string.Format("{0:#.#}", res);
        WeightLabel.Text = result;
    }

    void MinusWeightButton_Clicked(System.Object sender, System.EventArgs e)
    {
        double res = double.Parse(WeightLabel.Text) - 0.1;
        string result = string.Format("{0:#.#}", res);
        WeightLabel.Text = result;
    }


    async void ToEat_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Eat());
    }

    void ToSettings_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    async void ContentPage_Loaded(System.Object sender, System.EventArgs e)
    {
        Allccal();
        AddDay();
    }
    public void Allccal()
    {
        _user = Helper.GetContext().Users.Where(user => user.Uuid == Helper.guid).FirstOrDefault();

        double activityK = 1.5;

        switch (_user.Activity)
        {
            case 1:
                activityK = 1.2;
                break;
            case 2:
                activityK = 1.375;
                break;
            case 3:
                activityK = 1.55;
                break;
            case 4:
                activityK = 1.7;
                break;
            case 5:
                activityK = 1.9;
                break;
        } //коэффициент активности

        int purposeK = 0;

        switch (_user.Purpose)
        {
            case 1:
                purposeK = 0;
                break;
            case 2:
                purposeK = -200;
                break;
            case 3:
                purposeK = 200;
                break;
        } //коэффициент цели

        int genderK = 0;

        switch (_user.Gender)
        {
            case 1:
                genderK = 5;
                break;
            case 2:
                genderK = -161;
                break;
        } //коэффициент пола

        int age = DateOnly.FromDateTime(DateTime.Now).Year - _user.Birthday.Value.Year;

        double resultccal = Convert.ToDouble(((10 * _user.Weight) + (6.25 * _user.Height) - (5 * age)) * activityK + purposeK + genderK);


        ResultCcal.Text = Convert.ToInt32(resultccal).ToString();

        int eaten = Convert.ToInt32(EatLabel.Text);
        AllCcalProgressBar.Progress = eaten / resultccal;
        StayLabel.Text = (Convert.ToInt32(resultccal) - eaten).ToString();

        WeightLabel.Text = _user.Weight.ToString();
    }

    public void AddDay()
    {
        var context = Helper.GetContext();

        var thisday = DateOnly.FromDateTime(DayDatePicker.Date);

        var searchday = context.Days.Where(day => day.Datenow == thisday && day.Uuid == Helper.guid).FirstOrDefault();

        int ccal = Convert.ToInt32(ResultCcal.Text);

        int proteins = Convert.ToInt32(ccal * 0.3) / 4;
        int fats = Convert.ToInt32(ccal * 0.3) / 9;
        int carbohydrates = Convert.ToInt32(ccal * 0.4) / 4;

        
        EndCarbohydratesLabel.Text = proteins.ToString();
        EndFatsLabel.Text = fats.ToString();
        EndProteinsLabel.Text = proteins.ToString();

        if (searchday == null)
        {
            Day newday = new Day
            {
                Uuid = Helper.guid,
                Datenow = thisday,
                Ccal = ccal,
                Proteins = proteins,
                Fats = fats,
                Carbohydrates = carbohydrates,
            };
            context.Days.Add(newday);
            context.SaveChanges();
        }
       
    }

    protected override async void OnAppearing()
    {
       
        base.OnAppearing();

      //здесь писать код после возвращения с других страниц
    }

    async void DayDatePicker_DateSelected(System.Object sender, Microsoft.Maui.Controls.DateChangedEventArgs e)
    {
        Allccal();
        AddDay();
    }
}
