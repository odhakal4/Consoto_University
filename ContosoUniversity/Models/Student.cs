using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(15,MinimumLength =1)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }
        [StringLength(15, ErrorMessage = "First name cannot be longer than 15 characters.")]
        [Required]
        [Column("First_Name")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        public string FullName
        {
            get { return LastName + "," + FirstMidName; }
        }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}