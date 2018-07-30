using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeGenerator;

namespace PropertyAgencyCommissionNu {
    public partial class UcReport : UserControl {

        public static UcReport _instance;
        public static UcReport Instance {
            get {
                if (_instance == null)
                    _instance = new UcReport();
                return _instance;
            }
        }
        public UcReport() {
            InitializeComponent();
        }

        /// <summary>
        /// hide all panel
        /// </summary>
        void HideAll() {
            panelTree.Hide();
            panelShowSpecificClosing.Hide();
            panelAgentsClosingByUnit.Hide();
            panelShowCommissionSummary.Hide();
        }

        /// <summary>
        /// show the agency tree
        /// </summary>
        public void ShowTree() {
            HideAll();
            panelTree.Show();
            panelTree.Location = new Point(0, 0);

            Agent[] agents = Connection.Instance.GetAgentDatas();
            

            TreeData.TreeDataTableDataTable dtTree = new TreeData.TreeDataTableDataTable();


            for (int i = 0; i < agents.Length; i++) {
                string status = "";

                string pOrVp = "";

                if(agents[i].ID == Connection.Instance.GetPrincipalOrViceDataFromBranchID(agents[i].BranchID, PrincipalOrVice.Principal)[1].ToString()) {
                    pOrVp = "P";
                }else if(agents[i].ID == Connection.Instance.GetPrincipalOrViceDataFromBranchID(agents[i].BranchID, PrincipalOrVice.VicePrincipal)[1].ToString()) {
                    pOrVp = "VP";
                }

                if (agents[i].Status == 0) {
                    status = "(disabled)";
                } else {
                    status = "(active)";
                }
                dtTree.AddTreeDataTableRow(agents[i].ID, agents[i].UplineID, agents[i].Name + "\n Branch : " + agents[i].BranchID + "\n\n" + status + " \n\n" + pOrVp, "");
            }
            
            TreeBuilder myTree = new TreeBuilder(dtTree);


            myTree.BoxHeight = 100;
            myTree.BoxWidth = 200;

            Image temp = Image.FromStream(
            myTree.GenerateTree("Elton",
            System.Drawing.Imaging.ImageFormat.Bmp));

            pictureBoxTree.Size = temp.Size;
            pictureBoxTree.Image = temp;
        }

        /// <summary>
        /// show the specific closing
        /// </summary>
        public void ShowSpecificClosing() {
            HideAll();
            panelShowSpecificClosing.Show();
            panelShowSpecificClosing.Location = new Point(0, 0);
            
            comboBoxClosingID.GetComboBoxAutoFillData(Connection.Instance.GetClosingPropertyIDs());
        }

        /// <summary>
        /// generete the closing view
        /// </summary>
        /// <param name="closing"></param>
        void GenerateTree(ClosingProperty closing) {
            treeViewSpecificClosing.Nodes.Clear();
            TreeNode tNode;

            tNode = treeViewSpecificClosing.Nodes.Add("Closing ID : " + closing.id + " (Total Nominal : Rp " +
                    closing.TotalNominal + ") | Type : " + closing.ClosingType);

            AgentClosing[] agents = Connection.Instance.GetAgentClosingDataFromClosingData(closing.id.ToString());

            for(int i = 0; i < agents.Length; i++) {
                treeViewSpecificClosing.Nodes[0].Nodes.Add(i + ". " + agents[i].AgentID + " (Rp " + agents[i].Nominal + ") - " + agents[i].Unit + " units");

                Commission[] commissions = Connection.Instance.GetCommissionDataFromAgentAndClosing(agents[i].AgentID, agents[i].ClosingID);

                for(int j = 0; j < commissions.Length; j++) {
                    treeViewSpecificClosing.Nodes[0].Nodes[i].Nodes.Add(commissions[j].CommissionLevel + " : " +
                            commissions[j].AgentID + " (Rp " + commissions[j].CommissionNominal + ") Level : " + commissions[j].CommissionLevelValue);
                }
            }
            treeViewSpecificClosing.ExpandAll();
        }

        /// <summary>
        /// show agents closing summary
        /// </summary>
        public void ShowAgentClosingSummary() {
            HideAll();
            panelAgentsClosingByUnit.Show();
            panelAgentsClosingByUnit.Location = new Point(0, 0);

            FillTable();
        }

        /// <summary>
        /// helper class for filling the anget closing summary table
        /// </summary>
        class tempAgentData{
            public string id;
            public double nominal;
            public int count;
            public double units;

            public tempAgentData(string id) {
                this.id = id;
                nominal = 0;
                count = 0;
                units = 0;
            }
        }

        /// <summary>
        /// fill the table with summary of the agent closing
        /// </summary>
        void FillTable() {
            dataGridViewClosingCount.Rows.Clear();

            List<tempAgentData> result = new List<tempAgentData>();
            string[] agentids = Connection.Instance.GetAgentIDs();
            for(int i = 0; i < agentids.Length; i++) {
                result.Add(new tempAgentData(agentids[i]));
            }

            ClosingProperty[] closings = Connection.Instance.GetClosingDataInPeriod(dateTimePickerFrom2.Value, dateTimePickerTo2.Value);
            for (int i = 0; i < closings.Length; i++) {
                AgentClosing[] agents = Connection.Instance.GetAgentClosingDataFromClosingData(closings[i].id.ToString());
                for (int j = 0; j < agents.Length; j++) {
                   for(int k = 0; k < result.Count; k++) {
                        if(result[k].id == agents[j].AgentID) {
                            result[k].count++;
                            result[k].nominal += agents[j].Nominal;
                            result[k].units += agents[j].Unit;
                            break;
                        }
                    }
                   
                }
            }
            for(int i = 0; i < result.Count; i++) {
                dataGridViewClosingCount.Rows.Add(result[i].id, Connection.Instance.GetAgentName(result[i].id), result[i].count, result[i].units, result[i].nominal); 
            }
        }

        private void buttonGoTable_Click(object sender, EventArgs e) {
            FillTable();
        }
        /// <summary>
        /// show commission summary
        /// </summary>
        public void ShowCommissionSummary() {
            HideAll();
            panelShowCommissionSummary.Show();
            panelShowCommissionSummary.Location = new Point(0, 0);
        }

        /// <summary>
        /// fill the chart with commission summary
        /// </summary>
        void FillChart() {
            chartCommission.Series["Commissions"].Points.Clear();
            ClosingProperty[] closings = Connection.Instance.GetClosingDataInPeriod(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            double[] result = new double[5];
            for(int i = 0; i < closings.Length; i++) {
                AgentClosing[] agents = Connection.Instance.GetAgentClosingDataFromClosingData(closings[i].id.ToString());

                for (int j = 0; j < agents.Length; j++) {
                    Commission[] commissions = Connection.Instance.GetCommissionDataFromAgentAndClosing(agents[j].AgentID, agents[j].ClosingID);

                    for (int k = 0; k < commissions.Length; k++) {
                        result[k] += commissions[k].CommissionNominal;
                    }
                }
            }

            chartCommission.Series["Commissions"].Points.AddXY("Upline1", result[0]);
            chartCommission.Series["Commissions"].Points.AddXY("Upline2", result[1]);
            chartCommission.Series["Commissions"].Points.AddXY("Upline3", result[2]);
            chartCommission.Series["Commissions"].Points.AddXY("Principal", result[3]);
            chartCommission.Series["Commissions"].Points.AddXY("VicePrincipal", result[4]);
        }

        private void buttonGo_Click(object sender, EventArgs e) {
            FillChart();
        }

        private void comboBoxClosingID_SelectedIndexChanged_1(object sender, EventArgs e) {
            ClosingProperty globalClosing = Connection.Instance.GetClosingDataWithId(int.Parse(comboBoxClosingID.SelectedValue.ToString().TrimStart('0')));
            GenerateTree(globalClosing);
        }

        private void pictureBoxTree_Click(object sender, EventArgs e) {
            
        }
    }
}
