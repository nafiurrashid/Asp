using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cool.Website.Models
{
    public class Product
    {
        public string date { get; set; }
        public string trade_codet { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string open { get; set; }
        public string close { get; set; }
        public string volume { get; set; }

        public override string ToString()=>JsonSerializer.Serialize<Product>(this);

      



    }   
}
