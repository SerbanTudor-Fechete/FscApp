using Microsoft.VisualBasic;

namespace FscAppLibrary.Models
{
    public class ProgramareOnlineModel
    {
        public int Id { get; set; }
        public string ProgramareService { get; set; }
        public int ProgramarePersons { get; set; }
        public DateTime ProgramareDateTime { get; set; }
        public string ProgramareName { get; set; }
        public string ProgramareEmail { get; set; }
        public string ProgramarePhone { get; set; }
        public string ProgramareDescription { get; set; }

    }
}
