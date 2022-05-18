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
                Domain.Entities.EmergencyContact contact = new()
                {
                    Name = "TestDomain"
                };
                Infrastructure.Class2 class2 = new();
                return contact.Name + class2.Name;
            }
            set
            {

            }
        }
    }
}