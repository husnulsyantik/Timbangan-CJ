using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CJTimbangan.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReflectionIT.Mvc.Paging;
using Microsoft.EntityFrameworkCore;
using PagedList;

namespace CJTimbangan.Controllers
{
   
    public class ReprintController : Controller
    {
        private readonly SettingTimbanganContext db;
        public ReprintController(SettingTimbanganContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            var tes = HttpContext.Request.Query;

            var start_date = tes["start_date"].ToString();
            var end_date = tes["end_date"].ToString();
            var shift = tes["shift"].ToString();
            var product = tes["product"].ToString();
            var qry = db.m_hasil.Select(m => m);
            //.OrderByDescending(p => p.tgl_produksi);
            if (start_date != "")
            {
                DateTime dt = Convert.ToDateTime(start_date);
                qry = qry.Where(p => p.tgl_produksi >= dt);
                ViewBag.start_date = start_date;

            }
            else
            {
                ViewBag.start_date = "";
            }
            if (end_date != "")
            {
                DateTime dt = Convert.ToDateTime(end_date);

                qry = qry.Where(p => p.tgl_produksi <= dt);
                ViewBag.end_date = end_date;
            }
            else
            {
                ViewBag.end_date = "";
            }

            if (shift != "")
            {

                qry = qry.Where(p => p.shift == Convert.ToInt32(shift));
                ViewBag.shift = shift;
            }
            else
            {
                ViewBag.shift = "";
            }
            if (product != "")
            {
                qry = qry.Where(p => p.barang == product);
                ViewBag.product = product;
            }
            else
            {
                ViewBag.product = "";
            }



            //var allUserRoles = db.m_hasil.Select(p => p.lot_no).ToList();
            //qry.OrderByDescending(p => p.tgl_produksi);
            //var model = await PagingList.CreateAsync(qry, 10, page);
            var model = qry.ToPagedList(page, 10);
            //var model = qry;
            return View(model);



        }
        //[HttpGet]
        //public async Task<IActionResult> Index(int page = 1)
        //{
        //    var qry = db.m_hasil.AsNoTracking().Where(p => p.reprint != 0).OrderByDescending(p => p.id_transaksi);
        //    var model = await PagingList.CreateAsync(qry, 10, page);
        //    return View(model);



        //}
       

    }
}
