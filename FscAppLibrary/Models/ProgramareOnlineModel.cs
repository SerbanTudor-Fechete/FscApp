namespace FscAppLibrary.Models
{
    public class ProgramareOnlineModel
    {
        [Key]
        public int Id { get; set; }

        public string ProgramareService { get; set; }

        public string ProgramarePersons { get; set; }

        public string ProgramareTime { get; set; }

        public DateTime ProgramareDateTime { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti un nume")]
        [MaxLength(50, ErrorMessage = "Va rog sa nu folosoti mai mult de 50 de caractere")]
        [Column(TypeName = "varchar(50)")]
        public string ProgramareName { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti o adreasa de email")]
        [EmailAddress(ErrorMessage = "Va rog sa folositi o adresa de email valida")]
        public string ProgramareEmail { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti un numar de telefon")]
        [Phone(ErrorMessage = "Va rog sa folositi un numar de telefon valid")]
        public string ProgramarePhone { get; set; }


        [MaxLength(2000, ErrorMessage = "Va rog sa nu folositi mai mult de 2000 de caractere")]
        [Column(TypeName = "varchar(2000)")]
        public string ProgramareDescription { get; set; }

    }
}
