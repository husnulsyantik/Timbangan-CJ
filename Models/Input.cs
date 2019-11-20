using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CJTimbangan.Models
{
    public partial class Input{

                public int id_transaksi {set; get;}
                public String id_controller {set; get;}
                public String type_controller {set; get;}
                public String id_printer {set; get;}
                public String type_printer {set; get;}
                public String id_dig_scale {set; get;}
                public String type_dig_scale {set; get;}
                public String lot_no {set; get;}
                public String barang {set; get;}
                public int counter {set; get;}
                public float tare {set; get;}
                public String kemasan {set; get;}
                [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy hh:mm:ss }")]
                public DateTime tgl_cetak {set; get;}
                [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
                public DateTime tgl_produksi {set; get;}
                public float weight{set; get;}    
                public String location{set; get;}
                public String status { set; get; }
                public int reprint { set; get; }
                public int shift { set; get; }


    }
}