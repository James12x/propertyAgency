using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class Commission {
        public string CommissionLevel;
        public double CommissionLevelValue;
        public double CommissionNominal;
        public string AgentID;
        public int ClosingID;
        public string AgentClosingID;

        public Commission() {

        }

        public Commission(object[] data) {
            CommissionLevel = data[1].ToString();
            CommissionLevelValue = (double)data[2];
            CommissionNominal = (double)data[3];
            AgentID = data[4].ToString();
            ClosingID = (int)data[5];
            AgentClosingID = data[6].ToString();
        }

        public Commission(string level, int commissionLevelValue, double nominal, string agentId, int closingId, string agentClosingID) {
            CommissionLevel = level;
            CommissionLevelValue = commissionLevelValue;
            CommissionNominal = nominal;
            AgentID = agentId;
            ClosingID = closingId;
            AgentClosingID = agentClosingID;
        }
        
        public object[] GetCommissionData() {
            return new object[] {CommissionLevel, CommissionLevelValue, CommissionNominal, AgentID, ClosingID, AgentClosingID };
        }
    }
}


