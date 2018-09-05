using Microsoft.EntityFrameworkCore;

namespace MyExpenditures.DbModels
{
    public class ExpenditureDbContext : DbContext
    {
        public ExpenditureDbContext(DbContextOptions<ExpenditureDbContext> options)
            : base(options)
        { }

        public DbSet<Expenditure> Expenditures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expenditure>().HasData(
            new Expenditure()
            {
                Id = 1,
                PurchasedItem = "Samsung S7 Edge",
                Price = 1550.0M,
                Category = "Electronic devices",
                MonthOfPurchase = "June",
                YearOfPurchase = 2018
            },
            new Expenditure()
            {
                Id = 2,
                PurchasedItem = "Xiaomi MI Band 3",
                Price = 168.0M,
                Category = "Electronic devices",
                MonthOfPurchase = "June",
                YearOfPurchase = 2018
            },
            new Expenditure()
            {
                Id = 3,
                PurchasedItem = "Bicycle chain",
                Price = 65.0M,
                Category = "Hobby",
                MonthOfPurchase = "August",
                YearOfPurchase = 2018
            },
            new Expenditure()
            {
                Id = 4,
                PurchasedItem = "Pizza",
                Price = 32.5M,
                Category = "Food",
                MonthOfPurchase = "August",
                YearOfPurchase = 2018
            },
            new Expenditure()
            {
                Id = 5,
                PurchasedItem = "T-shirt",
                Price = 49.0M,
                Category = "Clothes",
                MonthOfPurchase = "August",
                YearOfPurchase = 2018
            },
            new Expenditure()
            {
                Id = 6,
                PurchasedItem = "Petrol",
                Price = 179.8M,
                Category = "Car",
                MonthOfPurchase = "August",
                YearOfPurchase = 2018
            });
        }
    }
}
