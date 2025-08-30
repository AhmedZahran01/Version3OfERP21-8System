using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3OfERP21_8System.Models.Invoices_and_supplier
{
    public class CashInvoice  // فاتوره كاش  
    {
        public int CashInvoiceId { get; set; } // رقم الفاتوره الكاش 
        public DateTime InvoiceDate { get; set; }   // تاريخ الفاتوره
        public double Total_price { get; set; } // المبلغ الاجمالي
        public string SuppliersName { get; set; }  // اسم المستورد

        [ForeignKey("Suppliers")]
        public int suppliersId { get; set; }
        public Suppliers suppliers { get; set; } = new Suppliers();    

    }
}
