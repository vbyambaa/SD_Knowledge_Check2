using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck_2
{
    public class MyMug
    {
    
        public string? Name { get; set; }
        public string? Color { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Color: {Color}, Description: {Description}";
        }
    }
}
