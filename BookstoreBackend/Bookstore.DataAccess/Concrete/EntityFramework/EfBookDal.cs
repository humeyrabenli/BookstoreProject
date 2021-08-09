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
                             join p in context.Publishers
                             on b.PublisherId equals p.PublisherId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName=c.CategoryName,
                                 PublisherName = p.PublisherName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName,
                                 UnitPrice=b.UnitPrice,
                                 ImageName=b.ImageName,
                                 Description=b.Description,
                                 Cover=b.Cover,
                                 PublicationDate=b.PublicationDate,
                                 NumberOfPage=b.NumberOfPage
                                 

                             };
                return result.ToList();
            }
            
            
        }

        public List<BookDetailDto> GetBooksByAuthorName(string authorname)
        {
            using (BookstoreContext context = new BookstoreContext())
            {
                var result = from b in context.Books
                             join p in context.Publishers
                             on b.PublisherId equals p.PublisherId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 PublisherName = p.PublisherName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName,
                                 UnitPrice = b.UnitPrice,
                                 ImageName = b.ImageName,
                                 Description = b.Description,
                                 Cover = b.Cover,
                                 PublicationDate = b.PublicationDate,
                                 NumberOfPage = b.NumberOfPage


                             };
                return result.Where(x => x.AuthorName.Contains(authorname) || x.AuthorLastName.Contains(authorname)).ToList();
            }
        }

        public List<BookDetailDto> GetBooksByCategoryName(string categoryname)
        {
            using (BookstoreContext context = new BookstoreContext())
            {
                var result = from b in context.Books
                             join p in context.Publishers
                             on b.PublisherId equals p.PublisherId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 PublisherName = p.PublisherName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName,
                                 UnitPrice = b.UnitPrice,
                                 ImageName = b.ImageName,
                                 Description = b.Description,
                                 Cover = b.Cover,
                                 PublicationDate = b.PublicationDate,
                                 NumberOfPage = b.NumberOfPage


                             };
                return result.Where(x => x.CategoryName.Contains(categoryname)).ToList();
            }
        }

        public List<BookDetailDto> GetBooksByName(string bookname)
        {
            using (BookstoreContext context = new BookstoreContext())
            {
                var result = from b in context.Books
                             join p in context.Publishers
                             on b.PublisherId equals p.PublisherId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 PublisherName = p.PublisherName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName,
                                 UnitPrice = b.UnitPrice,
                                 ImageName = b.ImageName,
                                 Description = b.Description,
                                 Cover = b.Cover,
                                 PublicationDate = b.PublicationDate,
                                 NumberOfPage = b.NumberOfPage


                             };
                return result.Where(x => x.BookName.Contains(bookname)).ToList();
            }
        }

        public BookDetailDto GetByBookId(int bookId)
        {
            using (BookstoreContext context = new BookstoreContext())
            {
                var result = from b in context.Books
                             join p in context.Publishers
                             on b.PublisherId equals p.PublisherId
                             join a in context.Authors on b.AuthorId equals a.AuthorId
                             join c in context.Categories on b.CategoryId equals c.CategoryId
                             select new BookDetailDto
                             {
                                 BookId = b.BookId,
                                 BookName = b.BookName,
                                 CategoryName = c.CategoryName,
                                 PublisherName = p.PublisherName,
                                 AuthorName = a.AuthorName,
                                 AuthorLastName = a.AuthorLastName,
                                 UnitPrice = b.UnitPrice,
                                 ImageName = b.ImageName,
                                 Description = b.Description,
                                 Cover = b.Cover,
                                 PublicationDate = b.PublicationDate,
                                 NumberOfPage = b.NumberOfPage


                             };
                return result.FirstOrDefault(x => x.BookId == bookId);
            }
        }


        //public List<BookDetailDto> GetBooksByCategoryName(string categoryname)
        //{
        //    using (BookstoreContext context = new BookstoreContext())
        //    {
        //        var result = from b in context.Books
        //                     join p in context.Publishers
        //                     on b.PublisherId equals p.PublisherId
        //                     join a in context.Authors on b.AuthorId equals a.AuthorId
        //                     select new BookDetailDto
        //                     {
        //                         BookId = b.BookId,
        //                         BookName = b.BookName,
        //                         PublisherName = p.PublisherName,
        //                         AuthorName = a.AuthorName,
        //                         AuthorLastName = a.AuthorLastName,
        //                         UnitPrice = b.UnitPrice,
        //                         ImageName = b.ImageName,
        //                         Description = b.Description,
        //                         Cover = b.Cover,
        //                         PublicationDate = b.PublicationDate,
        //                         NumberOfPage = b.NumberOfPage


        //                     };
        //        return result.Where(x => x..Contains(categoryname)).ToList();
        //    }
        //}
    }
}
