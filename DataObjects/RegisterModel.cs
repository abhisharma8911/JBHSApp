using System;

namespace DataObjects
{
    public class RegisterModel
    {
        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
