using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAMN_Software.DataClasses
{
    public class EmployeeChange
    {
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Username { get; private set; }
        public string Bsn { get; private set; }
        public string PhoneNumber { get; private set; }

        public string IceNumber { get; private set; }
        public ICERelation IceRelationship { get; private set; }


        public EmployeeChange(string bsn, string username, string firstName, string secondName, string phoneNumber, string iceNumber, ICERelation iceRelationship)
        {
            FirstName = firstName;
            SecondName = secondName;
            Username = username;
            Bsn = bsn;
            PhoneNumber = phoneNumber;
            IceNumber = iceNumber;
            IceRelationship = iceRelationship;
        }

    }
}
