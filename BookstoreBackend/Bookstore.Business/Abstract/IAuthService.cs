using Bookstore.Core.Entities.Concrete;
using Bookstore.Core.Utilities.Results;
using Bookstore.Core.Utilities.Security.JWT;
using Bookstore.Entities.DTOs;

namespace Bookstore.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);


    }
}
