using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.Models
{
    public partial class Message
    {
        [Key]
        public int MessageId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Text { get; set; }
        public string Status { get; set; }
        public DateTime SendTime { get; set; }

        public  UserInfo User { get; set; }
    }
}
