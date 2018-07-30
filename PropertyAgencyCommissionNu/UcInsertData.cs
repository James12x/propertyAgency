using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Bunifu.Framework.UI;

namespace PropertyAgencyCommissionNu {
    public partial class UcInsertData : UserControl {
        public static UcInsertData _instance;
        public static UcInsertData Instance {
            get {
                if (_instance == null)
                    _instance = new UcInsertData();
                return _instance;
            }
        }


        public UcInsertData() {
            InitializeComponent();

            Color backColor = new Color();
            backColor = Color.FromArgb(58, 71, 80);
            tabControlAgent.UseCustomBackColor = true;

            SetUI();
        }

        /// <summary>
        /// hide all tab
        /// </summary>
        public void HideAllTab() {
            tabControlBranch.Hide();
            tabControlPrincipalAndVice.Hide();
            tabControlAgent.Hide();
        }
        /// <summary>
        /// load the default data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcInsertDataAgent_Load(object sender, EventArgs e) {
            HideAllTab();
            tabControlAgent.Show();
            tabControlAgent.Location = new Point(0, 0);
            tabControlAgent.SelectedIndex = 0;
            tabControlAgent_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// set default UI
        /// </summary>
        void SetUI() {
            if (FormMain.currentLogInType == LogInType.Admin) {
                myButton1.Show();
                myButton1.Location = new Point(116, -38);
            } else {
                myButton1.Visible = false;
            }
        }


        #region Branch
        /// <summary>
        /// set the default value for branch control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlBranch_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlBranch.SelectedIndex == 0) { //new branch

            } else if (tabControlBranch.SelectedIndex == 1) { //edit branch
                comboBoxEditBranchID.GetComboBoxAutoFillData(Connection.Instance.GetBranchIDs());
                comboBoxEditBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                comboBoxEditBranchID_SelectedIndexChanged(sender, e);
            } else if (tabControlBranch.SelectedIndex == 2) { // delete branch
                if (FormMain.currentLogInType == LogInType.Super_Admin) {
                    comboBoxDeleteBranchID.GetComboBoxAutoFillData(Connection.Instance.GetBranchIDs());
                    comboBoxDeleteBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                }
            }
        }
        /// <summary>
        /// auto fill the branch control
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="data"></param>
        void AutoFillBranchData(ref MetroTabPage tabPage, Branch data) {
            foreach (var i in tabPage.Controls) {
                if (i is BunifuMaterialTextbox) {

                    BunifuMaterialTextbox temp = (BunifuMaterialTextbox)i;
                    if (temp.Name == "textBoxEditBranchAddress") {
                        temp.Text = data.Address;
                    } else if (temp.Name == "textBoxEditBranchCity") {
                        temp.Text = data.City;
                    }
                    if (temp.Name == "labelDeleteBranchAddress") {
                        temp.Text = data.Address;
                    } else if (temp.Name == "labelDeleteBranchCity") {
                        temp.Text = data.City;
                    }

                } else if (i is ComboBox) {
                    ComboBox temp = (ComboBox)i;
                    if (temp.Name == "comboBoxEditBranchID" || temp.Name == "comboBoxDeleteBranchID") {
                        temp.SelectedItem = data.ID;
                    } else if (temp.Name == "comboBoxEditBranchName" || temp.Name == "comboBoxDeleteBranchName") {
                        temp.SelectedItem = data.Name;
                    }
                } else if (i is MyTextBox) {
                    MyTextBox temp = (MyTextBox)i;
                    temp.Text = "";
                } else if (i is Label) {
                    Label temp = (Label)i;
                    if (temp.Name == "labelDeleteBranchAddress") {
                        temp.Text = data.Address;
                    } else if (temp.Name == "labelDeleteBranchCity") {
                        temp.Text = data.City;
                    }
                }
            }
        }

        void FillBranchData(ref MetroTabPage tabpage, string data, TempData dataType) {
            Branch tempBranch = new Branch(Connection.Instance.GetBranchData(data, dataType));
            AutoFillBranchData(ref tabpage, tempBranch);

        }

        /// <summary>
        /// load the branch data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadBranch(object sender, EventArgs e) {
            HideAllTab();
            tabControlBranch.Show();
            tabControlBranch.Location = new Point(0, 0);
            tabControlBranch.SelectedIndex = 0;
            tabControlBranch_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region principal
        /// <summary>
        /// set the default data in principal and vice control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlPrincipalAndVice_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlPrincipalAndVice.SelectedIndex == 0) { //principal
                comboBoxPrincipalBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                comboBoxPrincipalName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNamesInBranch(Connection.Instance.GetBranchIDFromName(comboBoxPrincipalBranchName.Text)));

                comboBoxPrincipalBranchName_SelectedIndexChanged(sender, e);
            } else if (tabControlPrincipalAndVice.SelectedIndex == 1) { //vice principal
                comboBoxVicePrincipalBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                comboBoxVicePrincipalName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNamesInBranch(Connection.Instance.GetBranchIDFromName(comboBoxVicePrincipalBranchName.Text)));

                comboBoxVicePrincipalBranchName_SelectedIndexChanged(sender, e);
            }
        }
        /// <summary>
        /// fill the principal or vice data
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="branchName"></param>
        /// <param name="type"></param>
        void FillPrincipalOrViceData(ref MetroTabPage tabPage, string branchName, PrincipalOrVice type) {
            PrincipalAndVice tempData;

            tempData = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromName(branchName), type));
            if (type == PrincipalOrVice.Principal) {
                comboBoxPrincipalName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNamesInBranch(Connection.Instance.GetBranchIDFromName(comboBoxPrincipalBranchName.Text)));
            } else {
                comboBoxVicePrincipalName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNamesInBranch(Connection.Instance.GetBranchIDFromName(comboBoxVicePrincipalBranchName.Text)));
            }
            AutoFillPrincipalOrViceData(ref tabPage, tempData);

        }

        /// <summary>
        /// auto fill principal and vice data
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="data"></param>
        void AutoFillPrincipalOrViceData(ref MetroTabPage tabPage, PrincipalAndVice data) {
            foreach (var i in tabPage.Controls) {
                if (i is TextBox) {

                } else if (i is ComboBox) {
                    ComboBox temp = (ComboBox)i;
                    if (temp.Name == "comboBoxPrincipalName" || temp.Name == "comboBoxVicePrincipalName") {
                        temp.SelectedItem = Connection.Instance.GetAgentName(data.AgentID);
                    } else if (temp.Name == "comboBoxPrincipalBranchName" || temp.Name == "comboBoxVicePrincipalBranchName") {
                        temp.SelectedItem = Connection.Instance.GetBranchNameFromID(data.BranchID);
                    }
                } else if (i is MyTextBox) {
                    MyTextBox temp = (MyTextBox)i;
                    temp.Text = "";
                } else if (i is Label) {
                    Label temp = (Label)i;
                    if (temp.Name == "labelPrincipalDateJoined" || temp.Name == "labelVicePrincipalDateJoined") {
                        temp.Text = data.DateSelected.ToString("dddd, dd - MMM - yyyy");
                    }
                } else if (i is BunifuDatepicker) {
                    BunifuDatepicker temp = (BunifuDatepicker)i;
                    if (temp.Name == "dateTimePickerPrincipalDateJoinend" || temp.Name == "dateTimePickerVicePrincipalDateJoined") {
                        temp.Value = data.DateSelected;
                    }
                }
            }
        }
        /// <summary>
        /// load the principal or vice data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadPrincipalAndVice(object sender, EventArgs e) {
            HideAllTab();
            tabControlPrincipalAndVice.Show();
            tabControlPrincipalAndVice.Location = new Point(0, 0);
            tabControlPrincipalAndVice.SelectedIndex = 0;
            tabControlPrincipalAndVice_SelectedIndexChanged(sender, e);
        }

        #endregion

        #region Agent stuff
        /// <summary>
        /// load the agent data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadAgent(object sender, EventArgs e) {
            HideAllTab();
            tabControlAgent.Show();
            tabControlAgent.Location = new Point(0, 0);
            tabControlAgent.SelectedIndex = 0;
            tabControlAgent_SelectedIndexChanged(sender, e);
        }
        /// <summary>
        /// set the default value for agents control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlAgent_SelectedIndexChanged(object sender, EventArgs e) {
            if (tabControlAgent.SelectedIndex == 0) { //new agent
                comboBoxNewAgentBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                comboBoxNewAgentUplineName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames(false));
            } else if (tabControlAgent.SelectedIndex == 1) { //update agent
                comboBoxUpdateAgentID.GetComboBoxAutoFillData(Connection.Instance.GetAgentIDs());

                comboBoxUpdateAgentName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames());
                comboBoxUpdateAgentBranchName.GetComboBoxAutoFillData(Connection.Instance.GetBranchNames());
                comboBoxUpdateAgentUplineName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames(false));

                comboBoxUpdateAgentID_SelectedIndexChanged(sender, e);
            } else if (tabControlAgent.SelectedIndex == 2) { //diasble agnet
                if (FormMain.currentLogInType == LogInType.Super_Admin) {
                    comboBoxDisableAgentID.GetComboBoxAutoFillData(Connection.Instance.GetAgentIDs());
                    comboBoxDisableAgentName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames());
                }
            }
        }
        /// <summary>
        /// fill out the agetns data
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="data"></param>
        /// <param name="dataType"></param>
        void FillAgentData(ref MetroTabPage tabPage, string data, TempData dataType) {
            Agent tempAgent = new Agent(Connection.Instance.GetAgentData(data, dataType));

            AutoFillAgentData(ref tabPage, tempAgent);

        }
        /// <summary>
        /// auto fill the agents data
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="data"></param>
        void AutoFillAgentData(ref MetroTabPage tabPage, Agent data) {
            foreach (var i in tabPage.Controls) {
                if (i is BunifuMaterialTextbox) {
                    BunifuMaterialTextbox temp = (BunifuMaterialTextbox)i;
                    if (temp.Name == "textBoxUpdateAgentEmail") {
                        temp.Text = data.Email;
                    }

                    if (temp.Name == "labelDisableAgentEmail") {
                        temp.Text = data.Email;
                    } else if (temp.Name == "labelDisableAgentPhoneNumber") {
                        temp.Text = data.PhoneNumber;
                    } else if (temp.Name == "labelDisableAgentDateJoined") {
                        temp.Text = data.DateJoined.ToString();
                    } else if (temp.Name == "labelDisableAgentBranchName") {
                        temp.Text = Connection.Instance.GetBranchNameFromAgentID(data.ID);
                    } else if (temp.Name == "labelDisableAgentUplineName") {
                        temp.Text = Connection.Instance.GetAgentName(data.UplineID);
                    } else if (temp.Name == "labelUpdateAgentDateJoined") {
                        temp.Text = data.DateJoined.ToString("dddd, dd - MMM - yyyy");
                    }
                } else if (i is ComboBox) {
                    ComboBox temp = (ComboBox)i;
                    if (temp.Name == "comboBoxUpdateAgentID" || temp.Name == "comboBoxDisableAgentID") {
                        temp.SelectedItem = data.ID;
                    } else if (temp.Name == "comboBoxUpdateAgentName" || temp.Name == "comboBoxDisableAgentName") {
                        temp.SelectedItem = data.Name;
                    } else if (temp.Name == "comboBoxUpdateAgentBranchName") {
                        temp.SelectedItem = Connection.Instance.GetBranchNameFromID(data.BranchID);
                    } else if (temp.Name == "comboBoxUpdateAgentUplineName") {
                        temp.SelectedItem = Connection.Instance.GetAgentName(data.UplineID);
                    }
                } else if (i is MyTextBox) {
                    MyTextBox temp = (MyTextBox)i;
                    temp.Text = "";
                } else if (i is Label) {
                    Label temp = (Label)i;
                    if (temp.Name == "labelDisableAgentEmail") {
                        temp.Text = data.Email;
                    } else if (temp.Name == "labelDisableAgentPhoneNumber") {
                        temp.Text = data.PhoneNumber;
                    } else if (temp.Name == "labelDisableAgentDateJoined") {
                        temp.Text = data.DateJoined.ToString();
                    } else if (temp.Name == "labelDisableAgentBranchName") {
                        temp.Text = Connection.Instance.GetBranchNameFromAgentID(data.ID);
                    } else if (temp.Name == "labelDisableAgentUplineName") {
                        temp.Text = Connection.Instance.GetAgentName(data.UplineID);
                    } else if (temp.Name == "labelUpdateAgentDateJoined") {
                        temp.Text = data.DateJoined.ToString("dddd, dd - MMM - yyyy");
                    }
                } else if (i is BunifuDatepicker) {
                    BunifuDatepicker temp = (BunifuDatepicker)i;
                    if (temp.Name == "dateTimePickerUpdateAgent") {
                        temp.Value = data.DateJoined;
                    }
                } else if (i is TextBox) {
                    TextBox temp = (TextBox)i;
                    if (temp.Name == "textBoxNumericUpdateAgentPhoneNumber") {
                        temp.Text = data.PhoneNumber;
                    }
                }

            }
        }

        #endregion

        #region comboBoxes

        //agents
        private void comboBoxUpdateAgentID_SelectedIndexChanged(object sender, EventArgs e) {
            comboBoxUpdateAgentUplineName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames(false), new string[] { comboBoxUpdateAgentName.Text });
            FillAgentData(ref tabPageUpdateAgent, comboBoxUpdateAgentID.SelectedItem.ToString(), TempData.ID);
        }

        private void comboBoxUpdateAgentName_SelectedIndexChanged(object sender, EventArgs e) {
            comboBoxUpdateAgentUplineName.GetComboBoxAutoFillData(Connection.Instance.GetAgentNames(false), new string[] { comboBoxUpdateAgentName.Text });
            FillAgentData(ref tabPageUpdateAgent, comboBoxUpdateAgentName.SelectedItem.ToString(), TempData.Name);
        }
        private void comboBoxDisableAgentID_SelectedIndexChanged(object sender, EventArgs e) {
            FillAgentData(ref tabPageDisableAgent, comboBoxDisableAgentID.SelectedItem.ToString(), TempData.ID);
        }

        private void comboBoxDisableAgentName_SelectedIndexChanged(object sender, EventArgs e) {
            FillAgentData(ref tabPageDisableAgent, comboBoxDisableAgentName.SelectedItem.ToString(), TempData.Name);
        }

        //branchs
        private void comboBoxEditBranchName_SelectedIndexChanged(object sender, EventArgs e) {
            FillBranchData(ref tabPageEditBranch, comboBoxEditBranchName.Text, TempData.Name);
        }


        private void comboBoxEditBranchID_SelectedIndexChanged(object sender, EventArgs e) {
            FillBranchData(ref tabPageEditBranch, comboBoxEditBranchID.Text, TempData.ID);
        }

        private void comboBoxDeleteBranchID_SelectedIndexChanged(object sender, EventArgs e) {
            FillBranchData(ref tabPageDeleteBranch, comboBoxDeleteBranchID.Text, TempData.ID);
        }

        private void comboBoxDeleteBranchName_SelectedIndexChanged(object sender, EventArgs e) {
            FillBranchData(ref tabPageDeleteBranch, comboBoxDeleteBranchName.Text, TempData.Name);
        }


        //principals and vices
        private void comboBoxPrincipalBranchName_SelectedIndexChanged(object sender, EventArgs e) {
            FillPrincipalOrViceData(ref tabPagePrincipal, comboBoxPrincipalBranchName.Text, PrincipalOrVice.Principal);
        }

        private void comboBoxVicePrincipalBranchName_SelectedIndexChanged(object sender, EventArgs e) {
            FillPrincipalOrViceData(ref tabPageVicePrincipal, comboBoxVicePrincipalBranchName.Text, PrincipalOrVice.VicePrincipal);
        }

        #endregion

        /// <summary>
        /// rest the UI to its default
        /// </summary>
        /// <param name="tabPage"></param>
        /// <param name="type"></param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ClearData(ref MetroTabPage tabPage, DataType type, object sender, EventArgs e) {
            foreach (var i in tabPage.Controls) {
                if (i is BunifuMaterialTextbox) {
                    BunifuMaterialTextbox temp = (BunifuMaterialTextbox)i;
                    temp.Text = "";
                } else if (i is ComboBox) {
                    ComboBox temp = (ComboBox)i;
                    temp.SelectedIndex = 0;
                } else if (i is MyTextBox) {
                    MyTextBox temp = (MyTextBox)i;
                    temp.Text = "";
                } else if (i is TextBox) {
                    TextBox temp = (TextBox)i;
                    temp.Text = "";
                }
            }

            if (type == DataType.Agent) {
                tabControlAgent_SelectedIndexChanged(sender, e);
            } else if (type == DataType.Branch) {
                tabControlBranch_SelectedIndexChanged(sender, e);
            }
        }

        private void buttonUpdateAgentClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageUpdateAgent, DataType.Agent, sender, e);
        }

        private void buttonNewAgentClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageAddAgent, DataType.Agent, sender, e);
        }

        private void buttonDisableAgentClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageDisableAgent, DataType.Agent, sender, e);
        }

        private void buttonClearPrincipal_Click(object sender, EventArgs e) {
            ClearData(ref tabPageVicePrincipal, DataType.Agent, sender, e);
        }

        private void buttonClearPrincipal_Click_1(object sender, EventArgs e) {
            ClearData(ref tabPagePrincipal, DataType.Agent, sender, e);
        }

        private void buttonNewBranchClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageNewBranch, DataType.Agent, sender, e);
        }

        private void buttonEditBranchClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageEditBranch, DataType.Agent, sender, e);
        }

        private void buttonDeleteBranchClear_Click(object sender, EventArgs e) {
            ClearData(ref tabPageDeleteBranch, DataType.Agent, sender, e);
        }

        //inserts
        private void buttonNewAgentInsert_Click(object sender, EventArgs e) {
            string errorMsg = "";

            Agent tempAgent = new Agent();

            tempAgent.ID = textBoxNewAgentID.Text;
            tempAgent.Name = textBoxNewAgentName.Text;
            tempAgent.Email = textBoxNewAgentEmail.Text;
            tempAgent.PhoneNumber = textBoxNumericNewAgentPhoneNumber.Text;

            tempAgent.DateJoined = dateTimePickerNewAgent.Value;

            string tempBranchName = comboBoxNewAgentBranchName.Text;

            tempAgent.BranchID = Connection.Instance.GetBranchIDFromName(tempBranchName);

            string tempUplineName = comboBoxNewAgentUplineName.Text;

            tempAgent.UplineID = Connection.Instance.GetAgentID(tempUplineName);
            
            int counter = 0;
            if (tempAgent.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentID";
            }
            if (tempAgent.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }

            Connection.Instance.InsertNewAgent(tempAgent.GetAgentData());
            buttonNewAgentClear_Click(sender, e);
        }
        private void buttonUpdateAgent_Click(object sender, EventArgs e) {
            string errorMsg = "";

            Agent tempAgent = new Agent();

            tempAgent.ID = comboBoxUpdateAgentID.Text;
            tempAgent.Name = comboBoxUpdateAgentName.Text;
            tempAgent.Email = textBoxUpdateAgentEmail.Text;
            tempAgent.PhoneNumber = textBoxNumericUpdateAgentPhoneNumber.Text;

            if (textBoxNumericNewAgentPhoneNumber.Text != "") {
                tempAgent.PhoneNumber = "0";
            }

            tempAgent.DateJoined = dateTimePickerUpdateAgent.Value;

            string tempBranchName = comboBoxUpdateAgentBranchName.Text;

            tempAgent.BranchID = Connection.Instance.GetBranchIDFromName(tempBranchName);

            string tempUplineName = comboBoxUpdateAgentUplineName.Text;

            tempAgent.UplineID = Connection.Instance.GetAgentID(tempUplineName);

            int counter = 0;
            if (!Connection.Instance.IsAgentExists(tempAgent.ID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". ID does not exist";
            }

            if (tempAgent.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentID";
            }

            if (tempAgent.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }
            Connection.Instance.UpdateAgentData(tempAgent.GetAgentData());
            tabControlAgent_SelectedIndexChanged(sender, e);
        }

        private void buttonDisableAgent_Click(object sender, EventArgs e) {
            string errorMsg = "";

            Agent tempAgent = new Agent();

            tempAgent.ID = comboBoxDisableAgentID.Text;
            tempAgent.Name = comboBoxDisableAgentName.Text;

            int counter = 0;

            if (!Connection.Instance.IsAgentExists(tempAgent.ID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". ID does not exist";
            }

            if (tempAgent.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentID";
            }

            if (tempAgent.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }
            Connection.Instance.DisableAgent(tempAgent.ID);
            tabControlAgent_SelectedIndexChanged(sender, e);
        }

        private void buttonNewBranchCreate_Click(object sender, EventArgs e) {
            string errorMsg = "";
            Branch tempBranch = new Branch();
            tempBranch.ID = textBoxNewBranchID.Text;
            tempBranch.Name = textBoxNewBranchName.Text;
            tempBranch.Address = textBoxNewBranchAddress.Text;
            tempBranch.City = textBoxNewBranchCity.Text;

            int counter = 0;
            if (tempBranch.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill BranchID";
            }
            if (tempBranch.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill BranchName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }
            Connection.Instance.InsertNewBranch(tempBranch.GetBranchData());

            buttonNewBranchClear_Click(sender, e);
        }

        private void buttonEditBranch_Click(object sender, EventArgs e) {
            string errorMsg = "";
            Branch tempBranch = new Branch();
            tempBranch.ID = comboBoxEditBranchID.Text;
            tempBranch.Name = comboBoxEditBranchName.Text;
            tempBranch.Address = textBoxEditBranchAddress.Text;
            tempBranch.City = textBoxEditBranchCity.Text;
            int counter = 0;
            if (!Connection.Instance.IsBranchExist(tempBranch.ID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Branch ID does not exist";
            }
            if (tempBranch.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill BranchID";
            }
            if (tempBranch.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill BranchName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }
            Connection.Instance.EditBranch(tempBranch.GetBranchData());
            tabControlBranch_SelectedIndexChanged(sender, e);
        }

        private void buttonDeleteBranch_Click(object sender, EventArgs e) {
            string errorMsg = "";

            Branch tempBranch = new Branch();

            tempBranch.ID = comboBoxDeleteBranchID.Text;
            tempBranch.Name = comboBoxDeleteBranchName.Text;

            int counter = 0;

            if (!Connection.Instance.IsBranchExist(tempBranch.ID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Branch ID does not exist";
            }

            if (tempBranch.ID == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentID";
            }
            if (tempBranch.Name == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill AgentName";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                return;
            }
            Connection.Instance.DeleteBranch(tempBranch.ID);

            tabControlBranch_SelectedIndexChanged(sender, e);
        }

        private void buttonSetPrincipal_Click(object sender, EventArgs e) {
            string errorMsg = "";

            PrincipalAndVice principal = new PrincipalAndVice();

            principal.AgentID = Connection.Instance.GetAgentID(comboBoxPrincipalName.Text);
            principal.BranchID = Connection.Instance.GetBranchIDFromName(comboBoxPrincipalBranchName.Text);
            principal.DateSelected = dateTimePickerPrincipalDateJoinend.Value;

            int counter = 0;

            if (!Connection.Instance.IsBranchExist(principal.BranchID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Branch name does not exist";
            }
            if (!Connection.Instance.IsAgentExists(principal.AgentID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Agent name does not exist";
            }
            if (new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(principal.BranchID, PrincipalOrVice.VicePrincipal)).AgentID == principal.AgentID) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Agent is a vice principal, please choose another agent";
            }

            if (comboBoxPrincipalName.Text == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill Agent name";
            }
            if (comboBoxPrincipalBranchName.Text == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill Branch name";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                tabControlPrincipalAndVice_SelectedIndexChanged(sender, e);
                return;
            }

            Connection.Instance.UpdatePrincipalOrVice(principal.GetPrincipalOrViceData(), PrincipalOrVice.Principal);
            tabControlPrincipalAndVice_SelectedIndexChanged(sender, e);
        }

        private void buttonPrincipalSet_Click(object sender, EventArgs e) {
            string errorMsg = "";

            PrincipalAndVice viceP = new PrincipalAndVice();

            viceP.AgentID = Connection.Instance.GetAgentID(comboBoxVicePrincipalName.Text);
            viceP.BranchID = Connection.Instance.GetBranchIDFromName(comboBoxVicePrincipalBranchName.Text);
            viceP.DateSelected = dateTimePickerPrincipalDateJoinend.Value;

            int counter = 0;

            if (!Connection.Instance.IsBranchExist(viceP.BranchID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Branch name does not exist";
            }
            if (!Connection.Instance.IsAgentExists(viceP.AgentID)) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Agent name does not exist";
            }
            if (new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(viceP.BranchID, PrincipalOrVice.Principal)).AgentID == viceP.AgentID) {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Agent is a principal, please choose another agent";
            }


            if (comboBoxPrincipalName.Text == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill Agent name";
            }
            if (comboBoxPrincipalBranchName.Text == "") {
                counter++;
                errorMsg += "\n" + counter.ToString() + ". Please fill Branch name";
            }

            if (counter > 0) {
                MessageBox.Show(errorMsg);
                tabControlPrincipalAndVice_SelectedIndexChanged(sender, e);
                return;

            }

            Connection.Instance.UpdatePrincipalOrVice(viceP.GetPrincipalOrViceData(), PrincipalOrVice.VicePrincipal);
            tabControlPrincipalAndVice_SelectedIndexChanged(sender, e);
        }
    }
}
