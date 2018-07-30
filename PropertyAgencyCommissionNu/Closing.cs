using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyAgencyCommissionNu {
    public class ClosingProperty {
        public int id;
        public DateTime DateClosed;
        public string ClosingType;
        public double TotalNominal;

        public ClosingProperty() {

        }

        public ClosingProperty(DateTime dateClosed, string closingType, double totalNominal) {
            DateClosed = dateClosed;
            ClosingType = closingType;
            TotalNominal = totalNominal;
        }

        public ClosingProperty(object[] data) {
            id = (int)data[0];
            DateClosed = DateTime.Parse(data[1].ToString());
            ClosingType = data[2].ToString();
            TotalNominal = (double)data[3];
        }

        public object[] GetClosingData() {
            return new object[] {DateClosed, ClosingType, TotalNominal};
        }
    }
}

public enum TypeOfClosing {
    Property,
    Loan
}
