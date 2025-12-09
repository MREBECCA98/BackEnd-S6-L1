using System.ComponentModel.DataAnnotations;

namespace BackEnd_S6_L1.Models.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Cognome { get; set; }
        [Required]
        public DateTime DataNascita { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
