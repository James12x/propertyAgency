using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu {
    public partial class UcInsertCommission : UserControl {
        public static UcInsertCommission _instance;
        public static UcInsertCommission Instance {
            get {
                if (_instance == null)
                    _instance = new UcInsertCommission();
                return _instance;
            }
        }

        public const int MAXTAB = 4;
        int nextClosingID = 0;

        List<MyButton> myButtons = new List<MyButton>();

        public List<ParticipatingAgents> ParticipatedAgents = new List<ParticipatingAgents>();

        public UcInsertCommission() {
            InitializeComponent();

            flowLayoutPanelAgent.FlowDirection = FlowDirection.TopDown;
        }
        /// <summary>
        /// get all currently added agents
        /// </summary>
        /// <returns></returns>
        public string[] GetAgentNames() {
            List<string> temp = new List<string>();
            for (int i = 0; i < ParticipatedAgents.Count; i++) {
                temp.Add(ParticipatedAgents[i].agent.Name);
            }
            return temp.ToArray();
        }

        private void UcInsertCommission_Load(object sender, EventArgs e) {
            nextClosingID = Connection.Instance.GetNextClosingID();
            this.DoubleBuffered = true;

            ClearData();
        }
        /// <summary>
        /// reset the input field
        /// </summary>
        void ClearData() {
            labelInsertCommissionID.Text = Connection.Instance.GetNextClosingIDInString();
            radioButtonClosingProperty.Checked = true;
            myTextBoxTotalNominal.Text = "";

            ParticipatedAgents.Clear();
            flowLayoutPanelAgent.Controls.Clear();
        }

        private void buttonInsertCommissionAddAgent_Click(object sender, EventArgs e) {
            if (ParticipatedAgents.Count == 4) {
                MessageBox.Show("Number of agents cannot be more than 4");
                return;
            }
            FormAddAgent formAddAgent = new FormAddAgent();
            formAddAgent.formInsertComm = this;
            formAddAgent.ShowDialog();
        }
        /// <summary>
        /// add agent closing
        /// </summary>
        /// <param name="agent"></param>
        public void AddAgent(Agent agent) {
            ParticipatedAgents.Add(new ParticipatingAgents(agent));
            RefreshAgentGroupBox();
            SetValuesToDefault();
        }

        /// <summary>
        /// set the default values of the nominal textboxes
        /// </summary>
        void SetValuesToDefault() {
            for(int i = 0; i < ParticipatedAgents.Count; i++) {
                if(ParticipatedAgents.Count == 1) {
                    ParticipatedAgents[i].nominal.Text = myTextBoxTotalNominal.GetValue().ToString();
                    ParticipatedAgents[i].unit.Text = "1";
                } else if (ParticipatedAgents.Count == 2) {
                    ParticipatedAgents[i].nominal.Text = (myTextBoxTotalNominal.GetValue() / 2).ToString();
                    ParticipatedAgents[i].unit.Text = "0,5";
                } else if(ParticipatedAgents.Count == 3) {
                    if(i == 0) {
                        ParticipatedAgents[i].nominal.Text = (myTextBoxTotalNominal.GetValue() / 2).ToString();
                        ParticipatedAgents[i].unit.Text = "0,5";
                    } else if(i > 0) {
                        ParticipatedAgents[i].nominal.Text = (myTextBoxTotalNominal.GetValue() / 4).ToString();
                        ParticipatedAgents[i].unit.Text = "0,25";
                    }
                }else if(ParticipatedAgents.Count == 4) {
                    ParticipatedAgents[i].nominal.Text = (myTextBoxTotalNominal.GetValue() / 4).ToString();
                    ParticipatedAgents[i].unit.Text = "0,25";
                }

                if (radioButtonClosingLoan.Checked) {
                    ParticipatedAgents[i].unit.Text = "0";
                }

                ParticipatedAgents[i].nominal.Format();
            }
        }

        /// <summary>
        /// refresh the UI for agent closing
        /// </summary>
        public void RefreshAgentGroupBox() {
            flowLayoutPanelAgent.Controls.Clear();
            for (int i = 0; i < ParticipatedAgents.Count; i++) {
                Label agentName = new Label();
                agentName.AutoSize = true;
                agentName.Text = (i + 1) + ". " + ParticipatedAgents[i].agent.Name;
                agentName.Font = new Font("Century Gothic", 15, FontStyle.Bold);
                agentName.ForeColor = Color.White;

                Label nominalLabel = new Label();
                nominalLabel.AutoSize = true;
                nominalLabel.Text = "Nominal";
                nominalLabel.Font = new Font("Century Gothic", 14f);
                nominalLabel.ForeColor = Color.White;

                Label unitLabel = new Label();
                unitLabel.AutoSize = true;
                unitLabel.Text = "Unit";
                unitLabel.Font = new Font("Century Gothic", 14f);
                unitLabel.ForeColor = Color.White;

                MyButton myButtonRemove = new MyButton();
                myButtonRemove.id = i;
                myButtonRemove.Text = "Remove";
                myButtonRemove.Size = new Size(111, 29);
                myButtonRemove.BackColor = Color.FromArgb(37, 45, 51);
                myButtonRemove.ForeColor = Color.White;

                MyTextBox myTextBoxNominal = new MyTextBox();
                if (ParticipatedAgents[i].nominal != null) {
                    myTextBoxNominal = ParticipatedAgents[i].nominal;
                } else {
                    myTextBoxNominal.Multiline = true;
                    myTextBoxNominal.BackColor = Color.FromArgb(37, 45, 51);
                    myTextBoxNominal.Size = new Size(300, 32);
                    myTextBoxNominal.ForeColor = Color.White;
                    myTextBoxNominal.TextAlign = HorizontalAlignment.Right;
                    myTextBoxNominal.Font = new Font("Century Gothic", 14f);
        }

                TextBoxNumeric textBoxNumericUnit = new TextBoxNumeric();
                if (ParticipatedAgents[i].unit != null) {
                    textBoxNumericUnit = ParticipatedAgents[i].unit;
                } else {
                    textBoxNumericUnit.Multiline = true;
                    textBoxNumericUnit.BackColor = Color.FromArgb(37, 45, 51);
                    textBoxNumericUnit.Size = new Size(300, 32);
                    textBoxNumericUnit.ForeColor = Color.White;
                    textBoxNumericUnit.TextAlign = HorizontalAlignment.Right;
                    textBoxNumericUnit.Font = new Font("Century Gothic", 14f);
                }


                Panel panelControl = new Panel();
                panelControl.Width = 300;
                panelControl.AutoSize = true;

                panelControl.Controls.Add(agentName);
                panelControl.Controls.Add(nominalLabel);
                panelControl.Controls.Add(unitLabel);

                panelControl.Controls.Add(myTextBoxNominal);
                ParticipatedAgents[i].nominal = myTextBoxNominal;
                panelControl.Controls.Add(textBoxNumericUnit);
                ParticipatedAgents[i].unit = textBoxNumericUnit;

                panelControl.Controls.Add(myButtonRemove);

                flowLayoutPanelAgent.Controls.Add(panelControl);

                panelControl.Left = 3;
                panelControl.Top = 3 + (panelControl.Height * (i));

                agentName.Left = 85;
                agentName.Top = 14;

                myButtonRemove.Left = agentName.Left + 263;
                myButtonRemove.SetMiddle(agentName.Middle());


                nominalLabel.Left = agentName.Left;
                nominalLabel.Top = agentName.Top + 41;
                myTextBoxNominal.Left = nominalLabel.Right + 19;
                myTextBoxNominal.SetMiddle(nominalLabel.Middle());

                unitLabel.SetRight(nominalLabel.Right);
                unitLabel.Top = nominalLabel.Bottom + 19;
                textBoxNumericUnit.Left = myTextBoxNominal.Left;
                textBoxNumericUnit.SetMiddle(unitLabel.Middle());
                
                myButtonRemove.Click += delegate {
                    ParticipatedAgents.RemoveAt(myButtonRemove.id);
                    RefreshAgentGroupBox();
                    SetValuesToDefault();
                };
            }
        }

        /// <summary>
        /// inserting the closing, agent closing, and commission
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertComissionSave_Click(object sender, EventArgs e) {
            double temp = 0;
            double temp2 = 0;
            for (int i = 0; i < ParticipatedAgents.Count; i++) {
                temp += ParticipatedAgents[i].nominal.GetValue();
                temp2 += double.Parse(ParticipatedAgents[i].unit.Text);
            }

            if(temp > myTextBoxTotalNominal.GetValue()) {
                MessageBox.Show("Nominal in agents closing is higher than total nominal. Please check again");
                return;
            }

            if(temp2 > 1) {
                MessageBox.Show("Total unit cannot be more than 1");
                return;
            }

            ClosingProperty closing = new ClosingProperty();
            closing.DateClosed = dateTimePickerInsertCommission.Value;
            closing.ClosingType = radioButtonClosingProperty.Checked ? TypeOfClosing.Property.ToString() : TypeOfClosing.Loan.ToString();
            closing.TotalNominal = myTextBoxTotalNominal.GetValue();

            Connection.Instance.InsertNewClosing(closing.GetClosingData());

            for (int i = 0; i < ParticipatedAgents.Count; i++) {
                AgentClosing agentClosing = new AgentClosing();
                if (radioButtonClosingProperty.Checked) {
                    agentClosing.Unit = double.Parse(ParticipatedAgents[i].unit.Text);
                } else {
                    agentClosing.Unit = 0;
                }

                agentClosing.Nominal = ParticipatedAgents[i].nominal.GetValue();
                agentClosing.AgentID = ParticipatedAgents[i].agent.ID;
                agentClosing.ClosingID = nextClosingID;

                string currentAgentID = "";

                Connection.Instance.InsertNewAgentClosing(agentClosing.GetAgentClosingData());
                bool principalFirst = false;
                bool viceFirst = false;

                if (ParticipatedAgents[i].agent.ID == new Agent(Connection.Instance.GetAgentData(new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(ParticipatedAgents[i].agent.BranchID, PrincipalOrVice.Principal)).AgentID, TempData.ID)).ID) {
                    principalFirst = true;
                } else if (ParticipatedAgents[i].agent.ID == new Agent(Connection.Instance.GetAgentData(new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(ParticipatedAgents[i].agent.BranchID, PrincipalOrVice.VicePrincipal)).AgentID, TempData.ID)).ID) {
                    viceFirst = true;
                }
                bool principalTaken = false;
                bool viceTaken = false;
                for (int j = 0; j < 5; j++) {
                    Commission commission = new Commission();
                    PrincipalAndVice princi = new PrincipalAndVice();
                    PrincipalAndVice vicePrinci = new PrincipalAndVice();

                    commission.AgentClosingID = ParticipatedAgents[i].agent.ID;
                    if (j == 0) {
                        currentAgentID = Connection.Instance.GetUplineIDFromAgentID(ParticipatedAgents[i].agent.ID);
                        commission.CommissionLevel = Helper.Upline1;
                        if (currentAgentID != Connection.Instance.GetEmptyAgent()) {
                            princi = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.Principal));
                            vicePrinci = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.VicePrincipal));
                        }

                        if (currentAgentID == princi.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            principalTaken = true;
                        } else if (currentAgentID == vicePrinci.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            viceTaken = true;
                        } else {
                            commission.AgentID = currentAgentID;
                        }
                    } else if (j == 1) {
                        currentAgentID = Connection.Instance.GetUplineIDFromAgentID(currentAgentID);
                        commission.CommissionLevel = Helper.Upline2;
                        if (currentAgentID != Connection.Instance.GetEmptyAgent()) {
                            princi = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.Principal));
                            vicePrinci = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.VicePrincipal));
                        }

                        if (currentAgentID == princi.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            principalTaken = true;
                        } else if (currentAgentID == vicePrinci.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            viceTaken = true;
                        } else {
                            commission.AgentID = currentAgentID;
                        }
                    } else if (j == 2) {
                        currentAgentID = Connection.Instance.GetUplineIDFromAgentID(currentAgentID);
                        commission.CommissionLevel = Helper.Upline3;
                        if (currentAgentID != Connection.Instance.GetEmptyAgent()) {
                            princi = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.Principal));
                            vicePrinci = new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(Connection.Instance.GetBranchIDFromAgentID(currentAgentID), PrincipalOrVice.VicePrincipal));
                        }
                        if (currentAgentID == princi.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            principalTaken = true;
                        } else if (currentAgentID == vicePrinci.AgentID) {
                            if (!principalFirst && !viceFirst) {
                                commission.AgentID = Connection.Instance.GetEmptyAgent();
                            } else {
                                commission.AgentID = currentAgentID;
                            }
                            viceTaken = true;
                        } else {
                            commission.AgentID = currentAgentID;
                        }
                    } else if (j == 3) {
                        currentAgentID = new Agent(Connection.Instance.GetAgentData(new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(ParticipatedAgents[i].agent.BranchID, PrincipalOrVice.Principal)).AgentID, TempData.ID)).ID;
                        commission.CommissionLevel = Helper.Principal;

                        if (principalTaken || principalFirst) {
                            commission.AgentID = Connection.Instance.GetEmptyAgent();
                        } else {
                            commission.AgentID = currentAgentID;
                        }

                    } else if (j == 4) {
                        currentAgentID = new Agent(Connection.Instance.GetAgentData(new PrincipalAndVice(Connection.Instance.GetPrincipalOrViceDataFromBranchID(ParticipatedAgents[i].agent.BranchID, PrincipalOrVice.VicePrincipal)).AgentID, TempData.ID)).ID;
                        commission.CommissionLevel = Helper.VicePrincipal;
                        //   MessageBox.Show("Vice taken : " + viceTaken.ToString() + ", viceFirst : " + viceFirst.ToString());
                        if (viceTaken || viceFirst) {
                            commission.AgentID = Connection.Instance.GetEmptyAgent();
                        } else {
                            commission.AgentID = currentAgentID;
                        }
                    }

                    commission.CommissionLevelValue = Connection.Instance.GetCommissionLevelValue(commission.CommissionLevel);

                    if (Connection.Instance.CheckActiveAgent(commission.AgentID, TempData.ID)) {
                        commission.CommissionNominal = ParticipatedAgents[i].nominal.GetValue() * commission.CommissionLevelValue / 100;
                    } else {
                        commission.CommissionNominal = 0;
                    }
                    
                    commission.ClosingID = nextClosingID;
                    
                    Connection.Instance.InsertNewCommission(commission.GetCommissionData());
                }
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e) {
            SetValuesToDefault();
        }
    }
}
