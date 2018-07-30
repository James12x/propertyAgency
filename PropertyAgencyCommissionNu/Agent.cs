using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class Agent {
        private string iD;
        private string name;
        private string email;
        private string phoneNumber;
        private int status;
        private DateTime dateJoined;
        private string branchID;
        private string uplineID;

        public string ID {
            get {
                return iD;
            }

            set {
                iD = value;
            }
        }

        public string Name {
            get {
                return name;
            }

            set {
                name = value;
            }
        }

        public string Email {
            get {
                return email != "" ? email : null;
            }

            set {
                email = value;
            }
        }

        public string PhoneNumber {
            get {
                return phoneNumber;
            }

            set {
                phoneNumber = value;
            }
        }

        public int Status {
            get {
                return status;
            }

            set {
                status = value;
            }
        }

        public DateTime DateJoined {
            get {
                return dateJoined;
            }

            set {
                dateJoined = value;
            }
        }

        public string BranchID {
            get {
                return branchID != "" ? branchID : null;
            }

            set {
                branchID = value;
            }
        }

        public string UplineID {
            get {
                return uplineID != "" ? uplineID : null;
            }

            set {
                uplineID = value;
            }
        }

        public Agent() {
            Status = 1;
        }

        public Agent(object[] data) {
            ID = data[0].ToString();
            Name = data[1].ToString();
            Email = data[2].ToString();
            PhoneNumber = data[3].ToString();
            Status = (Int16)data[4];
            DateJoined = DateTime.Parse(data[5].ToString());
            BranchID = data[6].ToString();
            UplineID =data[7].ToString();
        }

        public Agent(string id, string name, string email, string phoneNumber, DateTime dateJoined, string branchID, string uplineID) {
            ID = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Status = 1;
            DateJoined = dateJoined;
            BranchID = branchID;
            UplineID = uplineID;
        }

        public Agent(string[] data) {
            ID = data[0];
            Name = data[1];
            Email = data[2];
            Status = 1;
            PhoneNumber = data[4];
            DateJoined = DateTime.Parse(data[5]);
            BranchID = data[6];
            UplineID = data[7];
        }

        public object[] GetAgentData() {
            return new object[] { ID, Name, Email, PhoneNumber, Status, DateJoined, BranchID, UplineID };
        }
    }
}
