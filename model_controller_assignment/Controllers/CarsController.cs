using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cars.Services;
using Cars.Models;


namespace model_controller_assignment.Controllers
{
    public class CarsController : Controller
    {
        private object _CarsItemService;

        public async Car<IActionResult> Index()
        {
            var items = await _CarsItemService.GetIncompleteItemsAsync();
            var model = new CarsModel()
            {
                Items = items
            };
            return View(model);
        }
    }
}