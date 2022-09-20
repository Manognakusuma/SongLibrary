using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongProject.Models
{
    [Table("Users")]
    public class UserAccount
    {
        [Key]
        public string UserID { get; set; }
        [Required(ErrorMessage = "FirstName is Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName is Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "ConfirmPassword is Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password should be Same.")]
        public string ConfirmPassword { get; set; }
    }
}