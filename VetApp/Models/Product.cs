using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class Product : ModelBase
    {
        public Product() { }
        public Product(Product product)
        {
            Id = product.Id;
            ProductCode = product.ProductCode;
            Name = product.Name;
            Type = product.Type;
            Price = product.Price;
            Quantity = product.Quantity;
        }
        public int Id 
        {
            get
            {
                return id;
            }
            set 
            { 
                id = value;
                NotifyPropertyChanged(nameof(Id));
            }
        }
        public string ProductCode 
        { 
            get
            {
                return productCode;
            }
            set
            {
                productCode = value;
                NotifyPropertyChanged(nameof(ProductCode));
            } 
        }
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            set
            {
                name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }
        public int Type 
        { 
            get
            {
                return type;
            }
            set
            {
                type = value;
                NotifyPropertyChanged(nameof(Type));
            }
        }
        public double Price 
        { 
            get 
            { 
                return price; 
            }
            set
            {
                price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }
        public double Quantity 
        { 
            get
            {
                return quantity;
            } 
            set
            {
                quantity = value;
                NotifyPropertyChanged(nameof(Quantity));
            }
        }

        int id;
        string productCode;
        string name;
        int type;
        double price;
        double quantity;
    }
}
