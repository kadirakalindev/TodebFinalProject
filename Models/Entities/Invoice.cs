using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.Models
{
    public partial class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public int ApartmentId { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public virtual ApartmentInfo Apartment { get; set; }
    }
}
