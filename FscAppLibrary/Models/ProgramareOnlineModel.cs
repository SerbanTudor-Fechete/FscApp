using Microsoft.VisualBasic;

namespace FscAppLibrary.Models
{
    public class ProgramareOnlineModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100")]
        public string ProgramareService { get; set; }
        public int ProgramarePersons { get; set; }
        public DateTime ProgramareDateTime { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50")]
        public string ProgramareName { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100")]
        public string ProgramareEmail { get; set; }
        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar(12")]
        public string ProgramarePhone { get; set; }
        [MaxLength(2000)]
        [Column(TypeName = "varchar(2000")]
        public string ProgramareDescription { get; set; }

    }
}
