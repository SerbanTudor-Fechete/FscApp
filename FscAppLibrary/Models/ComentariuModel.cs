namespace FscAppLibrary.Models
{
    public class ComentariuModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti un nume")]
        [MaxLength(50, ErrorMessage = "Va rog sa nu folosoti mai mult de 50 de caractere")]
        [Column(TypeName = "varchar(50)")]
        public string ComentariuName { get; set; }

        [Required(ErrorMessage = "Va rog sa introduceti o descriere")]
        [MaxLength(1000, ErrorMessage = "Va rog sa nu folosoti mai mult de 1000 de caractere")]
        [Column(TypeName = "varchar(1000)")]
        public string ComentariuDescription { get; set; }

        public DateTime ComentariuDateTime { get; set; } = DateTime.Now;

        public int ComentariuVotes { get; set; }
    }
}
