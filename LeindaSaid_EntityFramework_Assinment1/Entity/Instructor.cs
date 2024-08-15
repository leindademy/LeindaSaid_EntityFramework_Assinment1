using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_EntityFramework_Assinment1.Entity
{
    public class Instructor
    {

        public List<Course> Courses { get; set; }

        public int deptId { get; set; }

        public Department department { get; set; }
        //Id
        public int Id { get; set; } // primary key

        //Name 
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        //Bouns 
        [DataType(DataType.Currency)]
        public int Bouns { get; set; }

        //salary
        [DataType(DataType.Currency)]
        public int salary { get; set; }

        // Address
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Address { get; set; }

        //Hourdate
        
        public int Hourrate { get; set; }












    }
}
