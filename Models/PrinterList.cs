using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CJTimbangan.Models
{
    
    public partial class PrinterList{
        public Setting cont { get; set; }
        public Setting print { get; set; }
        public Setting scale { get; set; }
        internal T ToObject<T>()
        {
            throw new NotImplementedException();
        }
    }
}