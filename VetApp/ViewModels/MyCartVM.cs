using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    public class MyCartVM
    {
        public MyCartVM(Cart cart)
        {
            MyCart = cart;
        }
        public Cart MyCart { get; }
    }
}
