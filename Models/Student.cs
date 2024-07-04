
namespace Models
{
    public class Student : Person
    {
        public Student(string FirstName, string LastName, DateOnly DateOfBirth, string Address, string ProfilePicture) : base(FirstName, LastName, DateOfBirth, Address, ProfilePicture)
        {
        }
        public Student(int Id, string FirstName, string LastName, DateOnly DateOfBirth, string Address, string ProfilePicture) : base(Id, FirstName, LastName, DateOfBirth, Address, ProfilePicture)
        {
        }

        public Student()
        {
            
        }
    }
}
