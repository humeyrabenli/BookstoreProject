﻿using Bookstore.Business.Abstract;
using Bookstore.Business.BusinessAspects.Autofac;
using Bookstore.Business.Constants;
using Bookstore.Business.ValidationRules.FluentValidation;
using Bookstore.Core.Aspects.Autofac.Validation;
using Bookstore.Core.CrossCuttingConcerns.Validation;
using Bookstore.Core.Utilities.Business;
using Bookstore.Core.Utilities.Results;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities;
using Bookstore.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }


        [SecuredOperation("book.add,admin")]
        [ValidationAspect(typeof(BookValidator))]
        public IResult Add(Book book)
        {
            IResult result=BusinessRules.Run(CheckIfBookNameExists(book.BookName));

            if (result!=null)
            {
                return result;
            }

            _bookDal.Add(book);
            return new SuccessResult(Messages.BookAdded);
           
            
        }

     
        public IDataResult<List<Book>> GetAll()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.BooksListed);
        }

        public IDataResult<List<Book>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.CategoryId == id));
        }

        public IDataResult<List<Book>> GetBookByAuthorId(int authorId)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.AuthorId == authorId));
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails()
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails());
        }

        public IDataResult<Book> GetById(int bookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(b => b.BookId == bookId));
        }

        public IDataResult<List<Book>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(b => b.UnitPrice >= min && b.UnitPrice <= max));
        }

       

        public IResult Delete(int bookId)
        {
            throw new NotImplementedException();
        }


        [ValidationAspect(typeof(BookValidator))]
        public IResult Update(Book book)
        {
            throw new NotImplementedException();
        }



        private IResult CheckIfBookNameExists(string bookName)
        {
            var result = _bookDal.GetAll(b => b.BookName == bookName).Any();
            if (result)
            {
                return new ErrorResult(Messages.BookNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
