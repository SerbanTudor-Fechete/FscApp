namespace FscAppLibrary.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un nume!")]
        [MaxLength(50, ErrorMessage = "Vă rog să nu folosoți mai mult de 50 de caractere!")]
        [Column(TypeName = "varchar(50)")]
        public string ReviewName { get; set; }

        [Required(ErrorMessage = "Vă rog să introduceți un mesaj!")]
        [MaxLength(2000, ErrorMessage = "Vă rog să nu folosiți mai mult de 2000 de caractere!")]
        [Column(TypeName = "varchar(2000)")]
        public string ReviewDescription { get; set; }

        public DateTime ReviewDateTime { get; set; } = DateTime.Now;

        public double ReviewRate { get; set; }

    }
}
