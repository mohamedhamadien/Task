using Microsoft.EntityFrameworkCore;


namespace Task.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ItemID);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Brand)
                    .HasMaxLength(10);

                entity.Property(e => e.Model)
                    .HasMaxLength(10);

                entity.Property(e => e.Color)
                    .HasMaxLength(10);

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(12, 2)")
                    .IsRequired()
                    .HasDefaultValue(0);
            });

            modelBuilder.Entity<Product>().HasData(
               new Product { ItemID = 1, ItemName = "Item1", Brand = "Brand1", Model = "Model1", Color = "Red", Price = 10.00m },
               new Product { ItemID = 2, ItemName = "Item2", Brand = "Brand2", Model = "Model2", Color = "Blue", Price = 20.00m },
               new Product { ItemID = 3, ItemName = "Item3", Brand = "Brand3", Model = "Model3", Color = "Green", Price = 30.00m },
               new Product { ItemID = 4, ItemName = "Item4", Brand = "Brand4", Model = "Model4", Color = "Yellow", Price = 40.00m },
               new Product { ItemID = 5, ItemName = "Item5", Brand = "Brand5", Model = "Model5", Color = "Orange", Price = 50.00m }
                   );
        }
    }
}