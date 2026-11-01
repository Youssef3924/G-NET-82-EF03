using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_82_EF03.Models
{
    internal class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } =null!;

        public string? Description { get; set; }

        public ICollection<Category> SubCategories { get; set; }=new HashSet<Category>();
         
        public int ParentID { get; set; }
        public Category? ParentCategory { get; set; }


    }
}
