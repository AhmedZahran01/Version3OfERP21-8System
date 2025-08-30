using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version3OfERP21_8System.Models.Invoices_and_supplier;

namespace Version3OfERP21_8System.Models
{
    public class Suppliers //الموردين 
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<CashInvoice> suppliers { get; set; } = new List<CashInvoice>();
        public List<Due_billsInvoice> due_BillsInvoices { get; set; } = new List<Due_billsInvoice>();
        public List<Return_to_Supplier> return_To_Suppliers { get; set; } = new List<Return_to_Supplier>();
        public List<Suppliers_cash> Suppliers_cash { get; set; } = new List<Suppliers_cash>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
