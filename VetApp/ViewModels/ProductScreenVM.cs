using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    internal class ProductScreenVM
    {
        public ProductScreenVM(Product product)
        {
            CurrentProduct = new Product(product);
        }
        public Product CurrentProduct 
        {
            get;
        }
    }
}
