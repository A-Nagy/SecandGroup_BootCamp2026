using Microsoft.EntityFrameworkCore;
using SecandGroup_1.Models;

namespace SecandGroup_1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){}

        //DbSet is a collection of entities of a specific type that can be queried from the database
        //and used to perform CRUD operations.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get;set; }

    }
}
