using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentForm
{
    class Product
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeProduct { get; set; }
        public int Price { get; set; }
        public int Iva { get; set; }
        public int Stock { get; set; }
        public int Borrado { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
