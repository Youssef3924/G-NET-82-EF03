using G_NET_82_EF03.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public string Title { get; set; } =null!;

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public CourseLevel Level { get; set; }

        public bool IsPublished { get; set; }

        public DateTime? PublishedAt { get; set; }

        [InverseProperty(nameof(Enrollment.course))]
        public ICollection<Enrollment>?EnrollmentsOfCourse=new HashSet<Enrollment>();

        public int InstructorID { get; set; }
        [InverseProperty(nameof(Instructor.Courses))]
        public Instructor instructor { get; set; } = null!; 
    }
}
