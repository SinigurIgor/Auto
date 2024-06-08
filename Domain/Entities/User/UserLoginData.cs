using System;

namespace Domain.Entities.User
{
    public class UserLoginData
    {
        public int Id { get; set; } // Первичный ключ


        //пароль 
        public string Password { get; set; }

        //айпи адрес пользователя
        public string UserIp { get; set; }

        //дата и время последнего входа
        public DateTime LastLogin { get; set; }

        //почта
        public string Email { get; set; }
        //дата авторизации
        public DateTime LoginDateTime { get; set; }
    }
}
