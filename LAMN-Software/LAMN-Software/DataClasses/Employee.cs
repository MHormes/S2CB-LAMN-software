using System;

namespace LAMN_Software
{
    public class Employee
    {
        private string firstName;
        private string secondName;
        private string username;
        private int bsn;
        private DateTime dateOfBirth;
        private int phoneNumber;
        private string email;
        private int iceNumber;
        private ICERelation iceRelationship;
        private JobPosition position;
        private DateTime contractEnding;
        private string addInformation;
        private string quittingReason;

        public int Bsn
        {
            get { return bsn; }
            set { bsn = value; }
        }

        public Employee(string firstName, string secondName, string username, int bsn, DateTime dateOfBirth, int phoneNumber, string email, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation, string quittingReason)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.username = username;
            this.bsn = bsn;
            this.dateOfBirth = dateOfBirth;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.iceNumber = iceNumber;
            this.iceRelationship = iceRelationship;
            this.position = position;
            this.contractEnding = contractEnding;
            this.addInformation = addInformation;
            this.quittingReason = quittingReason;
        }
    }
}
