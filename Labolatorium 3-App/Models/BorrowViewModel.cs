using Microsoft.AspNetCore.Mvc.Rendering;

namespace Labolatorium_3_App.Models
{
    public class BorrowViewModel
    {
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }

        public IEnumerable<SelectListItem> Books { get; set; }
    }
}
