using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CJTimbangan.Models;
using Newtonsoft.Json;

namespace CJTimbangan.Controllers
{
   
    public class SettingController : Controller
    {
        private readonly SettingTimbanganContext db;
        public SettingController(SettingTimbanganContext context)
        {
            db = context;
        }
  
        [HttpGet]
        public IActionResult Index()
        {
            var items = db.m_code.Select(p => p);

            return View(items);
        }
        [HttpGet]
        public IActionResult home()
        {
            var posts = db.m_code
                        .Where(p => p.code == "CR")
                        .ToList();

            return View(posts);

        }

        
        [HttpGet]
        public JsonResult Update(int id)
        {
            var item = db.m_code.SingleOrDefault(p=>p.id.Equals(id));

            return Json(item);
        }
        [HttpPost]
        public JsonResult Update([FromBody] [Bind("id,code,id_controller,type_controller,ip_controller,barang,lot_no,counter,tare,kemasan,location,id_printer,type_printer,ip_printer,path,id_dig_scale,type_dig_scale")] dynamic data){
            bool save = false;
            //data.code = "CR";
            List<Setting> items = data.ToObject<List<Setting>>();
            foreach(Setting item in items){
                item.code = "CR";
            if(ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();
                save = true;
            }
        }
            return Json(save);
        }

          

         }
}
