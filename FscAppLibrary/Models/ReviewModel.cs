namespace FscAppLibrary.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50")]
        public string ReviewName { get; set; }

        [MaxLength(2000)]
        [Column(TypeName = "varchar(2000")]
        public string ReviewDescription { get; set; }

        public DateTime ReviewDateTime { get; set; } = DateTime.Now;

        public double ReviewRate { get; set; }

        public int ReviewVotes { get; set; }

        public int ReviewComents { get; set; }

        public ComentariuModel Comentariu { get; set; }
    }
}
