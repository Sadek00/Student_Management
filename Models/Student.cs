using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Quad_StudentManagement.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Gender { get; set; }
        public DateTime DOB { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        [ValidateNever]
        public Class Class { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}
