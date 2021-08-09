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
    public class PublisherManager : IPublisherService
    {
        IPublisherDal _publisherDal;

        public PublisherManager(IPublisherDal publisherDal)
        {
            _publisherDal = publisherDal;
        }


        [SecuredOperation("publisher.add,admin")]
        public IResult Add(Publisher publisher)
        {
            _publisherDal.Add(publisher);
            return new SuccessResult(Messages.PublisherAdded);
        }


        [SecuredOperation("publisher.delete,admin")]
        public IResult Delete(Publisher publisher)
        {
            _publisherDal.Delete(publisher);
            return new SuccessResult(Messages.PublisherDeleted);
        }

        public IDataResult<List<Publisher>> GetAll()
        {
            return new SuccessDataResult<List<Publisher>>(_publisherDal.GetAll(), Messages.PublishersListed);
        }

        public IDataResult<Publisher> GetById(int publisherId)
        {
            return new SuccessDataResult<Publisher>(_publisherDal.Get(p => p.PublisherId == publisherId));
        }


        [SecuredOperation("publisher.update,admin")]
        public IResult Update(Publisher publisher)
        {
            _publisherDal.Update(publisher);
            return new SuccessResult(Messages.PublisherUpdated);
        }

    
    }
}
