using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.Models
{
    public partial class ApartmentInfo
    {
        public ApartmentInfo()
        {
            Dues = new HashSet<Due>();
            Invoices = new HashSet<Invoice>();
        }
        [Key]
        public int ApartmentId { get; set; }
        public int UserId { get; set; }
        public string Block { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string Owner { get; set; }

        public virtual UserInfo User { get; set; }
        public virtual ICollection<Due> Dues { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
