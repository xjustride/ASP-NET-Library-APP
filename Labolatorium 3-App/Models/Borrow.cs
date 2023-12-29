using Microsoft.AspNetCore.Identity;

namespace Labolatorium_3_App.Models
{
    public class Borrow
    {
        public int? Id { get; set; }
        public string? UserId { get; set; }
        public int? BookId { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public virtual Book Book { get; set; }
        // Jeśli używasz Identity, to prawdopodobnie będziesz miał model użytkownika
        public virtual IdentityUser User { get; set; }
    }
}
