using Data.Entities;

namespace Labolatorium_3_App.Models
{
    public interface IBorrowService
    {
        void BorrowBook(int bookId, string userId);
        IEnumerable<BorrowEntity> GetUserBorrows(string userId);
        // Możesz dodać tutaj inne metody potrzebne do zarządzania wypożyczeniami
    }
}
