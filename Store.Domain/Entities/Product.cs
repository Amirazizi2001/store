using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stoke { get; set; }
        public long Price { get; set; }
    }
}
