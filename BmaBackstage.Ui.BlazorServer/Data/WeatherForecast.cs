namespace BmaBackstage.Ui.BlazorServer.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary 
        {
            get
            {
                Domain.Class1 class1 = new();
                Infrastructure.Class2 class2 = new();
                return class1.GetString() + class2.GetString();
            }
            set
            {

            }
        }
    }
}