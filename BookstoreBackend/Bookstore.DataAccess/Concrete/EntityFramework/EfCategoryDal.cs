using Bookstore.Core.DataAccess;
using Bookstore.DataAccess.Abstract;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,BookstoreContext>,ICategoryDal
    {

    }
}
