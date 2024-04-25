using Domain.Entities.Responces;
using Domain.Entities.User;

namespace BusinessLogic.Interfaces
{
    public interface ISession
    {
        BaseResponces ValidateUserCredentialAction(UserLoginData ulData);
    }
}
 