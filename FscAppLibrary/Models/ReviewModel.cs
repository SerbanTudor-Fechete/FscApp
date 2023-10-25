namespace FscAppLibrary.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti un nume")]
        [MaxLength(50, ErrorMessage = "Va rog sa nu folosoti mai mult de 50 de caractere")]
        [Column(TypeName = "varchar(50)")]
        public string ReviewName { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti o descriere")]
        [MaxLength(2000, ErrorMessage = "Va rog sa nu folositi mai mult de 2000 de caractere")]
        [Column(TypeName = "varchar(2000)")]
        public string ReviewDescription { get; set; }

        public DateTime ReviewDateTime { get; set; } = DateTime.Now;

        public double ReviewRate { get; set; }


        public int ReviewComents { get; set; }

        public ComentariuModel Comentariu { get; set; }
    }
}
