using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new Class1());
        }
        [HttpPost]
        public ActionResult Index(Class1 c, string calcular)
        {
            if (calcular == "1")
            {
                c.total = c.n1 + c.n2;

            }
            else if (calcular == "2")
            {
                c.total = c.n1 - c.n2;

            }
            else if (calcular == "3")
            {
                c.total = c.n1 * c.n2;

            }
            else
            {
                c.total = c.n1 / c.n2;

            }
            return View(c);


        }
    }
  }