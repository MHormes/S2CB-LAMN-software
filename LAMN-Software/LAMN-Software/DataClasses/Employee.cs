using System;

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


        public Employee(string firstName, string secondName, string username, string bsn, DateTime dateOfBirth, string phoneNumber, string email, string iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation, string quittinReason)
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
            ContractEnding = contractEnding;
            AddInformation = addInformation;
            QuittingReason = quittinReason;
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName}. BSN:{Bsn}. Position:{Position.ToString()}";
        }
    }
}
