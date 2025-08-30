using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Version3OfERP21_8System.Models;
using Version3OfERP21_8System.Models.InvoiceContext;

namespace Dokaanah.DataAccessLayer.Data
{
    public static class StoreDokContextSeed
    {
        #region MyRegion

        public async static Task SeedAsync(InvoiceDbContext dbcontext)
        { 
            if (!dbcontext.Suppliers.Any()) // Check if the database is empty
            {
                var categoryData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\Suppliers.json");

                var suppliers = JsonSerializer.Deserialize<List<Suppliers>>(categoryData);
                 
                if (suppliers?.Count() > 0)
                {
                    foreach (var supplier in suppliers)
                    {
                        dbcontext.Set<Suppliers>().Add(supplier);
                    }
                    await dbcontext.SaveChangesAsync();
                     
                }
            } 
            
            if (!dbcontext.MainRegions.Any()) // Check if the database is empty
            {
                var mainRegionsData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\mainRegions.json");

                var mainRegions = JsonSerializer.Deserialize<List<MainRegions>>(mainRegionsData);
                 
                if (mainRegions?.Count() > 0)
                {
                    foreach (var supplier in mainRegions)
                    {
                        dbcontext.Set<MainRegions>().Add(supplier);
                    }
                    await dbcontext.SaveChangesAsync();
                }
            } 
                
            if (!dbcontext.SubRegions.Any()) // Check if the database is empty
            {
                var subRegionData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\subRegion.json");

                var subRegion = JsonSerializer.Deserialize<List<SubRegion>>(subRegionData);
                 
                if (subRegion?.Count() > 0)
                {
                    foreach (var subRegion1 in subRegion)
                    {
                        dbcontext.Set<SubRegion>().Add(subRegion1);
                    }
                    await dbcontext.SaveChangesAsync();
                    
                    
                }
            } 
              
            if (!dbcontext.Collectors.Any()) // Check if the database is empty
            {
                var CollectorData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\Collector.json");
                    //(" ");

                var collectors = JsonSerializer.Deserialize<List<Collector>>(CollectorData);
                 
                if (collectors?.Count() > 0)
                {
                    foreach (var subRegion1 in collectors)
                    {
                        dbcontext.Set<Collector>().Add(subRegion1);
                    }
                    await dbcontext.SaveChangesAsync();
                     
                }
            }   
              
            if (!dbcontext.Storekeepers.Any()) // Check if the database is empty
            {
                var StorekeepersData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\Storekeepers.json");
                //(" ");

                var storekeepers = JsonSerializer.Deserialize<List<Storekeepers>>(StorekeepersData);
                 
                if (storekeepers?.Count() > 0)
                {
                    foreach (var storekeepers1 in storekeepers)
                    {
                        dbcontext.Set<Storekeepers>().Add(storekeepers1);
                    }
                    await dbcontext.SaveChangesAsync();
                     
                }
            }   
          
            if (!dbcontext.Representatives.Any()) // Check if the database is empty
            {
                var RepresentativeData = File.ReadAllText
                    ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\Storekeepers.json");
                //(" ");

                var representative = JsonSerializer.Deserialize<List<Representative>>(RepresentativeData);
                 
                if (representative?.Count() > 0)
                {
                    foreach (var storekeepers1 in representative)
                    {
                        dbcontext.Set<Representative>().Add(storekeepers1);
                    }
                    await dbcontext.SaveChangesAsync();
                     
                }
            }   
       
            if (!dbcontext.Products.Any()) // Check if the database is empty
            {
                var productsData = File.ReadAllText
                 ("C:\\Users\\Click\\Desktop\\الشريف سيستم\\Local Copy Of Project\\Version 3 Of ERP System\\Version3OfERP21-8System\\Models\\InvoiceContext\\SeedingData\\Data\\DataSeeding\\Products.json");
                //(" ");

                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                 
                if (products?.Count() > 0)
                {
                    foreach (var product1 in products)
                    {
                        dbcontext.Set<Product>().Add(product1);
                    }
                    await dbcontext.SaveChangesAsync();
                     
                }
            }   
       
        
        
        

        }
        #endregion
    }
}
