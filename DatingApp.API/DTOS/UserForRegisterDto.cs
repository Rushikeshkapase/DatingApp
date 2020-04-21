using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOS
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(8), MinLength(4, ErrorMessage="You must specify password length between 4 to 8 characters")]
        public string Password {get; set;}
    }
}