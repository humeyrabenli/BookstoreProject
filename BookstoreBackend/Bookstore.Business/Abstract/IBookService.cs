using Bookstore.Core.Utilities.Results;
using Bookstore.Entities;
using Bookstore.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Abstract
{
    public interface IBookService
    {
        IDataResult<List<Book>> GetAll();
        IDataResult<List<Book>> GetAllByCategoryId(int id);
        IDataResult<List<Book>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<Book> GetById(int bookId);
        IDataResult<List<Book>> GetBookByAuthorId(int authorId);

        IDataResult<List<BookDetailDto>> GetBookDetails();

        IDataResult<List<BookDetailDto>> GetBooksByName(string name);
        IDataResult<List<BookDetailDto>> GetBooksByAuthorName(string authorname);
        IDataResult<List<BookDetailDto>> GetBooksByCategoryName(string categoryname);

        IDataResult<BookDetailDto> GetByBookId(int bookId);




        IResult Add(Book book);
        IResult Update(Book book);
        IResult Delete(Book book);


    }
}
