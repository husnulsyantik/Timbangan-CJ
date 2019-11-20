using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CJTimbangan.Models
{
    
    public partial class CounterList{
        public Setting hasil { get; set; }
        internal T ToObject<T>()
        {
            throw new NotImplementedException();
        }
    }
}