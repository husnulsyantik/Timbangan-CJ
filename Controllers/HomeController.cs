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
   
    public class HomeController : Controller
    {
        private readonly SettingTimbanganContext db;
        public HomeController(SettingTimbanganContext context)
        {
            db = context;
        }
        Random rdn = new Random();

        [HttpGet]
        public IActionResult Index()
        {
            return View();

        }
        public JsonResult GetRealTimeData()
        {
            var weight = db.m_hasil.Select(c => new { c.weight, c.tgl_cetak });
            //Input data = new Input
            //{
            //    tgl_cetak = ,
            //    weight = 
            //};
            return Json(weight);
        }
        //return View();



        [HttpGet]
        public IActionResult Login()
        {
          
               return View();
            
        }
        /*
        [HttpGet]
        public IActionResult ListTimbangan()
        {
            var posts = db.m_hasil
                         .Where(p => p.reprint == 0)
                         .ToList();

            return View(posts);


        }*/
        [HttpGet]
        public async Task<IActionResult> ListTimbangan(int page = 1)
        {
            var qry = db.m_hasil.AsNoTracking().Where(p => p.reprint == 0).OrderBy(p => p.id_transaksi);
            var model = await PagingList.CreateAsync(qry, 5, page);
            return View(model);
        }
        
        [HttpGet]
        public IActionResult DetailList()
        {
            var posts = db.m_hasil
                         .Where(p => p.reprint == 0)
                         .ToList();

            return View(posts);

        }
               

        [HttpGet]
        public IActionResult Input(){
            return View();
        }
        
        [HttpGet]
        public string tes()
        {
            var items = db.m_code.ToList();
            string  hasil = JsonConvert.SerializeObject(items);
            return hasil;
        }
         [HttpGet]
        public string kodereprint(int id)
        {
            //List<Setting> items = db.ToObject<List<Input>>();
            var items = db.m_hasil.SingleOrDefault(p=>p.id_transaksi.Equals(id));
            string  hasil = JsonConvert.SerializeObject(items);
            return hasil;
        }
        [HttpGet]
        public string teskode(String id)
        {
            //List<Setting> items = db.ToObject<List<Input>>();
            var items = db.m_code
                       .Where(p => p.id_controller.Equals(id))
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
                       .SingleOrDefault();
            //.Where(p => p.id_controller == id)
            //.ToList();
            string hasil = JsonConvert.SerializeObject(items);
            return hasil;
        }

        [HttpPost]
        public JsonResult Simpan([FromBody] dynamic data){
            // Console.WriteLine(items);
            bool save = false;
           
            List<Input> items = data.ToObject<List<Input>>();
            foreach(Input item in items){
                // DateTime tgl= System.DateTime.Now;
                // item.tgl_produksi = tgl;
                // item.tgl_cetak = tgl;
                
                if (ModelState.IsValid){
                    db.Add(item);
                    db.SaveChanges();
                    save = true;
                }
            }
            return Json(save);
        }

        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult DeleteList(int id)
        {
            if(ModelState.IsValid)
            {
                var item = db.m_hasil.Find(id);
                db.m_hasil.Remove(item);
                db.SaveChanges();

                return RedirectToAction("ListTimbangan");
            }
            return View();
        }
        

    }
}
