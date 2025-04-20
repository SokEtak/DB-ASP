using System.ComponentModel.DataAnnotations;

namespace DatabaseASP.NETWeb.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}
