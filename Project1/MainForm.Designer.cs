using System.Drawing;
using System.Windows.Forms;

namespace Project1
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            this.menu_panel = new System.Windows.Forms.TableLayoutPanel();
            this.proj_butt = new System.Windows.Forms.Button();
            this.worker_butt = new System.Windows.Forms.Button();
            this.cust_butt = new System.Windows.Forms.Button();
            this.pay_butt = new System.Windows.Forms.Button();
            this.workerPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.addWorkerToProjButt = new System.Windows.Forms.Button();
            this.workersInProjButt = new System.Windows.Forms.Button();
            this.createWorkerButt = new System.Windows.Forms.Button();
            this.showWorkersButt = new System.Windows.Forms.Button();
            this.custPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.searchProjByCusButt = new System.Windows.Forms.Button();
            this.searchCusByNameButt = new System.Windows.Forms.Button();
            this.createCusButt = new System.Windows.Forms.Button();
            this.showCusButt = new System.Windows.Forms.Button();
            this.paymentPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.searchByProjPaymentButt = new System.Windows.Forms.Button();
            this.addExpenseButt = new System.Windows.Forms.Button();
            this.addIncomeButt = new System.Windows.Forms.Button();
            this.showBalanceButt = new System.Windows.Forms.Button();
            this.exit_butt = new System.Windows.Forms.Button();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.showOpenProjTab = new System.Windows.Forms.TabPage();
            this.allProjGridView = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projStateDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurPolicyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archPlanPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.agreementPath = new System.Windows.Forms.DataGridViewLinkColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tesodotDataSet = new Project.tesodotDataSet();
            this.newProjTab = new System.Windows.Forms.TabPage();
            this.sumbitNewProjButt = new System.Windows.Forms.Button();
            this.addEngineerPlanButt = new System.Windows.Forms.Button();
            this.addContractButt = new System.Windows.Forms.Button();
            this.insurPolicyTextBox = new System.Windows.Forms.TextBox();
            this.engineerPlanTextBox = new System.Windows.Forms.TextBox();
            this.contractTextBox = new System.Windows.Forms.TextBox();
            this.inspecTelTextBox = new System.Windows.Forms.TextBox();
            this.inspecNameTextBox = new System.Windows.Forms.TextBox();
            this.archTelTextBox = new System.Windows.Forms.TextBox();
            this.archNameTextBox = new System.Windows.Forms.TextBox();
            this.contactTelTextBox = new System.Windows.Forms.TextBox();
            this.etaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.projNameTextBox = new System.Windows.Forms.TextBox();
            this.insurPolicyLabel = new System.Windows.Forms.Label();
            this.engineerPlanLable = new System.Windows.Forms.Label();
            this.contractLable = new System.Windows.Forms.Label();
            this.inspecTelLable = new System.Windows.Forms.Label();
            this.inspecNameLable = new System.Windows.Forms.Label();
            this.inspecInfoLable = new System.Windows.Forms.Label();
            this.archTelLable = new System.Windows.Forms.Label();
            this.archNameLable = new System.Windows.Forms.Label();
            this.archInfoLable = new System.Windows.Forms.Label();
            this.telContactLable = new System.Windows.Forms.Label();
            this.contactNameLable = new System.Windows.Forms.Label();
            this.contactInfoLable = new System.Windows.Forms.Label();
            this.etaDateLable = new System.Windows.Forms.Label();
            this.startDateLable = new System.Windows.Forms.Label();
            this.projNameLable = new System.Windows.Forms.Label();
            this.searchByProjNameTab = new System.Windows.Forms.TabPage();
            this.searchByProjNameDataGridView = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archTelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspTelDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurPolicyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archPlanPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.agreementPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.searchProjNameButt = new System.Windows.Forms.Button();
            this.searchByProjNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByProjNameLable = new System.Windows.Forms.Label();
            this.assignProjToCusTab = new System.Windows.Forms.TabPage();
            this.projCusAssignSaveButt = new System.Windows.Forms.Button();
            this.cusNameAssignComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projNameAssignComboBox = new System.Windows.Forms.ComboBox();
            this.projectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cusNameAssignLable = new System.Windows.Forms.Label();
            this.projNameAssignLable = new System.Windows.Forms.Label();
            this.showWorkerTab = new System.Windows.Forms.TabPage();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createNewWorkerTab = new System.Windows.Forms.TabPage();
            this.sumbitNewEmployeeButt = new System.Windows.Forms.Button();
            this.wTypeComboBox = new System.Windows.Forms.ComboBox();
            this.workertypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confNumTextBox = new System.Windows.Forms.TextBox();
            this.createPassTextBox = new System.Windows.Forms.TextBox();
            this.accountNumTextBox = new System.Windows.Forms.TextBox();
            this.branchNumTextBox = new System.Windows.Forms.TextBox();
            this.bankNumTextBox = new System.Windows.Forms.TextBox();
            this.eTypeCombo = new System.Windows.Forms.ComboBox();
            this.startWorkingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.eNameTextbox = new System.Windows.Forms.TextBox();
            this.eIDTextBox = new System.Windows.Forms.TextBox();
            this.wTypeLable = new System.Windows.Forms.Label();
            this.confNumLable = new System.Windows.Forms.Label();
            this.createPassLable = new System.Windows.Forms.Label();
            this.accountNumLable = new System.Windows.Forms.Label();
            this.branchNumLable = new System.Windows.Forms.Label();
            this.bankNumLable = new System.Windows.Forms.Label();
            this.paymentInfoLable = new System.Windows.Forms.Label();
            this.eTypeLable = new System.Windows.Forms.Label();
            this.eStartDateLable = new System.Windows.Forms.Label();
            this.eNameLable = new System.Windows.Forms.Label();
            this.eIDLable = new System.Windows.Forms.Label();
            this.searchWorkerByProjTab = new System.Windows.Forms.TabPage();
            this.searchWorkerByProjDataGridView = new System.Windows.Forms.DataGridView();
            this.eIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchWorkersInProjButt = new System.Windows.Forms.Button();
            this.searchWorkersInProjComboBox = new System.Windows.Forms.ComboBox();
            this.searchWorkersInProjLable = new System.Windows.Forms.Label();
            this.assignWorkerTab = new System.Windows.Forms.TabPage();
            this.projWorkerAssignButt = new System.Windows.Forms.Button();
            this.workerProjAssignComboBox = new System.Windows.Forms.ComboBox();
            this.projWorkerAssignComboBox = new System.Windows.Forms.ComboBox();
            this.workerProjAssignLabel = new System.Windows.Forms.Label();
            this.projWorkerAssignLable = new System.Windows.Forms.Label();
            this.showCusTab = new System.Windows.Forms.TabPage();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCusTab = new System.Windows.Forms.TabPage();
            this.sumbitCusCreateButt = new System.Windows.Forms.Button();
            this.cPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.cCityTextBox = new System.Windows.Forms.TextBox();
            this.cSNumTextBox = new System.Windows.Forms.TextBox();
            this.cStreetTextBox = new System.Windows.Forms.TextBox();
            this.cNameTextBox = new System.Windows.Forms.TextBox();
            this.cTypeComboBox = new System.Windows.Forms.ComboBox();
            this.cIDTextBox = new System.Windows.Forms.TextBox();
            this.cPhoneNumLable = new System.Windows.Forms.Label();
            this.cCityLable = new System.Windows.Forms.Label();
            this.cSNumLable = new System.Windows.Forms.Label();
            this.cStreetLable = new System.Windows.Forms.Label();
            this.cTypeLable = new System.Windows.Forms.Label();
            this.cFirstNameLable = new System.Windows.Forms.Label();
            this.cIDLable = new System.Windows.Forms.Label();
            this.searchCusByNameTab = new System.Windows.Forms.TabPage();
            this.searchCusByNameDataGridView = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStreetDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSNumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCusButt = new System.Windows.Forms.Button();
            this.cusSearchTextBox = new System.Windows.Forms.TextBox();
            this.cusSearchLabel = new System.Windows.Forms.Label();
            this.searchProjByCusTab = new System.Windows.Forms.TabPage();
            this.searchProjByCusDataGridView = new System.Windows.Forms.DataGridView();
            this.projIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projStateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.projNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etaDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archTelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspTelDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurPolicyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archPlanPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.agreementPathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cusProjSearchButt = new System.Windows.Forms.Button();
            this.cusProjSearchComboBox = new System.Windows.Forms.ComboBox();
            this.cusProjSearchLabel = new System.Windows.Forms.Label();
            this.showBalanceTab = new System.Windows.Forms.TabPage();
            this.showYearBalanceButt = new System.Windows.Forms.Button();
            this.totalBalanceLable = new System.Windows.Forms.Label();
            this.totalIncomeLable = new System.Windows.Forms.Label();
            this.totalExpanceLable = new System.Windows.Forms.Label();
            this.yearBalanceLabel = new System.Windows.Forms.Label();
            this.yearBalancePicker = new System.Windows.Forms.DateTimePicker();
            this.expensesDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMethodDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMethodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addIncomeTab = new System.Windows.Forms.TabPage();
            this.iProjNameComboBox = new System.Windows.Forms.ComboBox();
            this.incomeSumbitButt = new System.Windows.Forms.Button();
            this.iAmountTextBox = new System.Windows.Forms.TextBox();
            this.iPayMethodComboBox = new System.Windows.Forms.ComboBox();
            this.iPayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iProjNameLable = new System.Windows.Forms.Label();
            this.iAmountLable = new System.Windows.Forms.Label();
            this.iPayMethodLable = new System.Windows.Forms.Label();
            this.inPayDateLable = new System.Windows.Forms.Label();
            this.addExpenseTab = new System.Windows.Forms.TabPage();
            this.eDiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.eDiscriptionLable = new System.Windows.Forms.Label();
            this.eENameComboBox = new System.Windows.Forms.ComboBox();
            this.eReasonComboBox = new System.Windows.Forms.ComboBox();
            this.eReasonLable = new System.Windows.Forms.Label();
            this.expenseSumbitButt = new System.Windows.Forms.Button();
            this.eAmountTextBox = new System.Windows.Forms.TextBox();
            this.eMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ePayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.eENameLable = new System.Windows.Forms.Label();
            this.eAmountLable = new System.Windows.Forms.Label();
            this.eMethodLable = new System.Windows.Forms.Label();
            this.ePayDateLable = new System.Windows.Forms.Label();
            this.searchByProjPaymentTab = new System.Windows.Forms.TabPage();
            this.projIncomesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButtByProjPayment = new System.Windows.Forms.Button();
            this.searchByProjPaymentComboBox = new System.Windows.Forms.ComboBox();
            this.searchByProjPaymentLabel = new System.Windows.Forms.Label();
            this.addWorkerTypeAndCostTab = new System.Windows.Forms.TabPage();
            this.applyAddWorkerTypeButt = new System.Windows.Forms.Button();
            this.paymentPriceTextBox = new System.Windows.Forms.TextBox();
            this.paymentPriceLabel = new System.Windows.Forms.Label();
            this.workerTypeTextBox = new System.Windows.Forms.TextBox();
            this.workerTypeLabel = new System.Windows.Forms.Label();
            this.projectTableAdapter = new Project.tesodotDataSetTableAdapters.ProjectTableAdapter();
            this.employeeTableAdapter = new Project.tesodotDataSetTableAdapters.EmployeeTableAdapter();
            this.customerTableAdapter = new Project.tesodotDataSetTableAdapters.CustomerTableAdapter();
            this.worker_typeTableAdapter = new Project.tesodotDataSetTableAdapters.Worker_typeTableAdapter();
            this.incomesTableAdapter = new Project.tesodotDataSetTableAdapters.incomesTableAdapter();
            this.expensesTableAdapter = new Project.tesodotDataSetTableAdapters.expensesTableAdapter();
            this.closeTabButt = new System.Windows.Forms.Button();
            this.menu_panel.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.showOpenProjTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allProjGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesodotDataSet)).BeginInit();
            this.newProjTab.SuspendLayout();
            this.searchByProjNameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByProjNameDataGridView)).BeginInit();
            this.assignProjToCusTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).BeginInit();
            this.showWorkerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.createNewWorkerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workertypeBindingSource)).BeginInit();
            this.searchWorkerByProjTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchWorkerByProjDataGridView)).BeginInit();
            this.assignWorkerTab.SuspendLayout();
            this.showCusTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.newCusTab.SuspendLayout();
            this.searchCusByNameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCusByNameDataGridView)).BeginInit();
            this.searchProjByCusTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjByCusDataGridView)).BeginInit();
            this.showBalanceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            this.addIncomeTab.SuspendLayout();
            this.addExpenseTab.SuspendLayout();
            this.searchByProjPaymentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projIncomesDataGridView)).BeginInit();
            this.addWorkerTypeAndCostTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menu_panel.ColumnCount = 1;
            this.menu_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menu_panel.Controls.Add(this.proj_butt, 0, 0);
            this.menu_panel.Controls.Add(this.worker_butt, 0, 1);
            this.menu_panel.Controls.Add(this.cust_butt, 0, 2);
            this.menu_panel.Controls.Add(this.pay_butt, 0, 3);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu_panel.Location = new System.Drawing.Point(1770, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.RowCount = 4;
            this.menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menu_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menu_panel.Size = new System.Drawing.Size(134, 1041);
            this.menu_panel.TabIndex = 2;
            // 
            // proj_butt
            // 
            this.proj_butt.Dock = System.Windows.Forms.DockStyle.Right;
            this.proj_butt.FlatAppearance.BorderSize = 0;
            this.proj_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proj_butt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proj_butt.Location = new System.Drawing.Point(3, 3);
            this.proj_butt.Name = "proj_butt";
            this.proj_butt.Size = new System.Drawing.Size(128, 254);
            this.proj_butt.TabIndex = 0;
            this.proj_butt.Text = "פרויקטים";
            this.proj_butt.UseVisualStyleBackColor = true;
            this.proj_butt.MouseEnter += new System.EventHandler(this.proj_butt_MouseEnter);
            // 
            // worker_butt
            // 
            this.worker_butt.Dock = System.Windows.Forms.DockStyle.Right;
            this.worker_butt.FlatAppearance.BorderSize = 0;
            this.worker_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.worker_butt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worker_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.worker_butt.Location = new System.Drawing.Point(3, 263);
            this.worker_butt.Name = "worker_butt";
            this.worker_butt.Size = new System.Drawing.Size(128, 254);
            this.worker_butt.TabIndex = 1;
            this.worker_butt.Text = "עובדים";
            this.worker_butt.UseVisualStyleBackColor = true;
            this.worker_butt.MouseHover += new System.EventHandler(this.worker_butt_MouseHover);
            // 
            // cust_butt
            // 
            this.cust_butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cust_butt.FlatAppearance.BorderSize = 0;
            this.cust_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cust_butt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_butt.Location = new System.Drawing.Point(3, 523);
            this.cust_butt.Name = "cust_butt";
            this.cust_butt.Size = new System.Drawing.Size(128, 254);
            this.cust_butt.TabIndex = 2;
            this.cust_butt.Text = "לקוחות";
            this.cust_butt.UseVisualStyleBackColor = true;
            this.cust_butt.MouseHover += new System.EventHandler(this.cust_butt_MouseHover);
            // 
            // pay_butt
            // 
            this.pay_butt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pay_butt.FlatAppearance.BorderSize = 0;
            this.pay_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_butt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_butt.Location = new System.Drawing.Point(3, 783);
            this.pay_butt.Name = "pay_butt";
            this.pay_butt.Size = new System.Drawing.Size(128, 255);
            this.pay_butt.TabIndex = 3;
            this.pay_butt.Text = "תשלומים";
            this.pay_butt.UseVisualStyleBackColor = true;
            this.pay_butt.MouseHover += new System.EventHandler(this.pay_butt_MouseHover);
            // 
            // workerPanelMenu
            // 
            this.workerPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.workerPanelMenu.Name = "workerPanelMenu";
            this.workerPanelMenu.Size = new System.Drawing.Size(200, 100);
            this.workerPanelMenu.TabIndex = 0;
            // 
            // addWorkerToProjButt
            // 
            this.addWorkerToProjButt.Location = new System.Drawing.Point(0, 0);
            this.addWorkerToProjButt.Name = "addWorkerToProjButt";
            this.addWorkerToProjButt.Size = new System.Drawing.Size(75, 23);
            this.addWorkerToProjButt.TabIndex = 0;
            // 
            // workersInProjButt
            // 
            this.workersInProjButt.Location = new System.Drawing.Point(0, 0);
            this.workersInProjButt.Name = "workersInProjButt";
            this.workersInProjButt.Size = new System.Drawing.Size(75, 23);
            this.workersInProjButt.TabIndex = 0;
            // 
            // createWorkerButt
            // 
            this.createWorkerButt.Location = new System.Drawing.Point(0, 0);
            this.createWorkerButt.Name = "createWorkerButt";
            this.createWorkerButt.Size = new System.Drawing.Size(75, 23);
            this.createWorkerButt.TabIndex = 0;
            // 
            // showWorkersButt
            // 
            this.showWorkersButt.Location = new System.Drawing.Point(0, 0);
            this.showWorkersButt.Name = "showWorkersButt";
            this.showWorkersButt.Size = new System.Drawing.Size(75, 23);
            this.showWorkersButt.TabIndex = 0;
            // 
            // custPanelMenu
            // 
            this.custPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.custPanelMenu.Name = "custPanelMenu";
            this.custPanelMenu.Size = new System.Drawing.Size(200, 100);
            this.custPanelMenu.TabIndex = 0;
            // 
            // searchProjByCusButt
            // 
            this.searchProjByCusButt.Location = new System.Drawing.Point(0, 0);
            this.searchProjByCusButt.Name = "searchProjByCusButt";
            this.searchProjByCusButt.Size = new System.Drawing.Size(75, 23);
            this.searchProjByCusButt.TabIndex = 0;
            // 
            // searchCusByNameButt
            // 
            this.searchCusByNameButt.Location = new System.Drawing.Point(0, 0);
            this.searchCusByNameButt.Name = "searchCusByNameButt";
            this.searchCusByNameButt.Size = new System.Drawing.Size(75, 23);
            this.searchCusByNameButt.TabIndex = 0;
            // 
            // createCusButt
            // 
            this.createCusButt.Location = new System.Drawing.Point(0, 0);
            this.createCusButt.Name = "createCusButt";
            this.createCusButt.Size = new System.Drawing.Size(75, 23);
            this.createCusButt.TabIndex = 0;
            // 
            // showCusButt
            // 
            this.showCusButt.Location = new System.Drawing.Point(0, 0);
            this.showCusButt.Name = "showCusButt";
            this.showCusButt.Size = new System.Drawing.Size(75, 23);
            this.showCusButt.TabIndex = 0;
            // 
            // paymentPanelMenu
            // 
            this.paymentPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.paymentPanelMenu.Name = "paymentPanelMenu";
            this.paymentPanelMenu.Size = new System.Drawing.Size(200, 100);
            this.paymentPanelMenu.TabIndex = 0;
            // 
            // searchByProjPaymentButt
            // 
            this.searchByProjPaymentButt.Location = new System.Drawing.Point(0, 0);
            this.searchByProjPaymentButt.Name = "searchByProjPaymentButt";
            this.searchByProjPaymentButt.Size = new System.Drawing.Size(75, 23);
            this.searchByProjPaymentButt.TabIndex = 0;
            // 
            // addExpenseButt
            // 
            this.addExpenseButt.Location = new System.Drawing.Point(0, 0);
            this.addExpenseButt.Name = "addExpenseButt";
            this.addExpenseButt.Size = new System.Drawing.Size(75, 23);
            this.addExpenseButt.TabIndex = 0;
            // 
            // addIncomeButt
            // 
            this.addIncomeButt.Location = new System.Drawing.Point(0, 0);
            this.addIncomeButt.Name = "addIncomeButt";
            this.addIncomeButt.Size = new System.Drawing.Size(75, 23);
            this.addIncomeButt.TabIndex = 0;
            // 
            // showBalanceButt
            // 
            this.showBalanceButt.Location = new System.Drawing.Point(0, 0);
            this.showBalanceButt.Name = "showBalanceButt";
            this.showBalanceButt.Size = new System.Drawing.Size(75, 23);
            this.showBalanceButt.TabIndex = 0;
            // 
            // exit_butt
            // 
            this.exit_butt.FlatAppearance.BorderSize = 0;
            this.exit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_butt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_butt.Location = new System.Drawing.Point(0, 0);
            this.exit_butt.Name = "exit_butt";
            this.exit_butt.Size = new System.Drawing.Size(55, 23);
            this.exit_butt.TabIndex = 0;
            this.exit_butt.Text = "יציאה";
            this.exit_butt.UseVisualStyleBackColor = true;
            this.exit_butt.Click += new System.EventHandler(this.exit_butt_Click);
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.showOpenProjTab);
            this.tabContainer.Controls.Add(this.newProjTab);
            this.tabContainer.Controls.Add(this.searchByProjNameTab);
            this.tabContainer.Controls.Add(this.assignProjToCusTab);
            this.tabContainer.Controls.Add(this.showWorkerTab);
            this.tabContainer.Controls.Add(this.createNewWorkerTab);
            this.tabContainer.Controls.Add(this.searchWorkerByProjTab);
            this.tabContainer.Controls.Add(this.assignWorkerTab);
            this.tabContainer.Controls.Add(this.showCusTab);
            this.tabContainer.Controls.Add(this.newCusTab);
            this.tabContainer.Controls.Add(this.searchCusByNameTab);
            this.tabContainer.Controls.Add(this.searchProjByCusTab);
            this.tabContainer.Controls.Add(this.showBalanceTab);
            this.tabContainer.Controls.Add(this.addIncomeTab);
            this.tabContainer.Controls.Add(this.addExpenseTab);
            this.tabContainer.Controls.Add(this.searchByProjPaymentTab);
            this.tabContainer.Controls.Add(this.addWorkerTypeAndCostTab);
            this.tabContainer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContainer.Location = new System.Drawing.Point(0, 30);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabContainer.RightToLeftLayout = true;
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(1767, 1011);
            this.tabContainer.TabIndex = 3;
            this.tabContainer.Visible = false;
            this.tabContainer.MouseEnter += new System.EventHandler(this.tabContainer_MouseEnter);
            // 
            // showOpenProjTab
            // 
            this.showOpenProjTab.BackColor = System.Drawing.Color.SkyBlue;
            this.showOpenProjTab.Controls.Add(this.allProjGridView);
            this.showOpenProjTab.Location = new System.Drawing.Point(4, 24);
            this.showOpenProjTab.Name = "showOpenProjTab";
            this.showOpenProjTab.Padding = new System.Windows.Forms.Padding(3);
            this.showOpenProjTab.Size = new System.Drawing.Size(1759, 983);
            this.showOpenProjTab.TabIndex = 0;
            this.showOpenProjTab.Text = "פרויקטים";
            // 
            // allProjGridView
            // 
            this.allProjGridView.AllowUserToAddRows = false;
            this.allProjGridView.AutoGenerateColumns = false;
            this.allProjGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.allProjGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allProjGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn,
            this.projStateDataGridViewComboBoxColumn,
            this.projNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.etaDateDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactTelDataGridViewTextBoxColumn,
            this.archNameDataGridViewTextBoxColumn,
            this.archTelDataGridViewTextBoxColumn,
            this.inspNameDataGridViewTextBoxColumn,
            this.inspTelDataGridViewTextBoxColumn,
            this.insurPolicyDataGridViewTextBoxColumn,
            this.archPlanPath,
            this.agreementPath});
            this.allProjGridView.DataSource = this.projectBindingSource;
            this.allProjGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProjGridView.Location = new System.Drawing.Point(3, 3);
            this.allProjGridView.Name = "allProjGridView";
            this.allProjGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.allProjGridView.Size = new System.Drawing.Size(1753, 977);
            this.allProjGridView.TabIndex = 0;
            this.allProjGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allProjGridView_CellContentClick);
            this.allProjGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.allProjGridView_EditingControlShowing);
            this.allProjGridView.MouseEnter += new System.EventHandler(this.openProjGridView_MouseEnter);
            // 
            // projIDDataGridViewTextBoxColumn
            // 
            this.projIDDataGridViewTextBoxColumn.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn.HeaderText = "מספר פרויקט";
            this.projIDDataGridViewTextBoxColumn.Name = "projIDDataGridViewTextBoxColumn";
            this.projIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // projStateDataGridViewComboBoxColumn
            // 
            this.projStateDataGridViewComboBoxColumn.DataPropertyName = "projState";
            this.projStateDataGridViewComboBoxColumn.HeaderText = "סטטוס פרויקט";
            this.projStateDataGridViewComboBoxColumn.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל",
            "בעיכוב"});
            this.projStateDataGridViewComboBoxColumn.Name = "projStateDataGridViewComboBoxColumn";
            this.projStateDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.projStateDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // projNameDataGridViewTextBoxColumn
            // 
            this.projNameDataGridViewTextBoxColumn.DataPropertyName = "projName";
            this.projNameDataGridViewTextBoxColumn.HeaderText = "שם פרויקט";
            this.projNameDataGridViewTextBoxColumn.Name = "projNameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "תאריך תחילת הפרויקט";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // etaDateDataGridViewTextBoxColumn
            // 
            this.etaDateDataGridViewTextBoxColumn.DataPropertyName = "etaDate";
            this.etaDateDataGridViewTextBoxColumn.HeaderText = "תאריך משוער לסיום";
            this.etaDateDataGridViewTextBoxColumn.Name = "etaDateDataGridViewTextBoxColumn";
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "contactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "שם איש קשר";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            // 
            // contactTelDataGridViewTextBoxColumn
            // 
            this.contactTelDataGridViewTextBoxColumn.DataPropertyName = "contactTel";
            this.contactTelDataGridViewTextBoxColumn.HeaderText = "טלפון איש קשר";
            this.contactTelDataGridViewTextBoxColumn.Name = "contactTelDataGridViewTextBoxColumn";
            // 
            // archNameDataGridViewTextBoxColumn
            // 
            this.archNameDataGridViewTextBoxColumn.DataPropertyName = "archName";
            this.archNameDataGridViewTextBoxColumn.HeaderText = "שם מהנדס";
            this.archNameDataGridViewTextBoxColumn.Name = "archNameDataGridViewTextBoxColumn";
            // 
            // archTelDataGridViewTextBoxColumn
            // 
            this.archTelDataGridViewTextBoxColumn.DataPropertyName = "archTel";
            this.archTelDataGridViewTextBoxColumn.HeaderText = "טלפון מהנדס";
            this.archTelDataGridViewTextBoxColumn.Name = "archTelDataGridViewTextBoxColumn";
            // 
            // inspNameDataGridViewTextBoxColumn
            // 
            this.inspNameDataGridViewTextBoxColumn.DataPropertyName = "inspName";
            this.inspNameDataGridViewTextBoxColumn.HeaderText = "שם מפקח";
            this.inspNameDataGridViewTextBoxColumn.Name = "inspNameDataGridViewTextBoxColumn";
            // 
            // inspTelDataGridViewTextBoxColumn
            // 
            this.inspTelDataGridViewTextBoxColumn.DataPropertyName = "inspTel";
            this.inspTelDataGridViewTextBoxColumn.HeaderText = "טלפון מפקח";
            this.inspTelDataGridViewTextBoxColumn.Name = "inspTelDataGridViewTextBoxColumn";
            // 
            // insurPolicyDataGridViewTextBoxColumn
            // 
            this.insurPolicyDataGridViewTextBoxColumn.DataPropertyName = "insurPolicy";
            this.insurPolicyDataGridViewTextBoxColumn.HeaderText = "פוליסת ביטוח";
            this.insurPolicyDataGridViewTextBoxColumn.Name = "insurPolicyDataGridViewTextBoxColumn";
            // 
            // archPlanPath
            // 
            this.archPlanPath.DataPropertyName = "archPlanPath";
            this.archPlanPath.HeaderText = "תוכנית הנדסית";
            this.archPlanPath.Name = "archPlanPath";
            this.archPlanPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.archPlanPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // agreementPath
            // 
            this.agreementPath.DataPropertyName = "agreementPath";
            this.agreementPath.HeaderText = "הסכם";
            this.agreementPath.Name = "agreementPath";
            this.agreementPath.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agreementPath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.tesodotDataSet;
            // 
            // tesodotDataSet
            // 
            this.tesodotDataSet.DataSetName = "tesodotDataSet";
            this.tesodotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newProjTab
            // 
            this.newProjTab.BackColor = System.Drawing.Color.SkyBlue;
            this.newProjTab.Controls.Add(this.sumbitNewProjButt);
            this.newProjTab.Controls.Add(this.addEngineerPlanButt);
            this.newProjTab.Controls.Add(this.addContractButt);
            this.newProjTab.Controls.Add(this.insurPolicyTextBox);
            this.newProjTab.Controls.Add(this.engineerPlanTextBox);
            this.newProjTab.Controls.Add(this.contractTextBox);
            this.newProjTab.Controls.Add(this.inspecTelTextBox);
            this.newProjTab.Controls.Add(this.inspecNameTextBox);
            this.newProjTab.Controls.Add(this.archTelTextBox);
            this.newProjTab.Controls.Add(this.archNameTextBox);
            this.newProjTab.Controls.Add(this.contactTelTextBox);
            this.newProjTab.Controls.Add(this.etaDateTimePicker);
            this.newProjTab.Controls.Add(this.startDateTimePicker);
            this.newProjTab.Controls.Add(this.contactNameTextBox);
            this.newProjTab.Controls.Add(this.projNameTextBox);
            this.newProjTab.Controls.Add(this.insurPolicyLabel);
            this.newProjTab.Controls.Add(this.engineerPlanLable);
            this.newProjTab.Controls.Add(this.contractLable);
            this.newProjTab.Controls.Add(this.inspecTelLable);
            this.newProjTab.Controls.Add(this.inspecNameLable);
            this.newProjTab.Controls.Add(this.inspecInfoLable);
            this.newProjTab.Controls.Add(this.archTelLable);
            this.newProjTab.Controls.Add(this.archNameLable);
            this.newProjTab.Controls.Add(this.archInfoLable);
            this.newProjTab.Controls.Add(this.telContactLable);
            this.newProjTab.Controls.Add(this.contactNameLable);
            this.newProjTab.Controls.Add(this.contactInfoLable);
            this.newProjTab.Controls.Add(this.etaDateLable);
            this.newProjTab.Controls.Add(this.startDateLable);
            this.newProjTab.Controls.Add(this.projNameLable);
            this.newProjTab.Location = new System.Drawing.Point(4, 24);
            this.newProjTab.Name = "newProjTab";
            this.newProjTab.Padding = new System.Windows.Forms.Padding(3);
            this.newProjTab.Size = new System.Drawing.Size(1759, 983);
            this.newProjTab.TabIndex = 0;
            this.newProjTab.Text = "פרויקט חדש";
            this.newProjTab.MouseEnter += new System.EventHandler(this.newProjTab_MouseEnter);
            // 
            // sumbitNewProjButt
            // 
            this.sumbitNewProjButt.Location = new System.Drawing.Point(1561, 543);
            this.sumbitNewProjButt.Name = "sumbitNewProjButt";
            this.sumbitNewProjButt.Size = new System.Drawing.Size(75, 23);
            this.sumbitNewProjButt.TabIndex = 32;
            this.sumbitNewProjButt.Text = "צור פרויקט";
            this.sumbitNewProjButt.UseVisualStyleBackColor = true;
            this.sumbitNewProjButt.Click += new System.EventHandler(this.sumbitNewProjButt_Click);
            // 
            // addEngineerPlanButt
            // 
            this.addEngineerPlanButt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEngineerPlanButt.Location = new System.Drawing.Point(1482, 434);
            this.addEngineerPlanButt.Name = "addEngineerPlanButt";
            this.addEngineerPlanButt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addEngineerPlanButt.Size = new System.Drawing.Size(39, 23);
            this.addEngineerPlanButt.TabIndex = 31;
            this.addEngineerPlanButt.Text = "צרף";
            this.addEngineerPlanButt.UseVisualStyleBackColor = true;
            this.addEngineerPlanButt.Click += new System.EventHandler(this.addEngineerPlanButt_Click);
            // 
            // addContractButt
            // 
            this.addContractButt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContractButt.Location = new System.Drawing.Point(1543, 391);
            this.addContractButt.Name = "addContractButt";
            this.addContractButt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addContractButt.Size = new System.Drawing.Size(39, 23);
            this.addContractButt.TabIndex = 30;
            this.addContractButt.Text = "צרף";
            this.addContractButt.UseVisualStyleBackColor = true;
            this.addContractButt.Click += new System.EventHandler(this.addContractButt_Click);
            // 
            // insurPolicyTextBox
            // 
            this.insurPolicyTextBox.Location = new System.Drawing.Point(1579, 485);
            this.insurPolicyTextBox.Name = "insurPolicyTextBox";
            this.insurPolicyTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.insurPolicyTextBox.Size = new System.Drawing.Size(100, 23);
            this.insurPolicyTextBox.TabIndex = 29;
            // 
            // engineerPlanTextBox
            // 
            this.engineerPlanTextBox.Location = new System.Drawing.Point(1526, 434);
            this.engineerPlanTextBox.MaxLength = 2000;
            this.engineerPlanTextBox.Name = "engineerPlanTextBox";
            this.engineerPlanTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.engineerPlanTextBox.Size = new System.Drawing.Size(100, 23);
            this.engineerPlanTextBox.TabIndex = 28;
            // 
            // contractTextBox
            // 
            this.contractTextBox.Location = new System.Drawing.Point(1586, 391);
            this.contractTextBox.MaxLength = 2000;
            this.contractTextBox.Name = "contractTextBox";
            this.contractTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contractTextBox.Size = new System.Drawing.Size(100, 23);
            this.contractTextBox.TabIndex = 27;
            // 
            // inspecTelTextBox
            // 
            this.inspecTelTextBox.Location = new System.Drawing.Point(1482, 352);
            this.inspecTelTextBox.MaxLength = 10;
            this.inspecTelTextBox.Name = "inspecTelTextBox";
            this.inspecTelTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inspecTelTextBox.Size = new System.Drawing.Size(100, 23);
            this.inspecTelTextBox.TabIndex = 26;
            // 
            // inspecNameTextBox
            // 
            this.inspecNameTextBox.Location = new System.Drawing.Point(1494, 315);
            this.inspecNameTextBox.Name = "inspecNameTextBox";
            this.inspecNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inspecNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.inspecNameTextBox.TabIndex = 25;
            // 
            // archTelTextBox
            // 
            this.archTelTextBox.Location = new System.Drawing.Point(1482, 274);
            this.archTelTextBox.MaxLength = 10;
            this.archTelTextBox.Name = "archTelTextBox";
            this.archTelTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.archTelTextBox.Size = new System.Drawing.Size(100, 23);
            this.archTelTextBox.TabIndex = 24;
            // 
            // archNameTextBox
            // 
            this.archNameTextBox.Location = new System.Drawing.Point(1494, 234);
            this.archNameTextBox.Name = "archNameTextBox";
            this.archNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.archNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.archNameTextBox.TabIndex = 23;
            // 
            // contactTelTextBox
            // 
            this.contactTelTextBox.Location = new System.Drawing.Point(1482, 197);
            this.contactTelTextBox.MaxLength = 10;
            this.contactTelTextBox.Name = "contactTelTextBox";
            this.contactTelTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contactTelTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactTelTextBox.TabIndex = 22;
            // 
            // etaDateTimePicker
            // 
            this.etaDateTimePicker.CustomFormat = "MM.dd.yyyy";
            this.etaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.etaDateTimePicker.Location = new System.Drawing.Point(1522, 113);
            this.etaDateTimePicker.Name = "etaDateTimePicker";
            this.etaDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.etaDateTimePicker.Size = new System.Drawing.Size(104, 23);
            this.etaDateTimePicker.TabIndex = 21;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "MM.dd.yyyy";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTimePicker.Location = new System.Drawing.Point(1478, 69);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startDateTimePicker.Size = new System.Drawing.Size(104, 23);
            this.startDateTimePicker.TabIndex = 20;
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.Location = new System.Drawing.Point(1494, 158);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contactNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.contactNameTextBox.TabIndex = 19;
            // 
            // projNameTextBox
            // 
            this.projNameTextBox.Location = new System.Drawing.Point(1551, 30);
            this.projNameTextBox.Name = "projNameTextBox";
            this.projNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.projNameTextBox.TabIndex = 18;
            // 
            // insurPolicyLabel
            // 
            this.insurPolicyLabel.AutoSize = true;
            this.insurPolicyLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurPolicyLabel.Location = new System.Drawing.Point(1688, 486);
            this.insurPolicyLabel.Name = "insurPolicyLabel";
            this.insurPolicyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.insurPolicyLabel.Size = new System.Drawing.Size(55, 19);
            this.insurPolicyLabel.TabIndex = 16;
            this.insurPolicyLabel.Text = ":ביטוח*";
            // 
            // engineerPlanLable
            // 
            this.engineerPlanLable.AutoSize = true;
            this.engineerPlanLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineerPlanLable.Location = new System.Drawing.Point(1635, 435);
            this.engineerPlanLable.Name = "engineerPlanLable";
            this.engineerPlanLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.engineerPlanLable.Size = new System.Drawing.Size(112, 19);
            this.engineerPlanLable.TabIndex = 15;
            this.engineerPlanLable.Text = ":תוכנית הנדסית*";
            // 
            // contractLable
            // 
            this.contractLable.AutoSize = true;
            this.contractLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractLable.Location = new System.Drawing.Point(1695, 392);
            this.contractLable.Name = "contractLable";
            this.contractLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contractLable.Size = new System.Drawing.Size(48, 19);
            this.contractLable.TabIndex = 14;
            this.contractLable.Text = ":חוזה*";
            // 
            // inspecTelLable
            // 
            this.inspecTelLable.AutoSize = true;
            this.inspecTelLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspecTelLable.Location = new System.Drawing.Point(1591, 353);
            this.inspecTelLable.Name = "inspecTelLable";
            this.inspecTelLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inspecTelLable.Size = new System.Drawing.Size(45, 19);
            this.inspecTelLable.TabIndex = 13;
            this.inspecTelLable.Text = ":טלפון";
            // 
            // inspecNameLable
            // 
            this.inspecNameLable.AutoSize = true;
            this.inspecNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspecNameLable.Location = new System.Drawing.Point(1603, 316);
            this.inspecNameLable.Name = "inspecNameLable";
            this.inspecNameLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inspecNameLable.Size = new System.Drawing.Size(33, 19);
            this.inspecNameLable.TabIndex = 12;
            this.inspecNameLable.Text = ":שם";
            // 
            // inspecInfoLable
            // 
            this.inspecInfoLable.AutoSize = true;
            this.inspecInfoLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspecInfoLable.Location = new System.Drawing.Point(1657, 316);
            this.inspecInfoLable.Name = "inspecInfoLable";
            this.inspecInfoLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inspecInfoLable.Size = new System.Drawing.Size(82, 19);
            this.inspecInfoLable.TabIndex = 11;
            this.inspecInfoLable.Text = ":פרטי מפקח";
            // 
            // archTelLable
            // 
            this.archTelLable.AutoSize = true;
            this.archTelLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archTelLable.Location = new System.Drawing.Point(1591, 275);
            this.archTelLable.Name = "archTelLable";
            this.archTelLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.archTelLable.Size = new System.Drawing.Size(45, 19);
            this.archTelLable.TabIndex = 10;
            this.archTelLable.Text = ":טלפון";
            // 
            // archNameLable
            // 
            this.archNameLable.AutoSize = true;
            this.archNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archNameLable.Location = new System.Drawing.Point(1603, 235);
            this.archNameLable.Name = "archNameLable";
            this.archNameLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.archNameLable.Size = new System.Drawing.Size(33, 19);
            this.archNameLable.TabIndex = 9;
            this.archNameLable.Text = ":שם";
            // 
            // archInfoLable
            // 
            this.archInfoLable.AutoSize = true;
            this.archInfoLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archInfoLable.Location = new System.Drawing.Point(1648, 235);
            this.archInfoLable.Name = "archInfoLable";
            this.archInfoLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.archInfoLable.Size = new System.Drawing.Size(87, 19);
            this.archInfoLable.TabIndex = 8;
            this.archInfoLable.Text = ":פרטי אדריכל";
            // 
            // telContactLable
            // 
            this.telContactLable.AutoSize = true;
            this.telContactLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telContactLable.Location = new System.Drawing.Point(1591, 198);
            this.telContactLable.Name = "telContactLable";
            this.telContactLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.telContactLable.Size = new System.Drawing.Size(45, 19);
            this.telContactLable.TabIndex = 7;
            this.telContactLable.Text = ":טלפון";
            // 
            // contactNameLable
            // 
            this.contactNameLable.AutoSize = true;
            this.contactNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNameLable.Location = new System.Drawing.Point(1603, 159);
            this.contactNameLable.Name = "contactNameLable";
            this.contactNameLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactNameLable.Size = new System.Drawing.Size(33, 19);
            this.contactNameLable.TabIndex = 6;
            this.contactNameLable.Text = ":שם";
            // 
            // contactInfoLable
            // 
            this.contactInfoLable.AutoSize = true;
            this.contactInfoLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfoLable.Location = new System.Drawing.Point(1638, 159);
            this.contactInfoLable.Name = "contactInfoLable";
            this.contactInfoLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactInfoLable.Size = new System.Drawing.Size(109, 19);
            this.contactInfoLable.TabIndex = 5;
            this.contactInfoLable.Text = ":פרטי איש קשר*";
            // 
            // etaDateLable
            // 
            this.etaDateLable.AutoSize = true;
            this.etaDateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etaDateLable.Location = new System.Drawing.Point(1635, 116);
            this.etaDateLable.Name = "etaDateLable";
            this.etaDateLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etaDateLable.Size = new System.Drawing.Size(112, 19);
            this.etaDateLable.TabIndex = 4;
            this.etaDateLable.Text = ":זמן סיום משוער*";
            // 
            // startDateLable
            // 
            this.startDateLable.AutoSize = true;
            this.startDateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLable.Location = new System.Drawing.Point(1591, 73);
            this.startDateLable.Name = "startDateLable";
            this.startDateLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startDateLable.Size = new System.Drawing.Size(156, 19);
            this.startDateLable.TabIndex = 3;
            this.startDateLable.Text = ":תאריך תחילת הפרויקט*";
            // 
            // projNameLable
            // 
            this.projNameLable.AutoSize = true;
            this.projNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameLable.Location = new System.Drawing.Point(1660, 31);
            this.projNameLable.Name = "projNameLable";
            this.projNameLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.projNameLable.Size = new System.Drawing.Size(87, 19);
            this.projNameLable.TabIndex = 2;
            this.projNameLable.Text = ":שם פרויקט*";
            // 
            // searchByProjNameTab
            // 
            this.searchByProjNameTab.BackColor = System.Drawing.Color.SkyBlue;
            this.searchByProjNameTab.Controls.Add(this.searchByProjNameDataGridView);
            this.searchByProjNameTab.Controls.Add(this.searchProjNameButt);
            this.searchByProjNameTab.Controls.Add(this.searchByProjNameTextBox);
            this.searchByProjNameTab.Controls.Add(this.searchByProjNameLable);
            this.searchByProjNameTab.Location = new System.Drawing.Point(4, 24);
            this.searchByProjNameTab.Name = "searchByProjNameTab";
            this.searchByProjNameTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchByProjNameTab.Size = new System.Drawing.Size(1759, 983);
            this.searchByProjNameTab.TabIndex = 2;
            this.searchByProjNameTab.Text = "חפש לפי שם פרויקט";
            this.searchByProjNameTab.MouseEnter += new System.EventHandler(this.searchByProjNameTab_MouseEnter);
            // 
            // searchByProjNameDataGridView
            // 
            this.searchByProjNameDataGridView.AllowUserToAddRows = false;
            this.searchByProjNameDataGridView.AutoGenerateColumns = false;
            this.searchByProjNameDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.searchByProjNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchByProjNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn1,
            this.projStateDataGridViewTextBoxColumn,
            this.projNameDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn2,
            this.etaDateDataGridViewTextBoxColumn1,
            this.contactNameDataGridViewTextBoxColumn1,
            this.contactTelDataGridViewTextBoxColumn1,
            this.archNameDataGridViewTextBoxColumn1,
            this.archTelDataGridViewTextBoxColumn1,
            this.inspNameDataGridViewTextBoxColumn1,
            this.inspTelDataGridViewTextBoxColumn1,
            this.insurPolicyDataGridViewTextBoxColumn1,
            this.archPlanPathDataGridViewTextBoxColumn,
            this.agreementPathDataGridViewTextBoxColumn});
            this.searchByProjNameDataGridView.DataSource = this.projectBindingSource;
            this.searchByProjNameDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchByProjNameDataGridView.Location = new System.Drawing.Point(3, 50);
            this.searchByProjNameDataGridView.Name = "searchByProjNameDataGridView";
            this.searchByProjNameDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchByProjNameDataGridView.Size = new System.Drawing.Size(1753, 930);
            this.searchByProjNameDataGridView.TabIndex = 15;
            this.searchByProjNameDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchByProjNameDataGridView_CellContentClick);
            this.searchByProjNameDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.searchByProjNameDataGridView_EditingControlShowing);
            this.searchByProjNameDataGridView.MouseEnter += new System.EventHandler(this.searchByProjNameDataGridView_MouseEnter);
            // 
            // projIDDataGridViewTextBoxColumn1
            // 
            this.projIDDataGridViewTextBoxColumn1.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn1.HeaderText = "מספר פרויקט";
            this.projIDDataGridViewTextBoxColumn1.Name = "projIDDataGridViewTextBoxColumn1";
            this.projIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // projStateDataGridViewTextBoxColumn
            // 
            this.projStateDataGridViewTextBoxColumn.DataPropertyName = "projState";
            this.projStateDataGridViewTextBoxColumn.HeaderText = "מצב פרויקט";
            this.projStateDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל",
            "בעיכוב"});
            this.projStateDataGridViewTextBoxColumn.Name = "projStateDataGridViewTextBoxColumn";
            this.projStateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.projStateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // projNameDataGridViewTextBoxColumn1
            // 
            this.projNameDataGridViewTextBoxColumn1.DataPropertyName = "projName";
            this.projNameDataGridViewTextBoxColumn1.HeaderText = "שם פרויקט";
            this.projNameDataGridViewTextBoxColumn1.Name = "projNameDataGridViewTextBoxColumn1";
            // 
            // startDateDataGridViewTextBoxColumn2
            // 
            this.startDateDataGridViewTextBoxColumn2.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn2.HeaderText = "תאריך התחלה";
            this.startDateDataGridViewTextBoxColumn2.Name = "startDateDataGridViewTextBoxColumn2";
            // 
            // etaDateDataGridViewTextBoxColumn1
            // 
            this.etaDateDataGridViewTextBoxColumn1.DataPropertyName = "etaDate";
            this.etaDateDataGridViewTextBoxColumn1.HeaderText = "תאריך סיום משוער";
            this.etaDateDataGridViewTextBoxColumn1.Name = "etaDateDataGridViewTextBoxColumn1";
            // 
            // contactNameDataGridViewTextBoxColumn1
            // 
            this.contactNameDataGridViewTextBoxColumn1.DataPropertyName = "contactName";
            this.contactNameDataGridViewTextBoxColumn1.HeaderText = "שם איש קשר";
            this.contactNameDataGridViewTextBoxColumn1.Name = "contactNameDataGridViewTextBoxColumn1";
            // 
            // contactTelDataGridViewTextBoxColumn1
            // 
            this.contactTelDataGridViewTextBoxColumn1.DataPropertyName = "contactTel";
            this.contactTelDataGridViewTextBoxColumn1.HeaderText = "טלפון איש קשר";
            this.contactTelDataGridViewTextBoxColumn1.Name = "contactTelDataGridViewTextBoxColumn1";
            // 
            // archNameDataGridViewTextBoxColumn1
            // 
            this.archNameDataGridViewTextBoxColumn1.DataPropertyName = "archName";
            this.archNameDataGridViewTextBoxColumn1.HeaderText = "שם מהנדס";
            this.archNameDataGridViewTextBoxColumn1.Name = "archNameDataGridViewTextBoxColumn1";
            // 
            // archTelDataGridViewTextBoxColumn1
            // 
            this.archTelDataGridViewTextBoxColumn1.DataPropertyName = "archTel";
            this.archTelDataGridViewTextBoxColumn1.HeaderText = "טלפון מהנדס";
            this.archTelDataGridViewTextBoxColumn1.Name = "archTelDataGridViewTextBoxColumn1";
            // 
            // inspNameDataGridViewTextBoxColumn1
            // 
            this.inspNameDataGridViewTextBoxColumn1.DataPropertyName = "inspName";
            this.inspNameDataGridViewTextBoxColumn1.HeaderText = "שם מפקח";
            this.inspNameDataGridViewTextBoxColumn1.Name = "inspNameDataGridViewTextBoxColumn1";
            // 
            // inspTelDataGridViewTextBoxColumn1
            // 
            this.inspTelDataGridViewTextBoxColumn1.DataPropertyName = "inspTel";
            this.inspTelDataGridViewTextBoxColumn1.HeaderText = "טלפון מפקח";
            this.inspTelDataGridViewTextBoxColumn1.Name = "inspTelDataGridViewTextBoxColumn1";
            // 
            // insurPolicyDataGridViewTextBoxColumn1
            // 
            this.insurPolicyDataGridViewTextBoxColumn1.DataPropertyName = "insurPolicy";
            this.insurPolicyDataGridViewTextBoxColumn1.HeaderText = "פוליסת ביטוח";
            this.insurPolicyDataGridViewTextBoxColumn1.Name = "insurPolicyDataGridViewTextBoxColumn1";
            // 
            // archPlanPathDataGridViewTextBoxColumn
            // 
            this.archPlanPathDataGridViewTextBoxColumn.DataPropertyName = "archPlanPath";
            this.archPlanPathDataGridViewTextBoxColumn.HeaderText = "תוכנית הנדסית";
            this.archPlanPathDataGridViewTextBoxColumn.Name = "archPlanPathDataGridViewTextBoxColumn";
            this.archPlanPathDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.archPlanPathDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // agreementPathDataGridViewTextBoxColumn
            // 
            this.agreementPathDataGridViewTextBoxColumn.DataPropertyName = "agreementPath";
            this.agreementPathDataGridViewTextBoxColumn.HeaderText = "הסכם";
            this.agreementPathDataGridViewTextBoxColumn.Name = "agreementPathDataGridViewTextBoxColumn";
            this.agreementPathDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agreementPathDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // searchProjNameButt
            // 
            this.searchProjNameButt.Location = new System.Drawing.Point(1423, 17);
            this.searchProjNameButt.Name = "searchProjNameButt";
            this.searchProjNameButt.Size = new System.Drawing.Size(75, 23);
            this.searchProjNameButt.TabIndex = 14;
            this.searchProjNameButt.Text = "חפש";
            this.searchProjNameButt.UseVisualStyleBackColor = true;
            this.searchProjNameButt.Click += new System.EventHandler(this.searchProjNameButt_Click);
            // 
            // searchByProjNameTextBox
            // 
            this.searchByProjNameTextBox.Location = new System.Drawing.Point(1504, 17);
            this.searchByProjNameTextBox.Name = "searchByProjNameTextBox";
            this.searchByProjNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchByProjNameTextBox.Size = new System.Drawing.Size(151, 23);
            this.searchByProjNameTextBox.TabIndex = 13;
            // 
            // searchByProjNameLable
            // 
            this.searchByProjNameLable.AutoSize = true;
            this.searchByProjNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByProjNameLable.Location = new System.Drawing.Point(1662, 21);
            this.searchByProjNameLable.Name = "searchByProjNameLable";
            this.searchByProjNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchByProjNameLable.Size = new System.Drawing.Size(79, 19);
            this.searchByProjNameLable.TabIndex = 11;
            this.searchByProjNameLable.Text = "שם פרויקט:";
            // 
            // assignProjToCusTab
            // 
            this.assignProjToCusTab.BackColor = System.Drawing.Color.SkyBlue;
            this.assignProjToCusTab.Controls.Add(this.projCusAssignSaveButt);
            this.assignProjToCusTab.Controls.Add(this.cusNameAssignComboBox);
            this.assignProjToCusTab.Controls.Add(this.projNameAssignComboBox);
            this.assignProjToCusTab.Controls.Add(this.cusNameAssignLable);
            this.assignProjToCusTab.Controls.Add(this.projNameAssignLable);
            this.assignProjToCusTab.Location = new System.Drawing.Point(4, 24);
            this.assignProjToCusTab.Name = "assignProjToCusTab";
            this.assignProjToCusTab.Padding = new System.Windows.Forms.Padding(3);
            this.assignProjToCusTab.Size = new System.Drawing.Size(1759, 983);
            this.assignProjToCusTab.TabIndex = 3;
            this.assignProjToCusTab.Text = "שיוך פרויקט ללקוח";
            this.assignProjToCusTab.MouseEnter += new System.EventHandler(this.assignProjToCusTab_MouseEnter);
            // 
            // projCusAssignSaveButt
            // 
            this.projCusAssignSaveButt.Location = new System.Drawing.Point(1555, 112);
            this.projCusAssignSaveButt.Name = "projCusAssignSaveButt";
            this.projCusAssignSaveButt.Size = new System.Drawing.Size(75, 23);
            this.projCusAssignSaveButt.TabIndex = 16;
            this.projCusAssignSaveButt.Text = "שמור";
            this.projCusAssignSaveButt.UseVisualStyleBackColor = true;
            this.projCusAssignSaveButt.Click += new System.EventHandler(this.projCusAssignSaveButt_Click);
            // 
            // cusNameAssignComboBox
            // 
            this.cusNameAssignComboBox.DataSource = this.customerBindingSource1;
            this.cusNameAssignComboBox.DisplayMember = "cName";
            this.cusNameAssignComboBox.FormattingEnabled = true;
            this.cusNameAssignComboBox.Location = new System.Drawing.Point(1530, 68);
            this.cusNameAssignComboBox.Name = "cusNameAssignComboBox";
            this.cusNameAssignComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusNameAssignComboBox.Size = new System.Drawing.Size(121, 23);
            this.cusNameAssignComboBox.TabIndex = 15;
            this.cusNameAssignComboBox.ValueMember = "cID";
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.tesodotDataSet;
            // 
            // projNameAssignComboBox
            // 
            this.projNameAssignComboBox.DataSource = this.projectBindingSource1;
            this.projNameAssignComboBox.DisplayMember = "projName";
            this.projNameAssignComboBox.FormattingEnabled = true;
            this.projNameAssignComboBox.Location = new System.Drawing.Point(1530, 25);
            this.projNameAssignComboBox.Name = "projNameAssignComboBox";
            this.projNameAssignComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projNameAssignComboBox.Size = new System.Drawing.Size(121, 23);
            this.projNameAssignComboBox.TabIndex = 14;
            this.projNameAssignComboBox.ValueMember = "projID";
            // 
            // projectBindingSource1
            // 
            this.projectBindingSource1.DataMember = "Project";
            this.projectBindingSource1.DataSource = this.tesodotDataSet;
            // 
            // cusNameAssignLable
            // 
            this.cusNameAssignLable.AutoSize = true;
            this.cusNameAssignLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusNameAssignLable.Location = new System.Drawing.Point(1670, 68);
            this.cusNameAssignLable.Name = "cusNameAssignLable";
            this.cusNameAssignLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusNameAssignLable.Size = new System.Drawing.Size(66, 19);
            this.cusNameAssignLable.TabIndex = 13;
            this.cusNameAssignLable.Text = "שם לקוח:";
            // 
            // projNameAssignLable
            // 
            this.projNameAssignLable.AutoSize = true;
            this.projNameAssignLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projNameAssignLable.Location = new System.Drawing.Point(1657, 25);
            this.projNameAssignLable.Name = "projNameAssignLable";
            this.projNameAssignLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projNameAssignLable.Size = new System.Drawing.Size(79, 19);
            this.projNameAssignLable.TabIndex = 12;
            this.projNameAssignLable.Text = "שם פרויקט:";
            // 
            // showWorkerTab
            // 
            this.showWorkerTab.BackColor = System.Drawing.Color.SkyBlue;
            this.showWorkerTab.Controls.Add(this.employeeDataGridView);
            this.showWorkerTab.Location = new System.Drawing.Point(4, 24);
            this.showWorkerTab.Name = "showWorkerTab";
            this.showWorkerTab.Padding = new System.Windows.Forms.Padding(3);
            this.showWorkerTab.Size = new System.Drawing.Size(1759, 983);
            this.showWorkerTab.TabIndex = 4;
            this.showWorkerTab.Text = "כלל העובדים";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AllowUserToAddRows = false;
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eIDDataGridViewTextBoxColumn,
            this.eNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn1,
            this.eTypeDataGridViewTextBoxColumn,
            this.bankNumDataGridViewTextBoxColumn,
            this.branchNumDataGridViewTextBoxColumn,
            this.accountNumDataGridViewTextBoxColumn});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDataGridView.Location = new System.Drawing.Point(3, 3);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeeDataGridView.Size = new System.Drawing.Size(1753, 977);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.MouseEnter += new System.EventHandler(this.employeeDataGridView_MouseEnter);
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "מספר ת\"ז";
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            // 
            // eNameDataGridViewTextBoxColumn
            // 
            this.eNameDataGridViewTextBoxColumn.DataPropertyName = "eName";
            this.eNameDataGridViewTextBoxColumn.HeaderText = "שם העובד";
            this.eNameDataGridViewTextBoxColumn.Name = "eNameDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn1
            // 
            this.startDateDataGridViewTextBoxColumn1.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn1.HeaderText = "תאריך תחילת עבודה";
            this.startDateDataGridViewTextBoxColumn1.Name = "startDateDataGridViewTextBoxColumn1";
            // 
            // eTypeDataGridViewTextBoxColumn
            // 
            this.eTypeDataGridViewTextBoxColumn.DataPropertyName = "eType";
            this.eTypeDataGridViewTextBoxColumn.HeaderText = "סוג העובד";
            this.eTypeDataGridViewTextBoxColumn.Name = "eTypeDataGridViewTextBoxColumn";
            // 
            // bankNumDataGridViewTextBoxColumn
            // 
            this.bankNumDataGridViewTextBoxColumn.DataPropertyName = "bankNum";
            this.bankNumDataGridViewTextBoxColumn.HeaderText = "מספר בנק";
            this.bankNumDataGridViewTextBoxColumn.Name = "bankNumDataGridViewTextBoxColumn";
            // 
            // branchNumDataGridViewTextBoxColumn
            // 
            this.branchNumDataGridViewTextBoxColumn.DataPropertyName = "branchNum";
            this.branchNumDataGridViewTextBoxColumn.HeaderText = "מספר סניף";
            this.branchNumDataGridViewTextBoxColumn.Name = "branchNumDataGridViewTextBoxColumn";
            // 
            // accountNumDataGridViewTextBoxColumn
            // 
            this.accountNumDataGridViewTextBoxColumn.DataPropertyName = "accountNum";
            this.accountNumDataGridViewTextBoxColumn.HeaderText = "מספר חשבון";
            this.accountNumDataGridViewTextBoxColumn.Name = "accountNumDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.tesodotDataSet;
            // 
            // createNewWorkerTab
            // 
            this.createNewWorkerTab.BackColor = System.Drawing.Color.SkyBlue;
            this.createNewWorkerTab.Controls.Add(this.sumbitNewEmployeeButt);
            this.createNewWorkerTab.Controls.Add(this.wTypeComboBox);
            this.createNewWorkerTab.Controls.Add(this.confNumTextBox);
            this.createNewWorkerTab.Controls.Add(this.createPassTextBox);
            this.createNewWorkerTab.Controls.Add(this.accountNumTextBox);
            this.createNewWorkerTab.Controls.Add(this.branchNumTextBox);
            this.createNewWorkerTab.Controls.Add(this.bankNumTextBox);
            this.createNewWorkerTab.Controls.Add(this.eTypeCombo);
            this.createNewWorkerTab.Controls.Add(this.startWorkingDatePicker);
            this.createNewWorkerTab.Controls.Add(this.eNameTextbox);
            this.createNewWorkerTab.Controls.Add(this.eIDTextBox);
            this.createNewWorkerTab.Controls.Add(this.wTypeLable);
            this.createNewWorkerTab.Controls.Add(this.confNumLable);
            this.createNewWorkerTab.Controls.Add(this.createPassLable);
            this.createNewWorkerTab.Controls.Add(this.accountNumLable);
            this.createNewWorkerTab.Controls.Add(this.branchNumLable);
            this.createNewWorkerTab.Controls.Add(this.bankNumLable);
            this.createNewWorkerTab.Controls.Add(this.paymentInfoLable);
            this.createNewWorkerTab.Controls.Add(this.eTypeLable);
            this.createNewWorkerTab.Controls.Add(this.eStartDateLable);
            this.createNewWorkerTab.Controls.Add(this.eNameLable);
            this.createNewWorkerTab.Controls.Add(this.eIDLable);
            this.createNewWorkerTab.Location = new System.Drawing.Point(4, 24);
            this.createNewWorkerTab.Name = "createNewWorkerTab";
            this.createNewWorkerTab.Padding = new System.Windows.Forms.Padding(3);
            this.createNewWorkerTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createNewWorkerTab.Size = new System.Drawing.Size(1759, 983);
            this.createNewWorkerTab.TabIndex = 5;
            this.createNewWorkerTab.Text = "צור עובד חדש";
            this.createNewWorkerTab.MouseEnter += new System.EventHandler(this.createNewWorkerTab_MouseEnter);
            // 
            // sumbitNewEmployeeButt
            // 
            this.sumbitNewEmployeeButt.Location = new System.Drawing.Point(1567, 475);
            this.sumbitNewEmployeeButt.Name = "sumbitNewEmployeeButt";
            this.sumbitNewEmployeeButt.Size = new System.Drawing.Size(75, 23);
            this.sumbitNewEmployeeButt.TabIndex = 23;
            this.sumbitNewEmployeeButt.Text = "צור עובד";
            this.sumbitNewEmployeeButt.UseVisualStyleBackColor = true;
            this.sumbitNewEmployeeButt.Click += new System.EventHandler(this.sumbitNewEmployeeButt_Click);
            // 
            // wTypeComboBox
            // 
            this.wTypeComboBox.DataSource = this.workertypeBindingSource;
            this.wTypeComboBox.DisplayMember = "wType";
            this.wTypeComboBox.FormattingEnabled = true;
            this.wTypeComboBox.Location = new System.Drawing.Point(1548, 415);
            this.wTypeComboBox.Name = "wTypeComboBox";
            this.wTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.wTypeComboBox.TabIndex = 22;
            this.wTypeComboBox.ValueMember = "wType";
            // 
            // workertypeBindingSource
            // 
            this.workertypeBindingSource.DataMember = "Worker_type";
            this.workertypeBindingSource.DataSource = this.tesodotDataSet;
            // 
            // confNumTextBox
            // 
            this.confNumTextBox.Location = new System.Drawing.Point(1548, 369);
            this.confNumTextBox.Name = "confNumTextBox";
            this.confNumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.confNumTextBox.TabIndex = 21;
            // 
            // createPassTextBox
            // 
            this.createPassTextBox.Location = new System.Drawing.Point(1581, 325);
            this.createPassTextBox.Name = "createPassTextBox";
            this.createPassTextBox.PasswordChar = '*';
            this.createPassTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.createPassTextBox.Size = new System.Drawing.Size(100, 23);
            this.createPassTextBox.TabIndex = 20;
            // 
            // accountNumTextBox
            // 
            this.accountNumTextBox.Location = new System.Drawing.Point(1457, 284);
            this.accountNumTextBox.Name = "accountNumTextBox";
            this.accountNumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.accountNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.accountNumTextBox.TabIndex = 19;
            // 
            // branchNumTextBox
            // 
            this.branchNumTextBox.Location = new System.Drawing.Point(1487, 245);
            this.branchNumTextBox.Name = "branchNumTextBox";
            this.branchNumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchNumTextBox.Size = new System.Drawing.Size(79, 23);
            this.branchNumTextBox.TabIndex = 18;
            // 
            // bankNumTextBox
            // 
            this.bankNumTextBox.Location = new System.Drawing.Point(1512, 200);
            this.bankNumTextBox.Name = "bankNumTextBox";
            this.bankNumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bankNumTextBox.Size = new System.Drawing.Size(58, 23);
            this.bankNumTextBox.TabIndex = 17;
            // 
            // eTypeCombo
            // 
            this.eTypeCombo.FormattingEnabled = true;
            this.eTypeCombo.Items.AddRange(new object[] {
            "פועל",
            "מנהל פרויקט",
            "מנהל"});
            this.eTypeCombo.Location = new System.Drawing.Point(1550, 154);
            this.eTypeCombo.Name = "eTypeCombo";
            this.eTypeCombo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eTypeCombo.Size = new System.Drawing.Size(121, 23);
            this.eTypeCombo.TabIndex = 16;
            this.eTypeCombo.SelectedIndexChanged += new System.EventHandler(this.eTypeCombo_SelectedIndexChanged);
            // 
            // startWorkingDatePicker
            // 
            this.startWorkingDatePicker.CustomFormat = "MM.dd.yyy";
            this.startWorkingDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startWorkingDatePicker.Location = new System.Drawing.Point(1506, 109);
            this.startWorkingDatePicker.Name = "startWorkingDatePicker";
            this.startWorkingDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startWorkingDatePicker.Size = new System.Drawing.Size(99, 23);
            this.startWorkingDatePicker.TabIndex = 15;
            // 
            // eNameTextbox
            // 
            this.eNameTextbox.Location = new System.Drawing.Point(1560, 72);
            this.eNameTextbox.Name = "eNameTextbox";
            this.eNameTextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eNameTextbox.Size = new System.Drawing.Size(100, 23);
            this.eNameTextbox.TabIndex = 13;
            // 
            // eIDTextBox
            // 
            this.eIDTextBox.Location = new System.Drawing.Point(1558, 27);
            this.eIDTextBox.MaxLength = 9;
            this.eIDTextBox.Name = "eIDTextBox";
            this.eIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.eIDTextBox.TabIndex = 12;
            // 
            // wTypeLable
            // 
            this.wTypeLable.AutoSize = true;
            this.wTypeLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wTypeLable.Location = new System.Drawing.Point(1676, 413);
            this.wTypeLable.Name = "wTypeLable";
            this.wTypeLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wTypeLable.Size = new System.Drawing.Size(72, 19);
            this.wTypeLable.TabIndex = 11;
            this.wTypeLable.Text = ":סוג פועל*";
            // 
            // confNumLable
            // 
            this.confNumLable.AutoSize = true;
            this.confNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confNumLable.Location = new System.Drawing.Point(1654, 367);
            this.confNumLable.Name = "confNumLable";
            this.confNumLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confNumLable.Size = new System.Drawing.Size(94, 19);
            this.confNumLable.TabIndex = 10;
            this.confNumLable.Text = ":מספר אישור*";
            // 
            // createPassLable
            // 
            this.createPassLable.AutoSize = true;
            this.createPassLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassLable.Location = new System.Drawing.Point(1687, 323);
            this.createPassLable.Name = "createPassLable";
            this.createPassLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.createPassLable.Size = new System.Drawing.Size(61, 19);
            this.createPassLable.TabIndex = 9;
            this.createPassLable.Text = ":סיסמא*";
            // 
            // accountNumLable
            // 
            this.accountNumLable.AutoSize = true;
            this.accountNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumLable.Location = new System.Drawing.Point(1563, 282);
            this.accountNumLable.Name = "accountNumLable";
            this.accountNumLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountNumLable.Size = new System.Drawing.Size(87, 19);
            this.accountNumLable.TabIndex = 8;
            this.accountNumLable.Text = ":מספר חשבון";
            // 
            // branchNumLable
            // 
            this.branchNumLable.AutoSize = true;
            this.branchNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNumLable.Location = new System.Drawing.Point(1572, 243);
            this.branchNumLable.Name = "branchNumLable";
            this.branchNumLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.branchNumLable.Size = new System.Drawing.Size(78, 19);
            this.branchNumLable.TabIndex = 7;
            this.branchNumLable.Text = ":מספר סניף";
            // 
            // bankNumLable
            // 
            this.bankNumLable.AutoSize = true;
            this.bankNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankNumLable.Location = new System.Drawing.Point(1576, 198);
            this.bankNumLable.Name = "bankNumLable";
            this.bankNumLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bankNumLable.Size = new System.Drawing.Size(74, 19);
            this.bankNumLable.TabIndex = 6;
            this.bankNumLable.Text = ":מספר בנק";
            // 
            // paymentInfoLable
            // 
            this.paymentInfoLable.AutoSize = true;
            this.paymentInfoLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInfoLable.Location = new System.Drawing.Point(1656, 198);
            this.paymentInfoLable.Name = "paymentInfoLable";
            this.paymentInfoLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paymentInfoLable.Size = new System.Drawing.Size(87, 19);
            this.paymentInfoLable.TabIndex = 5;
            this.paymentInfoLable.Text = ":פרטי תשלום";
            // 
            // eTypeLable
            // 
            this.eTypeLable.AutoSize = true;
            this.eTypeLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eTypeLable.Location = new System.Drawing.Point(1677, 152);
            this.eTypeLable.Name = "eTypeLable";
            this.eTypeLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eTypeLable.Size = new System.Drawing.Size(71, 19);
            this.eTypeLable.TabIndex = 4;
            this.eTypeLable.Text = ":סוג עובד*";
            // 
            // eStartDateLable
            // 
            this.eStartDateLable.AutoSize = true;
            this.eStartDateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eStartDateLable.Location = new System.Drawing.Point(1611, 110);
            this.eStartDateLable.Name = "eStartDateLable";
            this.eStartDateLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eStartDateLable.Size = new System.Drawing.Size(140, 19);
            this.eStartDateLable.TabIndex = 3;
            this.eStartDateLable.Text = ":תאריך תחילת עבודה*";
            // 
            // eNameLable
            // 
            this.eNameLable.AutoSize = true;
            this.eNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNameLable.Location = new System.Drawing.Point(1666, 72);
            this.eNameLable.Name = "eNameLable";
            this.eNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eNameLable.Size = new System.Drawing.Size(81, 19);
            this.eNameLable.TabIndex = 1;
            this.eNameLable.Text = "*שם העובד:";
            // 
            // eIDLable
            // 
            this.eIDLable.AutoSize = true;
            this.eIDLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eIDLable.Location = new System.Drawing.Point(1664, 25);
            this.eIDLable.Name = "eIDLable";
            this.eIDLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eIDLable.Size = new System.Drawing.Size(87, 19);
            this.eIDLable.TabIndex = 0;
            this.eIDLable.Text = ":מספר זהות*";
            // 
            // searchWorkerByProjTab
            // 
            this.searchWorkerByProjTab.BackColor = System.Drawing.Color.SkyBlue;
            this.searchWorkerByProjTab.Controls.Add(this.searchWorkerByProjDataGridView);
            this.searchWorkerByProjTab.Controls.Add(this.searchWorkersInProjButt);
            this.searchWorkerByProjTab.Controls.Add(this.searchWorkersInProjComboBox);
            this.searchWorkerByProjTab.Controls.Add(this.searchWorkersInProjLable);
            this.searchWorkerByProjTab.Location = new System.Drawing.Point(4, 24);
            this.searchWorkerByProjTab.Name = "searchWorkerByProjTab";
            this.searchWorkerByProjTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchWorkerByProjTab.Size = new System.Drawing.Size(1759, 983);
            this.searchWorkerByProjTab.TabIndex = 6;
            this.searchWorkerByProjTab.Text = "חיפוש עובדים בפרויקט";
            this.searchWorkerByProjTab.MouseEnter += new System.EventHandler(this.searchWorkerByProjTab_MouseEnter);
            // 
            // searchWorkerByProjDataGridView
            // 
            this.searchWorkerByProjDataGridView.AllowUserToAddRows = false;
            this.searchWorkerByProjDataGridView.AutoGenerateColumns = false;
            this.searchWorkerByProjDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.searchWorkerByProjDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchWorkerByProjDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eIDDataGridViewTextBoxColumn1,
            this.eNameDataGridViewTextBoxColumn1,
            this.startDateDataGridViewTextBoxColumn3,
            this.eTypeDataGridViewTextBoxColumn1});
            this.searchWorkerByProjDataGridView.DataSource = this.employeeBindingSource;
            this.searchWorkerByProjDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchWorkerByProjDataGridView.Location = new System.Drawing.Point(3, 68);
            this.searchWorkerByProjDataGridView.Name = "searchWorkerByProjDataGridView";
            this.searchWorkerByProjDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchWorkerByProjDataGridView.Size = new System.Drawing.Size(1753, 912);
            this.searchWorkerByProjDataGridView.TabIndex = 6;
            this.searchWorkerByProjDataGridView.MouseEnter += new System.EventHandler(this.searchWorkerByProjDataGridView_MouseEnter);
            // 
            // eIDDataGridViewTextBoxColumn1
            // 
            this.eIDDataGridViewTextBoxColumn1.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn1.HeaderText = "מספר תעודת זהות";
            this.eIDDataGridViewTextBoxColumn1.Name = "eIDDataGridViewTextBoxColumn1";
            // 
            // eNameDataGridViewTextBoxColumn1
            // 
            this.eNameDataGridViewTextBoxColumn1.DataPropertyName = "eName";
            this.eNameDataGridViewTextBoxColumn1.HeaderText = "שם עובד";
            this.eNameDataGridViewTextBoxColumn1.Name = "eNameDataGridViewTextBoxColumn1";
            // 
            // startDateDataGridViewTextBoxColumn3
            // 
            this.startDateDataGridViewTextBoxColumn3.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn3.HeaderText = "תאריך תחילת עבודה";
            this.startDateDataGridViewTextBoxColumn3.Name = "startDateDataGridViewTextBoxColumn3";
            // 
            // eTypeDataGridViewTextBoxColumn1
            // 
            this.eTypeDataGridViewTextBoxColumn1.DataPropertyName = "eType";
            this.eTypeDataGridViewTextBoxColumn1.HeaderText = "סוג עובד";
            this.eTypeDataGridViewTextBoxColumn1.Name = "eTypeDataGridViewTextBoxColumn1";
            // 
            // searchWorkersInProjButt
            // 
            this.searchWorkersInProjButt.Location = new System.Drawing.Point(1447, 29);
            this.searchWorkersInProjButt.Name = "searchWorkersInProjButt";
            this.searchWorkersInProjButt.Size = new System.Drawing.Size(75, 23);
            this.searchWorkersInProjButt.TabIndex = 5;
            this.searchWorkersInProjButt.Text = "חפש";
            this.searchWorkersInProjButt.UseVisualStyleBackColor = true;
            this.searchWorkersInProjButt.Click += new System.EventHandler(this.searchWorkersInProjButt_Click);
            // 
            // searchWorkersInProjComboBox
            // 
            this.searchWorkersInProjComboBox.DataSource = this.projectBindingSource;
            this.searchWorkersInProjComboBox.DisplayMember = "projName";
            this.searchWorkersInProjComboBox.FormattingEnabled = true;
            this.searchWorkersInProjComboBox.Location = new System.Drawing.Point(1544, 29);
            this.searchWorkersInProjComboBox.Name = "searchWorkersInProjComboBox";
            this.searchWorkersInProjComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchWorkersInProjComboBox.Size = new System.Drawing.Size(121, 23);
            this.searchWorkersInProjComboBox.TabIndex = 4;
            this.searchWorkersInProjComboBox.ValueMember = "projID";
            // 
            // searchWorkersInProjLable
            // 
            this.searchWorkersInProjLable.AutoSize = true;
            this.searchWorkersInProjLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWorkersInProjLable.Location = new System.Drawing.Point(1671, 29);
            this.searchWorkersInProjLable.Name = "searchWorkersInProjLable";
            this.searchWorkersInProjLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchWorkersInProjLable.Size = new System.Drawing.Size(79, 19);
            this.searchWorkersInProjLable.TabIndex = 3;
            this.searchWorkersInProjLable.Text = "שם פרויקט:";
            // 
            // assignWorkerTab
            // 
            this.assignWorkerTab.BackColor = System.Drawing.Color.SkyBlue;
            this.assignWorkerTab.Controls.Add(this.projWorkerAssignButt);
            this.assignWorkerTab.Controls.Add(this.workerProjAssignComboBox);
            this.assignWorkerTab.Controls.Add(this.projWorkerAssignComboBox);
            this.assignWorkerTab.Controls.Add(this.workerProjAssignLabel);
            this.assignWorkerTab.Controls.Add(this.projWorkerAssignLable);
            this.assignWorkerTab.Location = new System.Drawing.Point(4, 24);
            this.assignWorkerTab.Name = "assignWorkerTab";
            this.assignWorkerTab.Padding = new System.Windows.Forms.Padding(3);
            this.assignWorkerTab.Size = new System.Drawing.Size(1759, 983);
            this.assignWorkerTab.TabIndex = 7;
            this.assignWorkerTab.Text = "שיוך עובד לפרויקט";
            this.assignWorkerTab.MouseEnter += new System.EventHandler(this.assignWorkerTab_MouseEnter);
            // 
            // projWorkerAssignButt
            // 
            this.projWorkerAssignButt.Location = new System.Drawing.Point(1559, 110);
            this.projWorkerAssignButt.Name = "projWorkerAssignButt";
            this.projWorkerAssignButt.Size = new System.Drawing.Size(75, 23);
            this.projWorkerAssignButt.TabIndex = 7;
            this.projWorkerAssignButt.Text = "שמור";
            this.projWorkerAssignButt.UseVisualStyleBackColor = true;
            this.projWorkerAssignButt.Click += new System.EventHandler(this.projWorkerAssignButt_Click);
            // 
            // workerProjAssignComboBox
            // 
            this.workerProjAssignComboBox.DataSource = this.employeeBindingSource;
            this.workerProjAssignComboBox.DisplayMember = "eName";
            this.workerProjAssignComboBox.FormattingEnabled = true;
            this.workerProjAssignComboBox.Location = new System.Drawing.Point(1531, 68);
            this.workerProjAssignComboBox.Name = "workerProjAssignComboBox";
            this.workerProjAssignComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerProjAssignComboBox.Size = new System.Drawing.Size(121, 23);
            this.workerProjAssignComboBox.TabIndex = 6;
            this.workerProjAssignComboBox.ValueMember = "eID";
            // 
            // projWorkerAssignComboBox
            // 
            this.projWorkerAssignComboBox.DataSource = this.projectBindingSource;
            this.projWorkerAssignComboBox.DisplayMember = "projName";
            this.projWorkerAssignComboBox.FormattingEnabled = true;
            this.projWorkerAssignComboBox.Location = new System.Drawing.Point(1531, 22);
            this.projWorkerAssignComboBox.Name = "projWorkerAssignComboBox";
            this.projWorkerAssignComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projWorkerAssignComboBox.Size = new System.Drawing.Size(121, 23);
            this.projWorkerAssignComboBox.TabIndex = 5;
            this.projWorkerAssignComboBox.ValueMember = "projID";
            // 
            // workerProjAssignLabel
            // 
            this.workerProjAssignLabel.AutoSize = true;
            this.workerProjAssignLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerProjAssignLabel.Location = new System.Drawing.Point(1673, 68);
            this.workerProjAssignLabel.Name = "workerProjAssignLabel";
            this.workerProjAssignLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerProjAssignLabel.Size = new System.Drawing.Size(64, 19);
            this.workerProjAssignLabel.TabIndex = 4;
            this.workerProjAssignLabel.Text = "שם עובד:";
            // 
            // projWorkerAssignLable
            // 
            this.projWorkerAssignLable.AutoSize = true;
            this.projWorkerAssignLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projWorkerAssignLable.Location = new System.Drawing.Point(1658, 22);
            this.projWorkerAssignLable.Name = "projWorkerAssignLable";
            this.projWorkerAssignLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projWorkerAssignLable.Size = new System.Drawing.Size(79, 19);
            this.projWorkerAssignLable.TabIndex = 3;
            this.projWorkerAssignLable.Text = "שם פרויקט:";
            // 
            // showCusTab
            // 
            this.showCusTab.BackColor = System.Drawing.Color.SkyBlue;
            this.showCusTab.Controls.Add(this.customerDataGridView);
            this.showCusTab.Location = new System.Drawing.Point(4, 24);
            this.showCusTab.Name = "showCusTab";
            this.showCusTab.Padding = new System.Windows.Forms.Padding(3);
            this.showCusTab.Size = new System.Drawing.Size(1759, 983);
            this.showCusTab.TabIndex = 8;
            this.showCusTab.Text = "לקוחות";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cTypeDataGridViewComboBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cStreetDataGridViewTextBoxColumn,
            this.cSNumDataGridViewTextBoxColumn,
            this.cCityDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerDataGridView.Location = new System.Drawing.Point(3, 3);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.customerDataGridView.Size = new System.Drawing.Size(1753, 977);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.MouseEnter += new System.EventHandler(this.customerDataGridView_MouseEnter);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "cID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "מספר ת\"ז";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            // 
            // cTypeDataGridViewComboBoxColumn
            // 
            this.cTypeDataGridViewComboBoxColumn.DataPropertyName = "cType";
            this.cTypeDataGridViewComboBoxColumn.HeaderText = "סוג לקוח";
            this.cTypeDataGridViewComboBoxColumn.Items.AddRange(new object[] {
            "מר",
            "גב",
            "חברה"});
            this.cTypeDataGridViewComboBoxColumn.Name = "cTypeDataGridViewComboBoxColumn";
            this.cTypeDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cTypeDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "שם לקוח";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // cStreetDataGridViewTextBoxColumn
            // 
            this.cStreetDataGridViewTextBoxColumn.DataPropertyName = "cStreet";
            this.cStreetDataGridViewTextBoxColumn.HeaderText = "רחוב";
            this.cStreetDataGridViewTextBoxColumn.Name = "cStreetDataGridViewTextBoxColumn";
            // 
            // cSNumDataGridViewTextBoxColumn
            // 
            this.cSNumDataGridViewTextBoxColumn.DataPropertyName = "cSNum";
            this.cSNumDataGridViewTextBoxColumn.HeaderText = "מספר רחוב";
            this.cSNumDataGridViewTextBoxColumn.Name = "cSNumDataGridViewTextBoxColumn";
            // 
            // cCityDataGridViewTextBoxColumn
            // 
            this.cCityDataGridViewTextBoxColumn.DataPropertyName = "cCity";
            this.cCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.cCityDataGridViewTextBoxColumn.Name = "cCityDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "מספר טלפון";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.tesodotDataSet;
            // 
            // newCusTab
            // 
            this.newCusTab.BackColor = System.Drawing.Color.SkyBlue;
            this.newCusTab.Controls.Add(this.sumbitCusCreateButt);
            this.newCusTab.Controls.Add(this.cPhoneNumTextBox);
            this.newCusTab.Controls.Add(this.cCityTextBox);
            this.newCusTab.Controls.Add(this.cSNumTextBox);
            this.newCusTab.Controls.Add(this.cStreetTextBox);
            this.newCusTab.Controls.Add(this.cNameTextBox);
            this.newCusTab.Controls.Add(this.cTypeComboBox);
            this.newCusTab.Controls.Add(this.cIDTextBox);
            this.newCusTab.Controls.Add(this.cPhoneNumLable);
            this.newCusTab.Controls.Add(this.cCityLable);
            this.newCusTab.Controls.Add(this.cSNumLable);
            this.newCusTab.Controls.Add(this.cStreetLable);
            this.newCusTab.Controls.Add(this.cTypeLable);
            this.newCusTab.Controls.Add(this.cFirstNameLable);
            this.newCusTab.Controls.Add(this.cIDLable);
            this.newCusTab.Location = new System.Drawing.Point(4, 24);
            this.newCusTab.Name = "newCusTab";
            this.newCusTab.Padding = new System.Windows.Forms.Padding(3);
            this.newCusTab.Size = new System.Drawing.Size(1759, 983);
            this.newCusTab.TabIndex = 9;
            this.newCusTab.Text = "לקוח חדש";
            this.newCusTab.MouseEnter += new System.EventHandler(this.newCusTab_MouseEnter);
            // 
            // sumbitCusCreateButt
            // 
            this.sumbitCusCreateButt.Location = new System.Drawing.Point(1531, 345);
            this.sumbitCusCreateButt.Name = "sumbitCusCreateButt";
            this.sumbitCusCreateButt.Size = new System.Drawing.Size(75, 23);
            this.sumbitCusCreateButt.TabIndex = 18;
            this.sumbitCusCreateButt.Text = "צור לקוח";
            this.sumbitCusCreateButt.UseVisualStyleBackColor = true;
            this.sumbitCusCreateButt.Click += new System.EventHandler(this.sumbitCusCreateButt_Click);
            // 
            // cPhoneNumTextBox
            // 
            this.cPhoneNumTextBox.Location = new System.Drawing.Point(1580, 284);
            this.cPhoneNumTextBox.Name = "cPhoneNumTextBox";
            this.cPhoneNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.cPhoneNumTextBox.TabIndex = 17;
            // 
            // cCityTextBox
            // 
            this.cCityTextBox.Location = new System.Drawing.Point(1593, 243);
            this.cCityTextBox.Name = "cCityTextBox";
            this.cCityTextBox.Size = new System.Drawing.Size(100, 23);
            this.cCityTextBox.TabIndex = 16;
            // 
            // cSNumTextBox
            // 
            this.cSNumTextBox.Location = new System.Drawing.Point(1548, 196);
            this.cSNumTextBox.Name = "cSNumTextBox";
            this.cSNumTextBox.Size = new System.Drawing.Size(100, 23);
            this.cSNumTextBox.TabIndex = 15;
            // 
            // cStreetTextBox
            // 
            this.cStreetTextBox.Location = new System.Drawing.Point(1585, 155);
            this.cStreetTextBox.Name = "cStreetTextBox";
            this.cStreetTextBox.Size = new System.Drawing.Size(100, 23);
            this.cStreetTextBox.TabIndex = 14;
            // 
            // cNameTextBox
            // 
            this.cNameTextBox.Location = new System.Drawing.Point(1559, 112);
            this.cNameTextBox.Name = "cNameTextBox";
            this.cNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.cNameTextBox.TabIndex = 12;
            // 
            // cTypeComboBox
            // 
            this.cTypeComboBox.FormattingEnabled = true;
            this.cTypeComboBox.Items.AddRange(new object[] {
            "מר",
            "גב",
            "חברה"});
            this.cTypeComboBox.Location = new System.Drawing.Point(1572, 68);
            this.cTypeComboBox.Name = "cTypeComboBox";
            this.cTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.cTypeComboBox.TabIndex = 11;
            // 
            // cIDTextBox
            // 
            this.cIDTextBox.Location = new System.Drawing.Point(1506, 32);
            this.cIDTextBox.Name = "cIDTextBox";
            this.cIDTextBox.Size = new System.Drawing.Size(100, 23);
            this.cIDTextBox.TabIndex = 10;
            // 
            // cPhoneNumLable
            // 
            this.cPhoneNumLable.AutoSize = true;
            this.cPhoneNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPhoneNumLable.Location = new System.Drawing.Point(1686, 288);
            this.cPhoneNumLable.Name = "cPhoneNumLable";
            this.cPhoneNumLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cPhoneNumLable.Size = new System.Drawing.Size(53, 19);
            this.cPhoneNumLable.TabIndex = 9;
            this.cPhoneNumLable.Text = "*טלפון:";
            // 
            // cCityLable
            // 
            this.cCityLable.AutoSize = true;
            this.cCityLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCityLable.Location = new System.Drawing.Point(1699, 243);
            this.cCityLable.Name = "cCityLable";
            this.cCityLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cCityLable.Size = new System.Drawing.Size(40, 19);
            this.cCityLable.TabIndex = 8;
            this.cCityLable.Text = "*עיר:";
            // 
            // cSNumLable
            // 
            this.cSNumLable.AutoSize = true;
            this.cSNumLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cSNumLable.Location = new System.Drawing.Point(1654, 196);
            this.cSNumLable.Name = "cSNumLable";
            this.cSNumLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cSNumLable.Size = new System.Drawing.Size(85, 19);
            this.cSNumLable.TabIndex = 7;
            this.cSNumLable.Text = "*מספר בניין:";
            // 
            // cStreetLable
            // 
            this.cStreetLable.AutoSize = true;
            this.cStreetLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cStreetLable.Location = new System.Drawing.Point(1691, 155);
            this.cStreetLable.Name = "cStreetLable";
            this.cStreetLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cStreetLable.Size = new System.Drawing.Size(48, 19);
            this.cStreetLable.TabIndex = 6;
            this.cStreetLable.Text = "*רחוב:";
            // 
            // cTypeLable
            // 
            this.cTypeLable.AutoSize = true;
            this.cTypeLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTypeLable.Location = new System.Drawing.Point(1699, 68);
            this.cTypeLable.Name = "cTypeLable";
            this.cTypeLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cTypeLable.Size = new System.Drawing.Size(40, 19);
            this.cTypeLable.TabIndex = 5;
            this.cTypeLable.Text = "*סוג:";
            // 
            // cFirstNameLable
            // 
            this.cFirstNameLable.AutoSize = true;
            this.cFirstNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cFirstNameLable.Location = new System.Drawing.Point(1665, 112);
            this.cFirstNameLable.Name = "cFirstNameLable";
            this.cFirstNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cFirstNameLable.Size = new System.Drawing.Size(74, 19);
            this.cFirstNameLable.TabIndex = 3;
            this.cFirstNameLable.Text = "*שם לקוח:";
            // 
            // cIDLable
            // 
            this.cIDLable.AutoSize = true;
            this.cIDLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDLable.Location = new System.Drawing.Point(1612, 32);
            this.cIDLable.Name = "cIDLable";
            this.cIDLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cIDLable.Size = new System.Drawing.Size(127, 19);
            this.cIDLable.TabIndex = 2;
            this.cIDLable.Text = "*מספר זהות / ח.פ.:";
            // 
            // searchCusByNameTab
            // 
            this.searchCusByNameTab.BackColor = System.Drawing.Color.SkyBlue;
            this.searchCusByNameTab.Controls.Add(this.searchCusByNameDataGridView);
            this.searchCusByNameTab.Controls.Add(this.searchCusButt);
            this.searchCusByNameTab.Controls.Add(this.cusSearchTextBox);
            this.searchCusByNameTab.Controls.Add(this.cusSearchLabel);
            this.searchCusByNameTab.Location = new System.Drawing.Point(4, 24);
            this.searchCusByNameTab.Name = "searchCusByNameTab";
            this.searchCusByNameTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchCusByNameTab.Size = new System.Drawing.Size(1759, 983);
            this.searchCusByNameTab.TabIndex = 10;
            this.searchCusByNameTab.Text = "חיפוש לקוח לפי שם";
            this.searchCusByNameTab.MouseEnter += new System.EventHandler(this.searchCusByNameTab_MouseEnter);
            // 
            // searchCusByNameDataGridView
            // 
            this.searchCusByNameDataGridView.AllowUserToAddRows = false;
            this.searchCusByNameDataGridView.AutoGenerateColumns = false;
            this.searchCusByNameDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.searchCusByNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchCusByNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn1,
            this.cTypeDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn1,
            this.cStreetDataGridViewTextBoxColumn1,
            this.cSNumDataGridViewTextBoxColumn1,
            this.cCityDataGridViewTextBoxColumn1,
            this.phoneNumberDataGridViewTextBoxColumn1});
            this.searchCusByNameDataGridView.DataSource = this.customerBindingSource1;
            this.searchCusByNameDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchCusByNameDataGridView.Location = new System.Drawing.Point(3, 67);
            this.searchCusByNameDataGridView.Name = "searchCusByNameDataGridView";
            this.searchCusByNameDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchCusByNameDataGridView.Size = new System.Drawing.Size(1753, 913);
            this.searchCusByNameDataGridView.TabIndex = 18;
            this.searchCusByNameDataGridView.MouseEnter += new System.EventHandler(this.searchCusByNameDataGridView_MouseEnter);
            // 
            // cIDDataGridViewTextBoxColumn1
            // 
            this.cIDDataGridViewTextBoxColumn1.DataPropertyName = "cID";
            this.cIDDataGridViewTextBoxColumn1.HeaderText = "מספר תעודת זהות / ח.פ.";
            this.cIDDataGridViewTextBoxColumn1.Name = "cIDDataGridViewTextBoxColumn1";
            // 
            // cTypeDataGridViewTextBoxColumn
            // 
            this.cTypeDataGridViewTextBoxColumn.DataPropertyName = "cType";
            this.cTypeDataGridViewTextBoxColumn.HeaderText = "סוג לקוח";
            this.cTypeDataGridViewTextBoxColumn.Name = "cTypeDataGridViewTextBoxColumn";
            // 
            // cNameDataGridViewTextBoxColumn1
            // 
            this.cNameDataGridViewTextBoxColumn1.DataPropertyName = "cName";
            this.cNameDataGridViewTextBoxColumn1.HeaderText = "שם לקוח";
            this.cNameDataGridViewTextBoxColumn1.Name = "cNameDataGridViewTextBoxColumn1";
            // 
            // cStreetDataGridViewTextBoxColumn1
            // 
            this.cStreetDataGridViewTextBoxColumn1.DataPropertyName = "cStreet";
            this.cStreetDataGridViewTextBoxColumn1.HeaderText = "רחוב";
            this.cStreetDataGridViewTextBoxColumn1.Name = "cStreetDataGridViewTextBoxColumn1";
            // 
            // cSNumDataGridViewTextBoxColumn1
            // 
            this.cSNumDataGridViewTextBoxColumn1.DataPropertyName = "cSNum";
            this.cSNumDataGridViewTextBoxColumn1.HeaderText = "מספר בניין";
            this.cSNumDataGridViewTextBoxColumn1.Name = "cSNumDataGridViewTextBoxColumn1";
            // 
            // cCityDataGridViewTextBoxColumn1
            // 
            this.cCityDataGridViewTextBoxColumn1.DataPropertyName = "cCity";
            this.cCityDataGridViewTextBoxColumn1.HeaderText = "עיר";
            this.cCityDataGridViewTextBoxColumn1.Name = "cCityDataGridViewTextBoxColumn1";
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            this.phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "phoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn1.HeaderText = "מספר טלפון";
            this.phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            // 
            // searchCusButt
            // 
            this.searchCusButt.Location = new System.Drawing.Point(1439, 21);
            this.searchCusButt.Name = "searchCusButt";
            this.searchCusButt.Size = new System.Drawing.Size(75, 23);
            this.searchCusButt.TabIndex = 17;
            this.searchCusButt.Text = "חפש";
            this.searchCusButt.UseVisualStyleBackColor = true;
            this.searchCusButt.Click += new System.EventHandler(this.searchCusButt_Click);
            // 
            // cusSearchTextBox
            // 
            this.cusSearchTextBox.Location = new System.Drawing.Point(1520, 22);
            this.cusSearchTextBox.Name = "cusSearchTextBox";
            this.cusSearchTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusSearchTextBox.Size = new System.Drawing.Size(151, 23);
            this.cusSearchTextBox.TabIndex = 16;
            // 
            // cusSearchLabel
            // 
            this.cusSearchLabel.AutoSize = true;
            this.cusSearchLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusSearchLabel.Location = new System.Drawing.Point(1677, 25);
            this.cusSearchLabel.Name = "cusSearchLabel";
            this.cusSearchLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusSearchLabel.Size = new System.Drawing.Size(66, 19);
            this.cusSearchLabel.TabIndex = 15;
            this.cusSearchLabel.Text = "שם לקוח:";
            // 
            // searchProjByCusTab
            // 
            this.searchProjByCusTab.BackColor = System.Drawing.Color.SkyBlue;
            this.searchProjByCusTab.Controls.Add(this.searchProjByCusDataGridView);
            this.searchProjByCusTab.Controls.Add(this.cusProjSearchButt);
            this.searchProjByCusTab.Controls.Add(this.cusProjSearchComboBox);
            this.searchProjByCusTab.Controls.Add(this.cusProjSearchLabel);
            this.searchProjByCusTab.Location = new System.Drawing.Point(4, 24);
            this.searchProjByCusTab.Name = "searchProjByCusTab";
            this.searchProjByCusTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchProjByCusTab.Size = new System.Drawing.Size(1759, 983);
            this.searchProjByCusTab.TabIndex = 11;
            this.searchProjByCusTab.Text = "חיפוש פרויקטים של לקוח";
            this.searchProjByCusTab.MouseEnter += new System.EventHandler(this.searchProjByCusTab_MouseEnter);
            // 
            // searchProjByCusDataGridView
            // 
            this.searchProjByCusDataGridView.AllowUserToAddRows = false;
            this.searchProjByCusDataGridView.AutoGenerateColumns = false;
            this.searchProjByCusDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.searchProjByCusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchProjByCusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projIDDataGridViewTextBoxColumn2,
            this.projStateDataGridViewTextBoxColumn1,
            this.projNameDataGridViewTextBoxColumn2,
            this.startDateDataGridViewTextBoxColumn4,
            this.etaDateDataGridViewTextBoxColumn2,
            this.contactNameDataGridViewTextBoxColumn2,
            this.contactTelDataGridViewTextBoxColumn2,
            this.archNameDataGridViewTextBoxColumn2,
            this.archTelDataGridViewTextBoxColumn2,
            this.inspNameDataGridViewTextBoxColumn2,
            this.inspTelDataGridViewTextBoxColumn2,
            this.insurPolicyDataGridViewTextBoxColumn2,
            this.archPlanPathDataGridViewTextBoxColumn1,
            this.agreementPathDataGridViewTextBoxColumn1});
            this.searchProjByCusDataGridView.DataSource = this.projectBindingSource1;
            this.searchProjByCusDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchProjByCusDataGridView.Location = new System.Drawing.Point(3, 72);
            this.searchProjByCusDataGridView.Name = "searchProjByCusDataGridView";
            this.searchProjByCusDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchProjByCusDataGridView.Size = new System.Drawing.Size(1753, 908);
            this.searchProjByCusDataGridView.TabIndex = 7;
            this.searchProjByCusDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchProjByCusDataGridView_CellContentClick);
            this.searchProjByCusDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.searchProjByCusDataGridView_EditingControlShowing);
            this.searchProjByCusDataGridView.MouseEnter += new System.EventHandler(this.searchProjByCusDataGridView_MouseEnter);
            // 
            // projIDDataGridViewTextBoxColumn2
            // 
            this.projIDDataGridViewTextBoxColumn2.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn2.HeaderText = "מספר פרויקט";
            this.projIDDataGridViewTextBoxColumn2.Name = "projIDDataGridViewTextBoxColumn2";
            this.projIDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // projStateDataGridViewTextBoxColumn1
            // 
            this.projStateDataGridViewTextBoxColumn1.DataPropertyName = "projState";
            this.projStateDataGridViewTextBoxColumn1.HeaderText = "מצב פרויקט";
            this.projStateDataGridViewTextBoxColumn1.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל",
            "בעיכוב"});
            this.projStateDataGridViewTextBoxColumn1.Name = "projStateDataGridViewTextBoxColumn1";
            this.projStateDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.projStateDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // projNameDataGridViewTextBoxColumn2
            // 
            this.projNameDataGridViewTextBoxColumn2.DataPropertyName = "projName";
            this.projNameDataGridViewTextBoxColumn2.HeaderText = "שם פרויקט";
            this.projNameDataGridViewTextBoxColumn2.Name = "projNameDataGridViewTextBoxColumn2";
            // 
            // startDateDataGridViewTextBoxColumn4
            // 
            this.startDateDataGridViewTextBoxColumn4.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn4.HeaderText = "תאריך התחלה";
            this.startDateDataGridViewTextBoxColumn4.Name = "startDateDataGridViewTextBoxColumn4";
            // 
            // etaDateDataGridViewTextBoxColumn2
            // 
            this.etaDateDataGridViewTextBoxColumn2.DataPropertyName = "etaDate";
            this.etaDateDataGridViewTextBoxColumn2.HeaderText = "תאריך סיום משוער";
            this.etaDateDataGridViewTextBoxColumn2.Name = "etaDateDataGridViewTextBoxColumn2";
            // 
            // contactNameDataGridViewTextBoxColumn2
            // 
            this.contactNameDataGridViewTextBoxColumn2.DataPropertyName = "contactName";
            this.contactNameDataGridViewTextBoxColumn2.HeaderText = "שם איש קשר";
            this.contactNameDataGridViewTextBoxColumn2.Name = "contactNameDataGridViewTextBoxColumn2";
            // 
            // contactTelDataGridViewTextBoxColumn2
            // 
            this.contactTelDataGridViewTextBoxColumn2.DataPropertyName = "contactTel";
            this.contactTelDataGridViewTextBoxColumn2.HeaderText = "טלפון איש קשר";
            this.contactTelDataGridViewTextBoxColumn2.Name = "contactTelDataGridViewTextBoxColumn2";
            // 
            // archNameDataGridViewTextBoxColumn2
            // 
            this.archNameDataGridViewTextBoxColumn2.DataPropertyName = "archName";
            this.archNameDataGridViewTextBoxColumn2.HeaderText = "שם מהנדס";
            this.archNameDataGridViewTextBoxColumn2.Name = "archNameDataGridViewTextBoxColumn2";
            // 
            // archTelDataGridViewTextBoxColumn2
            // 
            this.archTelDataGridViewTextBoxColumn2.DataPropertyName = "archTel";
            this.archTelDataGridViewTextBoxColumn2.HeaderText = "טלפון מהנדס";
            this.archTelDataGridViewTextBoxColumn2.Name = "archTelDataGridViewTextBoxColumn2";
            // 
            // inspNameDataGridViewTextBoxColumn2
            // 
            this.inspNameDataGridViewTextBoxColumn2.DataPropertyName = "inspName";
            this.inspNameDataGridViewTextBoxColumn2.HeaderText = "שם מפקח";
            this.inspNameDataGridViewTextBoxColumn2.Name = "inspNameDataGridViewTextBoxColumn2";
            // 
            // inspTelDataGridViewTextBoxColumn2
            // 
            this.inspTelDataGridViewTextBoxColumn2.DataPropertyName = "inspTel";
            this.inspTelDataGridViewTextBoxColumn2.HeaderText = "טלפון מפקח";
            this.inspTelDataGridViewTextBoxColumn2.Name = "inspTelDataGridViewTextBoxColumn2";
            // 
            // insurPolicyDataGridViewTextBoxColumn2
            // 
            this.insurPolicyDataGridViewTextBoxColumn2.DataPropertyName = "insurPolicy";
            this.insurPolicyDataGridViewTextBoxColumn2.HeaderText = "פוליסת ביטוח";
            this.insurPolicyDataGridViewTextBoxColumn2.Name = "insurPolicyDataGridViewTextBoxColumn2";
            // 
            // archPlanPathDataGridViewTextBoxColumn1
            // 
            this.archPlanPathDataGridViewTextBoxColumn1.DataPropertyName = "archPlanPath";
            this.archPlanPathDataGridViewTextBoxColumn1.HeaderText = "תוכנית הנדסית";
            this.archPlanPathDataGridViewTextBoxColumn1.Name = "archPlanPathDataGridViewTextBoxColumn1";
            this.archPlanPathDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.archPlanPathDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // agreementPathDataGridViewTextBoxColumn1
            // 
            this.agreementPathDataGridViewTextBoxColumn1.DataPropertyName = "agreementPath";
            this.agreementPathDataGridViewTextBoxColumn1.HeaderText = "הסכם";
            this.agreementPathDataGridViewTextBoxColumn1.Name = "agreementPathDataGridViewTextBoxColumn1";
            this.agreementPathDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agreementPathDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cusProjSearchButt
            // 
            this.cusProjSearchButt.Location = new System.Drawing.Point(1456, 28);
            this.cusProjSearchButt.Name = "cusProjSearchButt";
            this.cusProjSearchButt.Size = new System.Drawing.Size(75, 23);
            this.cusProjSearchButt.TabIndex = 6;
            this.cusProjSearchButt.Text = "חפש";
            this.cusProjSearchButt.UseVisualStyleBackColor = true;
            this.cusProjSearchButt.Click += new System.EventHandler(this.cusProjSearchButt_Click);
            // 
            // cusProjSearchComboBox
            // 
            this.cusProjSearchComboBox.DataSource = this.customerBindingSource;
            this.cusProjSearchComboBox.DisplayMember = "cName";
            this.cusProjSearchComboBox.FormattingEnabled = true;
            this.cusProjSearchComboBox.Location = new System.Drawing.Point(1549, 28);
            this.cusProjSearchComboBox.Name = "cusProjSearchComboBox";
            this.cusProjSearchComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusProjSearchComboBox.Size = new System.Drawing.Size(121, 23);
            this.cusProjSearchComboBox.TabIndex = 5;
            this.cusProjSearchComboBox.ValueMember = "cID";
            // 
            // cusProjSearchLabel
            // 
            this.cusProjSearchLabel.AutoSize = true;
            this.cusProjSearchLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusProjSearchLabel.Location = new System.Drawing.Point(1676, 28);
            this.cusProjSearchLabel.Name = "cusProjSearchLabel";
            this.cusProjSearchLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusProjSearchLabel.Size = new System.Drawing.Size(56, 19);
            this.cusProjSearchLabel.TabIndex = 4;
            this.cusProjSearchLabel.Text = "לקוחות:";
            // 
            // showBalanceTab
            // 
            this.showBalanceTab.BackColor = System.Drawing.Color.SkyBlue;
            this.showBalanceTab.Controls.Add(this.showYearBalanceButt);
            this.showBalanceTab.Controls.Add(this.totalBalanceLable);
            this.showBalanceTab.Controls.Add(this.totalIncomeLable);
            this.showBalanceTab.Controls.Add(this.totalExpanceLable);
            this.showBalanceTab.Controls.Add(this.yearBalanceLabel);
            this.showBalanceTab.Controls.Add(this.yearBalancePicker);
            this.showBalanceTab.Controls.Add(this.expensesDataGridView);
            this.showBalanceTab.Controls.Add(this.incomesDataGridView);
            this.showBalanceTab.Location = new System.Drawing.Point(4, 24);
            this.showBalanceTab.Name = "showBalanceTab";
            this.showBalanceTab.Padding = new System.Windows.Forms.Padding(3);
            this.showBalanceTab.Size = new System.Drawing.Size(1759, 983);
            this.showBalanceTab.TabIndex = 12;
            this.showBalanceTab.Text = "הוצאות והכנסות";
            this.showBalanceTab.MouseEnter += new System.EventHandler(this.showBalanceTab_MouseEnter);
            // 
            // showYearBalanceButt
            // 
            this.showYearBalanceButt.Location = new System.Drawing.Point(1520, 22);
            this.showYearBalanceButt.Name = "showYearBalanceButt";
            this.showYearBalanceButt.Size = new System.Drawing.Size(75, 23);
            this.showYearBalanceButt.TabIndex = 9;
            this.showYearBalanceButt.Text = "הצג";
            this.showYearBalanceButt.UseVisualStyleBackColor = true;
            this.showYearBalanceButt.Click += new System.EventHandler(this.showYearBalanceButt_Click);
            // 
            // totalBalanceLable
            // 
            this.totalBalanceLable.AutoSize = true;
            this.totalBalanceLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBalanceLable.Location = new System.Drawing.Point(453, 25);
            this.totalBalanceLable.Name = "totalBalanceLable";
            this.totalBalanceLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalBalanceLable.Size = new System.Drawing.Size(110, 19);
            this.totalBalanceLable.TabIndex = 8;
            this.totalBalanceLable.Text = "סה\"כ מאזן כולל: ";
            // 
            // totalIncomeLable
            // 
            this.totalIncomeLable.AutoSize = true;
            this.totalIncomeLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeLable.Location = new System.Drawing.Point(770, 25);
            this.totalIncomeLable.Name = "totalIncomeLable";
            this.totalIncomeLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalIncomeLable.Size = new System.Drawing.Size(129, 19);
            this.totalIncomeLable.TabIndex = 7;
            this.totalIncomeLable.Text = "סה\"כ הכנסות כולל: ";
            // 
            // totalExpanceLable
            // 
            this.totalExpanceLable.AutoSize = true;
            this.totalExpanceLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpanceLable.Location = new System.Drawing.Point(1069, 25);
            this.totalExpanceLable.Name = "totalExpanceLable";
            this.totalExpanceLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalExpanceLable.Size = new System.Drawing.Size(127, 19);
            this.totalExpanceLable.TabIndex = 6;
            this.totalExpanceLable.Text = "סה\"כ הוצאות כולל: ";
            // 
            // yearBalanceLabel
            // 
            this.yearBalanceLabel.AutoSize = true;
            this.yearBalanceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearBalanceLabel.Location = new System.Drawing.Point(1698, 25);
            this.yearBalanceLabel.Name = "yearBalanceLabel";
            this.yearBalanceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yearBalanceLabel.Size = new System.Drawing.Size(39, 19);
            this.yearBalanceLabel.TabIndex = 5;
            this.yearBalanceLabel.Text = "שנה:";
            // 
            // yearBalancePicker
            // 
            this.yearBalancePicker.CustomFormat = "yyyy";
            this.yearBalancePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearBalancePicker.Location = new System.Drawing.Point(1612, 22);
            this.yearBalancePicker.Name = "yearBalancePicker";
            this.yearBalancePicker.RightToLeftLayout = true;
            this.yearBalancePicker.ShowUpDown = true;
            this.yearBalancePicker.Size = new System.Drawing.Size(80, 23);
            this.yearBalancePicker.TabIndex = 2;
            // 
            // expensesDataGridView
            // 
            this.expensesDataGridView.AllowUserToAddRows = false;
            this.expensesDataGridView.AllowUserToDeleteRows = false;
            this.expensesDataGridView.AutoGenerateColumns = false;
            this.expensesDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentID,
            this.paymentDateDataGridViewTextBoxColumn2,
            this.pMethodDataGridViewTextBoxColumn2,
            this.amoutDataGridViewTextBoxColumn2,
            this.exTypeDataGridViewTextBoxColumn,
            this.eIDDataGridViewTextBoxColumn2,
            this.otherDataGridViewTextBoxColumn});
            this.expensesDataGridView.DataSource = this.expensesBindingSource;
            this.expensesDataGridView.Location = new System.Drawing.Point(841, 66);
            this.expensesDataGridView.Name = "expensesDataGridView";
            this.expensesDataGridView.Size = new System.Drawing.Size(915, 909);
            this.expensesDataGridView.TabIndex = 1;
            this.expensesDataGridView.MouseEnter += new System.EventHandler(this.expensesDataGridView_MouseEnter);
            // 
            // paymentID
            // 
            this.paymentID.DataPropertyName = "paymentID";
            this.paymentID.HeaderText = "מספר תשלום";
            this.paymentID.Name = "paymentID";
            this.paymentID.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn2
            // 
            this.paymentDateDataGridViewTextBoxColumn2.DataPropertyName = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn2.HeaderText = "תאריך הוצאה";
            this.paymentDateDataGridViewTextBoxColumn2.Name = "paymentDateDataGridViewTextBoxColumn2";
            // 
            // pMethodDataGridViewTextBoxColumn2
            // 
            this.pMethodDataGridViewTextBoxColumn2.DataPropertyName = "pMethod";
            this.pMethodDataGridViewTextBoxColumn2.HeaderText = "דרך תשלום";
            this.pMethodDataGridViewTextBoxColumn2.Name = "pMethodDataGridViewTextBoxColumn2";
            // 
            // amoutDataGridViewTextBoxColumn2
            // 
            this.amoutDataGridViewTextBoxColumn2.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn2.HeaderText = "סכום";
            this.amoutDataGridViewTextBoxColumn2.Name = "amoutDataGridViewTextBoxColumn2";
            // 
            // exTypeDataGridViewTextBoxColumn
            // 
            this.exTypeDataGridViewTextBoxColumn.DataPropertyName = "exType";
            this.exTypeDataGridViewTextBoxColumn.HeaderText = "סוג הוצאה";
            this.exTypeDataGridViewTextBoxColumn.Name = "exTypeDataGridViewTextBoxColumn";
            // 
            // eIDDataGridViewTextBoxColumn2
            // 
            this.eIDDataGridViewTextBoxColumn2.DataPropertyName = "eID";
            this.eIDDataGridViewTextBoxColumn2.HeaderText = "מספר עובד";
            this.eIDDataGridViewTextBoxColumn2.Name = "eIDDataGridViewTextBoxColumn2";
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "הערה";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "expenses";
            this.expensesBindingSource.DataSource = this.tesodotDataSet;
            // 
            // incomesDataGridView
            // 
            this.incomesDataGridView.AllowUserToAddRows = false;
            this.incomesDataGridView.AllowUserToDeleteRows = false;
            this.incomesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incomesDataGridView.AutoGenerateColumns = false;
            this.incomesDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.incomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.paymentDateDataGridViewTextBoxColumn1,
            this.pMethodDataGridViewTextBoxColumn1,
            this.amoutDataGridViewTextBoxColumn1,
            this.projIDDataGridViewTextBoxColumn3});
            this.incomesDataGridView.DataSource = this.incomesBindingSource;
            this.incomesDataGridView.Location = new System.Drawing.Point(3, 66);
            this.incomesDataGridView.Name = "incomesDataGridView";
            this.incomesDataGridView.Size = new System.Drawing.Size(832, 909);
            this.incomesDataGridView.TabIndex = 0;
            this.incomesDataGridView.MouseEnter += new System.EventHandler(this.incomesDataGridView_MouseEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "paymentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "מספר תשלום";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn1
            // 
            this.paymentDateDataGridViewTextBoxColumn1.DataPropertyName = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn1.HeaderText = "תאריך הכנסה";
            this.paymentDateDataGridViewTextBoxColumn1.Name = "paymentDateDataGridViewTextBoxColumn1";
            // 
            // pMethodDataGridViewTextBoxColumn1
            // 
            this.pMethodDataGridViewTextBoxColumn1.DataPropertyName = "pMethod";
            this.pMethodDataGridViewTextBoxColumn1.HeaderText = "דרך תשלום";
            this.pMethodDataGridViewTextBoxColumn1.Name = "pMethodDataGridViewTextBoxColumn1";
            // 
            // amoutDataGridViewTextBoxColumn1
            // 
            this.amoutDataGridViewTextBoxColumn1.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn1.HeaderText = "סכום";
            this.amoutDataGridViewTextBoxColumn1.Name = "amoutDataGridViewTextBoxColumn1";
            // 
            // projIDDataGridViewTextBoxColumn3
            // 
            this.projIDDataGridViewTextBoxColumn3.DataPropertyName = "projID";
            this.projIDDataGridViewTextBoxColumn3.HeaderText = "מספר פרויקט";
            this.projIDDataGridViewTextBoxColumn3.Name = "projIDDataGridViewTextBoxColumn3";
            this.projIDDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "incomes";
            this.incomesBindingSource.DataSource = this.tesodotDataSet;
            // 
            // addIncomeTab
            // 
            this.addIncomeTab.BackColor = System.Drawing.Color.SkyBlue;
            this.addIncomeTab.Controls.Add(this.iProjNameComboBox);
            this.addIncomeTab.Controls.Add(this.incomeSumbitButt);
            this.addIncomeTab.Controls.Add(this.iAmountTextBox);
            this.addIncomeTab.Controls.Add(this.iPayMethodComboBox);
            this.addIncomeTab.Controls.Add(this.iPayDateTimePicker);
            this.addIncomeTab.Controls.Add(this.iProjNameLable);
            this.addIncomeTab.Controls.Add(this.iAmountLable);
            this.addIncomeTab.Controls.Add(this.iPayMethodLable);
            this.addIncomeTab.Controls.Add(this.inPayDateLable);
            this.addIncomeTab.Location = new System.Drawing.Point(4, 24);
            this.addIncomeTab.Name = "addIncomeTab";
            this.addIncomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.addIncomeTab.Size = new System.Drawing.Size(1759, 983);
            this.addIncomeTab.TabIndex = 13;
            this.addIncomeTab.Text = "הוסף הכנסה";
            this.addIncomeTab.MouseEnter += new System.EventHandler(this.addIncomeTab_MouseEnter);
            // 
            // iProjNameComboBox
            // 
            this.iProjNameComboBox.DataSource = this.projectBindingSource1;
            this.iProjNameComboBox.DisplayMember = "projName";
            this.iProjNameComboBox.FormattingEnabled = true;
            this.iProjNameComboBox.Location = new System.Drawing.Point(1528, 157);
            this.iProjNameComboBox.Name = "iProjNameComboBox";
            this.iProjNameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iProjNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.iProjNameComboBox.TabIndex = 21;
            this.iProjNameComboBox.ValueMember = "projID";
            // 
            // incomeSumbitButt
            // 
            this.incomeSumbitButt.Location = new System.Drawing.Point(1547, 227);
            this.incomeSumbitButt.Name = "incomeSumbitButt";
            this.incomeSumbitButt.Size = new System.Drawing.Size(75, 23);
            this.incomeSumbitButt.TabIndex = 20;
            this.incomeSumbitButt.Text = "הוסף הכנסה";
            this.incomeSumbitButt.UseVisualStyleBackColor = true;
            this.incomeSumbitButt.Click += new System.EventHandler(this.incomeSumbitButt_Click);
            // 
            // iAmountTextBox
            // 
            this.iAmountTextBox.Location = new System.Drawing.Point(1585, 114);
            this.iAmountTextBox.Name = "iAmountTextBox";
            this.iAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.iAmountTextBox.TabIndex = 18;
            // 
            // iPayMethodComboBox
            // 
            this.iPayMethodComboBox.FormattingEnabled = true;
            this.iPayMethodComboBox.Items.AddRange(new object[] {
            "צק",
            "העברה בנקאית",
            "מזומן"});
            this.iPayMethodComboBox.Location = new System.Drawing.Point(1530, 68);
            this.iPayMethodComboBox.Name = "iPayMethodComboBox";
            this.iPayMethodComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iPayMethodComboBox.Size = new System.Drawing.Size(121, 23);
            this.iPayMethodComboBox.TabIndex = 17;
            // 
            // iPayDateTimePicker
            // 
            this.iPayDateTimePicker.CustomFormat = "MM.dd.yyy";
            this.iPayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.iPayDateTimePicker.Location = new System.Drawing.Point(1532, 25);
            this.iPayDateTimePicker.Name = "iPayDateTimePicker";
            this.iPayDateTimePicker.Size = new System.Drawing.Size(101, 23);
            this.iPayDateTimePicker.TabIndex = 16;
            // 
            // iProjNameLable
            // 
            this.iProjNameLable.AutoSize = true;
            this.iProjNameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iProjNameLable.Location = new System.Drawing.Point(1655, 157);
            this.iProjNameLable.Name = "iProjNameLable";
            this.iProjNameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iProjNameLable.Size = new System.Drawing.Size(87, 19);
            this.iProjNameLable.TabIndex = 6;
            this.iProjNameLable.Text = "*שם פרויקט:";
            // 
            // iAmountLable
            // 
            this.iAmountLable.AutoSize = true;
            this.iAmountLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iAmountLable.Location = new System.Drawing.Point(1691, 114);
            this.iAmountLable.Name = "iAmountLable";
            this.iAmountLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iAmountLable.Size = new System.Drawing.Size(51, 19);
            this.iAmountLable.TabIndex = 5;
            this.iAmountLable.Text = "*סכום:";
            // 
            // iPayMethodLable
            // 
            this.iPayMethodLable.AutoSize = true;
            this.iPayMethodLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iPayMethodLable.Location = new System.Drawing.Point(1657, 68);
            this.iPayMethodLable.Name = "iPayMethodLable";
            this.iPayMethodLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iPayMethodLable.Size = new System.Drawing.Size(85, 19);
            this.iPayMethodLable.TabIndex = 4;
            this.iPayMethodLable.Text = "*דרך תשלום:";
            // 
            // inPayDateLable
            // 
            this.inPayDateLable.AutoSize = true;
            this.inPayDateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inPayDateLable.Location = new System.Drawing.Point(1639, 25);
            this.inPayDateLable.Name = "inPayDateLable";
            this.inPayDateLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.inPayDateLable.Size = new System.Drawing.Size(103, 19);
            this.inPayDateLable.TabIndex = 3;
            this.inPayDateLable.Text = "*תאריך תשלום:";
            // 
            // addExpenseTab
            // 
            this.addExpenseTab.BackColor = System.Drawing.Color.SkyBlue;
            this.addExpenseTab.Controls.Add(this.eDiscriptionTextBox);
            this.addExpenseTab.Controls.Add(this.eDiscriptionLable);
            this.addExpenseTab.Controls.Add(this.eENameComboBox);
            this.addExpenseTab.Controls.Add(this.eReasonComboBox);
            this.addExpenseTab.Controls.Add(this.eReasonLable);
            this.addExpenseTab.Controls.Add(this.expenseSumbitButt);
            this.addExpenseTab.Controls.Add(this.eAmountTextBox);
            this.addExpenseTab.Controls.Add(this.eMethodComboBox);
            this.addExpenseTab.Controls.Add(this.ePayDatePicker);
            this.addExpenseTab.Controls.Add(this.eENameLable);
            this.addExpenseTab.Controls.Add(this.eAmountLable);
            this.addExpenseTab.Controls.Add(this.eMethodLable);
            this.addExpenseTab.Controls.Add(this.ePayDateLable);
            this.addExpenseTab.Location = new System.Drawing.Point(4, 24);
            this.addExpenseTab.Name = "addExpenseTab";
            this.addExpenseTab.Padding = new System.Windows.Forms.Padding(3);
            this.addExpenseTab.Size = new System.Drawing.Size(1759, 983);
            this.addExpenseTab.TabIndex = 14;
            this.addExpenseTab.Text = "הוסף הוצאה";
            this.addExpenseTab.MouseEnter += new System.EventHandler(this.addExpenseTab_MouseEnter);
            // 
            // eDiscriptionTextBox
            // 
            this.eDiscriptionTextBox.Location = new System.Drawing.Point(1577, 200);
            this.eDiscriptionTextBox.Name = "eDiscriptionTextBox";
            this.eDiscriptionTextBox.Size = new System.Drawing.Size(100, 23);
            this.eDiscriptionTextBox.TabIndex = 34;
            // 
            // eDiscriptionLable
            // 
            this.eDiscriptionLable.AutoSize = true;
            this.eDiscriptionLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDiscriptionLable.Location = new System.Drawing.Point(1683, 200);
            this.eDiscriptionLable.Name = "eDiscriptionLable";
            this.eDiscriptionLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eDiscriptionLable.Size = new System.Drawing.Size(47, 19);
            this.eDiscriptionLable.TabIndex = 33;
            this.eDiscriptionLable.Text = "תיאור:";
            // 
            // eENameComboBox
            // 
            this.eENameComboBox.DataSource = this.employeeBindingSource;
            this.eENameComboBox.DisplayMember = "eName";
            this.eENameComboBox.FormattingEnabled = true;
            this.eENameComboBox.Location = new System.Drawing.Point(1539, 160);
            this.eENameComboBox.Name = "eENameComboBox";
            this.eENameComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eENameComboBox.Size = new System.Drawing.Size(121, 23);
            this.eENameComboBox.TabIndex = 32;
            this.eENameComboBox.ValueMember = "eID";
            this.eENameComboBox.TextChanged += new System.EventHandler(this.eENameComboBox_TextChanged);
            // 
            // eReasonComboBox
            // 
            this.eReasonComboBox.FormattingEnabled = true;
            this.eReasonComboBox.Items.AddRange(new object[] {
            "משכורת",
            "אחר"});
            this.eReasonComboBox.Location = new System.Drawing.Point(1516, 117);
            this.eReasonComboBox.Name = "eReasonComboBox";
            this.eReasonComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eReasonComboBox.Size = new System.Drawing.Size(121, 23);
            this.eReasonComboBox.TabIndex = 31;
            this.eReasonComboBox.SelectedIndexChanged += new System.EventHandler(this.eReasonComboBox_SelectedIndexChanged);
            // 
            // eReasonLable
            // 
            this.eReasonLable.AutoSize = true;
            this.eReasonLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eReasonLable.Location = new System.Drawing.Point(1643, 117);
            this.eReasonLable.Name = "eReasonLable";
            this.eReasonLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eReasonLable.Size = new System.Drawing.Size(95, 19);
            this.eReasonLable.TabIndex = 30;
            this.eReasonLable.Text = "*סיבת הוצאה:";
            // 
            // expenseSumbitButt
            // 
            this.expenseSumbitButt.Location = new System.Drawing.Point(1539, 292);
            this.expenseSumbitButt.Name = "expenseSumbitButt";
            this.expenseSumbitButt.Size = new System.Drawing.Size(75, 23);
            this.expenseSumbitButt.TabIndex = 29;
            this.expenseSumbitButt.Text = "הוסף הוצאה";
            this.expenseSumbitButt.UseVisualStyleBackColor = true;
            this.expenseSumbitButt.Click += new System.EventHandler(this.expenseSumbitButt_Click);
            // 
            // eAmountTextBox
            // 
            this.eAmountTextBox.Location = new System.Drawing.Point(1581, 246);
            this.eAmountTextBox.Name = "eAmountTextBox";
            this.eAmountTextBox.Size = new System.Drawing.Size(100, 23);
            this.eAmountTextBox.TabIndex = 27;
            // 
            // eMethodComboBox
            // 
            this.eMethodComboBox.FormattingEnabled = true;
            this.eMethodComboBox.Items.AddRange(new object[] {
            "צק",
            "העברה בנקאית",
            "מזומן"});
            this.eMethodComboBox.Location = new System.Drawing.Point(1526, 68);
            this.eMethodComboBox.Name = "eMethodComboBox";
            this.eMethodComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eMethodComboBox.Size = new System.Drawing.Size(121, 23);
            this.eMethodComboBox.TabIndex = 26;
            // 
            // ePayDatePicker
            // 
            this.ePayDatePicker.CustomFormat = "MM.dd.yyy";
            this.ePayDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ePayDatePicker.Location = new System.Drawing.Point(1528, 25);
            this.ePayDatePicker.Name = "ePayDatePicker";
            this.ePayDatePicker.Size = new System.Drawing.Size(101, 23);
            this.ePayDatePicker.TabIndex = 25;
            // 
            // eENameLable
            // 
            this.eENameLable.AutoSize = true;
            this.eENameLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eENameLable.Location = new System.Drawing.Point(1666, 160);
            this.eENameLable.Name = "eENameLable";
            this.eENameLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eENameLable.Size = new System.Drawing.Size(64, 19);
            this.eENameLable.TabIndex = 24;
            this.eENameLable.Text = "שם עובד:";
            // 
            // eAmountLable
            // 
            this.eAmountLable.AutoSize = true;
            this.eAmountLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eAmountLable.Location = new System.Drawing.Point(1687, 246);
            this.eAmountLable.Name = "eAmountLable";
            this.eAmountLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eAmountLable.Size = new System.Drawing.Size(51, 19);
            this.eAmountLable.TabIndex = 23;
            this.eAmountLable.Text = "*סכום:";
            // 
            // eMethodLable
            // 
            this.eMethodLable.AutoSize = true;
            this.eMethodLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMethodLable.Location = new System.Drawing.Point(1653, 68);
            this.eMethodLable.Name = "eMethodLable";
            this.eMethodLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eMethodLable.Size = new System.Drawing.Size(85, 19);
            this.eMethodLable.TabIndex = 22;
            this.eMethodLable.Text = "*דרך תשלום:";
            // 
            // ePayDateLable
            // 
            this.ePayDateLable.AutoSize = true;
            this.ePayDateLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePayDateLable.Location = new System.Drawing.Point(1635, 25);
            this.ePayDateLable.Name = "ePayDateLable";
            this.ePayDateLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ePayDateLable.Size = new System.Drawing.Size(103, 19);
            this.ePayDateLable.TabIndex = 21;
            this.ePayDateLable.Text = "*תאריך תשלום:";
            // 
            // searchByProjPaymentTab
            // 
            this.searchByProjPaymentTab.BackColor = System.Drawing.Color.SkyBlue;
            this.searchByProjPaymentTab.Controls.Add(this.projIncomesDataGridView);
            this.searchByProjPaymentTab.Controls.Add(this.searchButtByProjPayment);
            this.searchByProjPaymentTab.Controls.Add(this.searchByProjPaymentComboBox);
            this.searchByProjPaymentTab.Controls.Add(this.searchByProjPaymentLabel);
            this.searchByProjPaymentTab.Location = new System.Drawing.Point(4, 24);
            this.searchByProjPaymentTab.Name = "searchByProjPaymentTab";
            this.searchByProjPaymentTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchByProjPaymentTab.Size = new System.Drawing.Size(1759, 983);
            this.searchByProjPaymentTab.TabIndex = 15;
            this.searchByProjPaymentTab.Text = "חיפוש תשלומים בפרויקט";
            this.searchByProjPaymentTab.MouseEnter += new System.EventHandler(this.searchByProjPaymentTab_MouseEnter);
            // 
            // projIncomesDataGridView
            // 
            this.projIncomesDataGridView.AllowUserToAddRows = false;
            this.projIncomesDataGridView.AutoGenerateColumns = false;
            this.projIncomesDataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.projIncomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projIncomesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.paymentDateDataGridViewTextBoxColumn,
            this.pMethodDataGridViewTextBoxColumn,
            this.amoutDataGridViewTextBoxColumn});
            this.projIncomesDataGridView.DataSource = this.incomesBindingSource;
            this.projIncomesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projIncomesDataGridView.Location = new System.Drawing.Point(3, 51);
            this.projIncomesDataGridView.Name = "projIncomesDataGridView";
            this.projIncomesDataGridView.Size = new System.Drawing.Size(1753, 929);
            this.projIncomesDataGridView.TabIndex = 9;
            this.projIncomesDataGridView.MouseEnter += new System.EventHandler(this.projIncomesDataGridView_MouseEnter);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "paymentID";
            this.dataGridViewTextBoxColumn2.HeaderText = "מספר תשלום";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "paymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "תאריך תשלום";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            // 
            // pMethodDataGridViewTextBoxColumn
            // 
            this.pMethodDataGridViewTextBoxColumn.DataPropertyName = "pMethod";
            this.pMethodDataGridViewTextBoxColumn.HeaderText = "צורת תשלום";
            this.pMethodDataGridViewTextBoxColumn.Name = "pMethodDataGridViewTextBoxColumn";
            // 
            // amoutDataGridViewTextBoxColumn
            // 
            this.amoutDataGridViewTextBoxColumn.DataPropertyName = "amout";
            this.amoutDataGridViewTextBoxColumn.HeaderText = "סכום";
            this.amoutDataGridViewTextBoxColumn.Name = "amoutDataGridViewTextBoxColumn";
            // 
            // searchButtByProjPayment
            // 
            this.searchButtByProjPayment.Location = new System.Drawing.Point(1440, 22);
            this.searchButtByProjPayment.Name = "searchButtByProjPayment";
            this.searchButtByProjPayment.Size = new System.Drawing.Size(75, 23);
            this.searchButtByProjPayment.TabIndex = 8;
            this.searchButtByProjPayment.Text = "חפש";
            this.searchButtByProjPayment.UseVisualStyleBackColor = true;
            this.searchButtByProjPayment.Click += new System.EventHandler(this.searchButtByProjPayment_Click);
            // 
            // searchByProjPaymentComboBox
            // 
            this.searchByProjPaymentComboBox.DataSource = this.projectBindingSource;
            this.searchByProjPaymentComboBox.DisplayMember = "projName";
            this.searchByProjPaymentComboBox.FormattingEnabled = true;
            this.searchByProjPaymentComboBox.Location = new System.Drawing.Point(1537, 22);
            this.searchByProjPaymentComboBox.Name = "searchByProjPaymentComboBox";
            this.searchByProjPaymentComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchByProjPaymentComboBox.Size = new System.Drawing.Size(121, 23);
            this.searchByProjPaymentComboBox.TabIndex = 7;
            this.searchByProjPaymentComboBox.ValueMember = "projID";
            // 
            // searchByProjPaymentLabel
            // 
            this.searchByProjPaymentLabel.AutoSize = true;
            this.searchByProjPaymentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByProjPaymentLabel.Location = new System.Drawing.Point(1664, 22);
            this.searchByProjPaymentLabel.Name = "searchByProjPaymentLabel";
            this.searchByProjPaymentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchByProjPaymentLabel.Size = new System.Drawing.Size(79, 19);
            this.searchByProjPaymentLabel.TabIndex = 6;
            this.searchByProjPaymentLabel.Text = "שם פרויקט:";
            // 
            // addWorkerTypeAndCostTab
            // 
            this.addWorkerTypeAndCostTab.BackColor = System.Drawing.Color.SkyBlue;
            this.addWorkerTypeAndCostTab.Controls.Add(this.applyAddWorkerTypeButt);
            this.addWorkerTypeAndCostTab.Controls.Add(this.paymentPriceTextBox);
            this.addWorkerTypeAndCostTab.Controls.Add(this.paymentPriceLabel);
            this.addWorkerTypeAndCostTab.Controls.Add(this.workerTypeTextBox);
            this.addWorkerTypeAndCostTab.Controls.Add(this.workerTypeLabel);
            this.addWorkerTypeAndCostTab.Location = new System.Drawing.Point(4, 24);
            this.addWorkerTypeAndCostTab.Name = "addWorkerTypeAndCostTab";
            this.addWorkerTypeAndCostTab.Padding = new System.Windows.Forms.Padding(3);
            this.addWorkerTypeAndCostTab.Size = new System.Drawing.Size(1759, 983);
            this.addWorkerTypeAndCostTab.TabIndex = 17;
            this.addWorkerTypeAndCostTab.Text = "הוספת סוג עובד ותשלום";
            this.addWorkerTypeAndCostTab.MouseEnter += new System.EventHandler(this.addWorkerTypeAndCostTab_MouseEnter);
            // 
            // applyAddWorkerTypeButt
            // 
            this.applyAddWorkerTypeButt.Location = new System.Drawing.Point(1592, 112);
            this.applyAddWorkerTypeButt.Name = "applyAddWorkerTypeButt";
            this.applyAddWorkerTypeButt.Size = new System.Drawing.Size(75, 23);
            this.applyAddWorkerTypeButt.TabIndex = 9;
            this.applyAddWorkerTypeButt.Text = "הוסף";
            this.applyAddWorkerTypeButt.UseVisualStyleBackColor = true;
            this.applyAddWorkerTypeButt.Click += new System.EventHandler(this.applyAddWorkerTypeButt_Click);
            // 
            // paymentPriceTextBox
            // 
            this.paymentPriceTextBox.Location = new System.Drawing.Point(1580, 59);
            this.paymentPriceTextBox.Name = "paymentPriceTextBox";
            this.paymentPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.paymentPriceTextBox.TabIndex = 8;
            // 
            // paymentPriceLabel
            // 
            this.paymentPriceLabel.AutoSize = true;
            this.paymentPriceLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentPriceLabel.Location = new System.Drawing.Point(1696, 59);
            this.paymentPriceLabel.Name = "paymentPriceLabel";
            this.paymentPriceLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentPriceLabel.Size = new System.Drawing.Size(54, 19);
            this.paymentPriceLabel.TabIndex = 7;
            this.paymentPriceLabel.Text = "תשלום:";
            // 
            // workerTypeTextBox
            // 
            this.workerTypeTextBox.Location = new System.Drawing.Point(1580, 23);
            this.workerTypeTextBox.Name = "workerTypeTextBox";
            this.workerTypeTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.workerTypeTextBox.TabIndex = 6;
            // 
            // workerTypeLabel
            // 
            this.workerTypeLabel.AutoSize = true;
            this.workerTypeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerTypeLabel.Location = new System.Drawing.Point(1686, 23);
            this.workerTypeLabel.Name = "workerTypeLabel";
            this.workerTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.workerTypeLabel.Size = new System.Drawing.Size(64, 19);
            this.workerTypeLabel.TabIndex = 5;
            this.workerTypeLabel.Text = "סוג פועל:";
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // worker_typeTableAdapter
            // 
            this.worker_typeTableAdapter.ClearBeforeFill = true;
            // 
            // incomesTableAdapter
            // 
            this.incomesTableAdapter.ClearBeforeFill = true;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // closeTabButt
            // 
            this.closeTabButt.FlatAppearance.BorderSize = 0;
            this.closeTabButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeTabButt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeTabButt.Location = new System.Drawing.Point(61, 0);
            this.closeTabButt.Name = "closeTabButt";
            this.closeTabButt.Size = new System.Drawing.Size(92, 24);
            this.closeTabButt.TabIndex = 4;
            this.closeTabButt.Text = "סגור לשונית";
            this.closeTabButt.UseVisualStyleBackColor = true;
            this.closeTabButt.Click += new System.EventHandler(this.closeTabButt_Click);
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Project.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.closeTabButt);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.exit_butt);
            this.Controls.Add(this.menu_panel);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_menu";
            this.Text = "יסודות - חברה לבניה ושיפוץ";
            this.Load += new System.EventHandler(this.main_menu_Load);
            this.MouseEnter += new System.EventHandler(this.main_menu_MouseEnter);
            this.menu_panel.ResumeLayout(false);
            this.tabContainer.ResumeLayout(false);
            this.showOpenProjTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allProjGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tesodotDataSet)).EndInit();
            this.newProjTab.ResumeLayout(false);
            this.newProjTab.PerformLayout();
            this.searchByProjNameTab.ResumeLayout(false);
            this.searchByProjNameTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchByProjNameDataGridView)).EndInit();
            this.assignProjToCusTab.ResumeLayout(false);
            this.assignProjToCusTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource1)).EndInit();
            this.showWorkerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.createNewWorkerTab.ResumeLayout(false);
            this.createNewWorkerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workertypeBindingSource)).EndInit();
            this.searchWorkerByProjTab.ResumeLayout(false);
            this.searchWorkerByProjTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchWorkerByProjDataGridView)).EndInit();
            this.assignWorkerTab.ResumeLayout(false);
            this.assignWorkerTab.PerformLayout();
            this.showCusTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.newCusTab.ResumeLayout(false);
            this.newCusTab.PerformLayout();
            this.searchCusByNameTab.ResumeLayout(false);
            this.searchCusByNameTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCusByNameDataGridView)).EndInit();
            this.searchProjByCusTab.ResumeLayout(false);
            this.searchProjByCusTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProjByCusDataGridView)).EndInit();
            this.showBalanceTab.ResumeLayout(false);
            this.showBalanceTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            this.addIncomeTab.ResumeLayout(false);
            this.addIncomeTab.PerformLayout();
            this.addExpenseTab.ResumeLayout(false);
            this.addExpenseTab.PerformLayout();
            this.searchByProjPaymentTab.ResumeLayout(false);
            this.searchByProjPaymentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projIncomesDataGridView)).EndInit();
            this.addWorkerTypeAndCostTab.ResumeLayout(false);
            this.addWorkerTypeAndCostTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel menu_panel;
        private System.Windows.Forms.Button proj_butt;
        private System.Windows.Forms.Button worker_butt;
        private System.Windows.Forms.Button cust_butt;
        private System.Windows.Forms.Button pay_butt;
        private System.Windows.Forms.Button exit_butt;
        private System.Windows.Forms.TabControl tabContainer;


        #region PROJECT

        #region new proj tab - DONE
        private System.Windows.Forms.TabPage newProjTab;
        private System.Windows.Forms.Label insurPolicyLabel;
        private System.Windows.Forms.Label engineerPlanLable;
        private System.Windows.Forms.Label contractLable;
        private System.Windows.Forms.Label inspecTelLable;
        private System.Windows.Forms.Label inspecNameLable;
        private System.Windows.Forms.Label inspecInfoLable;
        private System.Windows.Forms.Label archTelLable;
        private System.Windows.Forms.Label archNameLable;
        private System.Windows.Forms.Label archInfoLable;
        private System.Windows.Forms.Label telContactLable;
        private System.Windows.Forms.Label contactNameLable;
        private System.Windows.Forms.Label contactInfoLable;
        private System.Windows.Forms.Label etaDateLable;
        private System.Windows.Forms.Label startDateLable;
        private System.Windows.Forms.Label projNameLable;
        private System.Windows.Forms.Button addEngineerPlanButt;
        private System.Windows.Forms.Button addContractButt;
        private System.Windows.Forms.TextBox insurPolicyTextBox;
        private System.Windows.Forms.TextBox engineerPlanTextBox;
        private System.Windows.Forms.TextBox contractTextBox;
        private System.Windows.Forms.TextBox inspecTelTextBox;
        private System.Windows.Forms.TextBox inspecNameTextBox;
        private System.Windows.Forms.TextBox archTelTextBox;
        private System.Windows.Forms.TextBox archNameTextBox;
        private System.Windows.Forms.TextBox contactTelTextBox;
        private System.Windows.Forms.DateTimePicker etaDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox projNameTextBox;
        private System.Windows.Forms.Button sumbitNewProjButt;
        #endregion

        #region show open proj tab
        private System.Windows.Forms.TabPage showOpenProjTab;
        #endregion

        #region search By Proj Name Tab
        private System.Windows.Forms.TabPage searchByProjNameTab;
        #endregion

        #region search Proj By Cus Tab
        private System.Windows.Forms.TabPage searchProjByCusTab;
        #endregion

        #endregion

        #region EMPLOYEES

        #region new employee tab - DONE
        private System.Windows.Forms.TabPage createNewWorkerTab;
        private System.Windows.Forms.Label eTypeLable;
        private System.Windows.Forms.Label eStartDateLable;
        private System.Windows.Forms.Label eNameLable;
        private System.Windows.Forms.Label eIDLable;
        private System.Windows.Forms.Label wTypeLable;
        private System.Windows.Forms.Label confNumLable;
        private System.Windows.Forms.Label createPassLable;
        private System.Windows.Forms.Label accountNumLable;
        private System.Windows.Forms.Label branchNumLable;
        private System.Windows.Forms.Label bankNumLable;
        private System.Windows.Forms.Label paymentInfoLable;
        private System.Windows.Forms.TextBox createPassTextBox;
        private System.Windows.Forms.TextBox accountNumTextBox;
        private System.Windows.Forms.TextBox branchNumTextBox;
        private System.Windows.Forms.TextBox bankNumTextBox;
        private System.Windows.Forms.ComboBox eTypeCombo;
        private System.Windows.Forms.DateTimePicker startWorkingDatePicker;
        private System.Windows.Forms.TextBox eNameTextbox;
        private System.Windows.Forms.TextBox eIDTextBox;
        private System.Windows.Forms.ComboBox wTypeComboBox;
        private System.Windows.Forms.TextBox confNumTextBox;
        private System.Windows.Forms.Button sumbitNewEmployeeButt;
        #endregion

        #region show Worker Tab
        private System.Windows.Forms.TabPage showWorkerTab;
        #endregion

        #region search Worker By Proj Tab
        private System.Windows.Forms.TabPage searchWorkerByProjTab;
        #endregion

        #region assign Worker Tab
        private System.Windows.Forms.TabPage assignWorkerTab;
        #endregion

        #endregion

        #region CUSTOMERS

        #region new cus tab - DONE
        private System.Windows.Forms.TabPage newCusTab;
        private System.Windows.Forms.Button sumbitCusCreateButt;
        private System.Windows.Forms.TextBox cPhoneNumTextBox;
        private System.Windows.Forms.TextBox cCityTextBox;
        private System.Windows.Forms.TextBox cSNumTextBox;
        private System.Windows.Forms.TextBox cStreetTextBox;
        private System.Windows.Forms.TextBox cNameTextBox;
        private System.Windows.Forms.ComboBox cTypeComboBox;
        private System.Windows.Forms.TextBox cIDTextBox;
        private System.Windows.Forms.Label cPhoneNumLable;
        private System.Windows.Forms.Label cCityLable;
        private System.Windows.Forms.Label cSNumLable;
        private System.Windows.Forms.Label cStreetLable;
        private System.Windows.Forms.Label cTypeLable;
        private System.Windows.Forms.Label cFirstNameLable;
        private System.Windows.Forms.Label cIDLable;
        #endregion

        #region search By Cus Name Tab
        private System.Windows.Forms.TabPage assignProjToCusTab;
        #endregion

        #region show Cus Tab
        private System.Windows.Forms.TabPage showCusTab;
        #endregion

        #region search Cus By Name Tab
        private System.Windows.Forms.TabPage searchCusByNameTab;
        #endregion

        #endregion

        #region BALANCE

        #region add income tab - DONE
        private System.Windows.Forms.TabPage addIncomeTab;
        private System.Windows.Forms.Button incomeSumbitButt;
        private System.Windows.Forms.TextBox iAmountTextBox;
        private System.Windows.Forms.ComboBox iPayMethodComboBox;
        private System.Windows.Forms.DateTimePicker iPayDateTimePicker;
        private System.Windows.Forms.Label iProjNameLable;
        private System.Windows.Forms.Label iAmountLable;
        private System.Windows.Forms.Label iPayMethodLable;
        private System.Windows.Forms.Label inPayDateLable;
        #endregion

        #region add expense tab - DONE
        private System.Windows.Forms.TabPage addExpenseTab;
        private System.Windows.Forms.Button expenseSumbitButt;
        private System.Windows.Forms.TextBox eAmountTextBox;
        private System.Windows.Forms.ComboBox eMethodComboBox;
        private System.Windows.Forms.DateTimePicker ePayDatePicker;
        private System.Windows.Forms.Label eENameLable;
        private System.Windows.Forms.Label eAmountLable;
        private System.Windows.Forms.Label eMethodLable;
        private System.Windows.Forms.Label ePayDateLable;
        private System.Windows.Forms.ComboBox eReasonComboBox;
        private System.Windows.Forms.Label eReasonLable;
        #endregion

        #region show Balance Tab
        private System.Windows.Forms.TabPage showBalanceTab;
        #endregion

        #region search By Payment
        private System.Windows.Forms.TabPage searchByProjPaymentTab;
        #endregion

        #endregion

        private System.Windows.Forms.TabPage addWorkerTypeAndCostTab;
        private System.Windows.Forms.DataGridView allProjGridView;
        private Project.tesodotDataSet tesodotDataSet;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private Project.tesodotDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Project.tesodotDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private Project.tesodotDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn cTypeDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn projStateDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn archTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurPolicyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn archPlanPath;
        private System.Windows.Forms.DataGridViewLinkColumn agreementPath;
        private System.Windows.Forms.DataGridView searchByProjNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn projStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn archNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn archTelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspTelDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurPolicyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn archPlanPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn agreementPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button searchProjNameButt;
        private System.Windows.Forms.TextBox searchByProjNameTextBox;
        private System.Windows.Forms.Label searchByProjNameLable;
        private System.Windows.Forms.Button projCusAssignSaveButt;
        private System.Windows.Forms.ComboBox cusNameAssignComboBox;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.ComboBox projNameAssignComboBox;
        private System.Windows.Forms.BindingSource projectBindingSource1;
        private System.Windows.Forms.Label cusNameAssignLable;
        private System.Windows.Forms.Label projNameAssignLable;
        private System.Windows.Forms.Label searchWorkersInProjLable;
        private System.Windows.Forms.DataGridView searchWorkerByProjDataGridView;
        private System.Windows.Forms.Button searchWorkersInProjButt;
        private System.Windows.Forms.ComboBox searchWorkersInProjComboBox;
        private System.Windows.Forms.Button projWorkerAssignButt;
        private System.Windows.Forms.ComboBox workerProjAssignComboBox;
        private System.Windows.Forms.ComboBox projWorkerAssignComboBox;
        private System.Windows.Forms.Label workerProjAssignLabel;
        private System.Windows.Forms.Label projWorkerAssignLable;
        private System.Windows.Forms.Button searchCusButt;
        private System.Windows.Forms.TextBox cusSearchTextBox;
        private System.Windows.Forms.Label cusSearchLabel;
        private System.Windows.Forms.DataGridView searchCusByNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStreetDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSNumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button cusProjSearchButt;
        private System.Windows.Forms.ComboBox cusProjSearchComboBox;
        private System.Windows.Forms.Label cusProjSearchLabel;
        private System.Windows.Forms.DataGridView searchProjByCusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn projStateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn etaDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTelDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn archNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn archTelDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspTelDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurPolicyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn archPlanPathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn agreementPathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox iProjNameComboBox;
        private System.Windows.Forms.ComboBox eENameComboBox;
        private System.Windows.Forms.BindingSource workertypeBindingSource;
        private Project.tesodotDataSetTableAdapters.Worker_typeTableAdapter worker_typeTableAdapter;
        private System.Windows.Forms.Button searchButtByProjPayment;
        private System.Windows.Forms.ComboBox searchByProjPaymentComboBox;
        private System.Windows.Forms.Label searchByProjPaymentLabel;
        private System.Windows.Forms.DataGridView projIncomesDataGridView;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private Project.tesodotDataSetTableAdapters.incomesTableAdapter incomesTableAdapter;
        private System.Windows.Forms.Button applyAddWorkerTypeButt;
        private System.Windows.Forms.TextBox paymentPriceTextBox;
        private System.Windows.Forms.Label paymentPriceLabel;
        private System.Windows.Forms.TextBox workerTypeTextBox;
        private System.Windows.Forms.Label workerTypeLabel;
        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.DataGridView incomesDataGridView;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private Project.tesodotDataSetTableAdapters.expensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.DateTimePicker yearBalancePicker;
        private Button showYearBalanceButt;
        private Label totalBalanceLable;
        private Label totalIncomeLable;
        private Label totalExpanceLable;
        private Label yearBalanceLabel;
        private TextBox eDiscriptionTextBox;
        private Label eDiscriptionLable;
        private DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn eNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn eTypeDataGridViewTextBoxColumn1;
        private Button closeTabButt;
        private DataGridViewTextBoxColumn paymentID;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn pMethodDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn exTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn pMethodDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn projIDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pMethodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amoutDataGridViewTextBoxColumn;
    }
}

