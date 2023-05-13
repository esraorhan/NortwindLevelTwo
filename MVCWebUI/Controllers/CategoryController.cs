using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using MVCWebUI.Models;
using DataAccess.Abstract;

namespace MVCWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryDal  _categoryDal;

        public CategoryController(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IActionResult Index()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryDal.GetList()
            };
            return View(model);
        }
    }
}
