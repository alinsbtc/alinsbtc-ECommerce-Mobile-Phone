using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_Mobile_Phone.ViewModels
{
    public class LoginVM
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
