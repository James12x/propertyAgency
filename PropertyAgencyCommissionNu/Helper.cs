using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu {
    public static class Helper {

        public static string Upline1 = "Upline1";
        public static string Upline2 = "Upline2";
        public static string Upline3 = "Upline3";
        public static string Principal = "Principal";
        public static string VicePrincipal = "ViceP";

        /// <summary>
        /// Extension Method for setting combobox autofill data
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="data"></param>
        public static void GetComboBoxAutoFillData(this ComboBox comboBox, string[] data) {
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            List<string> temp = data.ToList();

            comboBox.DataSource = data.ToList();
            if (data.Length > 0) {
                comboBox.SelectedItem = data[0];
            }
        }

        /// <summary>
        /// Extension Method for setting combobox autofill data, with extra parameter 
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="data"></param>
        /// <param name="removedData"></param>
        public static void GetComboBoxAutoFillData(this ComboBox comboBox, string[] data, string[] removedData) {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            List<string> temp = data.ToList();

            for (int i = 0; i < removedData.Length; i++) {
                if (temp.Contains(removedData[i])) {
                    temp.Remove(removedData[i]);
                }
            }

            comboBox.DataSource = temp;
            if (temp.Count > 0) {
                comboBox.SelectedItem = data[0];
            }
        }

        /// <summary>
        /// Extension Method for getting the middle of a control
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public static int Middle(this Control temp) {
            return temp.Top + (temp.Height / 2);
        }

        /// <summary>
        /// Extension Method for setting the middle of a control
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="value"></param>
        public static void SetMiddle(this Control temp, int value) {
            temp.Top = value - (temp.Height / 2);
        }

        /// <summary>
        /// Extension Method for setting the right of a control
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="value"></param>
        public static void SetRight(this Control temp, int value) {
            temp.Left = value - temp.Width;
        }

        /// <summary>
        /// Extension Method for setting the bottom of a control
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="value"></param>
        public static void SetBottom(this Control temp, int value) {
            temp.Top = value - temp.Height;
        }
    }

    /// <summary>
    /// Helper Class for Inserting Commission
    /// </summary>
    public class ParticipatingAgents {
        public Agent agent;
        public TextBoxNumeric unit;
        public MyTextBox nominal;
        public ParticipatingAgents() {

        }
        public ParticipatingAgents(Agent agent) {
            this.agent = agent;
        }
    }
}
