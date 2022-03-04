﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_Registration_Regex_Unit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationPattern userRegistrationPattern = new UserRegistrationPattern();
            string[] checkingFirstNames = { "Prem",  "Prem" };
            string[] checkingLastNames = { "Kumar",  "Kumar" };
            string[] checkingEMails = { "abc@bl.co", "abc.xyz@bl.co", "abc.xyz@bl.co.in", "abc.@bl.co" };
            string[] checkingNo = { "91 7981587635", "917730002849", "910720659414", "9172065941491" };
            string[] checkingPassword = { "222", "917206594149", "910720659414", "91Ab0659c1491" };
            userRegistrationPattern.ValidateFirstName(checkingFirstNames);
            userRegistrationPattern.ValidatelastName(checkingLastNames);
            userRegistrationPattern.ValidateeMail(checkingEMails);
            userRegistrationPattern.ValidateMobileNo(checkingNo);
            userRegistrationPattern.ValidatePassword(checkingPassword);
        }
    }
}