using MyExpenditures.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyExpenditures.Services
{
    public interface IExpendituresService
    {
        List<Expenditure> GetAll();
        Expenditure GetById(int idExpediture);
        void AddNewExpenditure(Expenditure expenditure);
        void UpdateExpenditure(Expenditure expenditure);
        void DeleteExpenditure(int idExpediture);

    }
}
