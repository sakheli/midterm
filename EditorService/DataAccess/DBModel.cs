namespace EditorService.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBModel : DbContext
    {
        public DBModel()
            : base("name=DBModel")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Publishing_House> Publishing_House { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Products)
                .WithMany(e => e.Authors)
                .Map(m => m.ToTable("Author_Product").MapLeftKey("Id_Author").MapRightKey("Id_Product"));

            modelBuilder.Entity<City>()
                .HasMany(e => e.Authors)
                .WithOptional(e => e.City)
                .HasForeignKey(e => e.Id_City);


            modelBuilder.Entity<Country>()
                .HasMany(e => e.Authors)
                .WithOptional(e => e.Country)
                .HasForeignKey(e => e.Id_Country);


            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Authors)
                .WithOptional(e => e.Gender)
                .HasForeignKey(e => e.Id_Gender);


            modelBuilder.Entity<ProductType>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.ProductType)
                .HasForeignKey(e => e.Id_ProductType);

            modelBuilder.Entity<Publishing_House>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Publishing_House)
                .HasForeignKey(e => e.Id_PublishingHouse);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.Id_Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
