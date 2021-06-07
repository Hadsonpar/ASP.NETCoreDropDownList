using ASP.NETCoreDropDownList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreDropDownList.Controllers
{
    public class HomeController : Controller
    {
        private readonly DBContext _dBContext;
        public HomeController(DBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public IActionResult Index()
        {
            List<lmsAdminProfession> adminProfessionsList = new List<lmsAdminProfession>();

            adminProfessionsList = (from lmsAdminProfession in _dBContext.lmsAdminProfession
                                    select lmsAdminProfession).ToList();

            adminProfessionsList.Insert(0, new lmsAdminProfession 
                                        { ID_PROFESSION = 0, NAME_PROFESSION = "Seleccionar"});

            ViewBag.ListAdminProfessions = adminProfessionsList;
            return View();
        }
    }
}
