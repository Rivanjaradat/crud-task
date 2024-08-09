using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_task.models
{
    internal class Order
    {
        public int Id { get; set; }
        public string adress { get; set; }
        public DateTime createdAt { get; set; }
        public override string ToString()
        {
            return ($"Id:{Id}, address: {adress}, data:{createdAt}");
        }

    }
}
