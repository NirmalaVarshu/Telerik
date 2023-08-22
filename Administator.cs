using System.ComponentModel.DataAnnotations;

namespace College.Models
{
    public class Administator
    {
        
        [Key] public int Id { get; set; }
        [Required(ErrorMessage ="User ID is Required")]
        public string UserName { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Password { get; set; } 
    }
}
