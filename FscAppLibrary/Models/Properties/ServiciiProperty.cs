namespace FscAppLibrary.Models.Properties
{
    public class ServiciiProperty
    {   
        public List<string> servicii = new()
        {
            "Simulator Pistol",
            "Simulator Vanatoare",
        };

        public List<string> persoane = new()
        {
             "Un tragator",
             "Doi tragatori",
             "Trei tragatori",
             "Patru tragatori"
        };

        public List<string> timp = new()
        {
             "30 de minute",
             "60 de minute",
             "90 de minute",
             "120 de minute"
        };

        public List<string> stele = new()
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
        };

        public List<TimeOnly> ore = new()
        {


        };

        public DateTime MinDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime MaxDate { get; set; } = DateTime.Now.AddMonths(1);
        public DateTime MinTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00);
        public DateTime MaxTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 00, 00);

    }
}
