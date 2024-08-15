using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeindaSaid_EntityFramework_Assinment1.Entity
{
    public class Student
    {
        //Id
        public int Id { get; set; }  //Primary Key

        //FirstName
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        // LastName
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string LastName { get; set; }

        //Address
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Address { get; set; }

        //Age
        [Range(18, 60, ErrorMessage= "Age must be between 18 and 65.")]
        public int Age { get; set; }

        public List<Stud_Course> Stud_Course { get; set; }   // Using A Imlicit Join

        public int deptId { get; set; } // Foreign Key

        public Department Department { get; set; }
    }
}
