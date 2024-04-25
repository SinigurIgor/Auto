

using BusinessLogic.Interfaces;
using BusinessLogic.MainAPI;
using Domain.Entities.Responces;
using Domain.Entities.User;

namespace BusinessLogic
{
    public class SessionBL : UserAPI, ISession
    {
        public BaseResponces ValidateUserCredentialAction(UserLoginData ulData)
        {
            return CheckUserCredential(ulData);
        }
    }
}
