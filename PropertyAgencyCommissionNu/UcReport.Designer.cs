namespace PropertyAgencyCommissionNu {
    partial class UcReport {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTree = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxTree = new System.Windows.Forms.PictureBox();
            this.panelShowSpecificClosing = new System.Windows.Forms.Panel();
            this.comboBoxClosingID = new PropertyAgencyCommissionNu.myComboBox();
            this.treeViewSpecificClosing = new System.Windows.Forms.TreeView();
            this.panelAgentsClosingByUnit = new System.Windows.Forms.Panel();
            this.buttonGoTable = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewClosingCount = new System.Windows.Forms.DataGridView();
            this.agentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalnominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTimePickerTo2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panelShowCommissionSummary = new System.Windows.Forms.Panel();
            this.buttonGo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTimePickerFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chartCommission = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).BeginInit();
            this.panelShowSpecificClosing.SuspendLayout();
            this.panelAgentsClosingByUnit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosingCount)).BeginInit();
            this.panelShowCommissionSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCommission)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTree
            // 
            this.panelTree.AutoScroll = true;
            this.panelTree.Controls.Add(this.label5);
            this.panelTree.Controls.Add(this.pictureBoxTree);
            this.panelTree.Location = new System.Drawing.Point(31, 17);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(1058, 715);
            this.panelTree.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(283, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "Agency Tree";
            // 
            // pictureBoxTree
            // 
            this.pictureBoxTree.Location = new System.Drawing.Point(38, 93);
            this.pictureBoxTree.Name = "pictureBoxTree";
            this.pictureBoxTree.Size = new System.Drawing.Size(370, 236);
            this.pictureBoxTree.TabIndex = 0;
            this.pictureBoxTree.TabStop = false;
            this.pictureBoxTree.Click += new System.EventHandler(this.pictureBoxTree_Click);
            // 
            // panelShowSpecificClosing
            // 
            this.panelShowSpecificClosing.Controls.Add(this.comboBoxClosingID);
            this.panelShowSpecificClosing.Controls.Add(this.treeViewSpecificClosing);
            this.panelShowSpecificClosing.Location = new System.Drawing.Point(708, 9);
            this.panelShowSpecificClosing.Name = "panelShowSpecificClosing";
            this.panelShowSpecificClosing.Size = new System.Drawing.Size(1058, 715);
            this.panelShowSpecificClosing.TabIndex = 1;
            // 
            // comboBoxClosingID
            // 
            this.comboBoxClosingID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.comboBoxClosingID.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.comboBoxClosingID.ForeColor = System.Drawing.Color.White;
            this.comboBoxClosingID.FormattingEnabled = true;
            this.comboBoxClosingID.Location = new System.Drawing.Point(97, 33);
            this.comboBoxClosingID.Name = "comboBoxClosingID";
            this.comboBoxClosingID.Size = new System.Drawing.Size(348, 45);
            this.comboBoxClosingID.TabIndex = 1;
            this.comboBoxClosingID.SelectedIndexChanged += new System.EventHandler(this.comboBoxClosingID_SelectedIndexChanged_1);
            // 
            // treeViewSpecificClosing
            // 
            this.treeViewSpecificClosing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.treeViewSpecificClosing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewSpecificClosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewSpecificClosing.ForeColor = System.Drawing.Color.White;
            this.treeViewSpecificClosing.Indent = 28;
            this.treeViewSpecificClosing.ItemHeight = 30;
            this.treeViewSpecificClosing.Location = new System.Drawing.Point(36, 103);
            this.treeViewSpecificClosing.Name = "treeViewSpecificClosing";
            this.treeViewSpecificClosing.Size = new System.Drawing.Size(494, 410);
            this.treeViewSpecificClosing.TabIndex = 0;
            // 
            // panelAgentsClosingByUnit
            // 
            this.panelAgentsClosingByUnit.Controls.Add(this.buttonGoTable);
            this.panelAgentsClosingByUnit.Controls.Add(this.label4);
            this.panelAgentsClosingByUnit.Controls.Add(this.flowLayoutPanel1);
            this.panelAgentsClosingByUnit.Controls.Add(this.label3);
            this.panelAgentsClosingByUnit.Controls.Add(this.dateTimePickerFrom2);
            this.panelAgentsClosingByUnit.Controls.Add(this.dateTimePickerTo2);
            this.panelAgentsClosingByUnit.Location = new System.Drawing.Point(795, 667);
            this.panelAgentsClosingByUnit.Name = "panelAgentsClosingByUnit";
            this.panelAgentsClosingByUnit.Size = new System.Drawing.Size(1058, 715);
            this.panelAgentsClosingByUnit.TabIndex = 1;
            // 
            // buttonGoTable
            // 
            this.buttonGoTable.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGoTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGoTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGoTable.BorderRadius = 0;
            this.buttonGoTable.ButtonText = "GO";
            this.buttonGoTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoTable.DisabledColor = System.Drawing.Color.Gray;
            this.buttonGoTable.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonGoTable.Iconimage = null;
            this.buttonGoTable.Iconimage_right = null;
            this.buttonGoTable.Iconimage_right_Selected = null;
            this.buttonGoTable.Iconimage_Selected = null;
            this.buttonGoTable.IconMarginLeft = 0;
            this.buttonGoTable.IconMarginRight = 0;
            this.buttonGoTable.IconRightVisible = false;
            this.buttonGoTable.IconRightZoom = 0D;
            this.buttonGoTable.IconVisible = false;
            this.buttonGoTable.IconZoom = 90D;
            this.buttonGoTable.IsTab = false;
            this.buttonGoTable.Location = new System.Drawing.Point(595, 50);
            this.buttonGoTable.Name = "buttonGoTable";
            this.buttonGoTable.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGoTable.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonGoTable.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonGoTable.selected = false;
            this.buttonGoTable.Size = new System.Drawing.Size(78, 49);
            this.buttonGoTable.TabIndex = 68;
            this.buttonGoTable.Text = "GO";
            this.buttonGoTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGoTable.Textcolor = System.Drawing.Color.White;
            this.buttonGoTable.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoTable.Click += new System.EventHandler(this.buttonGoTable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 33);
            this.label4.TabIndex = 67;
            this.label4.Text = "From";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridViewClosingCount);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 175);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 459);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewClosingCount
            // 
            this.dataGridViewClosingCount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dataGridViewClosingCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClosingCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentid,
            this.agentname,
            this.counts,
            this.units,
            this.totalnominal});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClosingCount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClosingCount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dataGridViewClosingCount.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClosingCount.Name = "dataGridViewClosingCount";
            this.dataGridViewClosingCount.Size = new System.Drawing.Size(651, 216);
            this.dataGridViewClosingCount.TabIndex = 0;
            // 
            // agentid
            // 
            this.agentid.HeaderText = "ID";
            this.agentid.Name = "agentid";
            // 
            // agentname
            // 
            this.agentname.HeaderText = "Name";
            this.agentname.Name = "agentname";
            this.agentname.Width = 200;
            // 
            // counts
            // 
            this.counts.HeaderText = "Closing Count";
            this.counts.Name = "counts";
            // 
            // units
            // 
            this.units.HeaderText = "Units";
            this.units.Name = "units";
            // 
            // totalnominal
            // 
            this.totalnominal.HeaderText = "Total Nominal";
            this.totalnominal.Name = "totalnominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 33);
            this.label3.TabIndex = 65;
            this.label3.Text = "To";
            // 
            // dateTimePickerFrom2
            // 
            this.dateTimePickerFrom2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dateTimePickerFrom2.BorderRadius = 0;
            this.dateTimePickerFrom2.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerFrom2.FormatCustom = "dddd, dd-MMMM-YYYYY";
            this.dateTimePickerFrom2.Location = new System.Drawing.Point(19, 105);
            this.dateTimePickerFrom2.Name = "dateTimePickerFrom2";
            this.dateTimePickerFrom2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerFrom2.Size = new System.Drawing.Size(309, 44);
            this.dateTimePickerFrom2.TabIndex = 66;
            this.dateTimePickerFrom2.Value = new System.DateTime(2017, 6, 18, 10, 58, 37, 713);
            // 
            // dateTimePickerTo2
            // 
            this.dateTimePickerTo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dateTimePickerTo2.BorderRadius = 0;
            this.dateTimePickerTo2.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerTo2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTo2.FormatCustom = "dddd, dd-MMMM-YYYYY";
            this.dateTimePickerTo2.Location = new System.Drawing.Point(364, 105);
            this.dateTimePickerTo2.Name = "dateTimePickerTo2";
            this.dateTimePickerTo2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerTo2.Size = new System.Drawing.Size(309, 44);
            this.dateTimePickerTo2.TabIndex = 64;
            this.dateTimePickerTo2.Value = new System.DateTime(2017, 6, 18, 10, 58, 37, 713);
            // 
            // panelShowCommissionSummary
            // 
            this.panelShowCommissionSummary.Controls.Add(this.buttonGo);
            this.panelShowCommissionSummary.Controls.Add(this.label2);
            this.panelShowCommissionSummary.Controls.Add(this.label46);
            this.panelShowCommissionSummary.Controls.Add(this.dateTimePickerTo);
            this.panelShowCommissionSummary.Controls.Add(this.dateTimePickerFrom);
            this.panelShowCommissionSummary.Controls.Add(this.label1);
            this.panelShowCommissionSummary.Controls.Add(this.chartCommission);
            this.panelShowCommissionSummary.Location = new System.Drawing.Point(1025, 26);
            this.panelShowCommissionSummary.Name = "panelShowCommissionSummary";
            this.panelShowCommissionSummary.Size = new System.Drawing.Size(1058, 715);
            this.panelShowCommissionSummary.TabIndex = 2;
            // 
            // buttonGo
            // 
            this.buttonGo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGo.BorderRadius = 0;
            this.buttonGo.ButtonText = "GO";
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGo.DisabledColor = System.Drawing.Color.Gray;
            this.buttonGo.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonGo.Iconimage = null;
            this.buttonGo.Iconimage_right = null;
            this.buttonGo.Iconimage_right_Selected = null;
            this.buttonGo.Iconimage_Selected = null;
            this.buttonGo.IconMarginLeft = 0;
            this.buttonGo.IconMarginRight = 0;
            this.buttonGo.IconRightVisible = false;
            this.buttonGo.IconRightZoom = 0D;
            this.buttonGo.IconVisible = false;
            this.buttonGo.IconZoom = 90D;
            this.buttonGo.IsTab = false;
            this.buttonGo.Location = new System.Drawing.Point(652, 33);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.buttonGo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(130)))), ((int)(((byte)(146)))));
            this.buttonGo.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonGo.selected = false;
            this.buttonGo.Size = new System.Drawing.Size(78, 49);
            this.buttonGo.TabIndex = 65;
            this.buttonGo.Text = "GO";
            this.buttonGo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGo.Textcolor = System.Drawing.Color.White;
            this.buttonGo.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 49);
            this.label2.TabIndex = 64;
            this.label2.Text = "To";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(12, 33);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(118, 49);
            this.label46.TabIndex = 63;
            this.label46.Text = "From";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dateTimePickerTo.BorderRadius = 0;
            this.dateTimePickerTo.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTo.FormatCustom = "dddd, dd-MMMM-YYYYY";
            this.dateTimePickerTo.Location = new System.Drawing.Point(421, 99);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerTo.Size = new System.Drawing.Size(309, 44);
            this.dateTimePickerTo.TabIndex = 62;
            this.dateTimePickerTo.Value = new System.DateTime(2017, 6, 18, 10, 58, 37, 713);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.dateTimePickerFrom.BorderRadius = 0;
            this.dateTimePickerFrom.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerFrom.FormatCustom = "dddd, dd-MMMM-YYYYY";
            this.dateTimePickerFrom.Location = new System.Drawing.Point(21, 99);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePickerFrom.Size = new System.Drawing.Size(309, 44);
            this.dateTimePickerFrom.TabIndex = 61;
            this.dateTimePickerFrom.Value = new System.DateTime(2017, 6, 18, 10, 58, 37, 713);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            // 
            // chartCommission
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCommission.ChartAreas.Add(chartArea1);
            legend1.Name = "Commissions";
            this.chartCommission.Legends.Add(legend1);
            this.chartCommission.Location = new System.Drawing.Point(21, 165);
            this.chartCommission.Name = "chartCommission";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Commissions";
            series1.Name = "Commissions";
            this.chartCommission.Series.Add(series1);
            this.chartCommission.Size = new System.Drawing.Size(709, 510);
            this.chartCommission.TabIndex = 0;
            this.chartCommission.Text = "chart1";
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.panelShowCommissionSummary);
            this.Controls.Add(this.panelShowSpecificClosing);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelAgentsClosingByUnit);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(1058, 715);
            this.panelTree.ResumeLayout(false);
            this.panelTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTree)).EndInit();
            this.panelShowSpecificClosing.ResumeLayout(false);
            this.panelAgentsClosingByUnit.ResumeLayout(false);
            this.panelAgentsClosingByUnit.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClosingCount)).EndInit();
            this.panelShowCommissionSummary.ResumeLayout(false);
            this.panelShowCommissionSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCommission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Panel panelShowSpecificClosing;
        private System.Windows.Forms.PictureBox pictureBoxTree;
        private System.Windows.Forms.TreeView treeViewSpecificClosing;
        private System.Windows.Forms.Panel panelAgentsClosingByUnit;
        private System.Windows.Forms.Panel panelShowCommissionSummary;
        private myComboBox comboBoxClosingID;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCommission;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerTo;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label46;
        private Bunifu.Framework.UI.BunifuFlatButton buttonGo;
        private System.Windows.Forms.DataGridView dataGridViewClosingCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerFrom2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerTo2;
        private Bunifu.Framework.UI.BunifuFlatButton buttonGoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn counts;
        private System.Windows.Forms.DataGridViewTextBoxColumn units;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalnominal;
        private System.Windows.Forms.Label label5;
    }
}
