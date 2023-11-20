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
        public string Page_no { get; set; }

        [MaxLength(20)] // Ustaw maksymalną długość dla ISBN
        public string ISBN { get; set; }

        public DateTime? PublicationDate { get; set; }

        public string PublishingHouse { get; set; }

        public int Priority { get; set; }
    }
}
