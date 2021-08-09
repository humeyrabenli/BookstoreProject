using Bookstore.Core.DataAccess;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Abstract
{
    public interface IPublisherDal:IEntityRepository<Publisher>
    {
    }
}
