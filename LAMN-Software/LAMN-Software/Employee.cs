﻿using System;

namespace LAMN_Software
{
    public class Employee
    {
        private string firstName;
        private string secondName;
        private int bsn;
        private DateTime dateOfBirth;
        private int phoneNumber;
        private int iceNumber;
        private ICERelation iceRelationship;
        private JobPosition position;
        private DateTime contractEnding;
        private string addInformation;

        public int Bsn
        {
            get { return bsn; }
            set { bsn = value; }
        }

        public Employee(string firstName, string secondName, int bsn, DateTime dateOfBirth, int phoneNumber, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.bsn = bsn;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.iceNumber = iceNumber;
            this.iceRelationship = iceRelationship;
            this.position = position;
            this.contractEnding = contractEnding;
            this.addInformation = addInformation;
        }
    }
}
