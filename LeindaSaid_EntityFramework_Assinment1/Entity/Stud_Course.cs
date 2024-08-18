using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_EntityFramework_Assinment1.Entity
{
    [PrimaryKey(nameof(Stud_ID), nameof(Course_ID))] //Composite key
    public class Stud_Course
    {
        public Student Student { get; set; }
        public Course Course { get; set; }

        //Stud_ID
        public int Stud_ID { get; set; } //Composite key

        //course_ID 
        
        public int Course_ID { get; set; } //Composite key

        //grade
        [Range(80, 100, ErrorMessage = " Range must be between 80 and 100 hours.")]
        public double grade { get; set; }




    }
}
