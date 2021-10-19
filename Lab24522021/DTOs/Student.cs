using System.ComponentModel.DataAnnotations;

namespace Licenta.Controllers
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Range(5, 99)]
        public int Age { get; set; }
    }
}