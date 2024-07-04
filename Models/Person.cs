using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get;  set; }
        [Required]
        [DisplayName("Date of Birth")]
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public string Address { get; set; }
        [DisplayName("Profile Picture")]
        [ValidateNever]
        public string ProfilePicture { get; set; }

        public Person(string FirstName, string LastName, DateOnly DateOfBirth, string Address, string ProfilePicture)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.ProfilePicture = ProfilePicture;
        }

        public Person(int Id, string FirstName, string LastName, DateOnly DateOfBirth, string Address, string ProfilePicture)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;
            this.ProfilePicture = ProfilePicture;
        }

        public Person()
        {
            
        }


    }
}
