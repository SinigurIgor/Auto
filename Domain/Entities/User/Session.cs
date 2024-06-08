using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.User
{
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Session { get; set; }
        [Required]
        [ForeignKey("Users")]
        public int ID_User { get; set; }
        [Required]
        public string SessionToken { get; set; }
        [Required]
        public DateTime ExpiryDateTime { get; set; }
        public virtual URegister Users { get; set; }
        public Session() { }
    }
}
