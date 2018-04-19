namespace UTS_PLOO_151524025_Reka_Alamsyah.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProductDBContext : DbContext
    {
        // Your context has been configured to use a 'ProductDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'UTS_PLOO_151524025_Reka_Alamsyah.Models.ProductDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ProductDBContext' 
        // connection string in the application configuration file.
        public ProductDBContext()
            : base("name=db_uts")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .Property(e => e.product_id);

            modelBuilder.Entity<Product>()
               .Property(e => e.product_name);

            modelBuilder.Entity<Product>()
               .Property(e => e.product_price);

            modelBuilder.Entity<Product>()
               .Property(e => e.category_id);
            modelBuilder.Entity<Product>()
               .Property(e => e.supplier_id);

            modelBuilder.Entity<Product>()
               .Property(e => e.minimum_stock);

        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}