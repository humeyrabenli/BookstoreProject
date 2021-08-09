using Bookstore.Core.Utilities.Results;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Abstract
{
    public interface IAuthorService
    {
        IDataResult<List<Author>> GetAll();
        IDataResult<Author> GetById(int authorid);

        IResult Add(Author author);
        IResult Update(Author author);
        IResult Delete(Author author);


    }
}
