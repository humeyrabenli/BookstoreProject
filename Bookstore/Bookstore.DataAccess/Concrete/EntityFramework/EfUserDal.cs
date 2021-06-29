using Bookstore.Core.DataAccess;
using Bookstore.Core.Entities.Concrete;
using Bookstore.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, BookstoreContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new BookstoreContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
