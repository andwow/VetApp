using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetApp.Models
{
    public class Pet : ModelBase
    {
        public Pet()
        {

        }
        public Pet(Pet pet)
        {
            Id = pet.id;
            PersonalCode = pet.PersonalCode;
            Name = pet.Name;
            Birthday = pet.Birthday;
            Gender = pet.Gender;
            Species = pet.Species;
            Breed = pet.Breed;
            Color = pet.Color;
            Marks = pet.Marks;
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
        public string PersonalCode
        {
            get
            {
                return personalCode;
            }
            set
            {
                personalCode = value;
                NotifyPropertyChanged(nameof(PersonalCode));
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
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
                NotifyPropertyChanged(nameof(Birthday));
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                NotifyPropertyChanged(nameof(Gender));
            }
        }
        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
                NotifyPropertyChanged(nameof(Species));
            }
        }
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
                NotifyPropertyChanged(nameof(Breed));
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
                NotifyPropertyChanged(nameof(Color));
            }
        }
        public string Marks
        {
            get
            {
                return marks;
            }
            set
            {
                marks = value;
                NotifyPropertyChanged(nameof(Marks));
            }
        }
        public string BirthdayString
        {
            get
            {
                return birthday.Date.ToString(@"dd.MM.yyyy");
            }
            set
            {
                birthday = DateTime.ParseExact(value, @"dd.MM.yyyy", provider);
                NotifyPropertyChanged(nameof(Birthday));
            }
        }
        private int id;
        private string personalCode;
        private string name;
        private DateTime birthday;
        private string gender;
        private string species;
        private string breed;
        private string color;
        private string marks;
        CultureInfo provider = CultureInfo.InvariantCulture;
    }
}
