 
using MIS.Areas.Identity.Data;
using MIS.Models;
 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MIS.Data
{
    public class MISDbContext : IdentityDbContext<MISUser>
    {
        public MISDbContext(DbContextOptions<MISDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);//is required for identity framework
            // builder.Entity<Employee>()
            // .HasOne(e => e.report_to)
            // .WithMany()
            // .HasForeignKey(m => m.report_to_id);
             
        }//ef


        public DbSet<MISUser> MISUsers { get; set; }

        public DbSet<ProductGroup> ProductGroups {get;set;}
        public DbSet<Product> Products {get;set;}
        public DbSet<OrderStatus> OrderStatuses {get;set;}
        public DbSet<ProductOrder> ProductOrders {get;set;}
  
        //public DbSet<> {get;set;}
    }//ec
}//en
