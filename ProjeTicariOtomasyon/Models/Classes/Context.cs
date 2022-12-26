using System.Data.Common;
using System.Data.Entity;

namespace MvcOnlineTicariOtomasyon.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin>Admins { get; set; }
        public DbSet<Current>Currents { get; set; }
        public DbSet<Department>Departments { get; set; }
        public DbSet<invoiceItem>invoiceItems { get; set; }
        public DbSet<invoice>invoices { get; set; }
        public DbSet<Expence>Expences { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Personel>Personels { get; set; }
        public DbSet<SalesMovement>SalesMovements { get; set; }
        public DbSet<Product>Products { get; set; }
  
    }
}
