using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stoke { get; set; }
        public long Price { get; set; }
    }
    public class CreateProductDto
    {
        public string Name { get; set; }
        public int Stoke { get; set; }
        public long Price { get; set; }
    }
}
