using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.User
{
   public  class CreateUserRequest
    {
        
        public string NameSurname { get; set; }
        
        public string IdentityNumber { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
       
        public string CarInfo { get; set; }
    }
}
