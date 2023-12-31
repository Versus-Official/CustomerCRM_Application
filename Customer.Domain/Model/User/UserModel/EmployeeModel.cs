﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Model.User.UserModel
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string AccountType { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
