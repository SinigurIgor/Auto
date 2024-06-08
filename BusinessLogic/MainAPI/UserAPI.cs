using Domain.Entities.Responces;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.MainAPI
{
    public class UserAPI
    {
        internal BaseResponces CheckUserCredential(UserLoginData data)
        {


            return new BaseResponces { Status = false };
        }
    }
}
