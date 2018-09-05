using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyExpenditures.Models
{
    public class ExpenditureRequest
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string PurchasedItem { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string MonthOfPurchase { get; set; }

        [Required]
        public int YearOfPurchase { get; set; }
    }
}
