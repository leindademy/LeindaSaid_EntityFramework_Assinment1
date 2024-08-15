using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_EntityFramework_Assinment1.Entity
{
    public class Department
    {
        //Id
        public int Id { get; set; } //primary key

        //Name 
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }


        //HiringDate
        [DataType(DataType.Date)]
        public string HiringDate { get; set; }
        public int Ins_ID { get; set; } // Foreign Key
        public List<Instructor> Instructors { get; set; }
        public List<Student> Students { get; set; }


    }
}
