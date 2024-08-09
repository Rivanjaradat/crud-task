using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_task.models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return ($"Id:{Id}, Name: {Name}, Price: {Price}");
        }
    }
    
}
