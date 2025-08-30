using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version3OfERP21_8System.Models.Invoices_and_supplier
{
    public class Due_billsInvoice  // فاتوره اجل  
    {
        public int Due_billsInvoiceId { get; set; } // رقم الفاتوره الكاش 
        public DateTime InvoiceDate { get; set; }   // تاريخ الفاتوره
        public double Total_price { get; set; } // المبلغ الاجمالي
        public double Duepercentage { get; set; } // نسبه التقسيط
        public string SuppliersName { get; set; }  // اسم المستورد

        [ForeignKey("Suppliers")]
        public int suppliersId { get; set; }
        public Suppliers suppliers { get; set; } = new Suppliers();


    }
}
