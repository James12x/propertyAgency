using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class AgentClosing {
        public double Unit;
        public double Nominal;
        public string AgentID;
        public int ClosingID;

        public AgentClosing() {
            

        }
        
        public AgentClosing(double unit, double nominal, string agentID, int closingID) {
            Unit = unit;
            Nominal = nominal;
            AgentID = agentID;
            ClosingID = closingID;
        }

        public AgentClosing(object[] data) {
            Unit = (double)data[1];
            Nominal = (double)data[2];
            AgentID = data[3].ToString();
            ClosingID = (int)data[4];
        }

        public object[] GetAgentClosingData() {
            return new object[] {Unit, Nominal,AgentID, ClosingID };
        }
    }
}
