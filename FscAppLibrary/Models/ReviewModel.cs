namespace FscAppLibrary.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string ReviewName { get; set; }
        public string ReviewDescription { get; set; }
        public DateTime ReviewDateTime { get; set; } = DateTime.Now;
        public double ReviewRate { get; set; }
        public int ReviewVotes { get; set; }
        public int ReviewComents { get; set; }
        public ComentariuModel Comentariu { get; set; }
    }
}
