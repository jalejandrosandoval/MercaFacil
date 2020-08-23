using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentForm
{
    class ShoppingCart
    {
        public Product Product { get; set; }
        public int Unitary { get { return Product.Price; } }
        public int Quantity { get; set; }
        public int Iva { get; set; }
        public int TotalPrice { get; set; }        

        
        public override string  ToString()
        {
            return Product.Name.ToString();            
        }
    }
}
