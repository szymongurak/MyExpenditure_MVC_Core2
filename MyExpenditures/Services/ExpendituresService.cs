using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MyExpenditures.DbModels;
using MyExpenditures.Services;
using NLog;

namespace MyExpenditures.Services
{
    public class ExpendituresService : IExpendituresService
    {
        private readonly ExpenditureDbContext _expenditureDbContext;

        private readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public ExpendituresService(ExpenditureDbContext expenditureDbContext)
        {
            _expenditureDbContext = expenditureDbContext;
        }

        public List<Expenditure> GetAll()
        {
            return _expenditureDbContext.Expenditures.ToList();
        }

        public Expenditure GetById(int idExpediture) =>
            _expenditureDbContext.Expenditures
            .Where(e => e.Id == idExpediture)
            .SingleOrDefault();

        public void AddNewExpenditure(Expenditure expenditure)
        {
            Logger.Warn("Added new expenditure");
            _expenditureDbContext.Expenditures.Add(expenditure);
            _expenditureDbContext.SaveChanges();
        }

        public void UpdateExpenditure(Expenditure expenditure)
        {
            var foundExpediture = GetById(expenditure.Id);
            if(foundExpediture != null)
            {
                foundExpediture.PurchasedItem = expenditure.PurchasedItem;
                foundExpediture.Price = expenditure.Price;
                foundExpediture.Category = expenditure.Category;
                foundExpediture.MonthOfPurchase = expenditure.MonthOfPurchase;
                foundExpediture.YearOfPurchase = expenditure.YearOfPurchase;
                _expenditureDbContext.SaveChanges();
            }
        }

        public void DeleteExpenditure(int idExpediture)
        {
            var foundExpediture = GetById(idExpediture);
            _expenditureDbContext.Expenditures.Remove(foundExpediture);
            _expenditureDbContext.SaveChanges();
        }
    }
}
