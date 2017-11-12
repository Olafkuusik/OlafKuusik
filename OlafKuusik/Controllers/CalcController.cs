using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlafKuusik.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Calc()
        {
            return View();
        }

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Substract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Pick any other number than zero");
                return 0;
            }
            else
            {
                return x / y;
            }
        }
    }
}