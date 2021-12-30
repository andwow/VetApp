using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class User : ModelBase
    {
        public User() { }
        public User(User user)
        {
            Id = user.Id;
            Cnp = user.Cnp;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Password = user.Password;
            IsVet = user.IsVet;
            Phone = user.Phone;
            Country = user.Country;
            District = user.District;
            City = user.City;
            Address = user.Address;
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
        public string Cnp
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
                NotifyPropertyChanged(nameof(Cnp));
            }
        }
        public string FirstName 
        {
            get 
            {
                return firstName;
            }
            set
            {
                firstName = value;
                NotifyPropertyChanged(nameof(FirstName));
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                NotifyPropertyChanged(nameof(LastName));
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                NotifyPropertyChanged(nameof(Email));
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }
        public bool IsVet
        {
            get
            {
                return isVet;
            }
            set
            {
                isVet = value;
                NotifyPropertyChanged(nameof(IsVet));
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                NotifyPropertyChanged(nameof(Phone));
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                NotifyPropertyChanged(nameof(Country));
            }
        }
        public string District
        {
            get
            {
                return district;
            }
            set
            {
                district = value;
                NotifyPropertyChanged(nameof(District));
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                NotifyPropertyChanged(nameof(City));
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                NotifyPropertyChanged(nameof(Address));
            }
        }

        int id;
        string cnp;
        string firstName;
        string lastName;
        string email;
        string password;
        bool isVet;
        string phone;
        string country;
        string district;
        string city;
        string address;

    }
}
