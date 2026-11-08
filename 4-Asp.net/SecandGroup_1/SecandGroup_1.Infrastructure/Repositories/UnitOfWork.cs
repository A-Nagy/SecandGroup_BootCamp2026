using SecandGroup_1.Application.Abstractions.Repositories;
using SecandGroup_1.Domain.Entities;
using SecandGroup_1.Infrastructure.Data;

namespace SecandGroup_1.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

     

        public IEmployeeRepository          Employees { get; }

        public IRepository<Department>      Departments { get; }

        public IRepository<Category>        Categories { get; }

        public IRepository<Permission>      Permissions { get; }

        public IRepository<Role>            Roles { get; }

        public IRepository<User>            Users { get; }

        public IRepository<Product>         Products { get; }
       
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Employees    = new EmployeeRepository(_context);
            Departments  = new Repository<Department>(_context);
            Categories   = new Repository<Category>(_context);
            Permissions  = new Repository<Permission>(_context);
            Roles        = new Repository<Role>(_context);
            Users        = new Repository<User>(_context);
            Products     = new Repository<Product>(_context);

        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
