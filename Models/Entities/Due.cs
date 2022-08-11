using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.Models
{
    public partial class Due
    {
        [Key]
        public int DueId { get; set; }
        public int ApartmentId { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public virtual ApartmentInfo Apartment { get; set; }
    }
}
