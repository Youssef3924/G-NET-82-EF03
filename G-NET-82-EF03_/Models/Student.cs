using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Models
{
    internal class Student
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly DateOfBirth { get; set; }
        public ICollection<Enrollment>? EnrollmentsOfStudent = new HashSet<Enrollment>();

    }
}
