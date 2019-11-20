using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CJTimbangan.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace CJTimbangan.Controllers
{
   
    public class CodeController : Controller
    {
        private readonly SettingTimbanganContext db;
        public CodeController(SettingTimbanganContext context)
        {
            db = context;
        }
  
        [HttpGet]
        public IActionResult Index()
        {
          
           //var items = db.m_code.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Timb()
        {
            var posts = db.m_code
                       .Where(p => p.code == "SC")
                       .ToList();
           
            return View(posts);
        }

        [HttpGet]
        public IActionResult AddTimb()
        {
            var max_id_string = db.m_code.Where(c => c.code == "SC").Select(c => c.id_dig_scale).Max();
            if (max_id_string == null)
            {
                var max_id_int = 0;
                var next_id = "TYDS" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }
            else
            {
                var max_id_int = Int32.Parse(Regex.Match(max_id_string, @"\d+").Value);
                var next_id = "TYDS" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }
            return View();
        }
        
        [HttpPost]
        public ActionResult AddTimb(Setting item){
            var max_id = db.m_code.Where(c => c.code == "SC").Select(c => c.id_dig_scale).Max();
            item.code = "SC";
                if(ModelState.IsValid){
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("Timb");
            }
            return View();        
        }
        public IActionResult UpdateTimb(int id)
        {
            var item = db.m_code.SingleOrDefault(p => p.id.Equals(id));

            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTimb([Bind("id,code,id_controller,type_controller,ip_controller,id_printer,type_printer,ip_printer,path,id_dig_scale,barang,lot_no,counter,tare,kemasan,type_dig_scale,location")] Setting item)
        {
            item.code = "SC";
            if (ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();
                return RedirectToAction("Timb");
            }

            return View();
        }
        [HttpGet]
        public IActionResult DeleteTimb(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.m_code.Find(id);
                db.m_code.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Timb");
            }

            return View();
        }  
        [HttpGet]
        public IActionResult Cont()
        {
            var posts = db.m_code
                       .Join(
                            db.m_code.Where(x => x.code == "PR"),
                            cont => cont.id_printer,
                            print => print.id_printer,
                            (cont, print) => new
                            {
                                cont = cont,
                                print = print
                            }
                        )
                        .Join(
                            db.m_code.Where(x => x.code == "SC"),
                            cont => cont.cont.id_dig_scale,
                            scale => scale.id_dig_scale,
                            (cont, scale) => new Setting
                            {
                                id = cont.cont.id,
                                code = cont.cont.code,
                                id_controller = cont.cont.id_controller,
                                type_controller = cont.cont.type_controller,
                                ip_controller = cont.cont.ip_controller,
                                barang = cont.cont.barang,
                                lot_no = cont.cont.lot_no,
                                counter = cont.cont.counter,
                                tare = cont.cont.tare,
                                kemasan = cont.cont.kemasan,
                                location = cont.cont.location,
                                id_printer = cont.cont.id_printer,
                                type_printer = cont.print.type_printer,
                                ip_printer = cont.print.ip_printer,
                                path = cont.print.path,
                                id_dig_scale = scale.id_dig_scale,
                                type_dig_scale = scale.type_dig_scale

                            }
                        )
                       .Where(p => p.code == "CR")
                       .ToList();
            //ViewBag.data_list = posts;
            return View(posts);
        }
        [HttpGet]
        public IActionResult Setting()
        {
            var okeh = db.m_code
                        .Where(p => p.code == "PR")
                        .Select(p => new
                        {
                            id_printer = p.id_printer,
                            type_printer = string.Format(" {0} | {1} | {2} ", p.id_printer, p.type_printer, p.ip_printer)
                        })
                        .ToList();
            var timbangan = db.m_code
                           .Where(p => p.code == "SC")
                           .Select(p => new
                           {
                               id_dig_scale = p.id_dig_scale,
                               type_dig_scale = string.Format(" {0} | {1} ", p.id_dig_scale, p.type_dig_scale)
                           })
                           .ToList();
            var max_id_string = db.m_code.Where(c => c.code == "CR").Select(c => c.id_controller).Max();
            if (max_id_string == null)
            {
                var max_id_int = 0;
                var next_id = "TYRP" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }
            else
            {
                var max_id_int = Int32.Parse(Regex.Match(max_id_string, @"\d+").Value);
                var next_id = "TYRP" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }

            ViewBag.Printer = new SelectList(okeh, "id_printer", "type_printer");
            ViewBag.Scale = new SelectList(timbangan, "id_dig_scale", "type_dig_scale");
            ViewBag.Barang = new SelectList(db.m_code.Where(p => p.code == "PRD").ToList(), "barang", "barang");
            

            return View();
        }
        [HttpPost] 
        public IActionResult Setting(Setting item)
        {
            var max_id = db.m_code.Where(c => c.code == "CR").Select(c => c.id_controller).Max();
            item.code = "CR";
            if (ModelState.IsValid)
            {
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("Cont");
            }
            return View();
        }
        /*[HttpGet]
        public IActionResult EditTimbangan()
        {
            var okeh = db.m_code
                        .Where(p => p.code == "PR")
                        .Select(p => new
                        {
                            id_printer = p.id_printer,
                            type_printer = string.Format(" {0} | {1} | {2} ", p.id_printer, p.type_printer, p.ip_printer)
                        })
                        .ToList();
            var timbangan = db.m_code
                           .Where(p => p.code == "SC")
                           .Select(p => new
                           {
                               id_dig_scale = p.id_dig_scale,
                               type_dig_scale = string.Format(" {0} | {1} ", p.id_dig_scale, p.type_dig_scale)
                           })
                           .ToList();

            ViewBag.Printer = new SelectList(okeh, "id_printer", "type_printer");
            ViewBag.Scale = new SelectList(timbangan, "id_dig_scale", "type_dig_scale");
            ViewBag.Barang = new SelectList(db.m_code.Where(p => p.code == "PRD").ToList(), "barang", "barang");
            return View();
        }*/
        [HttpGet]
        public IActionResult EditTimbangan(int id)
        {
            var okeh = db.m_code
                        .Where(p => p.code == "PR")
                        .Select(p => new
                        {
                            id_printer = p.id_printer,
                            type_printer = string.Format(" {0} | {1} | {2} ", p.id_printer, p.type_printer, p.ip_printer)
                        })
                        .ToList();
            var timbangan = db.m_code
                           .Where(p => p.code == "SC")
                           .Select(p => new
                           {
                               id_dig_scale = p.id_dig_scale,
                               type_dig_scale = string.Format(" {0} | {1} ", p.id_dig_scale, p.type_dig_scale)
                           })
                           .ToList();

            ViewBag.Printer = new SelectList(okeh, "id_printer", "type_printer");
            ViewBag.Scale = new SelectList(timbangan, "id_dig_scale", "type_dig_scale");
            ViewBag.Barang = new SelectList(db.m_code.Where(p => p.code == "PRD").ToList(), "barang", "barang");
            var item = db.m_code.SingleOrDefault(p => p.id.Equals(id));

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditTimbangan([Bind("id,code,id_controller,type_controller,ip_controller,barang,lot_no,counter,tare,kemasan,location,id_printer,type_printer,ip_printer,path,id_dig_scale,type_dig_scale")] Setting item)
        {
            item.code = "CR";
            if (ModelState.IsValid)
            {
                db.Update(item);
                db.SaveChanges();

                return RedirectToAction("cont");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var item = db.m_code.Find(id);
                db.m_code.Remove(item);
                db.SaveChanges();

                return RedirectToAction("Cont");
            }

            return View();
        }
        [HttpGet]
        public IActionResult Print()
        {
            var posts = db.m_code
                       .Where(p => p.code == "PR")
                       .ToList();
            //var items = db.master.ToList();
            return View(posts);
        }
        [HttpGet]
        public IActionResult AddPrint()
        {
            var max_id_string = db.m_code.Where(c => c.code == "PR").Select(c => c.id_printer).Max();
            if (max_id_string == null)
            {
                var max_id_int = 0;
                var next_id = "TYPT" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }
            else
            {
                var max_id_int = Int32.Parse(Regex.Match(max_id_string, @"\d+").Value);
                var next_id = "TYPT" + (max_id_int + 1).ToString();
                ViewBag.next_id = next_id;
            }
            return View();
        }
        
        [HttpPost]
        public ActionResult AddPrint(Setting item){
            var max_id = db.m_code.Where(c => c.code == "PR").Select(c => c.id_printer).Max();
            item.code = "PR";
            if (ModelState.IsValid){
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("Print");
            }
            return View();        
        } 
          [HttpGet]
        public IActionResult UpdatePrint(int id)
        {
            var item = db.m_code.SingleOrDefault(p=>p.id.Equals(id));

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePrint([Bind("id,code,id_controller,type_controller,ip_controller,id_printer,type_printer,ip_printer,path,id_dig_scale,barang,lot_no,counter,tare,kemasan,type_dig_scale,location")] Setting item)
        {
            item.code = "PR";
            if (ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();

                return RedirectToAction("print");
            }

            return View();
        }
        [HttpGet]
        public IActionResult DeletePrint(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.m_code.Find(id);
                db.m_code.Remove(item);
                db.SaveChanges();

                return RedirectToAction("print");
            }

            return View();
        } 
        
        [HttpGet]
        public IActionResult product()
        {
            var posts = db.m_code
                       .Where(p => p.code == "PRD")
                       .ToList();
            //var items = db.master.ToList();
            return View(posts);
        }  
         [HttpGet]
        public IActionResult Addproduct()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Addproduct(Setting item){
            item.code = "PRD";
                if(ModelState.IsValid){
                db.Add(item);
                db.SaveChanges();
                return RedirectToAction("product");
            }
            return View();        
        } 
         [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var item = db.m_code.SingleOrDefault(p=>p.id.Equals(id));

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateProduct([Bind("id,code,id_controller,type_controller,ip_controller,id_printer,type_printer,ip_printer,path,id_dig_scale,barang,lot_no,counter,tare,kemasan,type_dig_scale,location")] Setting item)
        {
            item.code = "PRD";
            if (ModelState.IsValid){
                db.Update(item);
                db.SaveChanges();

                return RedirectToAction("product");
            }

            return View();
        }
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.m_code.Find(id);
                db.m_code.Remove(item);
                db.SaveChanges();

                return RedirectToAction("product");
            }

            return View();
        } 


    }
}
