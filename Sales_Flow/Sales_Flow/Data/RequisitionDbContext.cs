using Microsoft.EntityFrameworkCore;
using Sales_Flow.Models;

namespace Sales_Flow.Data
{
    public class RequisitionDbContext : DbContext
    {
        public RequisitionDbContext(DbContextOptions options) : base(options)
        {

        }
         public DbSet<Requisition> Requisitions { get; set; }
        public DbSet<Requistionfile> RequisitionFiles { get; set; }
    }
}