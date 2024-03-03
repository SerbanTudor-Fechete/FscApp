namespace FscAppLibrary.Models.Properties
{
    public class ServiciiProperty
    {   
        public List<string> servicii = new()
        {
            "Simulator Pistol",
            "Simulator Vânătoare",
        };

        public List<string> persoane = new()
        {
             "Un trăgător",
             "Doi trăgători",
             "Trei trăgători",
             "Patru trăgători"
        };

        public List<string> timp = new()
        {
             "30 de minute",
             "60 de minute",
             "90 de minute",
             "120 de minute"
        };

        public List<double> stele = new()
        {
            1,
            2,
            3,
            4,
            5,
        };
            

        public DateTime MinDate { get; set; } = DateTime.Now.AddDays(1);
        public DateTime MaxDate { get; set; } = DateTime.Now.AddMonths(1);

    }
}
