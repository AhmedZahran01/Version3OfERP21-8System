using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3OfERP21_8System.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Percentage_Representative { get; set; } // نسبه المندوب 
        public double Main_purchase_price { get; set; } // سعر الشراء الاساسي    
        public double Sale_purchase_price { get; set; } // سعر  البيع الاساسي    

    }
}
