using System.ComponentModel.DataAnnotations;

namespace SecandGroup_1.Models
{
    public class Employee
    {
        //Data Annotations
        //this Library is used to add metadata to the class properties, such as validation rules like Constraint in Database.

        [Key]//Primary Key
        //key attribute is used to specify the primary key of the entity.
        //It indicates that the property it decorates is the unique identifier for instances of the class.
        public int Id { get; set; }
        [Required]//Required attribute is used to specify that a property is mandatory and cannot be null or empty.
                  //not null constraint in database
                  //string.empty is used to initialize the property with an empty string, ensuring that it is not null.
        [StringLength(200,ErrorMessage ="The Maximum Length of The Name IS 200 Characters")] //StringLength attribute is used to specify the maximum length of a string property.
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress(ErrorMessage ="Pls Write The Email Like Example@XXX.com")]//EmailAddress attribute is used to validate that the property contains a valid email address format.
        public string Email { get; set; } = "";
        [Required]
        [Range(3000, 10000, ErrorMessage = "Salary Must Be Between 3000 and 10000 SR")]//Range attribute is used to specify the valid range of values for a numeric property.
        public decimal Salary { get; set; }
        // ?  is used to indicate that the property is nullable, meaning it can have a value or be null.
        [StringLength(11)]
        public string? Phone { get; set; }
        public string? Address { get; set; }

    }
}
