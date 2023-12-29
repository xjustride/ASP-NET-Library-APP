using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Borrows")]
    public class BorrowEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        // Relacje do innych encji
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }

        [ForeignKey("BookId")]
        public virtual BookEntity Book { get; set; }
    }
}
