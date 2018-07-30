using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu
{
    public partial class UcSetting : UserControl
    {
        public static UcSetting _instance;
        public static UcSetting Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcSetting();
                return _instance;
            }
        }

        public UcSetting()
        {
            InitializeComponent();

            FillCurrentValue();
        }
        /// <summary>
        /// fill the current commission level value
        /// </summary>
        void FillCurrentValue() {
            textBoxUpline1.Text = Connection.Instance.GetCommissionLevelValue(Helper.Upline1).ToString();
            textBoxUpline2.Text = Connection.Instance.GetCommissionLevelValue(Helper.Upline2).ToString();
            textBoxUpline3.Text = Connection.Instance.GetCommissionLevelValue(Helper.Upline3).ToString();
            textBoxPrincipal.Text = Connection.Instance.GetCommissionLevelValue(Helper.Principal).ToString();
            textBoxVicePrincipal.Text = Connection.Instance.GetCommissionLevelValue(Helper.VicePrincipal).ToString();
        }

        private void buttonClearCommissionValue_Click(object sender, EventArgs e) {
            FillCurrentValue();
        }
        /// <summary>
        /// set the commission level value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCommissionValue_Click(object sender, EventArgs e) {
            Connection.Instance.SetCommissionLevelValue(Helper.Upline1, double.Parse(textBoxUpline1.Text));
            Connection.Instance.SetCommissionLevelValue(Helper.Upline2, double.Parse(textBoxUpline2.Text));
            Connection.Instance.SetCommissionLevelValue(Helper.Upline3, double.Parse(textBoxUpline3.Text));
            Connection.Instance.SetCommissionLevelValue(Helper.Principal, double.Parse(textBoxPrincipal.Text));
            Connection.Instance.SetCommissionLevelValue(Helper.VicePrincipal, double.Parse(textBoxVicePrincipal.Text));

            MessageBox.Show("Commission Level Value saved");
        }
    }
}
