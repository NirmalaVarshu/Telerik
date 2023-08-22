using System.ComponentModel.DataAnnotations;

namespace College.Models
{
    public class ProfessorModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProfessorID { get; set; }
        [Required]
        public string ProfessorName { get; set; }

        [Required]
        public string Department { get; set; }


        [Required]
        [Range(24, 60)]
        public int Age { get; set; }
        [Required]
        public int YOE { get; set; }

        [Required]
        [EmailAddress]
        public string ProfessorEmail { get; set; }
        [Required]
        [Phone]
        public string ProfessorPhone { get; set; }
    }
}
