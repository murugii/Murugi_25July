using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Murugi_25July.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string Role { get; set; }
        public string ResetPasswordCode { get; set; }
        public string ConfirmPassword { get; set; }
        public string Phone { get; set; }
    }
}