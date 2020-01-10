using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DAL.Context
{
    public class TrialContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public TrialContext():base("ForYura")
        {
            
        }
        static TrialContext()
        {
           // Database.SetInitializer(new StoreDbInitializer());
        }
    }
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<TrialContext>
    {
        protected override void Seed(TrialContext db)
        {
            
            //db.Products.Add(new Product { Name = "Nokia Lumia 630", Price = 220, Color = "Pled", Description = "Some text" });
            //db.Products.Add(new Product { Name = "iPhone 6", Price = 320, Color = "Pled", Description = "Some text" });
            //db.Products.Add(new Product { Name = "LG G4", Price = 260, Color = "Pled", Description = "Some text" });
            //db.Products.Add(new Product { Name = "Samsung Galaxy S 6", Price = 300, Color = "Pled", Description = "Some text" });
            //db.SaveChanges();
        }
    }
}