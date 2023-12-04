using Data;
using Data.Entities;


namespace Labolatorium_3_App.Models
{
    public class EFBookService : IBookService
    {
        private readonly AppDbContext _context;
        public EFBookService(AppDbContext context)
        {
            _context = context;
        }



        public int Add(Book book)
        {
            var e = _context.Books.Add(BookMapper.ToEntity(book));
            _context.SaveChanges();
            int id = e.Entity.Id;

            return id;
        }

        public void Delete(int id)
        {
            BookEntity? find = _context.Books.Find(id);
            if (find != null)
            {
                _context.Books.Remove(find);
                _context.SaveChanges();
            }
        }

        public List<Book> FindAll()
        {
            return _context.Books.Select(e => BookMapper.FromEntity(e)).ToList();
        }

        public List<LibraryEntity> FindAllOrganizations()
        {
            return _context.Libraries.ToList();
        }

        public Book? FindById(int id)
        {
            BookEntity? find = _context.Books.Find(id);

            return find != null ? BookMapper.FromEntity(find) : null;


        }

        public void Update(Book book)
        {
            var existingEntity = _context.Books.Find(book.id);

            if (existingEntity != null)
            {
                var updatedEntity = BookMapper.ToEntity(book);

                _context.Entry(existingEntity).CurrentValues.SetValues(updatedEntity);

                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException("Book not found");
            }
        }

    }
}