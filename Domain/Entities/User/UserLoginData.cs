using System;

namespace Domain.Entities.User
{
    public class UserLoginData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string UserIp { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
