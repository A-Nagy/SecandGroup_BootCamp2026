namespace SecandGroup_1.Security
{
    public class PermissionsNames
    {
        public const string ClaimType = "Permission";

        //Employee
        public const string EmployeeView    = "Employees.View";
        public const string EmployeeCreate  = "Employees.Create";
        public const string EmployeeEdit    = "Employees.Edit";
        public const string EmployeeDelete  = "Employees.Delete";
        public const string EmployeeDetails = "Employees.Details";
        //Department
        public const string DepartmentView    = "Departments.View";
        public const string DepartmentCreate  = "Departments.Create";
        public const string DepartmentEdit    = "Departments.Edit";
        public const string DepartmentDelete  = "Departments.Delete";
        public const string DepartmentDetails = "Departments.Details";
        //Role
        public const string RoleView    = "Roles.View";
        public const string RoleCreate  = "Roles.Create";
        public const string RoleEdit    = "Roles.Edit";
        public const string RoleDelete  = "Roles.Delete";
        public const string RoleDetails = "Roles.Details";
        //User
        public const string UserView    = "Users.View";
        public const string UserCreate  = "Users.Create";
        public const string UserEdit    = "Users.Edit";
        public const string UserDelete  = "Users.Delete";
        public const string UserDetails = "Users.Details";
        //Permission
        public const string PermissionView    = "Permissions.View";
        public const string PermissionCreate  = "Permissions.Create";
        public const string PermissionEdit    = "Permissions.Edit";
        public const string PermissionDelete  = "Permissions.Delete";
        public const string PermissionDetails = "Permissions.Details";
        //products
        public const string ProductView    = "Products.View";
        public const string ProductCreate  = "Products.Create";
        public const string ProductEdit    = "Products.Edit";
        public const string ProductDelete  = "Products.Delete";
        public const string ProductDetails = "Products.Details";
        //Category
        public const string CategoryView    = "Categories.View";
        public const string CategoryCreate  = "Categories.Create";
        public const string CategoryEdit    = "Categories.Edit";
        public const string CategoryDelete  = "Categories.Delete";
        public const string CategoryDetails = "Categories.Details";
        //All Permissions
        public static readonly string[] All =

        {
            EmployeeView, EmployeeCreate, EmployeeEdit, EmployeeDelete, EmployeeDetails,
            DepartmentView, DepartmentCreate, DepartmentEdit, DepartmentDelete, DepartmentDetails,
            RoleView, RoleCreate, RoleEdit, RoleDelete, RoleDetails,
            UserView, UserCreate, UserEdit, UserDelete, UserDetails,
            PermissionView, PermissionCreate, PermissionEdit, PermissionDelete, PermissionDetails,
            ProductView, ProductCreate, ProductEdit, ProductDelete, ProductDetails,
            CategoryView, CategoryCreate, CategoryEdit, CategoryDelete, CategoryDetails
        };

    }
}
