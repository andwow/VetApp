using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class Items : ModelBase
    {
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
        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                NotifyPropertyChanged(nameof(ProductId));
            }
        }
        public int InterventionId
        {
            get
            {
                return interventionId;
            }
            set
            {
                interventionId = value;
                NotifyPropertyChanged(nameof(InterventionId));
            }
        }
        int id;
        string name;
        int type;
        double quantity;
        double price;
        int productId;
        int interventionId;
    }
}
