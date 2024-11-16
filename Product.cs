using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_student_s_grades
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}
