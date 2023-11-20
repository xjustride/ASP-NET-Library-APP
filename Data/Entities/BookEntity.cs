using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("books")]
    public class BookEntity
    {
        [Key]
        [Column("id")]
        public int BookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Page_No { get; set; }

        [Required]
        [MinLength(13)]
        [MaxLength(13)] // Ustaw maksymalną długość dla ISBN
        public string ISBN { get; set; }

        public DateTime? PublicationDate { get; set; }
        [Required]
        public string PublishingHouse { get; set; }
        [Required]
        public int Priority { get; set; }
    }
}
