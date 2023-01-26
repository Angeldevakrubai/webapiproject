using Microsoft.EntityFrameworkCore;
namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
    public class Boarding_TypeContext : DbContext
    {
        public Boarding_TypeContext(DbContextOptions<Boarding_TypeContext> options): base(options)
        {
        }
        public DbSet<TodoBoarding_Type> TodoBoarding_Type { get; set; }
    }
    public class Branch_DetailsContext : DbContext
    {
        public Branch_DetailsContext(DbContextOptions<Branch_DetailsContext> options): base(options)
        {
        }
        public DbSet<TodoBranch_Details> TodoBranch_Details { get; set; }
    }
    public class Distributor_infoContext : DbContext
    {
        public Distributor_infoContext(DbContextOptions<Distributor_infoContext> options): base(options)
        {
        }
        public DbSet<TodoDistributor_info> TodoDistributor_info { get; set; }
    }
    public class Indian_Cargo_ShipmentContext : DbContext
    {
        public Indian_Cargo_ShipmentContext(DbContextOptions<Indian_Cargo_ShipmentContext> options): base(options)
        {
        }
        public DbSet<TodoIndian_Cargo_Shipment> TodoIndian_Cargo_Shipment { get; set; }
    }
    public class orderstatusContext : DbContext
    {
        public orderstatusContext(DbContextOptions<orderstatusContext> options): base(options)
        {
        }
        public DbSet<Todoorderstatus> Todoorderstatus { get; set; }
    }
    public class Products_CategoryContext : DbContext
    {
        public Products_CategoryContext(DbContextOptions<Products_CategoryContext> options): base(options)
        {
        }
        public DbSet<TodoProducts_Category> TodoProducts_Category { get; set; }
    }
    public class Products_DetailsContext : DbContext
    {
        public Products_DetailsContext(DbContextOptions<Products_DetailsContext> options): base(options)
        {
        }
        public DbSet<TodoProducts_Details> TodoProducts_Details { get; set; }
    }
    public class Transaction_DetailsContext : DbContext
    {
        public Transaction_DetailsContext(DbContextOptions<Transaction_DetailsContext> options): base(options)
        {
        }
        public DbSet<TodoTransaction_Details> TodoTransaction_Details { get; set; }
    }
}