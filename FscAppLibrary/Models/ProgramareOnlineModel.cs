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

        [Required(ErrorMessage = "Vă rog să introduceți un nume!")]
        [MaxLength(50, ErrorMessage = "Vă rog să nu folosoți mai mult de 50 de caractere!")]
        [Column(TypeName = "varchar(50)")]
        public string ProgramareName { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți o adresă de email!")]
        [EmailAddress(ErrorMessage = "Vă rog să folosiți o adresă de email validă!")]
        public string ProgramareEmail { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un număr de telefon!")]
        [Phone(ErrorMessage = "Vă rog să folosiți un număr de telefon valid!")]
        public string ProgramarePhone { get; set; }

        [MaxLength(2000, ErrorMessage = "Vă rog să nu folosiți mai mult de 2000 de caractere!")]
        [Column(TypeName = "varchar(2000)")]
        public string ProgramareDescription { get; set; }

    }
}
