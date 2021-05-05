using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationCET.Models
{
    public class Student
    {
        public Student()
        {
            CreationDate = DateTime.Now;
        }

        [DisplayName("Student Id")]
        public int Id { get; set; }
        
        [DisplayName("Name")]
        [Required(ErrorMessage = "You must enter your name")]
        public string Name { get; set; }
        
        [DisplayName("Surname")]
        [Required(ErrorMessage = "You must enter your surname")]
        public string Surname { get; set; }
        
        public string? Department { get; set; }
        
        public float? Height { get; set; }
        
        public float Weight { get; set; }
        
        [DisplayName("Birth of Date")]
        [Required(ErrorMessage = "You must enter your birth of date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        
        [DisplayName("Creation of Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [DisplayName("Last Updated")]
        public DateTime LastUpdate { get; set; }


    }
}
