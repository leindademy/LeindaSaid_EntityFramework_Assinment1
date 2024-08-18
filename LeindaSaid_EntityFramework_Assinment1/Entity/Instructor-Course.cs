using Microsoft.EntityFrameworkCore;
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
    [PrimaryKey(nameof(InstructorId), nameof(CourseId))] //Composite key

    public class Instructor_Course
    { 

        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
       
        [Range(0, 50, ErrorMessage = " This Evaluation Must be Between 0 and 50.")]
        public int Evaluation { get; set; }   

    }
}
