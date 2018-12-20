using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebMobileMVC.Helpers;
using WebMobileMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMobileMVC.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            try
            {
                ViewModelBase kiemtra = new ViewModelBase();
                if (kiemtra.khachHang != null)
                {
                    return View(kiemtra.khachHang);
                }
            }
            catch
            {
                return Redirect("https://localhost:5001/account/loginregister");
            }
            return View();
        }

        public IActionResult Review()
        {
            return View(ConstantVariable.dsSanPham);
        }

        public IActionResult Shipping()
        {
            return View();
        }

        public IActionResult Complete()
        {
            return View();
        }
    }
}
