using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    class Sale : Items
    {
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
        DateTime date;
        CultureInfo provider = CultureInfo.InvariantCulture;
    }
}
