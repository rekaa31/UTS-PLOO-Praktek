namespace UTS_PLOO_151524025_Reka_Alamsyah.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CategoryDBContext : DbContext
    {
        // Your context has been configured to use a 'CategoryDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'UTS_PLOO_151524025_Reka_Alamsyah.Models.CategoryDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CategoryDBContext' 
        // connection string in the application configuration file.
        public CategoryDBContext()
            : base("name=db_uts")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
               .Property(e => e.category_id);

            modelBuilder.Entity<Category>()
               .Property(e => e.category_name);

            modelBuilder.Entity<Category>()
               .Property(e => e.category_description);


        }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}