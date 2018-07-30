namespace PropertyAgencyCommissionNu
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelWindowBar = new System.Windows.Forms.Panel();
            this.buttonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.labelWindowInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelMenuInsertData = new System.Windows.Forms.Panel();
            this.buttonMenuAgent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuPrincipal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuBranch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelMenuReport = new System.Windows.Forms.Panel();
            this.buttonShowCommissionSummary = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonShowAgentsTransactionsByUnits = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonSpecificClossing = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonShowReportTree = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonDebugLogInSuperAdmin = new System.Windows.Forms.Button();
            this.buttonDebugLogInAdmin = new System.Windows.Forms.Button();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxLoginID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBoxLoginPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.textBoxMenu = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuSettings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuInsertComm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonMenuInsertData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.animatorPanelHor = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animatorPanelVer = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelWindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelMenuInsertData.SuspendLayout();
            this.panelMenuReport.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelWindowBar
            // 
            this.panelWindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.panelWindowBar.Controls.Add(this.buttonExit);
            this.panelWindowBar.Controls.Add(this.labelWindowInfo);
            this.animatorPanelVer.SetDecoration(this.panelWindowBar, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelWindowBar, BunifuAnimatorNS.DecorationType.None);
            this.panelWindowBar.Location = new System.Drawing.Point(0, 0);
            this.panelWindowBar.Name = "panelWindowBar";
            this.panelWindowBar.Size = new System.Drawing.Size(1476, 47);
            this.panelWindowBar.TabIndex = 0;
            this.panelWindowBar.Click += new System.EventHandler(this.panelWindowBar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.animatorPanelVer.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonExit, BunifuAnimatorNS.DecorationType.None);
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageActive = null;
            this.buttonExit.Location = new System.Drawing.Point(1121, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(25, 25);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonExit.TabIndex = 12;
            this.buttonExit.TabStop = false;
            this.buttonExit.Zoom = 10;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelWindowInfo
            // 
            this.labelWindowInfo.AutoSize = true;
            this.animatorPanelHor.SetDecoration(this.labelWindowInfo, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.labelWindowInfo, BunifuAnimatorNS.DecorationType.None);
            this.labelWindowInfo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelWindowInfo.ForeColor = System.Drawing.Color.White;
            this.labelWindowInfo.Location = new System.Drawing.Point(28, 15);
            this.labelWindowInfo.Name = "labelWindowInfo";
            this.labelWindowInfo.Size = new System.Drawing.Size(123, 19);
            this.labelWindowInfo.TabIndex = 10;
            this.labelWindowInfo.Text = "Property Agency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animatorPanelHor.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "SIGN IN";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.BorderRadius = 0;
            this.buttonLogin.ButtonText = "LOGIN";
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonLogin, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonLogin, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogin.Iconimage = null;
            this.buttonLogin.Iconimage_right = null;
            this.buttonLogin.Iconimage_right_Selected = null;
            this.buttonLogin.Iconimage_Selected = null;
            this.buttonLogin.IconMarginLeft = 0;
            this.buttonLogin.IconMarginRight = 0;
            this.buttonLogin.IconRightVisible = true;
            this.buttonLogin.IconRightZoom = 0D;
            this.buttonLogin.IconVisible = true;
            this.buttonLogin.IconZoom = 90D;
            this.buttonLogin.IsTab = false;
            this.buttonLogin.Location = new System.Drawing.Point(302, 247);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogin.selected = false;
            this.buttonLogin.Size = new System.Drawing.Size(370, 48);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogin.Textcolor = System.Drawing.Color.White;
            this.buttonLogin.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animatorPanelHor.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "USERNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animatorPanelHor.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PASSWORD";
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.panelMenuInsertData);
            this.panelLogin.Controls.Add(this.panelMenuReport);
            this.panelLogin.Controls.Add(this.buttonDebugLogInSuperAdmin);
            this.panelLogin.Controls.Add(this.buttonDebugLogInAdmin);
            this.panelLogin.Controls.Add(this.panelSignIn);
            this.animatorPanelVer.SetDecoration(this.panelLogin, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelLogin, BunifuAnimatorNS.DecorationType.None);
            this.panelLogin.Location = new System.Drawing.Point(100, 47);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1058, 715);
            this.panelLogin.TabIndex = 10;
            this.panelLogin.Click += new System.EventHandler(this.panelLogin_Click);
            // 
            // panelMenuInsertData
            // 
            this.panelMenuInsertData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panelMenuInsertData.Controls.Add(this.buttonMenuAgent);
            this.panelMenuInsertData.Controls.Add(this.buttonMenuPrincipal);
            this.panelMenuInsertData.Controls.Add(this.buttonMenuBranch);
            this.animatorPanelVer.SetDecoration(this.panelMenuInsertData, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelMenuInsertData, BunifuAnimatorNS.DecorationType.None);
            this.panelMenuInsertData.Location = new System.Drawing.Point(704, 527);
            this.panelMenuInsertData.Name = "panelMenuInsertData";
            this.panelMenuInsertData.Size = new System.Drawing.Size(272, 200);
            this.panelMenuInsertData.TabIndex = 11;
            // 
            // buttonMenuAgent
            // 
            this.buttonMenuAgent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuAgent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuAgent.BorderRadius = 0;
            this.buttonMenuAgent.ButtonText = "Agent";
            this.buttonMenuAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuAgent, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuAgent, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuAgent.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuAgent.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuAgent.Iconimage = null;
            this.buttonMenuAgent.Iconimage_right = null;
            this.buttonMenuAgent.Iconimage_right_Selected = null;
            this.buttonMenuAgent.Iconimage_Selected = null;
            this.buttonMenuAgent.IconMarginLeft = 0;
            this.buttonMenuAgent.IconMarginRight = 0;
            this.buttonMenuAgent.IconRightVisible = true;
            this.buttonMenuAgent.IconRightZoom = 0D;
            this.buttonMenuAgent.IconVisible = true;
            this.buttonMenuAgent.IconZoom = 90D;
            this.buttonMenuAgent.IsTab = false;
            this.buttonMenuAgent.Location = new System.Drawing.Point(0, 0);
            this.buttonMenuAgent.Name = "buttonMenuAgent";
            this.buttonMenuAgent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuAgent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuAgent.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuAgent.selected = false;
            this.buttonMenuAgent.Size = new System.Drawing.Size(279, 64);
            this.buttonMenuAgent.TabIndex = 20;
            this.buttonMenuAgent.Text = "Agent";
            this.buttonMenuAgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuAgent.Textcolor = System.Drawing.Color.White;
            this.buttonMenuAgent.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuAgent.Click += new System.EventHandler(this.buttonMenuAgent_Click);
            // 
            // buttonMenuPrincipal
            // 
            this.buttonMenuPrincipal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuPrincipal.BorderRadius = 0;
            this.buttonMenuPrincipal.ButtonText = "Principal and Vice P.";
            this.buttonMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuPrincipal.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuPrincipal.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuPrincipal.Iconimage = null;
            this.buttonMenuPrincipal.Iconimage_right = null;
            this.buttonMenuPrincipal.Iconimage_right_Selected = null;
            this.buttonMenuPrincipal.Iconimage_Selected = null;
            this.buttonMenuPrincipal.IconMarginLeft = 0;
            this.buttonMenuPrincipal.IconMarginRight = 0;
            this.buttonMenuPrincipal.IconRightVisible = true;
            this.buttonMenuPrincipal.IconRightZoom = 0D;
            this.buttonMenuPrincipal.IconVisible = true;
            this.buttonMenuPrincipal.IconZoom = 90D;
            this.buttonMenuPrincipal.IsTab = false;
            this.buttonMenuPrincipal.Location = new System.Drawing.Point(0, 137);
            this.buttonMenuPrincipal.Name = "buttonMenuPrincipal";
            this.buttonMenuPrincipal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuPrincipal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuPrincipal.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuPrincipal.selected = false;
            this.buttonMenuPrincipal.Size = new System.Drawing.Size(279, 64);
            this.buttonMenuPrincipal.TabIndex = 22;
            this.buttonMenuPrincipal.Text = "Principal and Vice P.";
            this.buttonMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuPrincipal.Textcolor = System.Drawing.Color.White;
            this.buttonMenuPrincipal.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuPrincipal.Click += new System.EventHandler(this.buttonMenuPrincipal_Click);
            // 
            // buttonMenuBranch
            // 
            this.buttonMenuBranch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuBranch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuBranch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuBranch.BorderRadius = 0;
            this.buttonMenuBranch.ButtonText = "Branch";
            this.buttonMenuBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuBranch, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuBranch, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuBranch.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuBranch.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuBranch.Iconimage = null;
            this.buttonMenuBranch.Iconimage_right = null;
            this.buttonMenuBranch.Iconimage_right_Selected = null;
            this.buttonMenuBranch.Iconimage_Selected = null;
            this.buttonMenuBranch.IconMarginLeft = 0;
            this.buttonMenuBranch.IconMarginRight = 0;
            this.buttonMenuBranch.IconRightVisible = true;
            this.buttonMenuBranch.IconRightZoom = 0D;
            this.buttonMenuBranch.IconVisible = true;
            this.buttonMenuBranch.IconZoom = 90D;
            this.buttonMenuBranch.IsTab = false;
            this.buttonMenuBranch.Location = new System.Drawing.Point(0, 68);
            this.buttonMenuBranch.Name = "buttonMenuBranch";
            this.buttonMenuBranch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuBranch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuBranch.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuBranch.selected = false;
            this.buttonMenuBranch.Size = new System.Drawing.Size(279, 64);
            this.buttonMenuBranch.TabIndex = 21;
            this.buttonMenuBranch.Text = "Branch";
            this.buttonMenuBranch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuBranch.Textcolor = System.Drawing.Color.White;
            this.buttonMenuBranch.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuBranch.Click += new System.EventHandler(this.buttonMenuBranch_Click);
            // 
            // panelMenuReport
            // 
            this.panelMenuReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panelMenuReport.Controls.Add(this.buttonShowCommissionSummary);
            this.panelMenuReport.Controls.Add(this.buttonShowAgentsTransactionsByUnits);
            this.panelMenuReport.Controls.Add(this.buttonSpecificClossing);
            this.panelMenuReport.Controls.Add(this.buttonShowReportTree);
            this.animatorPanelVer.SetDecoration(this.panelMenuReport, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelMenuReport, BunifuAnimatorNS.DecorationType.None);
            this.panelMenuReport.Location = new System.Drawing.Point(325, 88);
            this.panelMenuReport.Name = "panelMenuReport";
            this.panelMenuReport.Size = new System.Drawing.Size(407, 277);
            this.panelMenuReport.TabIndex = 23;
            // 
            // buttonShowCommissionSummary
            // 
            this.buttonShowCommissionSummary.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonShowCommissionSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowCommissionSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowCommissionSummary.BorderRadius = 0;
            this.buttonShowCommissionSummary.ButtonText = "Show Commission Summary";
            this.buttonShowCommissionSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonShowCommissionSummary, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonShowCommissionSummary, BunifuAnimatorNS.DecorationType.None);
            this.buttonShowCommissionSummary.DisabledColor = System.Drawing.Color.Gray;
            this.buttonShowCommissionSummary.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonShowCommissionSummary.Iconimage = null;
            this.buttonShowCommissionSummary.Iconimage_right = null;
            this.buttonShowCommissionSummary.Iconimage_right_Selected = null;
            this.buttonShowCommissionSummary.Iconimage_Selected = null;
            this.buttonShowCommissionSummary.IconMarginLeft = 0;
            this.buttonShowCommissionSummary.IconMarginRight = 0;
            this.buttonShowCommissionSummary.IconRightVisible = true;
            this.buttonShowCommissionSummary.IconRightZoom = 0D;
            this.buttonShowCommissionSummary.IconVisible = true;
            this.buttonShowCommissionSummary.IconZoom = 90D;
            this.buttonShowCommissionSummary.IsTab = false;
            this.buttonShowCommissionSummary.Location = new System.Drawing.Point(0, 204);
            this.buttonShowCommissionSummary.Name = "buttonShowCommissionSummary";
            this.buttonShowCommissionSummary.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowCommissionSummary.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonShowCommissionSummary.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonShowCommissionSummary.selected = false;
            this.buttonShowCommissionSummary.Size = new System.Drawing.Size(407, 64);
            this.buttonShowCommissionSummary.TabIndex = 23;
            this.buttonShowCommissionSummary.Text = "Show Commission Summary";
            this.buttonShowCommissionSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonShowCommissionSummary.Textcolor = System.Drawing.Color.White;
            this.buttonShowCommissionSummary.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonShowCommissionSummary.Click += new System.EventHandler(this.buttonShowCommissionSummary_Click);
            // 
            // buttonShowAgentsTransactionsByUnits
            // 
            this.buttonShowAgentsTransactionsByUnits.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonShowAgentsTransactionsByUnits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowAgentsTransactionsByUnits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowAgentsTransactionsByUnits.BorderRadius = 0;
            this.buttonShowAgentsTransactionsByUnits.ButtonText = "Show Agents Closings Summary";
            this.buttonShowAgentsTransactionsByUnits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonShowAgentsTransactionsByUnits, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonShowAgentsTransactionsByUnits, BunifuAnimatorNS.DecorationType.None);
            this.buttonShowAgentsTransactionsByUnits.DisabledColor = System.Drawing.Color.Gray;
            this.buttonShowAgentsTransactionsByUnits.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonShowAgentsTransactionsByUnits.Iconimage = null;
            this.buttonShowAgentsTransactionsByUnits.Iconimage_right = null;
            this.buttonShowAgentsTransactionsByUnits.Iconimage_right_Selected = null;
            this.buttonShowAgentsTransactionsByUnits.Iconimage_Selected = null;
            this.buttonShowAgentsTransactionsByUnits.IconMarginLeft = 0;
            this.buttonShowAgentsTransactionsByUnits.IconMarginRight = 0;
            this.buttonShowAgentsTransactionsByUnits.IconRightVisible = true;
            this.buttonShowAgentsTransactionsByUnits.IconRightZoom = 0D;
            this.buttonShowAgentsTransactionsByUnits.IconVisible = true;
            this.buttonShowAgentsTransactionsByUnits.IconZoom = 90D;
            this.buttonShowAgentsTransactionsByUnits.IsTab = false;
            this.buttonShowAgentsTransactionsByUnits.Location = new System.Drawing.Point(0, 136);
            this.buttonShowAgentsTransactionsByUnits.Name = "buttonShowAgentsTransactionsByUnits";
            this.buttonShowAgentsTransactionsByUnits.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowAgentsTransactionsByUnits.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonShowAgentsTransactionsByUnits.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonShowAgentsTransactionsByUnits.selected = false;
            this.buttonShowAgentsTransactionsByUnits.Size = new System.Drawing.Size(407, 64);
            this.buttonShowAgentsTransactionsByUnits.TabIndex = 22;
            this.buttonShowAgentsTransactionsByUnits.Text = "Show Agents Closings Summary";
            this.buttonShowAgentsTransactionsByUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonShowAgentsTransactionsByUnits.Textcolor = System.Drawing.Color.White;
            this.buttonShowAgentsTransactionsByUnits.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonShowAgentsTransactionsByUnits.Click += new System.EventHandler(this.buttonShowAgentsTransactionsByUnits_Click);
            // 
            // buttonSpecificClossing
            // 
            this.buttonSpecificClossing.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonSpecificClossing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonSpecificClossing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSpecificClossing.BorderRadius = 0;
            this.buttonSpecificClossing.ButtonText = "Show Specific Closing";
            this.buttonSpecificClossing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonSpecificClossing, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonSpecificClossing, BunifuAnimatorNS.DecorationType.None);
            this.buttonSpecificClossing.DisabledColor = System.Drawing.Color.Gray;
            this.buttonSpecificClossing.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonSpecificClossing.Iconimage = null;
            this.buttonSpecificClossing.Iconimage_right = null;
            this.buttonSpecificClossing.Iconimage_right_Selected = null;
            this.buttonSpecificClossing.Iconimage_Selected = null;
            this.buttonSpecificClossing.IconMarginLeft = 0;
            this.buttonSpecificClossing.IconMarginRight = 0;
            this.buttonSpecificClossing.IconRightVisible = true;
            this.buttonSpecificClossing.IconRightZoom = 0D;
            this.buttonSpecificClossing.IconVisible = true;
            this.buttonSpecificClossing.IconZoom = 90D;
            this.buttonSpecificClossing.IsTab = false;
            this.buttonSpecificClossing.Location = new System.Drawing.Point(0, 68);
            this.buttonSpecificClossing.Name = "buttonSpecificClossing";
            this.buttonSpecificClossing.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonSpecificClossing.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonSpecificClossing.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSpecificClossing.selected = false;
            this.buttonSpecificClossing.Size = new System.Drawing.Size(407, 64);
            this.buttonSpecificClossing.TabIndex = 21;
            this.buttonSpecificClossing.Text = "Show Specific Closing";
            this.buttonSpecificClossing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSpecificClossing.Textcolor = System.Drawing.Color.White;
            this.buttonSpecificClossing.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonSpecificClossing.Click += new System.EventHandler(this.buttonSpecificClossing_Click);
            // 
            // buttonShowReportTree
            // 
            this.buttonShowReportTree.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonShowReportTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowReportTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowReportTree.BorderRadius = 0;
            this.buttonShowReportTree.ButtonText = "Show Tree";
            this.buttonShowReportTree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonShowReportTree, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonShowReportTree, BunifuAnimatorNS.DecorationType.None);
            this.buttonShowReportTree.DisabledColor = System.Drawing.Color.Gray;
            this.buttonShowReportTree.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonShowReportTree.Iconimage = null;
            this.buttonShowReportTree.Iconimage_right = null;
            this.buttonShowReportTree.Iconimage_right_Selected = null;
            this.buttonShowReportTree.Iconimage_Selected = null;
            this.buttonShowReportTree.IconMarginLeft = 0;
            this.buttonShowReportTree.IconMarginRight = 0;
            this.buttonShowReportTree.IconRightVisible = true;
            this.buttonShowReportTree.IconRightZoom = 0D;
            this.buttonShowReportTree.IconVisible = true;
            this.buttonShowReportTree.IconZoom = 90D;
            this.buttonShowReportTree.IsTab = false;
            this.buttonShowReportTree.Location = new System.Drawing.Point(0, 0);
            this.buttonShowReportTree.Name = "buttonShowReportTree";
            this.buttonShowReportTree.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonShowReportTree.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonShowReportTree.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonShowReportTree.selected = false;
            this.buttonShowReportTree.Size = new System.Drawing.Size(407, 64);
            this.buttonShowReportTree.TabIndex = 20;
            this.buttonShowReportTree.Text = "Show Tree";
            this.buttonShowReportTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonShowReportTree.Textcolor = System.Drawing.Color.White;
            this.buttonShowReportTree.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonShowReportTree.Click += new System.EventHandler(this.buttonShowReportTree_Click);
            // 
            // buttonDebugLogInSuperAdmin
            // 
            this.animatorPanelHor.SetDecoration(this.buttonDebugLogInSuperAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.buttonDebugLogInSuperAdmin, BunifuAnimatorNS.DecorationType.None);
            this.buttonDebugLogInSuperAdmin.Location = new System.Drawing.Point(591, 118);
            this.buttonDebugLogInSuperAdmin.Name = "buttonDebugLogInSuperAdmin";
            this.buttonDebugLogInSuperAdmin.Size = new System.Drawing.Size(168, 23);
            this.buttonDebugLogInSuperAdmin.TabIndex = 25;
            this.buttonDebugLogInSuperAdmin.Text = "debug super admin";
            this.buttonDebugLogInSuperAdmin.UseVisualStyleBackColor = true;
            this.buttonDebugLogInSuperAdmin.Click += new System.EventHandler(this.buttonDebugLogInSuperAdmin_Click_1);
            // 
            // buttonDebugLogInAdmin
            // 
            this.animatorPanelHor.SetDecoration(this.buttonDebugLogInAdmin, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.buttonDebugLogInAdmin, BunifuAnimatorNS.DecorationType.None);
            this.buttonDebugLogInAdmin.Location = new System.Drawing.Point(592, 32);
            this.buttonDebugLogInAdmin.Name = "buttonDebugLogInAdmin";
            this.buttonDebugLogInAdmin.Size = new System.Drawing.Size(187, 23);
            this.buttonDebugLogInAdmin.TabIndex = 24;
            this.buttonDebugLogInAdmin.Text = "debug admin";
            this.buttonDebugLogInAdmin.UseVisualStyleBackColor = true;
            this.buttonDebugLogInAdmin.Visible = false;
            this.buttonDebugLogInAdmin.Click += new System.EventHandler(this.buttonDebugLogInAdmin_Click_1);
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.pictureBox1);
            this.panelSignIn.Controls.Add(this.textBoxLoginID);
            this.panelSignIn.Controls.Add(this.label2);
            this.panelSignIn.Controls.Add(this.buttonLogin);
            this.panelSignIn.Controls.Add(this.textBoxLoginPass);
            this.panelSignIn.Controls.Add(this.label1);
            this.panelSignIn.Controls.Add(this.label3);
            this.animatorPanelVer.SetDecoration(this.panelSignIn, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelSignIn, BunifuAnimatorNS.DecorationType.None);
            this.panelSignIn.Location = new System.Drawing.Point(148, 191);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(704, 330);
            this.panelSignIn.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.animatorPanelHor.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::PropertyAgencyCommissionNu.Properties.Resources._63699_user_silhouettew;
            this.pictureBox1.Location = new System.Drawing.Point(9, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxLoginID
            // 
            this.textBoxLoginID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.textBoxLoginID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animatorPanelVer.SetDecoration(this.textBoxLoginID, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.textBoxLoginID, BunifuAnimatorNS.DecorationType.None);
            this.textBoxLoginID.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.textBoxLoginID.ForeColor = System.Drawing.Color.White;
            this.textBoxLoginID.HintForeColor = System.Drawing.Color.White;
            this.textBoxLoginID.HintText = "";
            this.textBoxLoginID.isPassword = false;
            this.textBoxLoginID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.textBoxLoginID.LineIdleColor = System.Drawing.Color.White;
            this.textBoxLoginID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.textBoxLoginID.LineThickness = 5;
            this.textBoxLoginID.Location = new System.Drawing.Point(302, 97);
            this.textBoxLoginID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginID.Name = "textBoxLoginID";
            this.textBoxLoginID.Size = new System.Drawing.Size(370, 44);
            this.textBoxLoginID.TabIndex = 4;
            this.textBoxLoginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // textBoxLoginPass
            // 
            this.textBoxLoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.textBoxLoginPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animatorPanelVer.SetDecoration(this.textBoxLoginPass, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.textBoxLoginPass, BunifuAnimatorNS.DecorationType.None);
            this.textBoxLoginPass.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.textBoxLoginPass.ForeColor = System.Drawing.Color.White;
            this.textBoxLoginPass.HintForeColor = System.Drawing.Color.White;
            this.textBoxLoginPass.HintText = "";
            this.textBoxLoginPass.isPassword = true;
            this.textBoxLoginPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.textBoxLoginPass.LineIdleColor = System.Drawing.Color.White;
            this.textBoxLoginPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.textBoxLoginPass.LineThickness = 5;
            this.textBoxLoginPass.Location = new System.Drawing.Point(302, 176);
            this.textBoxLoginPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginPass.Name = "textBoxLoginPass";
            this.textBoxLoginPass.Size = new System.Drawing.Size(370, 44);
            this.textBoxLoginPass.TabIndex = 5;
            this.textBoxLoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panelSideMenu.Controls.Add(this.textBoxMenu);
            this.panelSideMenu.Controls.Add(this.buttonLogOut);
            this.panelSideMenu.Controls.Add(this.buttonMenuSettings);
            this.panelSideMenu.Controls.Add(this.buttonMenuReport);
            this.panelSideMenu.Controls.Add(this.buttonMenuInsertComm);
            this.panelSideMenu.Controls.Add(this.buttonMenuInsertData);
            this.panelSideMenu.Controls.Add(this.labelMenu);
            this.panelSideMenu.Controls.Add(this.buttonMenu);
            this.animatorPanelVer.SetDecoration(this.panelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.panelSideMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelSideMenu.Location = new System.Drawing.Point(0, 47);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(335, 923);
            this.panelSideMenu.TabIndex = 10;
            // 
            // textBoxMenu
            // 
            this.textBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.textBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animatorPanelHor.SetDecoration(this.textBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.textBoxMenu, BunifuAnimatorNS.DecorationType.None);
            this.textBoxMenu.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.textBoxMenu.ForeColor = System.Drawing.Color.White;
            this.textBoxMenu.Location = new System.Drawing.Point(65, 32);
            this.textBoxMenu.Multiline = true;
            this.textBoxMenu.Name = "textBoxMenu";
            this.textBoxMenu.Size = new System.Drawing.Size(270, 35);
            this.textBoxMenu.TabIndex = 21;
            this.textBoxMenu.Text = "MENU";
            this.textBoxMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogOut.BorderRadius = 0;
            this.buttonLogOut.ButtonText = "Log Out";
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonLogOut, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonLogOut, BunifuAnimatorNS.DecorationType.None);
            this.buttonLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.buttonLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Iconimage")));
            this.buttonLogOut.Iconimage_right = null;
            this.buttonLogOut.Iconimage_right_Selected = null;
            this.buttonLogOut.Iconimage_Selected = null;
            this.buttonLogOut.IconMarginLeft = 30;
            this.buttonLogOut.IconMarginRight = 0;
            this.buttonLogOut.IconRightVisible = true;
            this.buttonLogOut.IconRightZoom = 0D;
            this.buttonLogOut.IconVisible = true;
            this.buttonLogOut.IconZoom = 90D;
            this.buttonLogOut.IsTab = false;
            this.buttonLogOut.Location = new System.Drawing.Point(0, 650);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogOut.selected = false;
            this.buttonLogOut.Size = new System.Drawing.Size(344, 64);
            this.buttonLogOut.TabIndex = 20;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonLogOut.Textcolor = System.Drawing.Color.White;
            this.buttonLogOut.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonLogOut.Click += new System.EventHandler(this.bunifuFlatButtonLogOut_Click_1);
            // 
            // buttonMenuSettings
            // 
            this.buttonMenuSettings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuSettings.BorderRadius = 0;
            this.buttonMenuSettings.ButtonText = "Settings";
            this.buttonMenuSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuSettings, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuSettings, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuSettings.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuSettings.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuSettings.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMenuSettings.Iconimage")));
            this.buttonMenuSettings.Iconimage_right = null;
            this.buttonMenuSettings.Iconimage_right_Selected = null;
            this.buttonMenuSettings.Iconimage_Selected = null;
            this.buttonMenuSettings.IconMarginLeft = 30;
            this.buttonMenuSettings.IconMarginRight = 0;
            this.buttonMenuSettings.IconRightVisible = true;
            this.buttonMenuSettings.IconRightZoom = 0D;
            this.buttonMenuSettings.IconVisible = true;
            this.buttonMenuSettings.IconZoom = 90D;
            this.buttonMenuSettings.IsTab = false;
            this.buttonMenuSettings.Location = new System.Drawing.Point(0, 407);
            this.buttonMenuSettings.Name = "buttonMenuSettings";
            this.buttonMenuSettings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuSettings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuSettings.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuSettings.selected = false;
            this.buttonMenuSettings.Size = new System.Drawing.Size(344, 64);
            this.buttonMenuSettings.TabIndex = 19;
            this.buttonMenuSettings.Text = "Settings";
            this.buttonMenuSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuSettings.Textcolor = System.Drawing.Color.White;
            this.buttonMenuSettings.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuSettings.Click += new System.EventHandler(this.buttonMenuSettings_Click);
            // 
            // buttonMenuReport
            // 
            this.buttonMenuReport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuReport.BorderRadius = 0;
            this.buttonMenuReport.ButtonText = "Report";
            this.buttonMenuReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuReport, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuReport, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuReport.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuReport.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMenuReport.Iconimage")));
            this.buttonMenuReport.Iconimage_right = null;
            this.buttonMenuReport.Iconimage_right_Selected = null;
            this.buttonMenuReport.Iconimage_Selected = null;
            this.buttonMenuReport.IconMarginLeft = 30;
            this.buttonMenuReport.IconMarginRight = 0;
            this.buttonMenuReport.IconRightVisible = true;
            this.buttonMenuReport.IconRightZoom = 0D;
            this.buttonMenuReport.IconVisible = true;
            this.buttonMenuReport.IconZoom = 90D;
            this.buttonMenuReport.IsTab = false;
            this.buttonMenuReport.Location = new System.Drawing.Point(0, 339);
            this.buttonMenuReport.Name = "buttonMenuReport";
            this.buttonMenuReport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuReport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuReport.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuReport.selected = false;
            this.buttonMenuReport.Size = new System.Drawing.Size(344, 64);
            this.buttonMenuReport.TabIndex = 18;
            this.buttonMenuReport.Text = "Report";
            this.buttonMenuReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuReport.Textcolor = System.Drawing.Color.White;
            this.buttonMenuReport.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuReport.Click += new System.EventHandler(this.buttonMenuReport_Click);
            // 
            // buttonMenuInsertComm
            // 
            this.buttonMenuInsertComm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuInsertComm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuInsertComm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuInsertComm.BorderRadius = 0;
            this.buttonMenuInsertComm.ButtonText = "Insert Commission";
            this.buttonMenuInsertComm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuInsertComm, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuInsertComm, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuInsertComm.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuInsertComm.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuInsertComm.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMenuInsertComm.Iconimage")));
            this.buttonMenuInsertComm.Iconimage_right = null;
            this.buttonMenuInsertComm.Iconimage_right_Selected = null;
            this.buttonMenuInsertComm.Iconimage_Selected = null;
            this.buttonMenuInsertComm.IconMarginLeft = 30;
            this.buttonMenuInsertComm.IconMarginRight = 0;
            this.buttonMenuInsertComm.IconRightVisible = true;
            this.buttonMenuInsertComm.IconRightZoom = 0D;
            this.buttonMenuInsertComm.IconVisible = true;
            this.buttonMenuInsertComm.IconZoom = 90D;
            this.buttonMenuInsertComm.IsTab = false;
            this.buttonMenuInsertComm.Location = new System.Drawing.Point(0, 271);
            this.buttonMenuInsertComm.Name = "buttonMenuInsertComm";
            this.buttonMenuInsertComm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuInsertComm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuInsertComm.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuInsertComm.selected = false;
            this.buttonMenuInsertComm.Size = new System.Drawing.Size(344, 64);
            this.buttonMenuInsertComm.TabIndex = 17;
            this.buttonMenuInsertComm.Text = "Insert Commission";
            this.buttonMenuInsertComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuInsertComm.Textcolor = System.Drawing.Color.White;
            this.buttonMenuInsertComm.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuInsertComm.Click += new System.EventHandler(this.buttonMenuInsertComm_Click);
            // 
            // buttonMenuInsertData
            // 
            this.buttonMenuInsertData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(123)))), ((int)(((byte)(131)))));
            this.buttonMenuInsertData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuInsertData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMenuInsertData.BorderRadius = 0;
            this.buttonMenuInsertData.ButtonText = "Insert Data";
            this.buttonMenuInsertData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animatorPanelVer.SetDecoration(this.buttonMenuInsertData, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenuInsertData, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenuInsertData.DisabledColor = System.Drawing.Color.Gray;
            this.buttonMenuInsertData.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonMenuInsertData.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonMenuInsertData.Iconimage")));
            this.buttonMenuInsertData.Iconimage_right = null;
            this.buttonMenuInsertData.Iconimage_right_Selected = null;
            this.buttonMenuInsertData.Iconimage_Selected = null;
            this.buttonMenuInsertData.IconMarginLeft = 30;
            this.buttonMenuInsertData.IconMarginRight = 0;
            this.buttonMenuInsertData.IconRightVisible = true;
            this.buttonMenuInsertData.IconRightZoom = 0D;
            this.buttonMenuInsertData.IconVisible = true;
            this.buttonMenuInsertData.IconZoom = 90D;
            this.buttonMenuInsertData.IsTab = false;
            this.buttonMenuInsertData.Location = new System.Drawing.Point(0, 203);
            this.buttonMenuInsertData.Name = "buttonMenuInsertData";
            this.buttonMenuInsertData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonMenuInsertData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonMenuInsertData.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonMenuInsertData.selected = false;
            this.buttonMenuInsertData.Size = new System.Drawing.Size(344, 64);
            this.buttonMenuInsertData.TabIndex = 16;
            this.buttonMenuInsertData.Text = "Insert Data";
            this.buttonMenuInsertData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMenuInsertData.Textcolor = System.Drawing.Color.White;
            this.buttonMenuInsertData.TextFont = new System.Drawing.Font("Century Gothic", 15F);
            this.buttonMenuInsertData.Click += new System.EventHandler(this.buttonMenuInsertData_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMenu.AutoSize = true;
            this.animatorPanelHor.SetDecoration(this.labelMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this.labelMenu, BunifuAnimatorNS.DecorationType.None);
            this.labelMenu.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMenu.Location = new System.Drawing.Point(155, 84);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(91, 33);
            this.labelMenu.TabIndex = 11;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelMenu.Visible = false;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.animatorPanelVer.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelHor.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageActive = null;
            this.buttonMenu.Location = new System.Drawing.Point(32, 32);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(35, 35);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Zoom = 10;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelWindowBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // animatorPanelHor
            // 
            this.animatorPanelHor.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animatorPanelHor.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animatorPanelHor.DefaultAnimation = animation3;
            // 
            // animatorPanelVer
            // 
            this.animatorPanelVer.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.animatorPanelVer.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.animatorPanelVer.DefaultAnimation = animation4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1158, 762);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelWindowBar);
            this.Controls.Add(this.panelLogin);
            this.animatorPanelHor.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animatorPanelVer.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelWindowBar.ResumeLayout(false);
            this.panelWindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelMenuInsertData.ResumeLayout(false);
            this.panelMenuReport.ResumeLayout(false);
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelWindowBar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelWindowInfo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelSideMenu;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuSettings;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuReport;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuInsertComm;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuInsertData;
        private System.Windows.Forms.Label labelMenu;
        private Bunifu.Framework.UI.BunifuImageButton buttonMenu;
        private Bunifu.Framework.UI.BunifuImageButton buttonExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelMenuInsertData;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuPrincipal;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuBranch;
        private Bunifu.Framework.UI.BunifuFlatButton buttonMenuAgent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxLoginID;
        private BunifuAnimatorNS.BunifuTransition animatorPanelVer;
        private BunifuAnimatorNS.BunifuTransition animatorPanelHor;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Button buttonDebugLogInSuperAdmin;
        private System.Windows.Forms.Button buttonDebugLogInAdmin;
        private System.Windows.Forms.Panel panelMenuReport;
        private Bunifu.Framework.UI.BunifuFlatButton buttonShowAgentsTransactionsByUnits;
        private Bunifu.Framework.UI.BunifuFlatButton buttonSpecificClossing;
        private Bunifu.Framework.UI.BunifuFlatButton buttonShowReportTree;
        private Bunifu.Framework.UI.BunifuFlatButton buttonShowCommissionSummary;
        private Bunifu.Framework.UI.BunifuFlatButton buttonLogOut;
        private System.Windows.Forms.TextBox textBoxMenu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxLoginPass;
    }
}

