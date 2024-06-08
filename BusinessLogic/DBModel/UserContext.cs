﻿using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=AutoHub") { }

        public virtual DbSet<UserDTO> USers { get; set; }
    }
}
