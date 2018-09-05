using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyExpenditures.Services;
using MyExpenditures.Models;
using AutoMapper;
using MyExpenditures.DbModels;

namespace MyExpenditures.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExpendituresService _expendituresService;

        public HomeController(IExpendituresService expendituresService)
        {
            _expendituresService = expendituresService;
        }

        public IActionResult Index()
        {
            var list = _expendituresService.GetAll();
            return View("Index", AutoMapper.Mapper.Map<List<ExpenditureResponse>>(list));
        }

        public ViewResult Create() => View();

        [HttpPost]
        public IActionResult Create (ExpenditureRequest newExpenditure)
        {
            if (ModelState.IsValid)
            {
                _expendituresService.AddNewExpenditure(Mapper.Map<Expenditure>(newExpenditure));
                return RedirectToAction("Index");
            }
            return View(newExpenditure);
        }

        public ViewResult Edit(int id) => 
            View(Mapper.Map<ExpenditureRequest>(_expendituresService.GetById(id)));

        [HttpPost]
        public IActionResult Edit(ExpenditureRequest expediture)
        {
            if (ModelState.IsValid)
            {
                _expendituresService.UpdateExpenditure(Mapper.Map<Expenditure>(expediture));
                return RedirectToAction("Index");
            }
            return View(expediture);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _expendituresService.DeleteExpenditure(id);
            return RedirectToAction("Index");
        }
    }
}
