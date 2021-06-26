using Bookstore.Core.DataAccess;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities;
using Bookstore.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class EfBookDal : EfEntityRepositoryBase<Book, BookstoreContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (BookstoreContext context=new BookstoreContext())
            {
                var result = from b in context.Books
                             join c in context.Categories
                             on b.CategoryId equals c.CategoryId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName

                             };
                return result.ToList();
            }
        }
    }
}
