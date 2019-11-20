using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CJTimbangan.Models
{
    
    public partial class Setting{
        public int id {set; get;}
        public String code { set; get; }

        [Display(Name ="ID Controller")]
        public String id_controller {set; get;} 

        [Display(Name ="Type Controller")]
        public String type_controller {set; get;}

        [Display(Name ="IP Controller")]
        public String ip_controller {set; get;}

        [Display(Name ="Name Product")]
        public String barang {set; get;}

        [Display(Name ="LOT NUMBER")]
        public String lot_no {set; get;}

        [Display(Name ="Counter")]
      
        public int counter {set; get;}

        [Display(Name ="Tare")]
        
        public double tare {set; get;}

        [Display(Name ="Packaging")]
     
        public String kemasan {set; get;}

        [Display(Name ="Location")]
        public String location {set; get;}

        [Display(Name ="ID Printer")]
        public String id_printer {set; get;}

        [Display(Name ="Type Printer")]
        public String type_printer {set; get;}

        [Display(Name ="IP Printer")]
        public String ip_printer {set; get;}

        [Display(Name = "Path Label")]
        public String path { set; get; }

        [Display(Name ="ID Scale")]
        public String id_dig_scale   {set; get;}

        [Display(Name ="Type Scale")]
        public String type_dig_scale   {set; get;}

        internal T ToObject<T>()
        {
            throw new NotImplementedException();
        }
    }
}