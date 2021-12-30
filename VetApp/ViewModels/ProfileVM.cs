using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    internal class ProfileVM
    {
        public ProfileVM(User user)
        {
            CurrentUser = user;
        }

        public User CurrentUser { get; }

    }
}
