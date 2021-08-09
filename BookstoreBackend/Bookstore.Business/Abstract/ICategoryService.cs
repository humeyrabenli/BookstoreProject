using Bookstore.Core.Utilities.Results;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);

        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
