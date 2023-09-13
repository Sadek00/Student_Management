using System.ComponentModel.DataAnnotations;

namespace Task_Quad_StudentManagement.Models
{
    public class Class
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}