using Data.Entities;
using Data;

namespace Labolatorium_3_App.Models
{
    public class EFBorrowService : IBorrowService
    {
        private readonly AppDbContext _context;

        public EFBorrowService(AppDbContext context)
        {
            _context = context;
        }

        public void BorrowBook(int bookId, string userId)
        {
            var borrow = new BorrowEntity
            {
                BookId = bookId,
                UserId = userId,
                BorrowDate = DateTime.Now
            };
            _context.Borrows.Add(borrow);
            _context.SaveChanges();
        }

        public IEnumerable<BorrowEntity> GetUserBorrows(string userId)
        {
            return _context.Borrows.Where(b => b.UserId == userId).ToList();

        }
    }
}
