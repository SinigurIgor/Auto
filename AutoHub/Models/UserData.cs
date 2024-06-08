using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoHub.Models
{
    public class UserData
    {
        public List<string> Products { get; internal set; }
        public string Username { get; internal set; }
    }
}