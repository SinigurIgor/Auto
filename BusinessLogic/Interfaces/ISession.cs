using Domain.Entities.Responces;
using Domain.Entities.User;

namespace BusinessLogic.Interfaces
{
    public interface ISession
    {
        object GetUserByCookie(string value);
        BaseResponces ValidateUserCredentialAction(UserLoginData ulData);
    }
}
