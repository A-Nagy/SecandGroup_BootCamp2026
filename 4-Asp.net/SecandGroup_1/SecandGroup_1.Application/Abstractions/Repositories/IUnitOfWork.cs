using SecandGroup_1.Domain.Entities;

namespace SecandGroup_1.Application.Abstractions.Repositories
{
    public interface IUnitOfWork
    {
        IEmployeeRepository      Employees { get; }
        IRepository<Department>  Departments { get; }
        IRepository<Category>    Categories { get; }
        IRepository<Permission>  Permissions { get; }
        IRepository<Role>        Roles { get; }
        IRepository<User>        Users { get; }
        IRepository<Product>     Products { get; }

        int Save();


    }
}
