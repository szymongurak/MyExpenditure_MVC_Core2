using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MyExpenditures.Models
{
    public class ExpenditureRequest
    {
        public int Id { get; set; }

        public string PurchasedItem { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string MonthOfPurchase { get; set; }

        public int YearOfPurchase { get; set; }
    }
}
