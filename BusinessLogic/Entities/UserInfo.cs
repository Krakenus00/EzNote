﻿using System;
using DomainLibrary.Infrastucture.Enums;

namespace BusinessLogic.Entities
{
    public class UserInfo
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public GenderEnum.TypeOfGender Gender { get; set; }
        public bool Role { get; set; }
        //TODO: public Country _country { get; set; }
    }
}