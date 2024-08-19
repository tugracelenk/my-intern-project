using Microsoft.EntityFrameworkCore;

namespace MyProject.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<District> Districts { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category() { Id = 1, Name = "Bilim Kurgu" },
                    new Category() { Id = 2, Name = "Aksiyon" },
                    new Category() { Id = 3, Name = "Korku" },
                    new Category() { Id = 4, Name = "Komedi" },
                    new Category() { Id = 5, Name = "Romantik" }
                );

            modelBuilder.Entity<District>()
                .HasData(
                    new District() { Id = 1, Name = "Kadikoy" },
                    new District() { Id = 2, Name = "Besiktas" },
                    new District() { Id = 3, Name = "Bahcelievler" }
                );

            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie() { Id = 1, Name = "Yildizlar Arasi", Description = "Bu bir aciklama metnidir.", Rating = 4.1F, CategoryId = 1, DistrictId = 1 },
                    new Movie() { Id = 2, Name = "Recep Ivedik", Description = "Bu bir aciklama metnidir.", Rating = 4.8F, CategoryId = 4, DistrictId = 3 },
                    new Movie() { Id = 3, Name = "Recep Ivedik", Description = "Bu bir aciklama metnidir.", Rating = 3.2F, CategoryId = 1, DistrictId = 1 },
                    new Movie() { Id = 4, Name = "Tasiyici", Description = "Bu bir aciklama metnidir.", Rating = 4.9F, CategoryId = 2, DistrictId = 1 },
                    new Movie() { Id = 5, Name = "Tasiyici", Description = "Bu bir aciklama metnidir.", Rating = 5.0F, CategoryId = 2, DistrictId = 3 }

                );
        }


    }
}
