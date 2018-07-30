using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class PrincipalAndVice {
        public DateTime DateSelected;
        public string AgentID;
        public string BranchID;
        

        public PrincipalAndVice(object[] data) {
            DateSelected = DateTime.Parse(data[0].ToString());
            AgentID = data[1].ToString();
            BranchID = data[2].ToString();
        }

        public PrincipalAndVice() {
            AgentID = "";
            BranchID = "";
        }

        public object[] GetPrincipalOrViceData() {
            return new object[] { DateSelected.ToString(), AgentID, BranchID };
        }
    }
}
