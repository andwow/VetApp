using System;
using System.Collections.Generic;
using System.Globalization;
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
                if (Date != null)
                {
                    return date.Date.ToString(@"dd.MM.yyyy");
                }
                return "";
            }
            set
            {
                date = DateTime.ParseExact(value, @"dd.MM.yyyy", provider);
                NotifyPropertyChanged(nameof(Date));
            }
        }
        public DateTime NextDate
        {
            get
            {
                return nextDate;
            }
            set
            {
                nextDate = value;
                NotifyPropertyChanged(nameof(Date));
                NotifyPropertyChanged(nameof(DateString));
            }
        }
        public string NextDateString
        {
            get
            {
                string returnedDate = nextDate.Date.ToString(@"dd.MM.yyyy");
                if (returnedDate != "01.01.0001")
                {
                    return returnedDate;
                }
                return "";
            }
            set
            {
                nextDate = DateTime.ParseExact(value, @"dd.MM.yyyy", provider);
                NotifyPropertyChanged(nameof(NextDate));
                NotifyPropertyChanged(nameof(NextDateString));
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

        CultureInfo provider = CultureInfo.InvariantCulture;
    }
}
