using System;
using System.ComponentModel.DataAnnotations;

namespace CityExplorer.Model
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

       
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

       
        public Gender? Gender { get; set; }
    }
}
