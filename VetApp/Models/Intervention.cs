using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class Intervention : ModelBase
    {
        public int Pet
        {
            get
            {
                return pet;
            }
            set
            {
                pet = value;
                NotifyPropertyChanged(nameof(Pet));
            }
        }
        public int Vet
        {
            get
            {
                return vet;
            }
            set
            {
                vet = value;
                NotifyPropertyChanged(nameof(Vet));
            }
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
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged(nameof(Date));
            }
        }
        public string DateString
        {
            get
            {
                if (NextDate != null)
                {
                    return date.Date.ToString(@"dd.MM.yyyy");
                }
                return "";
            }
        }
        public DateTime NextDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged(nameof(Date));
            }
        }
        public string NextDateString
        {
            get
            {
                if (NextDate != null)
                {
                    return nextDate.Date.ToString(@"dd.MM.yyyy");
                }
                return "";
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


        int pet;
        int vet;
        int id;
        string name;
        int type;
        DateTime date;
        DateTime nextDate;
        double price;
    }
}
