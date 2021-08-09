using Bookstore.Core.Utilities.Results;
using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Business.Abstract
{
    public interface IPublisherService
    {
        IDataResult<List<Publisher>> GetAll();
        IDataResult<Publisher> GetById(int publisherId);

        IResult Add(Publisher publisher);
        IResult Update(Publisher publisher);
        IResult Delete(Publisher publisher);
    }
}
