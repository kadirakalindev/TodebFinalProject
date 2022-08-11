using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            ApartmentInfos = new HashSet<ApartmentInfo>();
            Messages = new HashSet<Message>();
        }
        [Key]
        public int UserId { get; set; }
        public string NameSurname { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CarInfo { get; set; }



        public  ICollection<ApartmentInfo> ApartmentInfos { get; set; }
        public  ICollection<Message> Messages { get; set; }
    }
}
