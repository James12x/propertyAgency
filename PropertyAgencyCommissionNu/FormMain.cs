using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyAgencyCommissionNu {
    public partial class FormMain : Form {

        const string ID_SUPER_ADMIN = "SuperAdmin";
        const string PASS_SUPER_ADMIN = "SuperAdmin";

        const string ID_ADMIN = "Admin";
        const string PASS_ADMIN = "Admin";

        public static LogInType currentLogInType = LogInType.None;
        public FormMain() {
            InitializeComponent();

            panelSideMenu.Width = 100;
            panelMenuInsertData.Visible = false;
            panelMenuReport.Visible = false;
        }

        /// <summary>
        /// open and close menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenu_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100) {
                panelSideMenu.Visible = false;
                panelSideMenu.Width = 335;
                animatorPanelHor.ShowSync(panelSideMenu);
                textBoxMenu.Visible = true;
            } else {
                panelSideMenu.Visible = false;
                panelSideMenu.Width = 100;
                animatorPanelVer.ShowSync(panelSideMenu);
                textBoxMenu.Visible = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e) {
            this.Close();
        }
        /// <summary>
        /// disable all UI
        /// </summary>
        void DisableAll() {
            if (panelSideMenu.Width == 335)
                panelSideMenu.Width = 100;
            panelSideMenu.Hide();
            panelSignIn.Show();
        }
        /// <summary>
        /// show all UI
        /// </summary>
        void ShowAll() {
            panelSignIn.Hide();
            panelSideMenu.Show();
            buttonMenuInsertData.Show();
            buttonMenuInsertComm.Show();
            buttonMenuReport.Show();
            buttonMenuSettings.Show();
        }
        /// <summary>
        /// set the default UI for Admin
        /// </summary>
        void AdminUI() {
            ShowAll();
            buttonMenuSettings.Hide();
        }

        /// <summary>
        /// reset the input field
        /// </summary>
        void ClearUI() {
            textBoxLoginID.Text = "";
            textBoxLoginPass.Text = "";
        }

        /// <summary>
        /// set the UI for Super Admin
        /// </summary>
        void SuperAdminUI() {
            ShowAll();
        }

        /// <summary>
        /// log in into the control
        /// </summary>
        /// <param name="loginType"></param>
        void LogIN(LogInType loginType) {
            currentLogInType = loginType;
            SetUiToLoginType();
            if (currentLogInType == LogInType.Admin) {
                textBoxMenu.Text = "Admin";
            } else {
                textBoxMenu.Text = "Super Admin";
            }
        }

        /// <summary>
        /// set the default UI
        /// </summary>
        void SetUiToLoginType() {
            if (currentLogInType == LogInType.None) {
                DisableAll();
            } else if (currentLogInType == LogInType.Admin) {
                AdminUI();
            } else {
                SuperAdminUI();
            }
        }

        private void FormMain_Load(object sender, EventArgs e) {
            currentLogInType = LogInType.None;
            SetUiToLoginType();
            Connection con = new Connection();
            Connection.Instance = con;
            Connection.Instance.Connect();
        }

        private void panelLogin_Click(object sender, EventArgs e) {
            panelMenuInsertData.Visible = false;
        }
        /// <summary>
        /// logs out of the control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonLogOut_Click(object sender, EventArgs e) {
            currentLogInType = LogInType.None;
            SetUiToLoginType();
            ClearUI();
        }


        private void buttonLogin_Click(object sender, EventArgs e) {
            string id = textBoxLoginID.Text;
            string pass = textBoxLoginPass.Text;

            if (id == "" || pass == "") {
                MessageBox.Show("ID or Password cannot be empty");
            } else {
                if (id == ID_SUPER_ADMIN && pass == PASS_SUPER_ADMIN) {
                    LogIN(LogInType.Super_Admin);
                } else if (id == ID_ADMIN && pass == PASS_ADMIN) {
                    LogIN(LogInType.Admin);
                } else {
                    MessageBox.Show("ID or Password is not correct");
                }
            }
        }

        private void buttonDebugLogInSuperAdmin_Click_1(object sender, EventArgs e) {
            LogIN(LogInType.Super_Admin);
        }

        private void buttonDebugLogInAdmin_Click_1(object sender, EventArgs e) {
            LogIN(LogInType.Admin);
        }
        
        private void bunifuFlatButtonLogOut_Click_1(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100) {
                panelSideMenu.Width = 335;
            } else {
                List<int> test = new List<int>();

                for (int i = 0; i < panelLogin.Controls.Count; i++) {
                    if (panelLogin.Controls[i] is UcInsertData) {
                        test.Add(i);
                    } else if (panelLogin.Controls[i] is UcInsertCommission) {
                        test.Add(i);
                    } else if (panelLogin.Controls[i] is UcReport) {
                        test.Add(i);
                    } else if (panelLogin.Controls[i] is UcSetting) {
                        test.Add(i);
                    }
                }

                for (int i = 0; i < test.Count; i++) {
                    panelLogin.Controls.RemoveAt(test[i]);
                }

                currentLogInType = LogInType.None;
                SetUiToLoginType();
                ClearUI();
                ClosePanel();
            }
        }
        /// <summary>
        /// show insert data menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuInsertData_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100)
                panelSideMenu.Width = 335;
            else if (panelSideMenu.Width != 100 && panelMenuInsertData.Visible == false) {
                panelMenuInsertData.Location = new Point(235, 203);

                panelMenuReport.Hide();
                panelMenuInsertData.Visible = true;
                panelMenuInsertData.BringToFront();
            } else {
                ClosePanel();
            }
        }

        private void panelWindowBar_Click(object sender, EventArgs e) {
            panelMenuInsertData.Visible = false;
        }

        /// <summary>
        /// show report menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuReport_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100)
                panelSideMenu.Width = 335;
            else if (panelSideMenu.Width != 100 && panelMenuReport.Visible == false) {
                panelMenuReport.Location = new Point(235, 339);
                panelMenuReport.Visible = true;
                panelMenuInsertData.Hide();
                panelMenuReport.BringToFront();
            } else {
                ClosePanel();
            }
        }
        /// <summary>
        /// go to agent control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuAgent_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcInsertData.Instance)) {
                panelLogin.Controls.Add(UcInsertData.Instance);
                UcInsertData.Instance.Dock = DockStyle.Fill;

                UcInsertData.Instance.Visible = false;
                UcInsertData.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcInsertData.Instance);

            } else {
                UcInsertData.Instance.Visible = false;
                UcInsertData.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcInsertData.Instance);
            }
            ClosePanel();
            panelMenuInsertData.Parent = UcInsertData.Instance;
            panelMenuInsertData.BringToFront();
            panelMenuInsertData.Location = new Point(235, 203);
            panelMenuInsertData.BringToFront();
            UcInsertData.Instance.LoadAgent(sender, e);
        }

        /// <summary>
        /// go to branch control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuBranch_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcInsertData.Instance)) {
                panelLogin.Controls.Add(UcInsertData.Instance);
                UcInsertData.Instance.Dock = DockStyle.Fill;
                UcInsertData.Instance.BringToFront();
            } else {
                UcInsertData.Instance.BringToFront();
            }
            ClosePanel();
            panelMenuInsertData.Parent = UcInsertData.Instance;
            panelMenuInsertData.BringToFront();
            panelMenuInsertData.Location = new Point(235, 203);
            panelMenuInsertData.BringToFront();
            UcInsertData.Instance.LoadBranch(sender, e);
        }

        /// <summary>
        /// go to principal/vice control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuPrincipal_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcInsertData.Instance)) {
                panelLogin.Controls.Add(UcInsertData.Instance);
                UcInsertData.Instance.Dock = DockStyle.Fill;
                UcInsertData.Instance.BringToFront();
            } else {
                UcInsertData.Instance.BringToFront();
            }
            ClosePanel();
            panelMenuInsertData.Parent = UcInsertData.Instance;
            panelMenuInsertData.Location = new Point(235, 203);
            panelMenuInsertData.BringToFront();
            UcInsertData.Instance.LoadPrincipalAndVice(sender, e);
        }
        /// <summary>
        /// close the menu panel
        /// </summary>
        private void ClosePanel() {
            panelSideMenu.Visible = false;
            panelSideMenu.Width = 100;

            textBoxMenu.Visible = false;
            panelMenuInsertData.Visible = false;
            panelMenuReport.Hide();
            animatorPanelVer.ShowSync(panelSideMenu);
        }
        /// <summary>
        /// go to insert commission control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuInsertComm_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100) {
                panelSideMenu.Width = 335;
            } else {
                if (!panelLogin.Controls.Contains(UcInsertCommission.Instance)) {
                    panelLogin.Controls.Add(UcInsertCommission.Instance);
                    UcInsertCommission.Instance.Dock = DockStyle.Fill;
                    UcInsertCommission.Instance.BringToFront();
                    ClosePanel();
                } else {
                    UcInsertCommission.Instance.BringToFront();
                    ClosePanel();
                }
            }
            panelMenuInsertData.Parent = UcInsertCommission.Instance;
            panelMenuInsertData.Location = new Point(235, 203);
            panelMenuInsertData.BringToFront();
        }

        /// <summary>
        /// go to setting control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMenuSettings_Click(object sender, EventArgs e) {
            if (panelSideMenu.Width == 100) {
                panelSideMenu.Width = 335;
            } else {
                if (!panelLogin.Controls.Contains(UcSetting.Instance)) {
                    panelLogin.Controls.Add(UcSetting.Instance);
                    UcSetting.Instance.Dock = DockStyle.Fill;
                    UcSetting.Instance.BringToFront();
                    ClosePanel();
                } else {
                    UcSetting.Instance.BringToFront();
                    ClosePanel();
                }
            }

            panelMenuInsertData.Parent = UcSetting.Instance;
            panelMenuInsertData.Location = new Point(235, 203);
            panelMenuInsertData.BringToFront();
        }

        /// <summary>
        /// go to report tree control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowReportTree_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcReport.Instance)) {
                panelLogin.Controls.Add(UcReport.Instance);
                UcReport.Instance.Dock = DockStyle.Fill;
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            } else {
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            }
            ClosePanel();
            panelMenuReport.Hide();
            panelMenuReport.Parent = UcReport.Instance;
            panelMenuReport.Location = new Point(235, 203);
            panelMenuReport.BringToFront();
            UcReport.Instance.ShowTree();
        }

        /// <summary>
        /// go to specific clossing control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpecificClossing_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcReport.Instance)) {
                panelLogin.Controls.Add(UcReport.Instance);
                UcReport.Instance.Dock = DockStyle.Fill;
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            } else {
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            }
            ClosePanel();
            panelMenuReport.Hide();
            panelMenuReport.Parent = UcReport.Instance;
            panelMenuReport.Location = new Point(235, 203);
            panelMenuReport.BringToFront();
            UcReport.Instance.ShowSpecificClosing();
        }
        /// <summary>
        /// go to agent closing summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowAgentsTransactionsByUnits_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcReport.Instance)) {
                panelLogin.Controls.Add(UcReport.Instance);
                UcReport.Instance.Dock = DockStyle.Fill;
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            } else {
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            }
            ClosePanel();
            panelMenuReport.Hide();
            panelMenuReport.Parent = UcReport.Instance;
            panelMenuReport.Location = new Point(235, 203);
            panelMenuReport.BringToFront();
            UcReport.Instance.ShowAgentClosingSummary();
        }
        /// <summary>
        /// go to commission summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCommissionSummary_Click(object sender, EventArgs e) {
            if (!panelLogin.Controls.Contains(UcReport.Instance)) {
                panelLogin.Controls.Add(UcReport.Instance);
                UcReport.Instance.Dock = DockStyle.Fill;
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            } else {
                UcReport.Instance.Visible = false;
                UcReport.Instance.BringToFront();
                animatorPanelHor.ShowSync(UcReport.Instance);
            }
            ClosePanel();
            panelMenuReport.Hide();
            panelMenuReport.Parent = UcReport.Instance;
            panelMenuReport.Location = new Point(235, 203);
            panelMenuReport.BringToFront();
            UcReport.Instance.ShowCommissionSummary();
        }
    }
}

public enum LogInType {
    None = 0,
    Super_Admin = 1,
    Admin = 2
}

