namespace FscAppLibrary.Models.Properties
{
    public class ServiciiProperty
    {
        public List<string> servicii = new()
        {
            "Simulator Pistol",
            "Simulator Vanatoare",
            "Aniversari"
        };

        public List<int> persoane = new()
        {
            1,
            2,
            3,
            4
        };

        public List<int> timp = new()
        {
            30,
            60,
            90,
            120
        };
        public DateTime MinDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime MaxDate { get; set; } = DateTime.Now.AddMonths(1);
        public DateTime MinTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00);
        public DateTime MaxTime { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 00, 00);

    }
}
