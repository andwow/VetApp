using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class Cart : ModelBase
    {
        public Cart()
        {
            Interventions = new ObservableCollection<Intervention>();
            Items = new ObservableCollection<Items>();
        }
        public ObservableCollection<Intervention> Interventions { get; }
        public ObservableCollection<Items> Items { get; }

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = value;
            }
        }
        public string TotalPriceString
        {
            get
            {
                return totalPrice.ToString();
            }
            set
            {
                totalPrice = double.Parse(value);
            }
        }

        double totalPrice;
    }
}
