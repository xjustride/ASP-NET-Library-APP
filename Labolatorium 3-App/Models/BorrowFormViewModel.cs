namespace Labolatorium_3_App.Models
{
    public class BorrowFormViewModel
    {
        public int BookId { get; set; }
        public int LibraryId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
