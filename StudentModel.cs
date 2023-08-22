using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace College.Models

{
    public class StudentModel
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public  string StudentID { get; set; }
        [Required]
        public string StudentName { get; set; }
       
        [Required]
        public string  Department { get; set; }


        [Required]
        [Range(0, 10)]
        public int Cgpa { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set;}
        [Required]
        [Phone]
        public string StudentPhone { get; set;}
    }
    
}
