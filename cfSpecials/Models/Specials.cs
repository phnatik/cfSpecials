using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace cfSpecials.Models
{
    public class Specials
    {
        public string SpecialID { get; set; }
        public string vTitle { get; set; }
        public string Condition { get; set; }
        public string MSRP { get; set; }
        public string FinalPrice { get; set; }
        public string TotalSavings { get; set; }
        public string StockNumber { get; set; }
        public string VIN { get; set; }
        public string OrderNumber { get; set; }
        
               
    }
    
    
}
