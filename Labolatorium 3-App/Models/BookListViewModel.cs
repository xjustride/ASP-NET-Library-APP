using Labolatorium_3_App.Models; 
namespace Labolatorium_3_App.Models
{
    public class BookListViewModel
    {
        public List<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }

    public class PageInfo
    {
        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
    }
}
