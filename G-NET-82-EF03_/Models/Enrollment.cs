using G_NET_82_EF03.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Models
{
    internal class Enrollment
    {
        public int StudentId { get; set; }
        public Student student { get; set; } = null!;
        public int CourseId { get; set; }
        public Course course { get; set; } = null!;
        public DateTime EnrollmentDate { get; set; }

        public decimal ProgressPercentage { get; set; }

        public EnrollmentStatus Status { get; set; }
            = EnrollmentStatus.Active;

        public decimal? FinalGrade { get; set; }



    }
}
