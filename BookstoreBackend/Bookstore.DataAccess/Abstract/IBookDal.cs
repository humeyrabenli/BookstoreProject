using Bookstore.Core.DataAccess;
using Bookstore.Entities;
using Bookstore.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Abstract
{
    public interface IBookDal:IEntityRepository<Book>
    {
        List<BookDetailDto> GetBookDetails();
        List<BookDetailDto> GetBooksByName(string bookname);

        List<BookDetailDto> GetBooksByAuthorName(string authorname);

        List<BookDetailDto> GetBooksByCategoryName(string categoryname);

        BookDetailDto GetByBookId(int bookId);


        //List<BookDetailDto> GetBooksByCategoryName(string categoryname);


    }
}
