using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3OfERP21_8System.Models.Invoices_and_supplier
{
    public class Suppliers_cash  // نقديه الموردين 
    { 
        public int Suppliers_cashId { get; set; } // رقم نقديه الموردين    
        public DateTime SupplyDate { get; set; }   // تاريخ التوريد
        public string SuppliersName { get; set; }  // اسم المستورد
        public double Supplly_Price { get; set; } // المبلغ المورد
        public string Supplly_Notes { get; set; }  // ملاحظات  

        [ForeignKey("Suppliers")]
        public int suppliersId { get; set; }
        public Suppliers suppliers { get; set; } = new Suppliers();


    }
}
