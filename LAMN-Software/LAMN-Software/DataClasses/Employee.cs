﻿using System;
using System.Text.RegularExpressions;

namespace LAMN_Software
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Username { get; set; }
        public string Bsn { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string IceNumber { get; set; }
        public ICERelation IceRelationship { get; set; }
        public JobPosition Position { get; set; }
        public DateTime ContractEnding { get; set; }
        public string AddInformation { get; set; }
        public string QuittingReason { get; set; }
        public double SalaryPerHour { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string ContractType { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; }
        public string Nationality { get; set; }
        public double FTE { get; set; }
        private string fullName;

        public Employee(string firstName, string secondName, string username, string bsn, DateTime dateOfBirth, string phoneNumber, string email, string iceNumber, ICERelation iceRelationship, JobPosition position, string addInformation, string quittingReason, double salaryPerHour, DateTime startingDate, DateTime endingDate, string contractType, string gender, string degree, string nationality)
        {
            FirstName = firstName;
            SecondName = secondName;
            Username = username;
            Bsn = bsn;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Email = email;
            IceNumber = iceNumber;
            IceRelationship = iceRelationship;
            Position = position;
            AddInformation = addInformation;
            fullName = FirstName + " " + SecondName;
            QuittingReason = quittingReason;
            SalaryPerHour = salaryPerHour;
            StartingDate = startingDate;
            EndingDate = endingDate;
            ContractType = contractType;
            Gender = gender;
            Degree = degree;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}. BSN:{Bsn}. Position:{Position.ToString()}";
        }

        public string GetFullName()
        {
            return fullName;
        }
    }
}
