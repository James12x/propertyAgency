using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class Branch {
        public string ID;
        public string Name;
        public string Address;
        public string City;

        public Branch() {

        }

        public Branch(string id, string name, string address, string city) {
            ID = id;
            Name = name;
            Address = address;
            City = city;
        }

        public Branch(object[] data) {
            ID = data[0].ToString();
            Name = data[1].ToString();
            Address = data[2].ToString();
            City = data[3].ToString();
        }

        public object[] GetBranchData() {
            return new object[] { ID, Name, Address, City};
        }
    }
}
