namespace FscAppLibrary.Models
{
    public class ComentariuModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string ComentariuName { get; set; }
        [MaxLength(2000)]
        [Column(TypeName = "varchar(500)")]
        public string ComentariuDescription { get; set; }

        public DateTime ComentariuDateTime { get; set; }

        public int ComentariuVotes { get; set; }
    }
}
