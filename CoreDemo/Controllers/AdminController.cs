using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        StockManager sm = new StockManager(new EfStockRepository());
        WareHouseManager wm = new WareHouseManager(new EfWareHouseRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockList()
        {
            var values = sm.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult StockAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StockAdd(Stock p)
        {
            sm.TAdd(p);
            return View();
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = sm.TGetById(id);
            sm.TDelete(blogvalue);
            return RedirectToAction("StockList");

        }
        [HttpGet]
        public IActionResult StockEdit(int id)
        {
            var stockvalue = sm.TGetById(id);

            List<SelectListItem> values = (from x in sm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.StockName,
                                                       Value = x.StockID.ToString()
                                                   }).ToList();
            ViewBag.cv = values;


            return View(stockvalue);
        }

        [HttpPost]
        public IActionResult StockEdit(Stock p)
        {

            sm.TUpdate(p);
            return RedirectToAction("StockList");
        }

        [HttpGet]
        public IActionResult WareHouseAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WareHouseAdd(WareHouse p)
        {
            wm.TAdd(p);
            return View();
        }
        public IActionResult WareHouseList()
        {
            var values2 = wm.GetList();
            return View(values2);
        }
    }
}
