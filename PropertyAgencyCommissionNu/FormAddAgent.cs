using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu
{
    public partial class FormAddAgent : Form
    {
        public UcInsertCommission formInsertComm;
        public FormAddAgent()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) {
            Agent agent = new Agent(Connection.Instance.GetAgentData(comboBoxAddAgentAgentName.SelectedItem.ToString(), TempData.Name));
            
            formInsertComm.AddAgent(agent);

            this.Close();
        }

        private void FormAddAgent_Load(object sender, EventArgs e) {
            comboBoxAddAgentAgentName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames(), formInsertComm.GetAgentNames());
        }

        private void comboBoxAddAgentAgentName_SelectedIndexChanged(object sender, EventArgs e) {
            labelBranchName.Text = Connection.Instance.GetBranchNameFromID(Connection.Instance.GetBranchIDFromAgentID(Connection.Instance.GetAgentID(comboBoxAddAgentAgentName.SelectedItem.ToString())));
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
