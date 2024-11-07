using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        /*
        int x; //field
        public int y { get; set; } //property

        void Method1() 
        {
            int z; //local variable
        }
        */

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public virtual  List<Product> Products { get; set; }
    }
}
