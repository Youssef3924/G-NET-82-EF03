using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Models
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string? Bio { get; set; }

        public DateTime JoinedAt { get; set; }


        public ICollection<Course>Courses=new HashSet<Course>();

    }
}
