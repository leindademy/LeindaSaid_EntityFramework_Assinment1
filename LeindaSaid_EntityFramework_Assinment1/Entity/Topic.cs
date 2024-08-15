using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeindaSaid_EntityFramework_Assinment1.Entity
{
    public class Topic

    {
        public string CourseName { get; set; }
        //Id
        public int Id { get; set; } //Primary Key

        //Name
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
        public string Name { get; set; }


    }
}
