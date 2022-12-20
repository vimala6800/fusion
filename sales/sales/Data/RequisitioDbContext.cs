using Microsoft.EntityFrameworkCore;
using sales.Models;

namespace sales.Data
{
    public class RequisitioDbContext : DbContext
    {
        public RequisitioDbContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Requisition> Requisitions { get; set; }
        public DbSet<RequisitionPatner> RequisitionPartners { get; set; }
    }
}




//namespace sales.Data

//{
//    public class RequistionDbContext : DbContext
//    {
//        public RequistionDbContext(DbContextOptions options) : base(options)
//        { }

//        public DbSet<Requisition> Requisitions { get; set; }
//    }
//}


