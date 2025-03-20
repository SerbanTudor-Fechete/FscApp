namespace FscAppLibrary.Models
{
    public class FormularDeContactModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un nume!")]
        [MaxLength(50, ErrorMessage = "Vă rog să nu folosoți mai mult de 50 de caractere!")]
        [Column(TypeName = "varchar(50)")]
        public string FormularName { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți o adresă de email!")]
        [EmailAddress(ErrorMessage = "Vă rog să folosiți o adresă de email validă!")]
        public string FormularEmail { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un număr de telefon!")]
        [Phone(ErrorMessage = "Vă rog să folosiți un număr de telefon valid!")]
        public string FormularPhone { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un mesaj!")]
        [MaxLength(2000, ErrorMessage = "Vă rog să nu folosiți mai mult de 2000 de caractere!")]
        [Column(TypeName = "varchar(2000)")]
        public string FormularDescription { get; set; }

    }
}
