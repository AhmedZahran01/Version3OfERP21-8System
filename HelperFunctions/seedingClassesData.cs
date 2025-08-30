using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.Models.Invoices_and_supplier;
using Version3OfERP21_8System.Views.Pages.RepresentativeAndCollector;

namespace Version3OfERP21_8System.HelperFunctions
{
    public class seedingClassesData
    {
        //1-
        public static List<MainRegions> SeedMainRegions()
        {
            List<MainRegions> defaults = new List<MainRegions>
            {
                new MainRegions { Id = 1, MainRegionName = "القاهرة", start_Number = 1 },
                new MainRegions { Id = 2, MainRegionName = "الجيزة", start_Number = 100 },
                new MainRegions { Id = 3, MainRegionName = "الإسكندرية", start_Number = 200 },
                new MainRegions { Id = 4, MainRegionName = "المنصورة", start_Number = 300 },
                new MainRegions { Id = 5, MainRegionName = "طنطا", start_Number = 400 },
                new MainRegions { Id = 6, MainRegionName = "بني سويف", start_Number = 500 },
                new MainRegions { Id = 7, MainRegionName = "أسيوط", start_Number = 600 },
                new MainRegions { Id = 8, MainRegionName = "سوهاج", start_Number = 700 },
                new MainRegions { Id = 9, MainRegionName = "الأقصر", start_Number = 800 },
                new MainRegions { Id = 10, MainRegionName = "أسوان", start_Number = 900 },

            };

            return defaults;
        }

        //4-
        public static List<SubRegion> SeedSubRegionData()
        {
            List<SubRegion> subRegions = new List<SubRegion>
            {
                new SubRegion { Id = 1, subRegionName = "مدينة نصر", MainRegionName = "القاهرة", mainRegionsId = 1 },
                new SubRegion { Id = 2, subRegionName = "المعادي", MainRegionName = "القاهرة", mainRegionsId = 1 },
                new SubRegion { Id = 3, subRegionName = "الدقي", MainRegionName = "الجيزة", mainRegionsId = 2 },
                new SubRegion { Id = 4, subRegionName = "الهرم", MainRegionName = "الجيزة", mainRegionsId = 2 },
                new SubRegion { Id = 5, subRegionName = "محرم بك", MainRegionName = "الإسكندرية", mainRegionsId = 3 },
                new SubRegion { Id = 6, subRegionName = "العجمي", MainRegionName = "الإسكندرية", mainRegionsId = 3 },
                new SubRegion { Id = 7, subRegionName = "طلخا", MainRegionName = "المنصورة", mainRegionsId = 4 },
                new SubRegion { Id = 8, subRegionName = "شبرا بابل", MainRegionName = "طنطا", mainRegionsId = 5 },
                new SubRegion { Id = 9, subRegionName = "الفشن", MainRegionName = "بني سويف", mainRegionsId = 6 },
                new SubRegion { Id = 10, subRegionName = "ديروط", MainRegionName = "أسيوط", mainRegionsId = 7 }
            };

            return subRegions;

        }

        //5-
        public static List<Suppliers> SeedsuppliersData()
        {
            var suppliers = new List<Suppliers>
            {
                new Suppliers { Id = 1, Name = "أحمد علي" },
                new Suppliers { Id = 2, Name = "محمد حسن" },
                new Suppliers { Id = 3, Name = "خالد عبد الله" },
                new Suppliers { Id = 4, Name = "عمرو إبراهيم" },
                new Suppliers { Id = 5, Name = "محمود يوسف" },
                new Suppliers { Id = 6, Name = "حسين سعيد" },
                new Suppliers { Id = 7, Name = "طارق مصطفى" },
                new Suppliers { Id = 8, Name = "مصطفى كامل" },
                new Suppliers { Id = 9, Name = "سامح فؤاد" },
                new Suppliers { Id = 10,Name = "ياسر عبد الحميد" }
            };
            return suppliers;

        }





        //6-
        public static List<CashInvoice> SeedCashInvoiceData()
        {
            var cashInvoice = new List<CashInvoice>
            {
                new CashInvoice { CashInvoiceId = 1 , SuppliersName = "أحمد علي"          , Total_price = 2000    },
                new CashInvoice { CashInvoiceId = 2 , SuppliersName = "محمد حسن"          , Total_price = 3000    },
                new CashInvoice { CashInvoiceId = 3 , SuppliersName = "خالد عبد الله"        , Total_price = 4000    },
                new CashInvoice { CashInvoiceId = 4 , SuppliersName = "عمرو إبراهيم"      , Total_price = 3320    },
                new CashInvoice { CashInvoiceId = 5 , SuppliersName = "محمود يوسف"        , Total_price = 1110    },
                new CashInvoice { CashInvoiceId = 6 , SuppliersName = "حسين سعيد"         , Total_price = 4000    },
                new CashInvoice { CashInvoiceId = 7 , SuppliersName = "طارق مصطفى"        , Total_price = 2300    },
                new CashInvoice { CashInvoiceId = 9 , SuppliersName = "سامح فؤاد"         , Total_price = 21000    },
                new CashInvoice { CashInvoiceId = 8 , SuppliersName = "مصطفى كامل"        , Total_price = 9000    },
             };
            return cashInvoice;

        }

        //7-
        public static List<Due_billsInvoice> SeedDue_billsInvoiceData()
        {
            var due_billsInvoice = new List<Due_billsInvoice>
            {
                new Due_billsInvoice { Due_billsInvoiceId = 1 , SuppliersName = "أحمد علي"          , Total_price = 2000  , Duepercentage = 2.5  },
                new Due_billsInvoice { Due_billsInvoiceId = 2 , SuppliersName = "محمد حسن"          , Total_price = 3000  , Duepercentage = 12.5  },
                new Due_billsInvoice { Due_billsInvoiceId = 3 , SuppliersName = "خالد عبد الله"        , Total_price = 4000  , Duepercentage = 25  },
                new Due_billsInvoice { Due_billsInvoiceId = 4 , SuppliersName = "عمرو إبراهيم"      , Total_price = 3320  , Duepercentage = 25  },
                new Due_billsInvoice { Due_billsInvoiceId = 5 , SuppliersName = "محمود يوسف"        , Total_price = 1110  , Duepercentage = 12.5  },
                new Due_billsInvoice { Due_billsInvoiceId = 6 , SuppliersName = "حسين سعيد"         , Total_price = 4000  , Duepercentage = 15  },
                new Due_billsInvoice { Due_billsInvoiceId = 7 , SuppliersName = "طارق مصطفى"        , Total_price = 2300  , Duepercentage = 25  },
                new Due_billsInvoice { Due_billsInvoiceId = 9 , SuppliersName = "سامح فؤاد"         , Total_price = 21000 , Duepercentage = 35   },
                new Due_billsInvoice { Due_billsInvoiceId = 8 , SuppliersName = "مصطفى كامل"        , Total_price = 9000  , Duepercentage = 10  },
             };
            return due_billsInvoice;

        }

        //8-
        public static List<Return_to_Supplier> SeedReturn_to_SupplierData()
        {
            var return_to_Supplier = new List<Return_to_Supplier>
            {
                new Return_to_Supplier { Return_to_SupplierId = 1 , SuppliersName = "أحمد علي"          , Total_price = 2000  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 2 , SuppliersName = "محمد حسن"          , Total_price = 3000  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 3 , SuppliersName = "خالد عبد الله"        , Total_price = 4000  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 4 , SuppliersName = "عمرو إبراهيم"      , Total_price = 3320  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 5 , SuppliersName = "محمود يوسف"        , Total_price = 1110  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 6 , SuppliersName = "حسين سعيد"         , Total_price = 4000  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 7 , SuppliersName = "طارق مصطفى"        , Total_price = 2300  ,    },
                new Return_to_Supplier { Return_to_SupplierId = 9 , SuppliersName = "سامح فؤاد"         , Total_price = 21000 ,    },
                new Return_to_Supplier { Return_to_SupplierId = 8 , SuppliersName = "مصطفى كامل"        , Total_price = 9000  ,    },
             };
            return return_to_Supplier;

        }

        //9-
        public static List<ruinInvoice> SeedruinInvoiceData()
        {
            var ruinInvoice = new List<ruinInvoice>
            {
                new ruinInvoice { ruinInvoiceId  = 1   },
                new ruinInvoice { ruinInvoiceId  = 2   },
                new ruinInvoice { ruinInvoiceId  = 3   },
                new ruinInvoice { ruinInvoiceId  = 4   },
                new ruinInvoice { ruinInvoiceId  = 5   },
                new ruinInvoice { ruinInvoiceId  = 6   },
                new ruinInvoice { ruinInvoiceId  = 7   },
                new ruinInvoice { ruinInvoiceId  = 9   },
                new ruinInvoice { ruinInvoiceId  = 8   },
             };
            return ruinInvoice;

        }

        //10-
        public static List<Suppliers_cash> SeedSuppliers_cashData()
        {
            var suppliers_cash = new List<Suppliers_cash>
            {
                new Suppliers_cash { Suppliers_cashId  = 1   , SuppliersName =  "أحمد علي"          , Supplly_Price =   2000     , Supplly_Notes = " عن طريق السواق   "         },
                new Suppliers_cash { Suppliers_cashId  = 2   , SuppliersName =  "محمد حسن"          , Supplly_Price =   3000     , Supplly_Notes = " عن طريق المندوب   "         },
                new Suppliers_cash { Suppliers_cashId  = 3   , SuppliersName =  "خالد عبد الله"        , Supplly_Price =   4000     , Supplly_Notes = " عن طريق السواق   "         },
                new Suppliers_cash { Suppliers_cashId  = 4   , SuppliersName =  "عمرو إبراهيم"      , Supplly_Price =   3320     , Supplly_Notes = " انا  "         },
                new Suppliers_cash { Suppliers_cashId  = 5   , SuppliersName =  "محمود يوسف"        , Supplly_Price =   1110     , Supplly_Notes = " عن طريق السواق   "         },
                new Suppliers_cash { Suppliers_cashId  = 6   , SuppliersName =  "حسين سعيد"         , Supplly_Price =   4000     , Supplly_Notes = "  انا "         },
                new Suppliers_cash { Suppliers_cashId  = 7   , SuppliersName =  "طارق مصطفى"        , Supplly_Price =   2300     , Supplly_Notes = " عن طريق السواق   "         },
                new Suppliers_cash { Suppliers_cashId  = 9   , SuppliersName =  "سامح فؤاد"         , Supplly_Price =   21000    , Supplly_Notes = " انا   "         },
                new Suppliers_cash { Suppliers_cashId  = 8   , SuppliersName =  "مصطفى كامل"        , Supplly_Price =   9000     , Supplly_Notes = "  انا  "         },
             };
            return suppliers_cash;
        }

         

        //2-
        public static List<Product> SeedproductsData()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "سكر أبيض", Type = "مواد غذائية", Percentage_Representative = 5, Main_purchase_price = 150, Sale_purchase_price = 145 },
                new Product { Id = 2, Name = "أرز بسمتي", Type = "مواد غذائية", Percentage_Representative = 4, Main_purchase_price = 200, Sale_purchase_price = 195 },
                new Product { Id = 3, Name = "زيت ذرة", Type = "زيوت", Percentage_Representative = 3.5, Main_purchase_price = 250, Sale_purchase_price = 240 },
                new Product { Id = 4, Name = "شاي أخضر", Type = "مشروبات", Percentage_Representative = 6, Main_purchase_price = 100, Sale_purchase_price = 95 },
                new Product { Id = 5, Name = "قهوة عربية", Type = "مشروبات", Percentage_Representative = 5.5, Main_purchase_price = 180, Sale_purchase_price = 175 },
                new Product { Id = 6, Name = "عصير برتقال", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 80, Sale_purchase_price = 75 },
                new Product { Id = 7, Name = "دقيق فاخر", Type = "مواد غذائية", Percentage_Representative = 3, Main_purchase_price = 120, Sale_purchase_price = 115 },
                new Product { Id = 8, Name = "عدس أصفر", Type = "بقوليات", Percentage_Representative = 4, Main_purchase_price = 140, Sale_purchase_price = 135 },
                new Product { Id = 9, Name = "فول مجروش", Type = "بقوليات", Percentage_Representative = 4.2, Main_purchase_price = 130, Sale_purchase_price = 125 },
                new Product { Id = 10, Name = "عسل نحل", Type = "مواد غذائية", Percentage_Representative = 6.5, Main_purchase_price = 300, Sale_purchase_price = 290 },
            };
            return products;


            //    LargeobservProductsList = new ObservableCollection<Product>
            //    {
            //        new Product { Id = 1, Name = "سكر أبيض", Type = "مواد غذائية", Percentage_Representative = 5, Main_purchase_price = 150, Sale_purchase_price = 145 },
            //        new Product { Id = 2, Name = "أرز بسمتي", Type = "مواد غذائية", Percentage_Representative = 4, Main_purchase_price = 200, Sale_purchase_price = 195 },
            //        new Product { Id = 3, Name = "زيت ذرة", Type = "زيوت", Percentage_Representative = 3.5, Main_purchase_price = 250, Sale_purchase_price = 240 },
            //        new Product { Id = 4, Name = "شاي أخضر", Type = "مشروبات", Percentage_Representative = 6, Main_purchase_price = 100, Sale_purchase_price = 95 },
            //        new Product { Id = 5, Name = "قهوة عربية", Type = "مشروبات", Percentage_Representative = 5.5, Main_purchase_price = 180, Sale_purchase_price = 175 },
            //        new Product { Id = 6, Name = "عصير برتقال", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 80, Sale_purchase_price = 75 },
            //        new Product { Id = 7, Name = "دقيق فاخر", Type = "مواد غذائية", Percentage_Representative = 3, Main_purchase_price = 120, Sale_purchase_price = 115 },
            //        new Product { Id = 8, Name = "عدس أصفر", Type = "بقوليات", Percentage_Representative = 4, Main_purchase_price = 140, Sale_purchase_price = 135 },
            //        new Product { Id = 9, Name = "فول مجروش", Type = "بقوليات", Percentage_Representative = 4.2, Main_purchase_price = 130, Sale_purchase_price = 125 },
            //        new Product { Id = 10, Name = "عسل نحل", Type = "مواد غذائية", Percentage_Representative = 6.5, Main_purchase_price = 300, Sale_purchase_price = 290 },
            //        new Product { Id = 11, Name = "مكرونة إسباجيتي", Type = "مواد غذائية", Percentage_Representative = 3.5, Main_purchase_price = 90, Sale_purchase_price = 85 },
            //        new Product { Id = 12, Name = "مكرونة أقلام", Type = "مواد غذائية", Percentage_Representative = 3.5, Main_purchase_price = 88, Sale_purchase_price = 83 },
            //        new Product { Id = 13, Name = "حمص", Type = "بقوليات", Percentage_Representative = 4, Main_purchase_price = 150, Sale_purchase_price = 145 },
            //        new Product { Id = 14, Name = "فاصوليا بيضاء", Type = "بقوليات", Percentage_Representative = 4, Main_purchase_price = 160, Sale_purchase_price = 155 },
            //        new Product { Id = 15, Name = "شاي أسود", Type = "مشروبات", Percentage_Representative = 6, Main_purchase_price = 95, Sale_purchase_price = 90 },
            //        new Product { Id = 16, Name = "عصير مانجو", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 85, Sale_purchase_price = 80 },
            //        new Product { Id = 17, Name = "جبنة بيضاء", Type = "ألبان", Percentage_Representative = 5, Main_purchase_price = 220, Sale_purchase_price = 210 },
            //        new Product { Id = 18, Name = "جبنة رومى", Type = "ألبان", Percentage_Representative = 5.2, Main_purchase_price = 250, Sale_purchase_price = 240 },
            //        new Product { Id = 19, Name = "لبن كامل الدسم", Type = "ألبان", Percentage_Representative = 4.8, Main_purchase_price = 110, Sale_purchase_price = 105 },
            //        new Product { Id = 20, Name = "لبن خالي الدسم", Type = "ألبان", Percentage_Representative = 4.8, Main_purchase_price = 108, Sale_purchase_price = 103 },
            //        new Product { Id = 21, Name = "زيت عباد الشمس", Type = "زيوت", Percentage_Representative = 3.5, Main_purchase_price = 240, Sale_purchase_price = 230 },
            //        new Product { Id = 22, Name = "زيت زيتون", Type = "زيوت", Percentage_Representative = 4, Main_purchase_price = 350, Sale_purchase_price = 340 },
            //        new Product { Id = 23, Name = "صلصة طماطم", Type = "مواد غذائية", Percentage_Representative = 3.2, Main_purchase_price = 70, Sale_purchase_price = 65 },
            //        new Product { Id = 24, Name = "كاتشب", Type = "مواد غذائية", Percentage_Representative = 3.2, Main_purchase_price = 75, Sale_purchase_price = 70 },
            //        new Product { Id = 25, Name = "مايونيز", Type = "مواد غذائية", Percentage_Representative = 3.5, Main_purchase_price = 90, Sale_purchase_price = 85 },
            //        new Product { Id = 26, Name = "مياه معدنية صغيرة", Type = "مشروبات", Percentage_Representative = 2, Main_purchase_price = 20, Sale_purchase_price = 18 },
            //        new Product { Id = 27, Name = "مياه معدنية كبيرة", Type = "مشروبات", Percentage_Representative = 2, Main_purchase_price = 35, Sale_purchase_price = 33 },
            //        new Product { Id = 28, Name = "بيبسي", Type = "مشروبات", Percentage_Representative = 3, Main_purchase_price = 50, Sale_purchase_price = 48 },
            //        new Product { Id = 29, Name = "كوكاكولا", Type = "مشروبات", Percentage_Representative = 3, Main_purchase_price = 50, Sale_purchase_price = 48 },
            //        new Product { Id = 30, Name = "سبرايت", Type = "مشروبات", Percentage_Representative = 3, Main_purchase_price = 50, Sale_purchase_price = 48 },
            //        new Product { Id = 31, Name = "فانتا", Type = "مشروبات", Percentage_Representative = 3, Main_purchase_price = 50, Sale_purchase_price = 48 },
            //        new Product { Id = 32, Name = "بسكويت سادة", Type = "حلويات", Percentage_Representative = 4, Main_purchase_price = 40, Sale_purchase_price = 38 },
            //        new Product { Id = 33, Name = "بسكويت بالشوكولاتة", Type = "حلويات", Percentage_Representative = 4, Main_purchase_price = 45, Sale_purchase_price = 42 },
            //        new Product { Id = 34, Name = "شوكولاتة بالحليب", Type = "حلويات", Percentage_Representative = 4.5, Main_purchase_price = 60, Sale_purchase_price = 55 },
            //        new Product { Id = 35, Name = "شوكولاتة داكنة", Type = "حلويات", Percentage_Representative = 4.5, Main_purchase_price = 65, Sale_purchase_price = 60 },
            //        new Product { Id = 36, Name = "لبان بالنعناع", Type = "حلويات", Percentage_Representative = 3, Main_purchase_price = 15, Sale_purchase_price = 12 },
            //        new Product { Id = 37, Name = "لبان بالفراولة", Type = "حلويات", Percentage_Representative = 3, Main_purchase_price = 15, Sale_purchase_price = 12 },
            //        new Product { Id = 38, Name = "عصير تفاح", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 85, Sale_purchase_price = 80 },
            //        new Product { Id = 39, Name = "عصير أناناس", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 85, Sale_purchase_price = 80 },
            //        new Product { Id = 40, Name = "عصير جوافة", Type = "مشروبات", Percentage_Representative = 4.5, Main_purchase_price = 85, Sale_purchase_price = 80 },
            //        new Product { Id = 41, Name = "تمر", Type = "مواد غذائية", Percentage_Representative = 5, Main_purchase_price = 250, Sale_purchase_price = 245 },
            //        new Product { Id = 42, Name = "تونة", Type = "معلبات", Percentage_Representative = 3.5, Main_purchase_price = 120, Sale_purchase_price = 115 },
            //        new Product { Id = 43, Name = "سردين", Type = "معلبات", Percentage_Representative = 3.5, Main_purchase_price = 110, Sale_purchase_price = 105 },
            //        new Product { Id = 44, Name = "فطر معلب", Type = "معلبات", Percentage_Representative = 3.5, Main_purchase_price = 150, Sale_purchase_price = 145 },
            //        new Product { Id = 45, Name = "ذرة معلبة", Type = "معلبات", Percentage_Representative = 3.5, Main_purchase_price = 140, Sale_purchase_price = 135 },
            //        new Product { Id = 46, Name = "خل أبيض", Type = "مواد غذائية", Percentage_Representative = 2.5, Main_purchase_price = 60, Sale_purchase_price = 55 },
            //        new Product { Id = 47, Name = "خل تفاح", Type = "مواد غذائية", Percentage_Representative = 2.5, Main_purchase_price = 65, Sale_purchase_price = 60 },
            //        new Product { Id = 48, Name = "عطر ورد", Type = "عطور", Percentage_Representative = 10, Main_purchase_price = 500, Sale_purchase_price = 480 },
            //        new Product { Id = 49, Name = "عطر مسك", Type = "عطور", Percentage_Representative = 10, Main_purchase_price = 550, Sale_purchase_price = 530 },
            //        new Product { Id = 50, Name = "عطر عنبر", Type = "عطور", Percentage_Representative = 10, Main_purchase_price = 600, Sale_purchase_price = 580 }
            //    };

        }

        //3-
        public static List<string> SeedproductNamesData()
        {
            List<string> productNames = new List<string>() { "مواد غذائية", "بقوليات ", "مشروبات", "ألبان", "حلويات" };

            return productNames;
        }


    }
}
