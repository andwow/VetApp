using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetApp.Models;

namespace VetApp.ViewModels
{
    public class MainMenuVM
    {
        internal MainMenuVM(User user)
        {
            ConnectedUser = user;
        }
        public User ConnectedUser { get; }
    }
}
