using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbacusAcademy.Entities
{
    public class Users
    {
        
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; } 
        public string Mobile { get; set; }
        [JsonIgnore]
        public virtual Student Student { get; set; }

    }

}
