using MyExpenditures.Models;
using MyExpenditures.DbModels;
using AutoMapper;

namespace MyExpenditures.Mapping
{
    public class ExpenditureMappingProfile : Profile
    {
        public ExpenditureMappingProfile()
        {
            CreateMap<ExpenditureRequest, Expenditure>();
            CreateMap<Expenditure, ExpenditureResponse>();
        }
    }
}
