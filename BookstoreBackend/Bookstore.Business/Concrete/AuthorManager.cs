using Bookstore.Business.Abstract;
using Bookstore.Business.BusinessAspects.Autofac;
using Bookstore.Business.Constants;
using Bookstore.Core.Utilities.Results;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }


        [SecuredOperation("author.add,admin")]
        public IResult Add(Author author)
        {
            _authorDal.Add(author);
            return new SuccessResult(Messages.AuthorAdded);
        }


        [SecuredOperation("author.delete,admin")]
        public IResult Delete(Author author)
        {
            _authorDal.Delete(author);
            return new SuccessResult(Messages.AuthorDeleted);
        }

        public IDataResult<List<Author>> GetAll()
        {
            return new SuccessDataResult<List<Author>>(_authorDal.GetAll(), Messages.AuthorsListed);
        }

        public IDataResult<Author> GetById(int authorid)
        {
            return new SuccessDataResult<Author>(_authorDal.Get(a => a.AuthorId == authorid));
        }

        [SecuredOperation("author.update,admin")]
        public IResult Update(Author author)
        {
            _authorDal.Update(author);
            return new SuccessResult(Messages.AuthorUpdated);
        }

       
    }
}
