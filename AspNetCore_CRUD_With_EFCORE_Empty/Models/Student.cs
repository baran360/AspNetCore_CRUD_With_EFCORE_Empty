using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCore_CRUD_With_EFCORE_Empty.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Student name is required.")]
        [DisplayName("Name")]
        public string? StudentName { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [DisplayName("Department")]
        public string? Department { get; set; }

        [Required(ErrorMessage = "Student age is required.")]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "Student number is required.")]
        [DisplayName("Number")]
        public string? StudentNumber { get; set; }
    }
}