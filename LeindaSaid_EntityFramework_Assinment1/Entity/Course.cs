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
    public class Course
    {
     
        public int TopId { get; set; } // Foreign Key
        public Topic Topic { get; set; }

        //Id
        public int Id { get; set; } // Primary Key


        //Duration
        [Required]
        [Range(1, 80, ErrorMessage = " Duration must be between 1 and 80 hours.")]
        public double Duration { get; set; }

        //Name
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        //Description
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Description { get; set; }
        public List<Stud_Course> Stud_Course { get; set; }   // Using A Imlicit Join


    }
}
