using Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Project1
{
    public partial class main_menu : Form
    {

        #region creation of panels and tabs
        private System.Windows.Forms.TableLayoutPanel projPanelMenu;
        private System.Windows.Forms.Button assignProjToCusButt;
        private System.Windows.Forms.Button searchByProjNameButt;
        private System.Windows.Forms.Button newProjButt;
        private System.Windows.Forms.Button showOpenProjButt;
        private System.Windows.Forms.Button addNewStepsButt;
        private System.Windows.Forms.TableLayoutPanel workerPanelMenu;
        private System.Windows.Forms.Button addWorkerToProjButt;
        private System.Windows.Forms.Button workersInProjButt;
        private System.Windows.Forms.Button createWorkerButt;
        private System.Windows.Forms.Button showWorkersButt;
        private System.Windows.Forms.Button addWorkerTypeAndCostButt;
        private System.Windows.Forms.TableLayoutPanel custPanelMenu;
        private System.Windows.Forms.Button searchProjByCusButt;
        private System.Windows.Forms.Button searchCusByNameButt;
        private System.Windows.Forms.Button createCusButt;
        private System.Windows.Forms.Button showCusButt;
        private System.Windows.Forms.TableLayoutPanel paymentPanelMenu;
        private System.Windows.Forms.Button searchByProjPaymentButt;
        private System.Windows.Forms.Button addExpenseButt;
        private System.Windows.Forms.Button addIncomeButt;
        private System.Windows.Forms.Button showBalanceButt;
        
        #endregion

        public main_menu()
        {
            InitializeComponent();

            #region init
            this.projPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.assignProjToCusButt = new System.Windows.Forms.Button();
            this.searchByProjNameButt = new System.Windows.Forms.Button();
            this.newProjButt = new System.Windows.Forms.Button();
            this.showOpenProjButt = new System.Windows.Forms.Button();
            this.addNewStepsButt = new System.Windows.Forms.Button();
            this.workerPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.addWorkerToProjButt = new System.Windows.Forms.Button();
            this.workersInProjButt = new System.Windows.Forms.Button();
            this.createWorkerButt = new System.Windows.Forms.Button();
            this.showWorkersButt = new System.Windows.Forms.Button();
            this.addWorkerTypeAndCostButt = new System.Windows.Forms.Button();
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
            this.projPanelMenu.SuspendLayout();
            this.workerPanelMenu.SuspendLayout();
            this.custPanelMenu.SuspendLayout();
            this.paymentPanelMenu.SuspendLayout();
            //// 
            //// projPanelMenu
            //// 
            this.projPanelMenu.ColumnCount = 1;
            this.projPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.projPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.projPanelMenu.Controls.Add(this.assignProjToCusButt, 0, 3);
            this.projPanelMenu.Controls.Add(this.searchByProjNameButt, 0, 2);
            this.projPanelMenu.Controls.Add(this.newProjButt, 0, 1);
            this.projPanelMenu.Controls.Add(this.showOpenProjButt, 0, 0);
            this.projPanelMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projPanelMenu.Location = new System.Drawing.Point(1611, 66);
            this.projPanelMenu.Name = "projPanelMenu";
            this.projPanelMenu.RowCount = 4;
            this.projPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.projPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.projPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.projPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.projPanelMenu.Size = new System.Drawing.Size(159, 155);
            this.projPanelMenu.TabIndex = 5;
            this.projPanelMenu.Visible = false;
            // 
            // assignProjToCusButt
            // 
            this.assignProjToCusButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignProjToCusButt.FlatAppearance.BorderSize = 0;
            this.assignProjToCusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignProjToCusButt.Location = new System.Drawing.Point(3, 102);
            this.assignProjToCusButt.Name = "assignProjToCusButt";
            this.assignProjToCusButt.Size = new System.Drawing.Size(153, 28);
            this.assignProjToCusButt.TabIndex = 3;
            this.assignProjToCusButt.Text = "שיוך פרויקט ללקוח";
            this.assignProjToCusButt.UseVisualStyleBackColor = true;
            this.assignProjToCusButt.Click += new EventHandler(assignProjToCusButt_Click);
            //// 
            //// searchByProjNameButt
            //// 
            this.searchByProjNameButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByProjNameButt.FlatAppearance.BorderSize = 0;
            this.searchByProjNameButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByProjNameButt.Location = new System.Drawing.Point(3, 69);
            this.searchByProjNameButt.Name = "searchByProjNameButt";
            this.searchByProjNameButt.Size = new System.Drawing.Size(153, 27);
            this.searchByProjNameButt.TabIndex = 2;
            this.searchByProjNameButt.Text = "חפש לפי שם פרויקט";
            this.searchByProjNameButt.UseVisualStyleBackColor = true;
            this.searchByProjNameButt.Click += new EventHandler(searchByProjNameButt_Click);
            // 
            // newProjButt
            // 
            this.newProjButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newProjButt.FlatAppearance.BorderSize = 0;
            this.newProjButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProjButt.Location = new System.Drawing.Point(3, 36);
            this.newProjButt.Name = "newProjButt";
            this.newProjButt.Size = new System.Drawing.Size(153, 27);
            this.newProjButt.TabIndex = 1;
            this.newProjButt.Text = "פרויקט חדש";
            this.newProjButt.UseVisualStyleBackColor = true;
            this.newProjButt.Click += new EventHandler(newProjButt_Click);
            // 
            // showOpenProjButt
            // 
            this.showOpenProjButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showOpenProjButt.FlatAppearance.BorderSize = 0;
            this.showOpenProjButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOpenProjButt.Location = new System.Drawing.Point(3, 3);
            this.showOpenProjButt.Name = "showOpenProjButt";
            this.showOpenProjButt.Size = new System.Drawing.Size(153, 36);
            this.showOpenProjButt.TabIndex = 0;
            this.showOpenProjButt.Text = "הצג פרויקטים";
            this.showOpenProjButt.UseVisualStyleBackColor = true;
            this.showOpenProjButt.Click += new EventHandler(showOpenProjButt_Click);
            // 
            // workerPanelMenu
            // 
            this.workerPanelMenu.ColumnCount = 1;
            this.workerPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workerPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.workerPanelMenu.Controls.Add(this.addWorkerTypeAndCostButt, 0, 4);
            this.workerPanelMenu.Controls.Add(this.addWorkerToProjButt, 0, 3);
            this.workerPanelMenu.Controls.Add(this.workersInProjButt, 0, 2);
            this.workerPanelMenu.Controls.Add(this.createWorkerButt, 0, 1);
            this.workerPanelMenu.Controls.Add(this.showWorkersButt, 0, 0);
            this.workerPanelMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerPanelMenu.Location = new System.Drawing.Point(1611, 325);
            this.workerPanelMenu.Name = "workerPanelMenu";
            this.workerPanelMenu.RowCount = 5;
            this.workerPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.workerPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.workerPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.workerPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.workerPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.workerPanelMenu.Size = new System.Drawing.Size(159, 155);
            this.workerPanelMenu.TabIndex = 6;
            this.workerPanelMenu.Visible = false;
            // 
            // addWorkerTypeAndCostButt
            // 
            this.addWorkerTypeAndCostButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWorkerTypeAndCostButt.FlatAppearance.BorderSize = 0;
            this.addWorkerTypeAndCostButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkerTypeAndCostButt.Location = new System.Drawing.Point(3, 135);
            this.addWorkerTypeAndCostButt.Name = "addWorkerTypeAndCostButt";
            this.addWorkerTypeAndCostButt.Size = new System.Drawing.Size(153, 28);
            this.addWorkerTypeAndCostButt.TabIndex = 4;
            this.addWorkerTypeAndCostButt.Text = "הוספת סוג עובד ותשלום";
            this.addWorkerTypeAndCostButt.UseVisualStyleBackColor = true;
            this.addWorkerTypeAndCostButt.Click += new EventHandler(addWorkerTypeAndCostButt_Click);
            // 
            // addWorkerToProjButt
            // 
            this.addWorkerToProjButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWorkerToProjButt.FlatAppearance.BorderSize = 0;
            this.addWorkerToProjButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWorkerToProjButt.Location = new System.Drawing.Point(3, 102);
            this.addWorkerToProjButt.Name = "addWorkerToProjButt";
            this.addWorkerToProjButt.Size = new System.Drawing.Size(153, 28);
            this.addWorkerToProjButt.TabIndex = 3;
            this.addWorkerToProjButt.Text = "שיוך עובד לפרויקט";
            this.addWorkerToProjButt.UseVisualStyleBackColor = true;
            this.addWorkerToProjButt.Click += new EventHandler(addWorkerToProjButt_Click);
            // 
            // workersInProjButt
            // 
            this.workersInProjButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workersInProjButt.FlatAppearance.BorderSize = 0;
            this.workersInProjButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workersInProjButt.Location = new System.Drawing.Point(3, 69);
            this.workersInProjButt.Name = "workersInProjButt";
            this.workersInProjButt.Size = new System.Drawing.Size(153, 27);
            this.workersInProjButt.TabIndex = 2;
            this.workersInProjButt.Text = "חיפוש עובדים בפרויקט";
            this.workersInProjButt.UseVisualStyleBackColor = true;
            this.workersInProjButt.Click += new EventHandler(workersInProjButt_Click);
            // 
            // createWorkerButt
            // 
            this.createWorkerButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createWorkerButt.FlatAppearance.BorderSize = 0;
            this.createWorkerButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createWorkerButt.Location = new System.Drawing.Point(3, 36);
            this.createWorkerButt.Name = "createWorkerButt";
            this.createWorkerButt.Size = new System.Drawing.Size(153, 27);
            this.createWorkerButt.TabIndex = 1;
            this.createWorkerButt.Text = "צור עובד חדש";
            this.createWorkerButt.UseVisualStyleBackColor = true;
            this.createWorkerButt.Click += new EventHandler(createWorkerButt_Click);
            // 
            // showWorkersButt
            // 
            this.showWorkersButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showWorkersButt.FlatAppearance.BorderSize = 0;
            this.showWorkersButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showWorkersButt.Location = new System.Drawing.Point(3, 3);
            this.showWorkersButt.Name = "showWorkersButt";
            this.showWorkersButt.Size = new System.Drawing.Size(153, 27);
            this.showWorkersButt.TabIndex = 0;
            this.showWorkersButt.Text = "הצג עובדים";
            this.showWorkersButt.UseVisualStyleBackColor = true;
            this.showWorkersButt.Click += new EventHandler(showWorkersButt_Click);
            // 
            // custPanelMenu
            // 
            this.custPanelMenu.ColumnCount = 1;
            this.custPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.custPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.custPanelMenu.Controls.Add(this.searchProjByCusButt, 0, 3);
            this.custPanelMenu.Controls.Add(this.searchCusByNameButt, 0, 2);
            this.custPanelMenu.Controls.Add(this.createCusButt, 0, 1);
            this.custPanelMenu.Controls.Add(this.showCusButt, 0, 0);
            this.custPanelMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custPanelMenu.Location = new System.Drawing.Point(1596, 582);
            this.custPanelMenu.Name = "custPanelMenu";
            this.custPanelMenu.RowCount = 4;
            this.custPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.custPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.custPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.custPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.custPanelMenu.Size = new System.Drawing.Size(174, 133);
            this.custPanelMenu.TabIndex = 7;
            this.custPanelMenu.Visible = false;
            // 
            // searchProjByCusButt
            // 
            this.searchProjByCusButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchProjByCusButt.FlatAppearance.BorderSize = 0;
            this.searchProjByCusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProjByCusButt.Location = new System.Drawing.Point(3, 102);
            this.searchProjByCusButt.Name = "searchProjByCusButt";
            this.searchProjByCusButt.Size = new System.Drawing.Size(168, 28);
            this.searchProjByCusButt.TabIndex = 3;
            this.searchProjByCusButt.Text = "חיפוש פרויקטים של לקוח";
            this.searchProjByCusButt.UseVisualStyleBackColor = true;
            this.searchProjByCusButt.Click += new EventHandler(searchProjByCusButt_Click);
            // 
            // searchCusByNameButt
            // 
            this.searchCusByNameButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCusByNameButt.FlatAppearance.BorderSize = 0;
            this.searchCusByNameButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCusByNameButt.Location = new System.Drawing.Point(3, 69);
            this.searchCusByNameButt.Name = "searchCusByNameButt";
            this.searchCusByNameButt.Size = new System.Drawing.Size(168, 27);
            this.searchCusByNameButt.TabIndex = 2;
            this.searchCusByNameButt.Text = "חיפוש לקוח לפני שם";
            this.searchCusByNameButt.UseVisualStyleBackColor = true;
            this.searchCusByNameButt.Click += new EventHandler(searchCusByNameButt_Click);
            // 
            // createCusButt
            // 
            this.createCusButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCusButt.FlatAppearance.BorderSize = 0;
            this.createCusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCusButt.Location = new System.Drawing.Point(3, 36);
            this.createCusButt.Name = "createCusButt";
            this.createCusButt.Size = new System.Drawing.Size(168, 27);
            this.createCusButt.TabIndex = 1;
            this.createCusButt.Text = "צור לקוח חדש";
            this.createCusButt.UseVisualStyleBackColor = true;
            this.createCusButt.Click += new EventHandler(createCusButt_Click);
            // 
            // showCusButt
            // 
            this.showCusButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCusButt.FlatAppearance.BorderSize = 0;
            this.showCusButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCusButt.Location = new System.Drawing.Point(3, 3);
            this.showCusButt.Name = "showCusButt";
            this.showCusButt.Size = new System.Drawing.Size(168, 27);
            this.showCusButt.TabIndex = 0;
            this.showCusButt.Text = "הצג לקוחות";
            this.showCusButt.UseVisualStyleBackColor = true;
            this.showCusButt.Click += new EventHandler(showCusButt_Click);
            // 
            // paymentPanelMenu
            // 
            this.paymentPanelMenu.ColumnCount = 1;
            this.paymentPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paymentPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.paymentPanelMenu.Controls.Add(this.searchByProjPaymentButt, 0, 3);
            this.paymentPanelMenu.Controls.Add(this.addExpenseButt, 0, 2);
            this.paymentPanelMenu.Controls.Add(this.addIncomeButt, 0, 1);
            this.paymentPanelMenu.Controls.Add(this.showBalanceButt, 0, 0);
            this.paymentPanelMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentPanelMenu.Location = new System.Drawing.Point(1611, 842);
            this.paymentPanelMenu.Name = "paymentPanelMenu";
            this.paymentPanelMenu.RowCount = 4;
            this.paymentPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.paymentPanelMenu.Size = new System.Drawing.Size(159, 133);
            this.paymentPanelMenu.TabIndex = 8;
            this.paymentPanelMenu.Visible = false;
            // 
            // searchByPaymentTypeButt
            // 
            this.searchByProjPaymentButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchByProjPaymentButt.FlatAppearance.BorderSize = 0;
            this.searchByProjPaymentButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByProjPaymentButt.Location = new System.Drawing.Point(3, 102);
            this.searchByProjPaymentButt.Name = "searchByProjPaymentButt";
            this.searchByProjPaymentButt.Size = new System.Drawing.Size(153, 28);
            this.searchByProjPaymentButt.TabIndex = 3;
            this.searchByProjPaymentButt.Text = "חיפוש לפי תשלומים בפרויקט";
            this.searchByProjPaymentButt.UseVisualStyleBackColor = true;
            this.searchByProjPaymentButt.Click += new EventHandler(searchByProjPaymentButt_Click);
            // 
            // addExpenseButt
            // 
            this.addExpenseButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpenseButt.FlatAppearance.BorderSize = 0;
            this.addExpenseButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpenseButt.Location = new System.Drawing.Point(3, 69);
            this.addExpenseButt.Name = "addExpenseButt";
            this.addExpenseButt.Size = new System.Drawing.Size(153, 27);
            this.addExpenseButt.TabIndex = 2;
            this.addExpenseButt.Text = "הוסף הוצאה";
            this.addExpenseButt.UseVisualStyleBackColor = true;
            this.addExpenseButt.Click += new EventHandler(addExpenseButt_Click);
            // 
            // addIncomeButt
            // 
            this.addIncomeButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncomeButt.FlatAppearance.BorderSize = 0;
            this.addIncomeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeButt.Location = new System.Drawing.Point(3, 36);
            this.addIncomeButt.Name = "addIncomeButt";
            this.addIncomeButt.Size = new System.Drawing.Size(153, 27);
            this.addIncomeButt.TabIndex = 1;
            this.addIncomeButt.Text = "הוסף הכנסה";
            this.addIncomeButt.UseVisualStyleBackColor = true;
            this.addIncomeButt.Click += new EventHandler(addIncomeButt_Click);
            // 
            // showBalanceButt
            // 
            this.showBalanceButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBalanceButt.FlatAppearance.BorderSize = 0;
            this.showBalanceButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBalanceButt.Location = new System.Drawing.Point(3, 3);
            this.showBalanceButt.Name = "showBalanceButt";
            this.showBalanceButt.Size = new System.Drawing.Size(153, 27);
            this.showBalanceButt.TabIndex = 0;
            this.showBalanceButt.Text = "הצג הוצאות והכנסות החברה";
            this.showBalanceButt.UseVisualStyleBackColor = true;
            this.showBalanceButt.Click += new EventHandler(showBalanceButt_Click);

            this.Controls.Add(this.paymentPanelMenu);
            this.Controls.Add(this.custPanelMenu);
            this.Controls.Add(this.workerPanelMenu);
            this.Controls.Add(this.projPanelMenu);
            this.projPanelMenu.ResumeLayout(false);
            this.workerPanelMenu.ResumeLayout(false);
            this.custPanelMenu.ResumeLayout(false);
            this.paymentPanelMenu.ResumeLayout(false);
            #endregion
        }
        


        #region mouse enters
        private void proj_butt_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = true;
            this.projPanelMenu.BringToFront();
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void worker_butt_MouseHover(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = true;
            this.workerPanelMenu.BringToFront();
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void cust_butt_MouseHover(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = true;
            this.custPanelMenu.BringToFront();
            this.paymentPanelMenu.Visible = false;
        }

        private void pay_butt_MouseHover(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = true;
            this.paymentPanelMenu.BringToFront();
        }

        private void main_menu_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void tabContainer_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void openProjGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void newProjTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchByProjNameTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchByProjNameDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void assignProjToCusTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void employeeDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void createNewWorkerTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchWorkerByProjTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchWorkerByProjDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void assignWorkerTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void customerDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void newCusTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchCusByNameTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchCusByNameDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchProjByCusTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchProjByCusDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void showBalanceTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void expensesDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void incomesDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void addIncomeTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void addExpenseTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void searchByProjPaymentTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void projIncomesDataGridView_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }

        private void addWorkerTypeAndCostTab_MouseEnter(object sender, EventArgs e)
        {
            this.projPanelMenu.Visible = false;
            this.workerPanelMenu.Visible = false;
            this.custPanelMenu.Visible = false;
            this.paymentPanelMenu.Visible = false;
        }
        #endregion

        #region tabs opening
        private void newProjButt_Click(object sender, EventArgs e)
        {
            #region creation of new project tab
            
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(newProjTab);
            tabContainer.SelectTab(newProjTab);

            #endregion
        }

        private void addIncomeButt_Click(object sender, EventArgs e)
        {
            #region creation of income tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(addIncomeTab);
            tabContainer.SelectTab(addIncomeTab);
            #endregion

        }

        private void addExpenseButt_Click(object sender, EventArgs e)
        {
            #region creation of expanse tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(addExpenseTab);
            tabContainer.SelectTab(addExpenseTab);
            #endregion

        }

        private void searchByProjPaymentButt_Click(object sender, EventArgs e)
        {
            #region creation of searchByProjPaymentButt tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(searchByProjPaymentTab);
            tabContainer.SelectTab(searchByProjPaymentTab);
            #endregion
        }

        private void showCusButt_Click(object sender, EventArgs e)
        {
            #region creation of showCus tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(showCusTab);
            tabContainer.SelectTab(showCusTab);
            #endregion
        }

        private void createCusButt_Click(object sender, EventArgs e)
        {
            #region creation of createCus tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(newCusTab);
            tabContainer.SelectTab(newCusTab);
            #endregion
        }

        private void searchCusByNameButt_Click(object sender, EventArgs e)
        {
            #region creation of searchCusByName tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(searchCusByNameTab);
            tabContainer.SelectTab(searchCusByNameTab);
            #endregion
        }

        private void searchProjByCusButt_Click(object sender, EventArgs e)
        {
            #region creation of searchProjByCus tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(searchProjByCusTab);
            tabContainer.SelectTab(searchProjByCusTab);
            #endregion
        }

        private void showWorkersButt_Click(object sender, EventArgs e)
        {
            #region creation of showWorkers tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(showWorkerTab);
            tabContainer.SelectTab(showWorkerTab);
            #endregion
        }

        private void createWorkerButt_Click(object sender, EventArgs e)
        {
            #region creation of createWorker tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(createNewWorkerTab);
            tabContainer.SelectTab(createNewWorkerTab);
            #endregion
        }

        private void workersInProjButt_Click(object sender, EventArgs e)
        {
            #region creation of workersInProj tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(searchWorkerByProjTab);
            tabContainer.SelectTab(searchWorkerByProjTab);
            #endregion
        }

        private void addWorkerToProjButt_Click(object sender, EventArgs e)
        {
            #region creation of addWorkerToProj tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(assignWorkerTab);
            tabContainer.SelectTab(assignWorkerTab);
            #endregion
        }

        private void addWorkerTypeAndCostButt_Click(object sender, EventArgs e)
        {
            #region creation of addWorkerTypeAndCostButt tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(addWorkerTypeAndCostTab);
            tabContainer.SelectTab(addWorkerTypeAndCostTab);
            #endregion
        }

        private void assignProjToCusButt_Click(object sender, EventArgs e)
        {
            #region creation of searchByCusName tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(assignProjToCusTab);
            tabContainer.SelectTab(assignProjToCusTab);
            #endregion
        }

        private void searchByProjNameButt_Click(object sender, EventArgs e)
        {
            #region creation of searchByProj tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(searchByProjNameTab);
            tabContainer.SelectTab(searchByProjNameTab);
            #endregion
        }

        private void showOpenProjButt_Click(object sender, EventArgs e)
        {
            #region creation of showOpenProj tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(showOpenProjTab);
            tabContainer.SelectTab(showOpenProjTab);
            #endregion
        }

        private void showBalanceButt_Click(object sender, EventArgs e)
        {
            #region creation of showOpenProj tab
            this.tabContainer.Visible = true;
            tabContainer.TabPages.Add(showBalanceTab);
            tabContainer.SelectTab(showBalanceTab);
            #endregion
        }
        #endregion

        private void main_menu_Load(object sender, EventArgs e)
        {
            while (tabContainer.TabCount > 0)
            {
                TabPage tabPage = (TabPage)tabContainer.TabPages[tabContainer.SelectedIndex];
                tabContainer.TabPages.Remove(tabPage);
            }
            tabContainer.Visible = false;
            this.expensesTableAdapter.Fill(this.tesodotDataSet.expenses);
            this.incomesTableAdapter.Fill(this.tesodotDataSet.incomes);
            this.worker_typeTableAdapter.Fill(this.tesodotDataSet.Worker_type);
            this.customerTableAdapter.Fill(this.tesodotDataSet.Customer);
            this.projectTableAdapter.Fill(this.tesodotDataSet.Project);
            this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
            projIsLate();

            #region balance tab load
            double sum = 0.0;
            for (int i = 0; i < incomesDataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(incomesDataGridView.Rows[i].Cells[3].Value);
            }
            totalIncomeLable.Text += sum.ToString();

            double sum1 = 0.0;
            for (int i = 0; i < expensesDataGridView.Rows.Count; ++i)
            {
                sum1 += Convert.ToDouble(expensesDataGridView.Rows[i].Cells[3].Value);
            }
            sum1 = sum1 * -1.0;
            totalExpanceLable.Text += sum1.ToString();

            double total = sum + sum1;
            totalBalanceLable.Text += total.ToString();
            #endregion
        }

        private void eTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eTypeCombo.SelectedItem.ToString() == "פועל")
            {
                createPassLable.Visible = false;
                createPassTextBox.Visible = false;
                confNumLable.Visible = true;
                confNumTextBox.Visible = true;
                wTypeLable.Visible = true;
                wTypeComboBox.Visible = true;
            }
            else if (eTypeCombo.SelectedItem.ToString() == "מנהל פרויקט" || eTypeCombo.SelectedItem.ToString() == "מנהל")
            {
                confNumLable.Visible = false;
                confNumTextBox.Visible = false;
                wTypeLable.Visible = false;
                wTypeComboBox.Visible = false;
                createPassLable.Visible = true;
                createPassTextBox.Visible = true;
            }
        }

        private void eReasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eReasonComboBox.Text == "אחר")
            {
                eENameLable.Visible = false;
                eENameComboBox.Visible = false;
                eDiscriptionLable.Visible = true;
                eDiscriptionTextBox.Visible = true;
            }
            else
            {
                eENameLable.Visible = true;
                eENameComboBox.Visible = true;
                eDiscriptionLable.Visible = false;
                eDiscriptionTextBox.Visible = false;
            }
        }

        private void addContractButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.FileName;
                contractTextBox.Text = path;
            }
        }

        private void addEngineerPlanButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.FileName;
                engineerPlanTextBox.Text = path;
            }
        }

        private void closeTabButt_Click(object sender, EventArgs e)
        {
            if (tabContainer.TabCount == 1)
            {
                tabContainer.Visible = false;
                TabPage tabPage = (TabPage)tabContainer.TabPages[tabContainer.SelectedIndex];
                tabContainer.TabPages.Remove(tabPage);
            }
            else if (tabContainer.TabCount == 0)
            {
                return;
            }
            else
            {
                TabPage tabPage = (TabPage)tabContainer.TabPages[tabContainer.SelectedIndex];
                tabContainer.TabPages.Remove(tabPage);
            }

        }

        private void exit_butt_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("האם אתה בטוח רוצה לצאת מהמערכת?", "יציאה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        #region queries

        private void sumbitNewProjButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (projNameTextBox.Text == "" || contactNameTextBox.Text == "" || contactTelTextBox.Text == "" || insurPolicyTextBox.Text == "" || engineerPlanTextBox.Text == "" || contractTextBox.Text == "")
            {
                string message = "לא כל השדות הדרושים לפתיחת פרויקט הוקלדו";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else if (archNameTextBox.Text != "" && inspecNameTextBox.Text != "")
            {
                if (archTelTextBox.Text == "" || inspecTelTextBox.Text == "")
                {
                    string message = "אנא הקלד את מספרו של המהנדס/מפקח אשר חסרים";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string state = "פעיל";
                 //   string query =
                 //"INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, inspName, inspTel, insurPolicy, archPlanPath, agreementPath) " +
                 //"VALUES(\'" + state + "\', \'" + projNameTextBox.Text + "\', \'" + startDateTimePicker.Value.ToString() + "', \'" + etaDateTimePicker.Value.ToString() + "'," +
                 //" \'" + contactNameTextBox.Text + "', \'" + contactTelTextBox.Text + "', \'" + archNameTextBox.Text + "', \'" + archTelTextBox.Text + "', " +
                 //"\'" + inspecNameTextBox.Text + "', \'" + inspecTelTextBox.Text + "', \'" + insurPolicyTextBox.Text + "', \'" + engineerPlanTextBox.Text + "', " +
                 //"\'" + contractTextBox.Text + "');";

                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, inspName, inspTel, insurPolicy, archPlanPath, agreementPath) " +
                "VALUES (@projState,@projName,@startDate,@etaDate,@contactName,@contactTel,@archName,@archTel,@inspName,@inspTel,@insurPolicy,@archPlanPath,@agreementPath)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@projState", state);
                    command.Parameters.AddWithValue("@projName", projNameTextBox.Text);
                    command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@etaDate", etaDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@contactName", contactNameTextBox.Text);
                    command.Parameters.AddWithValue("@contactTel", contactTelTextBox.Text);
                    command.Parameters.AddWithValue("@archName", archNameTextBox.Text);
                    command.Parameters.AddWithValue("@archTel", archTelTextBox.Text);
                    command.Parameters.AddWithValue("@inspName", inspecNameTextBox.Text);
                    command.Parameters.AddWithValue("@inspTel", inspecTelTextBox.Text);
                    command.Parameters.AddWithValue("@insurPolicy", insurPolicyTextBox.Text);
                    command.Parameters.AddWithValue("@archPlanPath", engineerPlanTextBox.Text);
                    command.Parameters.AddWithValue("@agreementPath", contractTextBox.Text);

                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    this.projectTableAdapter.Fill(this.tesodotDataSet.Project);
                }
            }
            else if (archNameTextBox.Text != "" )
            {
                if (archTelTextBox.Text == "")
                {
                    string message = "אנא הקלד את מספרו של המהנדס";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string state = "פעיל";
                    //   string query =
                    //"INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, insurPolicy, archPlanPath, agreementPath) " +
                    //"VALUES(\'" + state + "\', \'" + projNameTextBox.Text + "\', \'" + startDateTimePicker.Value.ToString() + "', \'" + etaDateTimePicker.Value.ToString() + "'," +
                    //" \'" + contactNameTextBox.Text + "', \'" + contactTelTextBox.Text + "', \'" + archNameTextBox.Text + "', \'" + archTelTextBox.Text + "', " +
                    //" \'" + insurPolicyTextBox.Text + "', \'" + engineerPlanTextBox.Text + "', " +
                    //"\'" + contractTextBox.Text + "');";

                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, insurPolicy, archPlanPath, agreementPath) " +
                "VALUES (@projState,@projName,@startDate,@etaDate,@contactName,@contactTel,@archName,@archTel,@insurPolicy,@archPlanPath,@agreementPath)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@projState", state);
                    command.Parameters.AddWithValue("@projName", projNameTextBox.Text);
                    command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@etaDate", etaDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@contactName", contactNameTextBox.Text);
                    command.Parameters.AddWithValue("@contactTel", contactTelTextBox.Text);
                    command.Parameters.AddWithValue("@archName", archNameTextBox.Text);
                    command.Parameters.AddWithValue("@archTel", archTelTextBox.Text);
                    command.Parameters.AddWithValue("@insurPolicy", insurPolicyTextBox.Text);
                    command.Parameters.AddWithValue("@archPlanPath", engineerPlanTextBox.Text);
                    command.Parameters.AddWithValue("@agreementPath", contractTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    this.projectTableAdapter.Fill(this.tesodotDataSet.Project);
                }
            }
            else if (inspecNameTextBox.Text != "")
            {
                if (inspecTelTextBox.Text == "")
                {
                    string message = "אנא הקלד את מספרו של המפקח";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string state = "פעיל";
                    //   string query =
                    //"INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, inspName, inspTel, insurPolicy, archPlanPath, agreementPath) " +
                    //"VALUES(\'" + state + "\', \'" + projNameTextBox.Text + "\', \'" + startDateTimePicker.Value.ToString() + "', \'" + etaDateTimePicker.Value.ToString() + "'," +
                    //" \'" + contactNameTextBox.Text + "', \'" + contactTelTextBox.Text + "', " +
                    //"\'" + inspecNameTextBox.Text + "', \'" + inspecTelTextBox.Text + "', \'" + insurPolicyTextBox.Text + "', \'" + engineerPlanTextBox.Text + "', " +
                    //"\'" + contractTextBox.Text + "');";

                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, inspName, inspTel, insurPolicy, archPlanPath, agreementPath) " +
                "VALUES (@projState,@projName,@startDate,@etaDate,@contactName,@contactTel,@inspName,@inspTel,@insurPolicy,@archPlanPath,@agreementPath)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@projState", state);
                    command.Parameters.AddWithValue("@projName", projNameTextBox.Text);
                    command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@etaDate", etaDateTimePicker.Value.ToString());
                    command.Parameters.AddWithValue("@contactName", contactNameTextBox.Text);
                    command.Parameters.AddWithValue("@contactTel", contactTelTextBox.Text);
                    command.Parameters.AddWithValue("@inspName", inspecNameTextBox.Text);
                    command.Parameters.AddWithValue("@inspTel", inspecTelTextBox.Text);
                    command.Parameters.AddWithValue("@insurPolicy", insurPolicyTextBox.Text);
                    command.Parameters.AddWithValue("@archPlanPath", engineerPlanTextBox.Text);
                    command.Parameters.AddWithValue("@agreementPath", contractTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    this.projectTableAdapter.Fill(this.tesodotDataSet.Project);
                }
            }
            else
            {
                string state = "פעיל";
                //string query =
                //"INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, insurPolicy, archPlanPath, agreementPath) " +
                //"VALUES(\'" + state + "\', \'" + projNameTextBox.Text + "\', \'" + startDateTimePicker.Value.ToString() + "', \'" + etaDateTimePicker.Value.ToString() + "'," +
                //" \'" + contactNameTextBox.Text + "', \'" + contactTelTextBox.Text + "', \'" + insurPolicyTextBox.Text + "', \'" + engineerPlanTextBox.Text + "', \'" + contractTextBox.Text + "');";

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "INSERT INTO Project ( projState, projName, startDate, etaDate, contactName, contactTel, insurPolicy, archPlanPath, agreementPath) " +
            "VALUES (@projState,@projName,@startDate,@etaDate,@contactName,@contactTel,@insurPolicy,@archPlanPath,@agreementPath)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@projState", state);
                command.Parameters.AddWithValue("@projName", projNameTextBox.Text);
                command.Parameters.AddWithValue("@startDate", startDateTimePicker.Value.ToString());
                command.Parameters.AddWithValue("@etaDate", etaDateTimePicker.Value.ToString());
                command.Parameters.AddWithValue("@contactName", contactNameTextBox.Text);
                command.Parameters.AddWithValue("@contactTel", contactTelTextBox.Text);
                command.Parameters.AddWithValue("@insurPolicy", insurPolicyTextBox.Text);
                command.Parameters.AddWithValue("@archPlanPath", engineerPlanTextBox.Text);
                command.Parameters.AddWithValue("@agreementPath", contractTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                this.projectTableAdapter.Fill(this.tesodotDataSet.Project);
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
            update_projTables();
        }

        private void sumbitNewEmployeeButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (eIDTextBox.Text == "" || eNameTextbox.Text == "" || startWorkingDatePicker.Value.ToString() == "" || eTypeCombo.SelectedItem.ToString() == "")
            {
                    string message = "לא כל השדות הדרושים ליצירת עובד חדש הוכנסו";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
            }
            else if (eTypeCombo.SelectedItem.ToString() == "מנהל פרויקט")
            {
                if (createPassTextBox.Text == "")
                {
                    string message = "לא הוכנסה סיסמא עבור מנהל פרויקט חדש";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else if (bankNumTextBox.Text != "" && branchNumTextBox.Text != "" && accountNumTextBox.Text != "")
                {
                    //   string query =
                    //"INSERT INTO Employee ( eID, eName, startDate, eType, bankNum, branchNum, accountNum) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + eNameTextbox.Text + "\', \'" + startWorkingDatePicker.Value.ToString() + "', \'" + eTypeCombo.SelectedItem.ToString() + "'," +
                    //" \'" + bankNumTextBox.Text + "', \'" + branchNumTextBox.Text + "', \'" + accountNumTextBox.Text + "');";

                    //   SqlCommand command = new SqlCommand(query, conn);
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType, bankNum, branchNum, accountNum) " +
                "VALUES (@eID,@eName,@startDate,@eType,@bankNum,@branchNum,@accountNum)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Text);
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@bankNum", bankNumTextBox.Text);
                    command.Parameters.AddWithValue("@branchNum", branchNumTextBox.Text);
                    command.Parameters.AddWithValue("@accountNum", accountNumTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    //   string query1 =
                    //"INSERT INTO Project_Manager ( eID, pmPassword) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + createPassTextBox.Text + "\');";

                    //   SqlCommand command1 = new SqlCommand(query, conn);
                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Project_Manager ( eID, pmPassword) " +
                   "VALUES (@eID,@pmPassword)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@pmPassword", createPassTextBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
                else
                {
                    //   string query =
                    //"INSERT INTO Employee ( eID, eName, startDate, eType) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + eNameTextbox.Text + "\', \'" + startWorkingDatePicker.Value.ToString() + "', \'" + eTypeCombo.SelectedItem.ToString() + "');";

                    //   SqlCommand command = new SqlCommand(query, conn);
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType) " +
                "VALUES (@eID,@eName,@startDate,@eType)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Value.ToString());
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    //   string query1 =
                    //"INSERT INTO Project_Manager ( eID, pmPassword) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + createPassTextBox.Text + "\');";

                    //   SqlCommand command1 = new SqlCommand(query, conn);
                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Project_Manager ( eID, pmPassword) " +
                   "VALUES (@eID,@pmPassword)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@pmPassword", createPassTextBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
            }
            else if (eTypeCombo.SelectedItem.ToString() == "מנהל")
            {
                if (createPassTextBox.Text == "")
                {
                    string message = "לא הוכנסה סיסמא עבור מנהל חדש";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else if (bankNumTextBox.Text != "" && branchNumTextBox.Text != "" && accountNumTextBox.Text != "")
                {
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType, bankNum, branchNum, accountNum) " +
                "VALUES (@eID,@eName,@startDate,@eType,@bankNum,@branchNum,@accountNum)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Value.ToString());
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@bankNum", bankNumTextBox.Text);
                    command.Parameters.AddWithValue("@branchNum", branchNumTextBox.Text);
                    command.Parameters.AddWithValue("@accountNum", accountNumTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Administrator ( eID, adminPassword) " +
                   "VALUES (@eID,@adminPassword)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@adminPassword", createPassTextBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
                else
                {
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType) " +
                "VALUES (@eID,@eName,@startDate,@eType)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Value.ToString());
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Administrator ( eID, adminPassword) " +
                   "VALUES (@eID,@adminPassword)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@adminPassword", createPassTextBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
            }
            else
            {
                if (confNumTextBox.Text == "" || wTypeComboBox.SelectedItem.ToString() == "")
                {
                    string message = "לא הוכנס מספר אישור/סוג פועל";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else if (bankNumTextBox.Text != "" && branchNumTextBox.Text != "" && accountNumTextBox.Text != "")
                {
                    //   string query =
                    //"INSERT INTO Employee ( eID, eName, startDate, eType, bankNum, branchNum, accountNum) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + eNameTextbox.Text + "\', \'" + startWorkingDatePicker.Value.ToString() + "', \'" + eTypeCombo.SelectedItem.ToString() + "'," +
                    //" \'" + bankNumTextBox.Text + "', \'" + branchNumTextBox.Text + "', \'" + accountNumTextBox.Text + "');";

                    //   SqlCommand command = new SqlCommand(query, conn);
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType, bankNum, branchNum, accountNum) " +
                "VALUES (@eID,@eName,@startDate,@eType,@bankNum,@branchNum,@accountNum)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Value.ToString());
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@bankNum", bankNumTextBox.Text);
                    command.Parameters.AddWithValue("@branchNum", branchNumTextBox.Text);
                    command.Parameters.AddWithValue("@accountNum", accountNumTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);

                    //   string query1 =
                    //"INSERT INTO Worker ( eID, confNumber, wType) " +
                    //"VALUES(\'" + eIDTextBox.Text + "\', \'" + confNumTextBox.Text + "\', \'" + wTypeComboBox.SelectedItem.ToString() + "\');";

                    //   SqlCommand command1 = new SqlCommand(query, conn);
                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Worker ( eID, confNumber, wType) " +
                   "VALUES (@eID,@confNumber,@wType)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@confNumber", confNumTextBox.Text);
                    command1.Parameters.AddWithValue("@wType", wTypeComboBox.SelectedItem.ToString());
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
                else
                {
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Employee ( eID, eName, startDate, eType) " +
                "VALUES (@eID,@eName,@startDate,@eType)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command.Parameters.AddWithValue("@eName", eNameTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", startWorkingDatePicker.Value.ToString());
                    command.Parameters.AddWithValue("@eType", eTypeCombo.SelectedItem.ToString());
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    SqlCommand command1 = new SqlCommand("", conn);
                    command1.CommandText =
                   "INSERT INTO Worker ( eID, confNumber, wType) " +
                   "VALUES (@eID,@confNumber,@wType)";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@eID", eIDTextBox.Text);
                    command1.Parameters.AddWithValue("@confNumber", confNumTextBox.Text);
                    command1.Parameters.AddWithValue("@wType", wTypeComboBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.employeeTableAdapter.Fill(this.tesodotDataSet.Employee);
                }
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
            update_employeeTables();
        }

        private void sumbitCusCreateButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (cIDTextBox.Text != "" && cTypeComboBox.SelectedItem.ToString() != "" && cNameTextBox.Text != "" && cStreetTextBox.Text != "" && 
                cSNumTextBox.Text != "" && cCityTextBox.Text != "" && cPhoneNumTextBox.Text != "") 
            {
                //string query =
                // "INSERT INTO Customer ( cID, cType, cName, cStreet, cSNum, cCity, phoneNumber) " +
                // "VALUES(\'" + cIDTextBox.Text + "\', \'" + cTypeComboBox.Text + "\', \'" + cNameTextBox.Text + "', \'" + cStreetTextBox.Text + "', " +
                // "\'" + cSNumTextBox.Text + "',  \'" + cCityTextBox.Text + "', \'" + cPhoneNumTextBox.Text + "');";


                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "INSERT INTO Customer ( cID, cType, cName, cStreet, cSNum, cCity, phoneNumber) VALUES (@cID,@cType,@cName,@cStreet,@cSNum,@cCity,@phoneNumber)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@cID", cIDTextBox.Text);
                command.Parameters.AddWithValue("@cType", cTypeComboBox.Text);
                command.Parameters.AddWithValue("@cName", cNameTextBox.Text);
                command.Parameters.AddWithValue("@cStreet", cStreetTextBox.Text);
                command.Parameters.AddWithValue("@cSNum", cSNumTextBox.Text);
                command.Parameters.AddWithValue("@cCity", cCityTextBox.Text);
                command.Parameters.AddWithValue("@phoneNumber", cPhoneNumTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                this.customerTableAdapter.Fill(this.tesodotDataSet.Customer);

            }
            else
            {
                string message = "לא כל השדות הדרושים ליצירת לקוח חדש הוכנסו";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
            update_cusTables();
        }

        private void incomeSumbitButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (iPayDateTimePicker.Text == "" || iPayMethodComboBox.Text == "" || iAmountTextBox.Text == "" || iProjNameComboBox.Text == "")
            {
                string message = "לא הוכנסו כל הפרטים הדרושים להוספת הכנסה חדשה.";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string query =
                // "INSERT INTO Payments ( paymentDate, pMethod, amout) " +
                // "VALUES(\'" + iPayDateTimePicker.Text + "\', \'" + iPayMethodComboBox.Text + "\', \'" + iAmountTextBox.Text + "');";

                //SqlCommand command = new SqlCommand(query, conn);

                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "INSERT INTO Payments ( paymentDate, pMethod, amout) VALUES (@paymentDate,@pMethod,@amout)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@paymentDate", iPayDateTimePicker.Text);
                command.Parameters.AddWithValue("@pMethod", iPayMethodComboBox.Text);
                command.Parameters.AddWithValue("@amout", iAmountTextBox.Text);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter oDa = new SqlDataAdapter("select * from Payments", conn);
                DataSet ds = new DataSet();
                oDa.Fill(ds);
                DataRow dr = (DataRow)ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
                string paymentIDNum = dr[0].ToString();

                //   string query1 =
                //"INSERT INTO incomes ( paymentDate, pMethod, amout, projID) " +
                //"VALUES(\'" + iPayDateTimePicker.Text + "\', \'" + iPayMethodComboBox.Text + "\', \'" + iAmountTextBox.Text + "', \'" + iProjNameComboBox.ValueMember.ToString() + "');";

                //   SqlCommand command1 = new SqlCommand(query, conn);


                SqlCommand command1 = new SqlCommand("", conn);

                command1.CommandText =
            "SET IDENTITY_INSERT incomes ON INSERT INTO incomes ( paymentID, paymentDate, pMethod, amout, projID) VALUES (@paymentID,@paymentDate,@pMethod,@amout,@projID) SET IDENTITY_INSERT incomes OFF";
                command1.Parameters.Clear();
                command1.Parameters.AddWithValue("@paymentID", paymentIDNum);
                command1.Parameters.AddWithValue("@paymentDate", iPayDateTimePicker.Text);
                command1.Parameters.AddWithValue("@pMethod", iPayMethodComboBox.Text);
                command1.Parameters.AddWithValue("@amout", iAmountTextBox.Text);
                command1.Parameters.AddWithValue("@projID", iProjNameComboBox.SelectedValue.ToString()); 
                conn.Open();
                command1.ExecuteNonQuery();
                conn.Close();
                this.incomesTableAdapter.Fill(this.tesodotDataSet.incomes);
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
            update_incomeTable();
        }

        private void expenseSumbitButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (ePayDatePicker.Text == "" || eMethodComboBox.Text == "" || eAmountTextBox.Text == "")
            {
                string message = "לא הוכנסו כל הפרטים הדרושים להוספת הוצאה חדשה ";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else if (eReasonComboBox.Text == "")
            {
                string message = "לא הוכנסה סיבת ההוצאה";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else if (eReasonComboBox.Text == "אחר")
            {
                if (eDiscriptionTextBox.Text == "")
                {
                    string message = "לא הוכנס תיאור עבור הוצאה";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else
                {
                    //   string query =
                    //"INSERT INTO Payments ( paymentDate, pMethod, amout) " +
                    //"VALUES(\'" + ePayDatePicker.Text + "\', \'" + eMethodComboBox.Text + "\', \'" + eAmountTextBox.Text + "');";

                    //   SqlCommand command = new SqlCommand(query, conn);
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Payments ( paymentDate, pMethod, amout) VALUES (@paymentDate,@pMethod,@amout)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@paymentDate", ePayDatePicker.Text);
                    command.Parameters.AddWithValue("@pMethod", eMethodComboBox.Text);
                    command.Parameters.AddWithValue("@amout", eAmountTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    //   string query1 =
                    //"INSERT INTO expenses ( paymentDate, pMethod, amout, exType, other) " +
                    //"VALUES(\'" + ePayDatePicker.Text + "\', \'" + eMethodComboBox.Text + "\', \'" + eAmountTextBox.Text + "', \'" + eReasonComboBox.Text + "', " +
                    //"\'" + eDiscriptionTextBox.Text + "');";

                    //   SqlCommand command1 = new SqlCommand(query, conn);

                    SqlDataAdapter oDa = new SqlDataAdapter("select * from Payments", conn);
                    DataSet ds = new DataSet();
                    oDa.Fill(ds);
                    DataRow dr = (DataRow)ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
                    string paymentIDNum = dr[0].ToString();

                    SqlCommand command1 = new SqlCommand("", conn);

                    command1.CommandText =
                "SET IDENTITY_INSERT expenses ON INSERT INTO expenses ( paymentID, paymentDate, pMethod, amout, exType, other) VALUES (@paymentID,@paymentDate,@pMethod,@amout,@exType,@other) SET IDENTITY_INSERT expenses OFF";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@paymentID", paymentIDNum);
                    command1.Parameters.AddWithValue("@paymentDate", ePayDatePicker.Text);
                    command1.Parameters.AddWithValue("@pMethod", eMethodComboBox.Text);
                    command1.Parameters.AddWithValue("@amout", eAmountTextBox.Text);
                    command1.Parameters.AddWithValue("@exType", eReasonComboBox.Text);
                    command1.Parameters.AddWithValue("@other", eDiscriptionTextBox.Text);
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.expensesTableAdapter.Fill(this.tesodotDataSet.expenses);
                    expensesDataGridView.Update();
                    expensesDataGridView.Refresh();
                }
            }
            else if (eReasonComboBox.Text == "משכורת")
            {
                if (eENameComboBox.Text == "")
                {
                    string message = "לא נבחר עובד עבור הוצאה";
                    string title = "שגיאה";
                    MessageBox.Show(message, title);
                }
                else
                {
                    SqlCommand command = new SqlCommand("", conn);

                    command.CommandText =
                "INSERT INTO Payments ( paymentDate, pMethod, amout) VALUES (@paymentDate,@pMethod,@amout)";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@paymentDate", ePayDatePicker.Text);
                    command.Parameters.AddWithValue("@pMethod", eMethodComboBox.Text);
                    command.Parameters.AddWithValue("@amout", eAmountTextBox.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    //   string query1 =
                    //"INSERT INTO expenses ( paymentDate, pMethod, amout, exType, eID) " +
                    //"VALUES(\'" + ePayDatePicker.Text + "\', \'" + eMethodComboBox.Text + "\', \'" + eAmountTextBox.Text + "', \'" + eReasonComboBox.Text + "', " +
                    //"\'" + eENameComboBox.ValueMember.ToString() + "');";

                    //   SqlCommand command1 = new SqlCommand(query, conn);

                    SqlDataAdapter oDa = new SqlDataAdapter("select * from Payments", conn);
                    DataSet ds = new DataSet();
                    oDa.Fill(ds);
                    DataRow dr = (DataRow)ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
                    string paymentIDNum = dr[0].ToString();

                    SqlCommand command1 = new SqlCommand("", conn);

                    command1.CommandText =
                "SET IDENTITY_INSERT expenses ON INSERT INTO expenses ( paymentID, paymentDate, pMethod, amout, exType, eID) VALUES (@paymentID,@paymentDate,@pMethod,@amout,@exType,@eID) SET IDENTITY_INSERT expenses OFF";
                    command1.Parameters.Clear();
                    command1.Parameters.AddWithValue("@paymentID", paymentIDNum);
                    command1.Parameters.AddWithValue("@paymentDate", ePayDatePicker.Text);
                    command1.Parameters.AddWithValue("@pMethod", eMethodComboBox.Text);
                    command1.Parameters.AddWithValue("@amout", eAmountTextBox.Text);
                    command1.Parameters.AddWithValue("@exType", eReasonComboBox.Text);
                    command1.Parameters.AddWithValue("@eID", eENameComboBox.SelectedValue.ToString());
                    conn.Open();
                    command1.ExecuteNonQuery();
                    conn.Close();
                    this.expensesTableAdapter.Fill(this.tesodotDataSet.expenses);
                }
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
            update_expensesTable();
        }

        private void projCusAssignSaveButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (projNameAssignComboBox.Text == "" || cusNameAssignComboBox.Text == "")
            {
                string message = "לא נבחרו כל הפרטים על מנת לשייך פרויקט ללקוח";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string query =
                // "INSERT INTO proj_of_customer ( projID, cID) " +
                // "VALUES(\'" + projNameAssignComboBox.ValueMember.ToString() + "\', \'" + cusNameAssignComboBox.ValueMember.ToString() + "\');";

                //SqlCommand command = new SqlCommand(query, conn);
                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "SET IDENTITY_INSERT proj_of_customer ON INSERT INTO proj_of_customer ( projID, cID) VALUES (@projID,@cID) SET IDENTITY_INSERT proj_of_customer OFF";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@projID", projNameAssignComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@cID", cusNameAssignComboBox.SelectedValue.ToString());
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
        }

        private void projWorkerAssignButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            if (projWorkerAssignComboBox.Text == "" || workerProjAssignComboBox.Text == "")
            {
                string message = "לא נבחרו כל הפרטים על מנת לשייך עובד לפרויקט";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string query =
                // "INSERT INTO works_on_proj ( projID, eID) " +
                // "VALUES(\'" + projWorkerAssignComboBox.ValueMember.ToString() + "\', \'" + workerProjAssignComboBox.ValueMember.ToString() + "\');";

                //SqlCommand command = new SqlCommand(query, conn);
                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "SET IDENTITY_INSERT works_on_proj ON INSERT INTO works_on_proj ( projID, eID) VALUES (@projID,@eID) SET IDENTITY_INSERT works_on_proj OFF";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@projID", projWorkerAssignComboBox.SelectedValue.ToString());
                command.Parameters.AddWithValue("@eID", workerProjAssignComboBox.SelectedValue.ToString());
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
        }

        private void applyAddWorkerTypeButt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30"; SqlConnection conn = new SqlConnection(connectionString);

            if (workerTypeTextBox.Text == "" || paymentPriceTextBox.Text == "")
            {
                string message = "לא הוכנסו כל הפרטים על מנת להוסיף סוג עובד וסכום";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string query =
                // "INSERT INTO Worker_type ( wType, fee) " +
                // "VALUES(\'" + workerTypeTextBox.Text + "\', \'" + paymentPriceTextBox.Text + "\');";

                //SqlCommand command = new SqlCommand(query, conn);
                SqlCommand command = new SqlCommand("", conn);

                command.CommandText =
            "INSERT INTO Worker_type ( wType, fee) VALUES (@wType,@fee)";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@wType", workerTypeTextBox.Text);
                command.Parameters.AddWithValue("@fee", paymentPriceTextBox.Text);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                this.worker_typeTableAdapter.Fill(this.tesodotDataSet.Worker_type);
            }
            update_workerTypeTable();
            string message1 = "כל הפרטים הוכנסו בהצלחה";
            string title1 = "הודעה";
            MessageBox.Show(message1, title1);
        }

        private void eENameComboBox_TextChanged(object sender, EventArgs e)
        {
            eAmountTextBox.Text = "";
            if (eENameComboBox.SelectedValue != null)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                string query =
                     "SELECT fee" +
                     " FROM Worker_type" +
                     " INNER JOIN Worker ON Worker_type.wType = Worker.wType" +
                     " WHERE Worker.eID = \'" + eENameComboBox.SelectedValue.ToString() + "\'";

                SqlCommand command = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string amount = dataReader.GetSqlMoney(0).ToString();
                    eAmountTextBox.Text = amount;
                    break;

                }
                dataReader.Close();
                conn.Close();
            }

            //int eID = Convert.ToInt32(eENameComboBox.SelectedValue);

            //DataView dataView1 = new DataView(tesodotDataSet.Worker);
            //dataView1.RowFilter = string.Format("eID = '%{0}%'", eID);
            //DataGridView data1 = new DataGridView();
            //data1.DataSource = dataView1;
            //if (data1.Rows[0].Cells[2].Value.ToString() == null)
            //{

            //}
            //else
            //{
            //    string typeR = data1.Rows[0].Cells[2].Value.ToString();
            //    DataView dataView = new DataView(tesodotDataSet.Worker_type);
            //    dataView.RowFilter = string.Format("wType = '%{0}%'", typeR);
            //    DataGridView data = new DataGridView();
            //    data.DataSource = dataView;
            //    eAmountTextBox.Text = data.Rows[0].Cells[2].Value.ToString();
            //}
        }

        private void searchProjNameButt_Click(object sender, EventArgs e)
        {
            if (searchByProjNameTextBox.Text == "")
            {
                string message = "אנא הכנס פרטים לשדה החיפוש";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=R:\First Digree\Third year\First Simester\Project\Step 4\Project1\Project1\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                //SqlConnection conn = new SqlConnection(connectionString);
                //string query =
                //     "SELECT *" +
                //     "FROM Project" +
                //     "WHERE Project.projName = \'" + searchByProjNameTextBox.Text + "\'";
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                //DataSet ds = new DataSet();
                //dataAdapter.Fill(ds);
                //searchByProjNameDataGridView.ReadOnly = true;
                //searchByProjNameDataGridView.DataSource = ds.Tables[0];

                DataView dataView = new DataView(tesodotDataSet.Project);
                dataView.RowFilter = string.Format("projName like '%{0}%'", searchByProjNameTextBox.Text);
                searchByProjNameDataGridView.DataSource = dataView;
            }
        }

        private void searchWorkersInProjButt_Click(object sender, EventArgs e)
        {
            if (searchWorkersInProjComboBox.Text == "")
            {
                string message = "אנא הכנס פרטים לשדה החיפוש";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                string query =
                    "SELECT Employee.eID, Employee.eName, Employee.startDate, Employee.eType" +
                    " FROM Employee" +
                    " INNER JOIN works_on_proj ON Employee.eID = works_on_proj.eID" +
                    " WHERE works_on_proj.projID = \'" + searchWorkersInProjComboBox.SelectedValue.ToString() + "\'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                searchWorkerByProjDataGridView.ReadOnly = true;
                searchWorkerByProjDataGridView.DataSource = ds.Tables[0];
            }
        }

        private void searchCusButt_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            if (cusSearchTextBox.Text == "")
            {
                string message = "אנא הכנס פרטים לשדה החיפוש";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=R:\First Digree\Third year\First Simester\Project\Step 4\Project1\Project1\tesodot.mdf;Integrated Security=True;Connect Timeout=30";

                //SqlConnection conn = new SqlConnection(connectionString);
                //string query =
                //     "SELECT *" +
                //     "FROM Customer" +
                //     "WHERE Customer.cName like %\'" + cusSearchTextBox.Text + "\'%";
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                //DataSet ds = new DataSet();
                //dataAdapter.Fill(ds);
                //searchCusByNameDataGridView.ReadOnly = true;
                //searchCusByNameDataGridView.DataSource = ds.Tables[0];
                DataView dataView = new DataView(tesodotDataSet.Customer);
                dataView.RowFilter = string.Format("cName like '%{0}%'", cusSearchTextBox.Text);
                searchCusByNameDataGridView.DataSource = dataView;

            }
        }

        private void cusProjSearchButt_Click(object sender, EventArgs e)
        {
            if (cusProjSearchComboBox.Text == "")
            {
                string message = "אנא הכנס פרטים לשדה החיפוש";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conn = new SqlConnection(connectionString);
                string query =
                    "SELECT * " +
                    "FROM Project " +
                    "INNER JOIN proj_of_customer ON Project.projID = proj_of_customer.projID" +
                    " WHERE proj_of_customer.cID = \'" + cusProjSearchComboBox.SelectedValue.ToString() + "\'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                searchProjByCusDataGridView.ReadOnly = true;
                searchProjByCusDataGridView.DataSource = ds.Tables[0];
                //DataView dataView = new DataView(tesodotDataSet.Project);
                //dataView.RowFilter = string.Format(query);
                //searchProjByCusDataGridView.DataSource = dataView;
            }
        }

        private void searchButtByProjPayment_Click(object sender, EventArgs e)
        {
            if (searchByProjPaymentComboBox.Text == "")
            {
                string message = "אנא הכנס פרטים לשדה החיפוש";
                string title = "שגיאה";
                MessageBox.Show(message, title);
            }
            else
            {
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=R:\First Digree\Third year\First Simester\Project\Step 4\Project1\Project1\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                //SqlConnection conn = new SqlConnection(connectionString);
                //string query =
                //    "SELECT *" +
                //    "FROM incomes" +
                //    "WHERE incomes.projID = \'" + searchByProjPaymentComboBox.ValueMember.ToString() + "\'";
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                //SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                //DataSet ds = new DataSet();
                //dataAdapter.Fill(ds);
                //searchProjByCusDataGridView.ReadOnly = true;
                //searchProjByCusDataGridView.DataSource = ds.Tables[0];

                DataView dataView = new DataView(tesodotDataSet.incomes);
                dataView.RowFilter = string.Format("projID = " + searchByProjPaymentComboBox.SelectedValue.ToString());
                projIncomesDataGridView.DataSource = dataView;
            }
        }

        private void showYearBalanceButt_Click(object sender, EventArgs e)
        {
            totalIncomeLable.Text = "סה\"כ הכנסות כולל: ";
            totalExpanceLable.Text = "סה\"כ הוצאות כולל: ";
            totalBalanceLable.Text = "סה\"כ מאזן כולל: ";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT *" +
                 " FROM incomes" +
                 " WHERE year(incomes.paymentDate) = \'" + yearBalancePicker.Text + "\'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            incomesDataGridView.ReadOnly = true;
            incomesDataGridView.DataSource = ds.Tables[0];

            string query1 =
                 "SELECT *" +
                 " FROM expenses" +
                 " WHERE year(expenses.paymentDate) = \'" + yearBalancePicker.Text + "\'";

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(query1, conn);
            SqlCommandBuilder commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            DataSet ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            expensesDataGridView.ReadOnly = true;
            expensesDataGridView.DataSource = ds1.Tables[0];

            //DataView dataView = new DataView(tesodotDataSet.incomes);
            //dataView.RowFilter = string.Format("year(paymentDate) = '%{0}%'", yearBalancePicker.Text);
            //incomesDataGridView.DataSource = dataView;

            //DataView dataView1 = new DataView(tesodotDataSet.expenses);
            //dataView1.RowFilter = string.Format("year(paymentDate) = '%{0}%'", yearBalancePicker.Text);
            //expensesDataGridView.DataSource = dataView1;

            double sum = 0.0;
            for (int i = 0; i < incomesDataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(incomesDataGridView.Rows[i].Cells[3].Value);
            }
            totalIncomeLable.Text += sum.ToString();

            double sum1 = 0.0;
            for (int i = 0; i < expensesDataGridView.Rows.Count; ++i)
            {
                sum1 += Convert.ToDouble(expensesDataGridView.Rows[i].Cells[3].Value);
            }
            sum1 = sum1 * -1.0;
            totalExpanceLable.Text += sum1.ToString();

            double total = sum + sum1;
            totalBalanceLable.Text += total.ToString();
        }

        #endregion

        #region updates 

        public void update_projTables()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT projID, projState, projName, startDate, etaDate, contactName, contactTel, archName, archTel, inspName, inspTel, insurPolicy, archPlanPath, agreementPath" +
                 " FROM Project";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            allProjGridView.ReadOnly = true;
            allProjGridView.DataSource = ds.Tables[0];

            searchByProjNameDataGridView.ReadOnly = true;
            searchByProjNameDataGridView.DataSource = ds.Tables[0];

            searchProjByCusDataGridView.ReadOnly = true;
            searchProjByCusDataGridView.DataSource = ds.Tables[0];

            projNameAssignComboBox.DataSource = ds.Tables[0];
            searchWorkersInProjComboBox.DataSource = ds.Tables[0];
            projWorkerAssignComboBox.DataSource = ds.Tables[0];
            iProjNameComboBox.DataSource = ds.Tables[0];
            searchByProjPaymentComboBox.DataSource = ds.Tables[0];
        }

        public void update_employeeTables()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT eID, eName, startDate, eType, bankNum, branchNum, accountNum" +
                 " FROM Employee";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.DataSource = ds.Tables[0];

            searchWorkerByProjDataGridView.ReadOnly = true;
            searchWorkerByProjDataGridView.DataSource = ds.Tables[0];

            workerProjAssignComboBox.DataSource = ds.Tables[0];
            eENameComboBox.DataSource = ds.Tables[0];
        }

        public void update_cusTables()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT cID, cType, cName, cStreet, cSNum, cCity, phoneNumber" +
                 " FROM Customer";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            customerDataGridView.ReadOnly = true;
            customerDataGridView.DataSource = ds.Tables[0];

            cusNameAssignComboBox.DataSource = ds.Tables[0];
            cusProjSearchComboBox.DataSource = ds.Tables[0];
        }

        public void update_incomeTable()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT paymentID, paymentDate, pMethod, amout, projID" +
                 " FROM incomes";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            incomesDataGridView.ReadOnly = true;
            incomesDataGridView.DataSource = ds.Tables[0];

            projIncomesDataGridView.ReadOnly = true;
            projIncomesDataGridView.DataSource = ds.Tables[0];

            totalIncomeLable.Text = "סה\"כ הכנסות כולל: ";
            totalExpanceLable.Text = "סה\"כ הוצאות כולל: ";
            totalBalanceLable.Text = "סה\"כ מאזן כולל: ";

            double sum = 0.0;
            for (int i = 0; i < incomesDataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(incomesDataGridView.Rows[i].Cells[3].Value);
            }
            totalIncomeLable.Text += sum.ToString();

            double sum1 = 0.0;
            for (int i = 0; i < expensesDataGridView.Rows.Count; ++i)
            {
                sum1 += Convert.ToDouble(expensesDataGridView.Rows[i].Cells[3].Value);
            }
            sum1 = sum1 * -1.0;
            totalExpanceLable.Text += sum1.ToString();

            double total = sum + sum1;
            totalBalanceLable.Text += total.ToString();
        }

        public void update_expensesTable()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT paymentID, paymentDate, pMethod, amout, exType, eID, other" +
                 " FROM expenses";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            expensesDataGridView.ReadOnly = true;
            expensesDataGridView.DataSource = ds.Tables[0];

            totalIncomeLable.Text = "סה\"כ הכנסות כולל: ";
            totalExpanceLable.Text = "סה\"כ הוצאות כולל: ";
            totalBalanceLable.Text = "סה\"כ מאזן כולל: ";

            double sum = 0.0;
            for (int i = 0; i < incomesDataGridView.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(incomesDataGridView.Rows[i].Cells[3].Value);
            }
            totalIncomeLable.Text += sum.ToString();

            double sum1 = 0.0;
            for (int i = 0; i < expensesDataGridView.Rows.Count; ++i)
            {
                sum1 += Convert.ToDouble(expensesDataGridView.Rows[i].Cells[3].Value);
            }
            sum1 = sum1 * -1.0;
            totalExpanceLable.Text += sum1.ToString();

            double total = sum + sum1;
            totalBalanceLable.Text += total.ToString();
        }

        public void update_workerTypeTable()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "SELECT wType, fee" +
                 " FROM Worker_type";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            wTypeComboBox.DataSource = ds.Tables[0];
        }

        private void projIsLate()
        {
            foreach (DataGridViewRow row in allProjGridView.Rows)
            {
                if ((DateTime)row.Cells[4].Value < DateTime.Now)
                {
                    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection conn = new SqlConnection(connectionString);
                    string state = "בעיכוב";
                    string query =
                         "UPDATE Project" +
                         " SET projState = N\'" + state + "\'" +
                         " WHERE projID = \'" + row.Cells[0].Value.ToString() + "\'";

                    SqlCommand command = new SqlCommand(query, conn);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    update_projTables();
                }
            }
        }

        private void allProjGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = allProjGridView.CurrentCell.RowIndex;
            int columnindex = allProjGridView.CurrentCell.ColumnIndex;

            if (columnindex == 12)
            {
                string filepath = (string)allProjGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }
            else if (columnindex == 13)
            {
                string filepath = (string)allProjGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }

        }

        private void allProjGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);

                // Add the event handler. 
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowindex = allProjGridView.CurrentCell.RowIndex;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30"; SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "UPDATE Project" +
                 " SET projState = N\'" + allProjGridView.Rows[rowindex].Cells[1].EditedFormattedValue.ToString() + "\'" +
                 " WHERE projID = \'" + allProjGridView.Rows[rowindex].Cells[0].Value.ToString() + "\'";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            update_projTables();
        }

        private void searchByProjNameDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = searchByProjNameDataGridView.CurrentCell.RowIndex;
            int columnindex = searchByProjNameDataGridView.CurrentCell.ColumnIndex;

            if (columnindex == 12)
            {
                string filepath = (string)searchByProjNameDataGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }
            else if (columnindex == 13)
            {
                string filepath = (string)searchByProjNameDataGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }
        }

        private void searchByProjNameDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged1);

                // Add the event handler. 
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged1);
            }
        }

        private void ComboBox_SelectedIndexChanged1(object sender, EventArgs e)
        {
            int rowindex = searchByProjNameDataGridView.CurrentCell.RowIndex;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "UPDATE Project" +
                 " SET projState = N\'" + searchByProjNameDataGridView.Rows[rowindex].Cells[1].EditedFormattedValue.ToString() + "\'" +
                 " WHERE projID = \'" + searchByProjNameDataGridView.Rows[rowindex].Cells[0].Value.ToString() + "\'";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            update_projTables();
        }

        private void searchProjByCusDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = searchProjByCusDataGridView.CurrentCell.RowIndex;
            int columnindex = searchProjByCusDataGridView.CurrentCell.ColumnIndex;

            if (columnindex == 12)
            {
                string filepath = (string)searchProjByCusDataGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }
            else if (columnindex == 13)
            {
                string filepath = (string)searchProjByCusDataGridView.Rows[rowindex].Cells[columnindex].Value;
                System.Diagnostics.Process.Start(filepath);
            }
        }

        private void searchProjByCusDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged2);

                // Add the event handler. 
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged2);
            }
        }

        private void ComboBox_SelectedIndexChanged2(object sender, EventArgs e)
        {
            int rowindex = searchByProjNameDataGridView.CurrentCell.RowIndex;

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tesodot.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);

            string query =
                 "UPDATE Project" +
                 " SET projState = N\'" + searchProjByCusDataGridView.Rows[rowindex].Cells[1].EditedFormattedValue.ToString() + "\'" +
                 " WHERE projID = \'" + searchProjByCusDataGridView.Rows[rowindex].Cells[0].Value.ToString() + "\'";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();

            update_projTables();
        }

        #endregion


    }
}
