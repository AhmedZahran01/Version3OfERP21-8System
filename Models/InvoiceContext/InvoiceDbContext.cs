using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Version3OfERP21_8System.Models.Invoices_and_supplier;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Version3OfERP21_8System.Models.InvoiceContext
{
    public class InvoiceDbContext : DbContext
    {

        #region Constractors Region

        public InvoiceDbContext()
        {
        }

        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
            : base(options)
        {
        }

        #endregion


        #region  Db Sets Region


        public virtual DbSet<Suppliers> Suppliers { get; set; } = null!;
        public virtual DbSet<MainRegions> MainRegions { get; set; } = null!;
        public virtual DbSet<SubRegion> SubRegions { get; set; } = null!;
        public virtual DbSet<Collector> Collectors { get; set; } = null!;
        public virtual DbSet<Storekeepers> Storekeepers { get; set; } = null!; 
        public virtual DbSet<Representative> Representatives { get; set; } = null!;
        public virtual DbSet<Product>  Products { get; set; } = null!;
        
          
        public virtual DbSet<Return_to_Supplier> Return_To_Suppliers { get; set; } = null!;
        public virtual DbSet<Due_billsInvoice> Due_BillsInvoices { get; set; } = null!;
        public virtual DbSet<CashInvoice> CashInvoices { get; set; } = null!;
        public virtual DbSet<ruinInvoice> RuinInvoices { get; set; } = null!; 
        public virtual DbSet<Suppliers_cash> Suppliers_Cashes { get; set; } = null!;


        #endregion

        #region On Configuring Region

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
           
            //"server=localhost;database=hospital;uid=root;pwd=new_password;"

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(
                    "server=localhost;database=invoiceSystem;uid=root;pwd=root;");


                //        "server=localhost;database=hospital;uid=root;pwd=new_password;"

            }
        }

        #endregion






    }
}
