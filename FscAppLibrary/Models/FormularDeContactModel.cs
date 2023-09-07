namespace FscAppLibrary.Models
{
    public class FormularDeContactModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50")]
        public string FormularName { get; set; }
        [Required]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100")]
        public string FormularEmail { get; set; }
        [Required]
        [MaxLength(12)]
        [Column(TypeName = "varchar(12")]
        public string FormularPhone { get; set; }
        [MaxLength(2000)]
        [Column(TypeName = "varchar(2000")]
        public string FormularDescription { get; set; }

    }
}
