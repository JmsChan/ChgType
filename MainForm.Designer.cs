namespace ChgType
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelBrokerCode;
        private System.Windows.Forms.Label labelInvestorAccount;
        private System.Windows.Forms.Label labelProxyNumber;
        private System.Windows.Forms.Label labelTransactionNumber;
        private System.Windows.Forms.Label labelBuySell;
        private System.Windows.Forms.Label labelStockCode;
        private System.Windows.Forms.Label labelChangeType;
        private System.Windows.Forms.Label labelMarginCode;
        private System.Windows.Forms.Label labelSplitShares;
        private System.Windows.Forms.Label labelSplitAmount;
        private System.Windows.Forms.Label labelOrderType;
        private System.Windows.Forms.TextBox textBrokerCode;
        private System.Windows.Forms.TextBox textInvestorAccount;
        private System.Windows.Forms.TextBox textProxyNumber;
        private System.Windows.Forms.TextBox textTransactionNumber;
        private System.Windows.Forms.ComboBox comboBuySell;
        private System.Windows.Forms.TextBox textStockCode;
        private System.Windows.Forms.ComboBox comboChangeType;
        private System.Windows.Forms.TextBox textMarginCode;
        private System.Windows.Forms.NumericUpDown numericSplitShares;
        private System.Windows.Forms.NumericUpDown numericSplitAmount;
        private System.Windows.Forms.ComboBox comboOrderType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            this.labelBrokerCode = new System.Windows.Forms.Label();
            this.textBrokerCode = new System.Windows.Forms.TextBox();
            this.labelInvestorAccount = new System.Windows.Forms.Label();
            this.textInvestorAccount = new System.Windows.Forms.TextBox();
            this.labelProxyNumber = new System.Windows.Forms.Label();
            this.textProxyNumber = new System.Windows.Forms.TextBox();
            this.labelTransactionNumber = new System.Windows.Forms.Label();
            this.textTransactionNumber = new System.Windows.Forms.TextBox();
            this.labelBuySell = new System.Windows.Forms.Label();
            this.comboBuySell = new System.Windows.Forms.ComboBox();
            this.labelStockCode = new System.Windows.Forms.Label();
            this.textStockCode = new System.Windows.Forms.TextBox();
            this.labelChangeType = new System.Windows.Forms.Label();
            this.comboChangeType = new System.Windows.Forms.ComboBox();
            this.labelMarginCode = new System.Windows.Forms.Label();
            this.textMarginCode = new System.Windows.Forms.TextBox();
            this.labelSplitShares = new System.Windows.Forms.Label();
            this.numericSplitShares = new System.Windows.Forms.NumericUpDown();
            this.labelSplitAmount = new System.Windows.Forms.Label();
            this.numericSplitAmount = new System.Windows.Forms.NumericUpDown();
            this.labelOrderType = new System.Windows.Forms.Label();
            this.comboOrderType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitShares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelInputs
            // 
            this.tableLayoutPanelInputs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelInputs.ColumnCount = 4;
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55556F));
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.77778F));
            this.tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.55556F));
            this.tableLayoutPanelInputs.Controls.Add(this.labelBrokerCode, 0, 0);
            this.tableLayoutPanelInputs.Controls.Add(this.textBrokerCode, 1, 0);
            this.tableLayoutPanelInputs.Controls.Add(this.labelInvestorAccount, 2, 0);
            this.tableLayoutPanelInputs.Controls.Add(this.textInvestorAccount, 3, 0);
            this.tableLayoutPanelInputs.Controls.Add(this.labelProxyNumber, 0, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.textProxyNumber, 1, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.labelTransactionNumber, 2, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.textTransactionNumber, 3, 1);
            this.tableLayoutPanelInputs.Controls.Add(this.labelBuySell, 0, 2);
            this.tableLayoutPanelInputs.Controls.Add(this.comboBuySell, 1, 2);
            this.tableLayoutPanelInputs.Controls.Add(this.labelStockCode, 2, 2);
            this.tableLayoutPanelInputs.Controls.Add(this.textStockCode, 3, 2);
            this.tableLayoutPanelInputs.Controls.Add(this.labelChangeType, 0, 3);
            this.tableLayoutPanelInputs.Controls.Add(this.comboChangeType, 1, 3);
            this.tableLayoutPanelInputs.Controls.Add(this.labelMarginCode, 2, 3);
            this.tableLayoutPanelInputs.Controls.Add(this.textMarginCode, 3, 3);
            this.tableLayoutPanelInputs.Controls.Add(this.labelSplitShares, 0, 4);
            this.tableLayoutPanelInputs.Controls.Add(this.numericSplitShares, 1, 4);
            this.tableLayoutPanelInputs.Controls.Add(this.labelSplitAmount, 2, 4);
            this.tableLayoutPanelInputs.Controls.Add(this.numericSplitAmount, 3, 4);
            this.tableLayoutPanelInputs.Controls.Add(this.labelOrderType, 0, 5);
            this.tableLayoutPanelInputs.Controls.Add(this.comboOrderType, 1, 5);
            this.tableLayoutPanelInputs.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelInputs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            this.tableLayoutPanelInputs.RowCount = 6;
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelInputs.Size = new System.Drawing.Size(900, 170);
            this.tableLayoutPanelInputs.TabIndex = 0;
            // 
            // labelBrokerCode
            // 
            this.labelBrokerCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBrokerCode.AutoSize = true;
            this.labelBrokerCode.Location = new System.Drawing.Point(3, 7);
            this.labelBrokerCode.Name = "labelBrokerCode";
            this.labelBrokerCode.Size = new System.Drawing.Size(65, 12);
            this.labelBrokerCode.TabIndex = 0;
            this.labelBrokerCode.Text = "證券商代號";
            // 
            // textBrokerCode
            // 
            this.textBrokerCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBrokerCode.Location = new System.Drawing.Point(188, 2);
            this.textBrokerCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBrokerCode.Name = "textBrokerCode";
            this.textBrokerCode.Size = new System.Drawing.Size(255, 22);
            this.textBrokerCode.TabIndex = 1;
            // 
            // labelInvestorAccount
            // 
            this.labelInvestorAccount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInvestorAccount.AutoSize = true;
            this.labelInvestorAccount.Location = new System.Drawing.Point(449, 7);
            this.labelInvestorAccount.Name = "labelInvestorAccount";
            this.labelInvestorAccount.Size = new System.Drawing.Size(65, 12);
            this.labelInvestorAccount.TabIndex = 2;
            this.labelInvestorAccount.Text = "投資人帳號";
            // 
            // textInvestorAccount
            // 
            this.textInvestorAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textInvestorAccount.Location = new System.Drawing.Point(546, 2);
            this.textInvestorAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textInvestorAccount.Name = "textInvestorAccount";
            this.textInvestorAccount.Size = new System.Drawing.Size(351, 22);
            this.textInvestorAccount.TabIndex = 3;
            // 
            // labelProxyNumber
            // 
            this.labelProxyNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProxyNumber.AutoSize = true;
            this.labelProxyNumber.Location = new System.Drawing.Point(3, 34);
            this.labelProxyNumber.Name = "labelProxyNumber";
            this.labelProxyNumber.Size = new System.Drawing.Size(65, 12);
            this.labelProxyNumber.TabIndex = 4;
            this.labelProxyNumber.Text = "委託書編號";
            // 
            // textProxyNumber
            // 
            this.textProxyNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textProxyNumber.Location = new System.Drawing.Point(188, 29);
            this.textProxyNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textProxyNumber.Name = "textProxyNumber";
            this.textProxyNumber.Size = new System.Drawing.Size(255, 22);
            this.textProxyNumber.TabIndex = 5;
            // 
            // labelTransactionNumber
            // 
            this.labelTransactionNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTransactionNumber.AutoSize = true;
            this.labelTransactionNumber.Location = new System.Drawing.Point(449, 34);
            this.labelTransactionNumber.Name = "labelTransactionNumber";
            this.labelTransactionNumber.Size = new System.Drawing.Size(65, 12);
            this.labelTransactionNumber.TabIndex = 6;
            this.labelTransactionNumber.Text = "成交總序號";
            // 
            // textTransactionNumber
            // 
            this.textTransactionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textTransactionNumber.Location = new System.Drawing.Point(546, 29);
            this.textTransactionNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTransactionNumber.Name = "textTransactionNumber";
            this.textTransactionNumber.Size = new System.Drawing.Size(351, 22);
            this.textTransactionNumber.TabIndex = 7;
            // 
            // labelBuySell
            // 
            this.labelBuySell.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBuySell.AutoSize = true;
            this.labelBuySell.Location = new System.Drawing.Point(3, 61);
            this.labelBuySell.Name = "labelBuySell";
            this.labelBuySell.Size = new System.Drawing.Size(41, 12);
            this.labelBuySell.TabIndex = 8;
            this.labelBuySell.Text = "買賣別";
            // 
            // comboBuySell
            // 
            this.comboBuySell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBuySell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBuySell.Location = new System.Drawing.Point(188, 57);
            this.comboBuySell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBuySell.Name = "comboBuySell";
            this.comboBuySell.Size = new System.Drawing.Size(255, 20);
            this.comboBuySell.TabIndex = 9;
            // 
            // labelStockCode
            // 
            this.labelStockCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStockCode.AutoSize = true;
            this.labelStockCode.Location = new System.Drawing.Point(449, 61);
            this.labelStockCode.Name = "labelStockCode";
            this.labelStockCode.Size = new System.Drawing.Size(53, 12);
            this.labelStockCode.TabIndex = 10;
            this.labelStockCode.Text = "證券代號";
            // 
            // textStockCode
            // 
            this.textStockCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textStockCode.Location = new System.Drawing.Point(546, 56);
            this.textStockCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textStockCode.Name = "textStockCode";
            this.textStockCode.Size = new System.Drawing.Size(351, 22);
            this.textStockCode.TabIndex = 11;
            // 
            // labelChangeType
            // 
            this.labelChangeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelChangeType.AutoSize = true;
            this.labelChangeType.Location = new System.Drawing.Point(3, 88);
            this.labelChangeType.Name = "labelChangeType";
            this.labelChangeType.Size = new System.Drawing.Size(124, 12);
            this.labelChangeType.TabIndex = 12;
            this.labelChangeType.Text = "異動別(1=新增,2=刪除)";
            // 
            // comboChangeType
            // 
            this.comboChangeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboChangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChangeType.Location = new System.Drawing.Point(188, 84);
            this.comboChangeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboChangeType.Name = "comboChangeType";
            this.comboChangeType.Size = new System.Drawing.Size(255, 20);
            this.comboChangeType.TabIndex = 13;
            // 
            // labelMarginCode
            // 
            this.labelMarginCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMarginCode.AutoSize = true;
            this.labelMarginCode.Location = new System.Drawing.Point(449, 88);
            this.labelMarginCode.Name = "labelMarginCode";
            this.labelMarginCode.Size = new System.Drawing.Size(89, 12);
            this.labelMarginCode.TabIndex = 14;
            this.labelMarginCode.Text = "變更後證金代號";
            // 
            // textMarginCode
            // 
            this.textMarginCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textMarginCode.Location = new System.Drawing.Point(546, 83);
            this.textMarginCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMarginCode.Name = "textMarginCode";
            this.textMarginCode.Size = new System.Drawing.Size(351, 22);
            this.textMarginCode.TabIndex = 15;
            // 
            // labelSplitShares
            // 
            this.labelSplitShares.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSplitShares.AutoSize = true;
            this.labelSplitShares.Location = new System.Drawing.Point(3, 115);
            this.labelSplitShares.Name = "labelSplitShares";
            this.labelSplitShares.Size = new System.Drawing.Size(77, 12);
            this.labelSplitShares.TabIndex = 16;
            this.labelSplitShares.Text = "分割成交股數";
            // 
            // numericSplitShares
            // 
            this.numericSplitShares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSplitShares.Location = new System.Drawing.Point(188, 110);
            this.numericSplitShares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericSplitShares.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericSplitShares.Name = "numericSplitShares";
            this.numericSplitShares.Size = new System.Drawing.Size(255, 22);
            this.numericSplitShares.TabIndex = 17;
            // 
            // labelSplitAmount
            // 
            this.labelSplitAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSplitAmount.AutoSize = true;
            this.labelSplitAmount.Location = new System.Drawing.Point(449, 115);
            this.labelSplitAmount.Name = "labelSplitAmount";
            this.labelSplitAmount.Size = new System.Drawing.Size(77, 12);
            this.labelSplitAmount.TabIndex = 18;
            this.labelSplitAmount.Text = "分割成交金額";
            // 
            // numericSplitAmount
            // 
            this.numericSplitAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSplitAmount.Location = new System.Drawing.Point(546, 110);
            this.numericSplitAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericSplitAmount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericSplitAmount.Name = "numericSplitAmount";
            this.numericSplitAmount.Size = new System.Drawing.Size(351, 22);
            this.numericSplitAmount.TabIndex = 19;
            // 
            // labelOrderType
            // 
            this.labelOrderType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelOrderType.AutoSize = true;
            this.labelOrderType.Location = new System.Drawing.Point(3, 143);
            this.labelOrderType.Name = "labelOrderType";
            this.labelOrderType.Size = new System.Drawing.Size(174, 24);
            this.labelOrderType.TabIndex = 20;
            this.labelOrderType.Text = "變更後委託類別(0=普通,1=代資,2=代券,3=自資,4=自券,5=一般借)";
            // 
            // comboOrderType
            // 
            this.comboOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOrderType.Location = new System.Drawing.Point(188, 145);
            this.comboOrderType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboOrderType.Name = "comboOrderType";
            this.comboOrderType.Size = new System.Drawing.Size(255, 20);
            this.comboOrderType.TabIndex = 21;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 184);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 26);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "新增";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.Location = new System.Drawing.Point(825, 184);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(86, 26);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "匯出";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dataGridViewRecords.Location = new System.Drawing.Point(10, 221);
            this.dataGridViewRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.Size = new System.Drawing.Size(900, 288);
            this.dataGridViewRecords.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "csv";
            this.saveFileDialog.Filter = "CSV 檔案 (*.csv)|*.csv";
            this.saveFileDialog.Title = "匯出 CSV 檔案";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "證券商代號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 72;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "投資人帳號";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 72;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "委託書編號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 72;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "成交總序號";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "買賣別";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "證券代號";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 61;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "異動別";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 61;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "變更後證金代號";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 83;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "分割成交股數";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 72;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "分割成交金額";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 72;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "變更後委託類別";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 83;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 518);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewRecords);
            this.Controls.Add(this.tableLayoutPanelInputs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(774, 408);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "改類編輯產生器";
            this.tableLayoutPanelInputs.ResumeLayout(false);
            this.tableLayoutPanelInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitShares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSplitAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}
