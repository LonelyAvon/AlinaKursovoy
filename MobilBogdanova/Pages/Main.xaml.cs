namespace MobilBogdanova;
using Pages;
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
        AddWater(1);
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
        AddWater(2);
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
        AddWater(3);
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
        AddWater(4);
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
        AddWater(5);
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
        AddWater(6);
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
        AddWater(7);
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
        AddWater(8);
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
        AddWater(9);
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
        AddWater(10);
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
        AddWater(11);
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
        AddWater(12);
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

        var db = Helper.GetContext();
        ChangeWeight(double.Parse(result));
    }

    public void ChangeWeight(double weight)
    {
        var db = Helper.GetContext();
        var thisday = DateOnly.FromDateTime(DayDatePicker.Date);
        var finduser = db.Users.Where(user => user.Uuid == Helper.guid).FirstOrDefault();

        var findday = db.Days.Where(day => day.Datenow == thisday && day.Uuid == Helper.guid).FirstOrDefault();
        findday.Weight = weight;
        finduser.Weight = weight;
        db.SaveChanges();
    }

    void MinusWeightButton_Clicked(System.Object sender, System.EventArgs e)
    {
        double res = double.Parse(WeightLabel.Text) - 0.1;
        string result = string.Format("{0:#.#}", res);

        WeightLabel.Text = result;
        ChangeWeight(double.Parse(result));
    }

    async void ToEat_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new EatMenu());
    }

    async void ToSettings_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Settings());
    }

    void ContentPage_Loaded(System.Object sender, System.EventArgs e)
    {
      
    }

    public double Allccal(double weight)
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

        double resultccal = Convert.ToDouble(((10 * weight) + (6.25 * _user.Height) - (5 * age)) * activityK + purposeK + genderK);

        return resultccal;
    }

    public void RefreshCcal()
    {
        var thisdate = DateOnly.FromDateTime(DayDatePicker.Date);

        var day = Helper.GetContext().Days.Where(day => day.Datenow == thisdate && day.Uuid == Helper.guid).FirstOrDefault();

        int resultccal = Convert.ToInt32(day.Ccal);
        ResultCcal.Text = Convert.ToInt32(resultccal).ToString();

        int eaten = Convert.ToInt32(EatLabel.Text);
        AllCcalProgressBar.Progress = eaten / resultccal;
        StayLabel.Text = (Convert.ToInt32(resultccal) - eaten).ToString();
    }

    public void AddDay()
    {
        var context = Helper.GetContext();

        var thisday = DateOnly.FromDateTime(DayDatePicker.Date);

        var searchday = context.Days.Where(day => day.Datenow == thisday && day.Uuid == Helper.guid).FirstOrDefault();
        var user = context.Users.Where(us => us.Uuid == Helper.guid).FirstOrDefault();

        int ccal = Convert.ToInt32(Allccal(Convert.ToDouble(user.Weight)));

        int proteins = Convert.ToInt32(ccal * 0.3) / 4;
        int fats = Convert.ToInt32(ccal * 0.3) / 9;
        int carbohydrates = Convert.ToInt32(ccal * 0.4) / 4;
        double water = double.Parse(ResultWater.Text);

        StayLabel.Text = ccal.ToString();
        EndCarbohydratesLabel.Text = proteins.ToString();
        EndFatsLabel.Text = fats.ToString();
        EndProteinsLabel.Text = proteins.ToString();
        Helper.CurrentDate = DateOnly.FromDateTime(DayDatePicker.Date); 

        if (searchday == null)
        {
            Day newday = new Day
            {
                Uuid = Helper.guid,
                Datenow = thisday,
                Ccal = ccal,
                Water = water,
                Weight = user.Weight,
                Proteins = proteins,
                Fats = fats,
                Carbohydrates = carbohydrates,
                Ccaleat = 0,
                Carbohydrateseat = 0,
                Fatseat = 0,
                Proteinseat = 0,
            };
            WeightLabel.Text = user.Weight.ToString();
            context.Days.Add(newday);
        }
        else
        {
            WeightLabel.Text = searchday.Weight.ToString();
        }

        context.SaveChanges();
    }

    public void RefreshWater()
    {
        var date = DateOnly.FromDateTime(DayDatePicker.Date);
        var db = Helper.GetContext();

        var thisday = db.Days.Where(day => day.Uuid == Helper.guid && day.Datenow == date).FirstOrDefault();

        if (thisday != null)
        {
            switch (thisday.Water / water)
            {

                case 1:
                    Glass1_Clicked(Glass1, new EventArgs());
                    break;
                case 2:
                    Glass2_Clicked(Glass2, new EventArgs());
                    break;
                case 3:
                    Glass3_Clicked(Glass3, new EventArgs());
                    break;
                case 4:
                    Glass4_Clicked(Glass4, new EventArgs());
                    break;
                case 5:
                    Glass5_Clicked(Glass5, new EventArgs());
                    break;
                case 6:
                    Glass6_Clicked(Glass6, new EventArgs());
                    break;
                case 7:
                    Glass7_Clicked(Glass7, new EventArgs());
                    break;
                case 8:
                    Glass8_Clicked(Glass8, new EventArgs());
                    break;
                case 9:
                    Glass9_Clicked(Glass9, new EventArgs());
                    break;
                case 10:
                    Glass10_Clicked(Glass10, new EventArgs());
                    break;
                case 11:
                    Glass11_Clicked(Glass11, new EventArgs());
                    break;
                case 12:
                    Glass12_Clicked(Glass12, new EventArgs());
                    break;
            }
        }
    }
    public void AddWater(int number)
    {
        var db = Helper.GetContext();

        var thisdate = DateOnly.FromDateTime(DayDatePicker.Date);

        var thisday = db.Days.Where(day => day.Datenow == thisdate && day.Uuid == Helper.guid).FirstOrDefault();

        double waterqua = water * number;

        thisday.Water = waterqua;

        db.SaveChanges();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        AddDay();
        RefreshWater();
        RefreshCcal();
        RefreshCcalBar();
        RefreshProteinsBar();
        RefreshCarbohydratesBar();
        RefreshFatsBar();
    }

    public void RefreshCcalBar()
    {
        var date = DateOnly.FromDateTime(DayDatePicker.Date);
        var day = Helper.GetContext().Days.Where(_day => _day.Datenow == date && _day.Uuid == Helper.guid).FirstOrDefault();

        EatLabel.Text = day.Ccaleat.ToString();
        StayLabel.Text = (day.Ccal - day.Ccaleat).ToString();
        AllCcalProgressBar.Progress = Convert.ToDouble(day.Ccaleat) / Convert.ToDouble(day.Ccal);
    }

    public void RefreshProteinsBar()
    {
        var date = DateOnly.FromDateTime(DayDatePicker.Date);
        var day = Helper.GetContext().Days.Where(_day => _day.Datenow == date && _day.Uuid == Helper.guid).FirstOrDefault();

        StartProteinsLabel.Text = day.Proteinseat.ToString();

        ProteinsProgressBar.Progress = Convert.ToDouble(day.Proteinseat) / Convert.ToDouble(day.Proteins);
    }

    public void RefreshCarbohydratesBar()
    {
        var date = DateOnly.FromDateTime(DayDatePicker.Date);
        var day = Helper.GetContext().Days.Where(_day => _day.Datenow == date && _day.Uuid == Helper.guid).FirstOrDefault();

        StartCarbohydratesLabel.Text = day.Carbohydrateseat.ToString();

        CarbohydratesProgressBar.Progress = Convert.ToDouble(day.Carbohydrateseat) / Convert.ToDouble(day.Carbohydrates);
    }

    public void RefreshFatsBar()
    {
        var date = DateOnly.FromDateTime(DayDatePicker.Date);
        var day = Helper.GetContext().Days.Where(_day => _day.Datenow == date && _day.Uuid == Helper.guid).FirstOrDefault();

        StartFatsLabel.Text = day.Fatseat.ToString();

        FatsProgressBar.Progress = Convert.ToDouble(day.Fatseat) / Convert.ToDouble(day.Fats);
    }

    void DayDatePicker_DateSelected(System.Object sender, Microsoft.Maui.Controls.DateChangedEventArgs e)
    {
        AddDay();
        RefreshWater();
        RefreshCcal();
        RefreshCcalBar();
        RefreshProteinsBar();
        RefreshCarbohydratesBar();
        RefreshFatsBar();
    }
}
