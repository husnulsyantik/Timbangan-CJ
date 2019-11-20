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

namespace CJTimbangan.Controllers
{
   
    public class Shift1cController : Controller
    {
        private readonly SettingTimbanganContext db;
        public Shift1cController(SettingTimbanganContext context)
        {
            db = context;
        }

     

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
                var qry = db.m_hasil.AsNoTracking().Where(p => p.reprint != 0 && p.shift ==1 ).OrderByDescending(p => p.id_transaksi);
               
                var model = await PagingList.CreateAsync(qry, 10, page);
                return View(model);
            }

       
          
        

    }
}
