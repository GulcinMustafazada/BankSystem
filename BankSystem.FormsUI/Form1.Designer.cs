
namespace BankSystem.FormsUI
{
    partial class Form1
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
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxCustomerCodeUpdate = new System.Windows.Forms.TextBox();
            this.lblCustomerCodeUpdate = new System.Windows.Forms.Label();
            this.tbxMoneyUpdate = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.tbxAddressUpdate = new System.Windows.Forms.TextBox();
            this.tbxAgeUpdate = new System.Windows.Forms.TextBox();
            this.tbxLastNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxFirstNameUpdate = new System.Windows.Forms.TextBox();
            this.lblMoneyUpdate = new System.Windows.Forms.Label();
            this.lblPhoneNumberUpdate = new System.Windows.Forms.Label();
            this.lblAddressUpdate = new System.Windows.Forms.Label();
            this.lblAgeUpdate = new System.Windows.Forms.Label();
            this.lblLastNameUpdate = new System.Windows.Forms.Label();
            this.lblFirstNameUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCustomerCodeAdd = new System.Windows.Forms.TextBox();
            this.lblCustomerCodeAdd = new System.Windows.Forms.Label();
            this.tbxMoneyAdd = new System.Windows.Forms.TextBox();
            this.tbxPhoneNumberAdd = new System.Windows.Forms.TextBox();
            this.tbxAddressAdd = new System.Windows.Forms.TextBox();
            this.tbxAgeAdd = new System.Windows.Forms.TextBox();
            this.tbxLastNameAdd = new System.Windows.Forms.TextBox();
            this.tbxFirstNameAdd = new System.Windows.Forms.TextBox();
            this.lblMoneyAdd = new System.Windows.Forms.Label();
            this.lblPhoneNumberAdd = new System.Windows.Forms.Label();
            this.lblAddressAdd = new System.Windows.Forms.Label();
            this.lblAgeAdd = new System.Windows.Forms.Label();
            this.lblLastNameAdd = new System.Windows.Forms.Label();
            this.lblFirstNameAdd = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxCustomerCodeSearch = new System.Windows.Forms.TextBox();
            this.lblCustomerCodeSearch = new System.Windows.Forms.Label();
            this.tbxPhoneNumberSearch = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberSearch = new System.Windows.Forms.Label();
            this.tbxAddressSearch = new System.Windows.Forms.TextBox();
            this.lblAddressSearch = new System.Windows.Forms.Label();
            this.tbxLastNameSearch = new System.Windows.Forms.TextBox();
            this.lblLastNameSearch = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tbxFirstNameSearch = new System.Windows.Forms.TextBox();
            this.lblFirstNameSearch = new System.Windows.Forms.Label();
            this.gbxByAge = new System.Windows.Forms.GroupBox();
            this.lblByAgeMin = new System.Windows.Forms.Label();
            this.tbxByAgeMin = new System.Windows.Forms.TextBox();
            this.lblByAgeMax = new System.Windows.Forms.Label();
            this.tbxByAgeMax = new System.Windows.Forms.TextBox();
            this.gbxByMoney = new System.Windows.Forms.GroupBox();
            this.lblByMoneyMin = new System.Windows.Forms.Label();
            this.tbxByMoneyMin = new System.Windows.Forms.TextBox();
            this.lblByMoneyMax = new System.Windows.Forms.Label();
            this.tbxByMoneyMax = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxByAge.SuspendLayout();
            this.gbxByMoney.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgwCustomers.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgwCustomers.Location = new System.Drawing.Point(113, 4);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.Size = new System.Drawing.Size(843, 147);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomers_CellClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxCrud.Controls.Add(this.btnDelete);
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxCrud.Location = new System.Drawing.Point(12, 157);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(661, 413);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "Crud";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(272, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCustomerCodeUpdate);
            this.gbxUpdate.Controls.Add(this.lblCustomerCodeUpdate);
            this.gbxUpdate.Controls.Add(this.tbxMoneyUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAddressUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAgeUpdate);
            this.gbxUpdate.Controls.Add(this.tbxLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFirstNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblMoneyUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblAddressUpdate);
            this.gbxUpdate.Controls.Add(this.lblAgeUpdate);
            this.gbxUpdate.Controls.Add(this.lblLastNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblFirstNameUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxUpdate.Location = new System.Drawing.Point(342, 28);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(295, 303);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(102, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxCustomerCodeUpdate
            // 
            this.tbxCustomerCodeUpdate.Location = new System.Drawing.Point(143, 227);
            this.tbxCustomerCodeUpdate.Name = "tbxCustomerCodeUpdate";
            this.tbxCustomerCodeUpdate.Size = new System.Drawing.Size(100, 27);
            this.tbxCustomerCodeUpdate.TabIndex = 14;
            // 
            // lblCustomerCodeUpdate
            // 
            this.lblCustomerCodeUpdate.AutoSize = true;
            this.lblCustomerCodeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerCodeUpdate.Location = new System.Drawing.Point(5, 230);
            this.lblCustomerCodeUpdate.Name = "lblCustomerCodeUpdate";
            this.lblCustomerCodeUpdate.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerCodeUpdate.TabIndex = 13;
            this.lblCustomerCodeUpdate.Text = "Customer Code";
            // 
            // tbxMoneyUpdate
            // 
            this.tbxMoneyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxMoneyUpdate.Location = new System.Drawing.Point(143, 195);
            this.tbxMoneyUpdate.Name = "tbxMoneyUpdate";
            this.tbxMoneyUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxMoneyUpdate.TabIndex = 12;
            // 
            // tbxPhoneNumberUpdate
            // 
            this.tbxPhoneNumberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPhoneNumberUpdate.Location = new System.Drawing.Point(143, 163);
            this.tbxPhoneNumberUpdate.Name = "tbxPhoneNumberUpdate";
            this.tbxPhoneNumberUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxPhoneNumberUpdate.TabIndex = 11;
            // 
            // tbxAddressUpdate
            // 
            this.tbxAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddressUpdate.Location = new System.Drawing.Point(143, 131);
            this.tbxAddressUpdate.Name = "tbxAddressUpdate";
            this.tbxAddressUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxAddressUpdate.TabIndex = 10;
            // 
            // tbxAgeUpdate
            // 
            this.tbxAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAgeUpdate.Location = new System.Drawing.Point(143, 100);
            this.tbxAgeUpdate.Name = "tbxAgeUpdate";
            this.tbxAgeUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxAgeUpdate.TabIndex = 9;
            // 
            // tbxLastNameUpdate
            // 
            this.tbxLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNameUpdate.Location = new System.Drawing.Point(143, 64);
            this.tbxLastNameUpdate.Name = "tbxLastNameUpdate";
            this.tbxLastNameUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxLastNameUpdate.TabIndex = 8;
            // 
            // tbxFirstNameUpdate
            // 
            this.tbxFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameUpdate.Location = new System.Drawing.Point(143, 32);
            this.tbxFirstNameUpdate.Name = "tbxFirstNameUpdate";
            this.tbxFirstNameUpdate.Size = new System.Drawing.Size(100, 26);
            this.tbxFirstNameUpdate.TabIndex = 7;
            // 
            // lblMoneyUpdate
            // 
            this.lblMoneyUpdate.AutoSize = true;
            this.lblMoneyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoneyUpdate.Location = new System.Drawing.Point(6, 196);
            this.lblMoneyUpdate.Name = "lblMoneyUpdate";
            this.lblMoneyUpdate.Size = new System.Drawing.Size(56, 20);
            this.lblMoneyUpdate.TabIndex = 5;
            this.lblMoneyUpdate.Text = "Money";
            // 
            // lblPhoneNumberUpdate
            // 
            this.lblPhoneNumberUpdate.AutoSize = true;
            this.lblPhoneNumberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumberUpdate.Location = new System.Drawing.Point(5, 162);
            this.lblPhoneNumberUpdate.Name = "lblPhoneNumberUpdate";
            this.lblPhoneNumberUpdate.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNumberUpdate.TabIndex = 4;
            this.lblPhoneNumberUpdate.Text = "Phone Number";
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddressUpdate.Location = new System.Drawing.Point(6, 131);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(68, 20);
            this.lblAddressUpdate.TabIndex = 3;
            this.lblAddressUpdate.Text = "Address";
            // 
            // lblAgeUpdate
            // 
            this.lblAgeUpdate.AutoSize = true;
            this.lblAgeUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeUpdate.Location = new System.Drawing.Point(6, 100);
            this.lblAgeUpdate.Name = "lblAgeUpdate";
            this.lblAgeUpdate.Size = new System.Drawing.Size(38, 20);
            this.lblAgeUpdate.TabIndex = 2;
            this.lblAgeUpdate.Text = "Age";
            // 
            // lblLastNameUpdate
            // 
            this.lblLastNameUpdate.AutoSize = true;
            this.lblLastNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameUpdate.Location = new System.Drawing.Point(6, 70);
            this.lblLastNameUpdate.Name = "lblLastNameUpdate";
            this.lblLastNameUpdate.Size = new System.Drawing.Size(86, 20);
            this.lblLastNameUpdate.TabIndex = 1;
            this.lblLastNameUpdate.Text = "Last Name";
            // 
            // lblFirstNameUpdate
            // 
            this.lblFirstNameUpdate.AutoSize = true;
            this.lblFirstNameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameUpdate.Location = new System.Drawing.Point(6, 32);
            this.lblFirstNameUpdate.Name = "lblFirstNameUpdate";
            this.lblFirstNameUpdate.Size = new System.Drawing.Size(86, 20);
            this.lblFirstNameUpdate.TabIndex = 0;
            this.lblFirstNameUpdate.Text = "First Name";
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxCustomerCodeAdd);
            this.gbxAdd.Controls.Add(this.lblCustomerCodeAdd);
            this.gbxAdd.Controls.Add(this.tbxMoneyAdd);
            this.gbxAdd.Controls.Add(this.tbxPhoneNumberAdd);
            this.gbxAdd.Controls.Add(this.tbxAddressAdd);
            this.gbxAdd.Controls.Add(this.tbxAgeAdd);
            this.gbxAdd.Controls.Add(this.tbxLastNameAdd);
            this.gbxAdd.Controls.Add(this.tbxFirstNameAdd);
            this.gbxAdd.Controls.Add(this.lblMoneyAdd);
            this.gbxAdd.Controls.Add(this.lblPhoneNumberAdd);
            this.gbxAdd.Controls.Add(this.lblAddressAdd);
            this.gbxAdd.Controls.Add(this.lblAgeAdd);
            this.gbxAdd.Controls.Add(this.lblLastNameAdd);
            this.gbxAdd.Controls.Add(this.lblFirstNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxAdd.Location = new System.Drawing.Point(14, 28);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(295, 303);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(102, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxCustomerCodeAdd
            // 
            this.tbxCustomerCodeAdd.Location = new System.Drawing.Point(143, 227);
            this.tbxCustomerCodeAdd.Name = "tbxCustomerCodeAdd";
            this.tbxCustomerCodeAdd.Size = new System.Drawing.Size(100, 27);
            this.tbxCustomerCodeAdd.TabIndex = 14;
            // 
            // lblCustomerCodeAdd
            // 
            this.lblCustomerCodeAdd.AutoSize = true;
            this.lblCustomerCodeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerCodeAdd.Location = new System.Drawing.Point(5, 230);
            this.lblCustomerCodeAdd.Name = "lblCustomerCodeAdd";
            this.lblCustomerCodeAdd.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerCodeAdd.TabIndex = 13;
            this.lblCustomerCodeAdd.Text = "Customer Code";
            // 
            // tbxMoneyAdd
            // 
            this.tbxMoneyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxMoneyAdd.Location = new System.Drawing.Point(143, 195);
            this.tbxMoneyAdd.Name = "tbxMoneyAdd";
            this.tbxMoneyAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxMoneyAdd.TabIndex = 12;
            // 
            // tbxPhoneNumberAdd
            // 
            this.tbxPhoneNumberAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPhoneNumberAdd.Location = new System.Drawing.Point(143, 163);
            this.tbxPhoneNumberAdd.Name = "tbxPhoneNumberAdd";
            this.tbxPhoneNumberAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxPhoneNumberAdd.TabIndex = 11;
            // 
            // tbxAddressAdd
            // 
            this.tbxAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddressAdd.Location = new System.Drawing.Point(143, 131);
            this.tbxAddressAdd.Name = "tbxAddressAdd";
            this.tbxAddressAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxAddressAdd.TabIndex = 10;
            // 
            // tbxAgeAdd
            // 
            this.tbxAgeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAgeAdd.Location = new System.Drawing.Point(143, 100);
            this.tbxAgeAdd.Name = "tbxAgeAdd";
            this.tbxAgeAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxAgeAdd.TabIndex = 9;
            // 
            // tbxLastNameAdd
            // 
            this.tbxLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNameAdd.Location = new System.Drawing.Point(143, 64);
            this.tbxLastNameAdd.Name = "tbxLastNameAdd";
            this.tbxLastNameAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxLastNameAdd.TabIndex = 8;
            // 
            // tbxFirstNameAdd
            // 
            this.tbxFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameAdd.Location = new System.Drawing.Point(143, 32);
            this.tbxFirstNameAdd.Name = "tbxFirstNameAdd";
            this.tbxFirstNameAdd.Size = new System.Drawing.Size(100, 26);
            this.tbxFirstNameAdd.TabIndex = 7;
            // 
            // lblMoneyAdd
            // 
            this.lblMoneyAdd.AutoSize = true;
            this.lblMoneyAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoneyAdd.Location = new System.Drawing.Point(6, 196);
            this.lblMoneyAdd.Name = "lblMoneyAdd";
            this.lblMoneyAdd.Size = new System.Drawing.Size(56, 20);
            this.lblMoneyAdd.TabIndex = 5;
            this.lblMoneyAdd.Text = "Money";
            // 
            // lblPhoneNumberAdd
            // 
            this.lblPhoneNumberAdd.AutoSize = true;
            this.lblPhoneNumberAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumberAdd.Location = new System.Drawing.Point(5, 162);
            this.lblPhoneNumberAdd.Name = "lblPhoneNumberAdd";
            this.lblPhoneNumberAdd.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNumberAdd.TabIndex = 4;
            this.lblPhoneNumberAdd.Text = "Phone Number";
            // 
            // lblAddressAdd
            // 
            this.lblAddressAdd.AutoSize = true;
            this.lblAddressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddressAdd.Location = new System.Drawing.Point(6, 131);
            this.lblAddressAdd.Name = "lblAddressAdd";
            this.lblAddressAdd.Size = new System.Drawing.Size(68, 20);
            this.lblAddressAdd.TabIndex = 3;
            this.lblAddressAdd.Text = "Address";
            // 
            // lblAgeAdd
            // 
            this.lblAgeAdd.AutoSize = true;
            this.lblAgeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeAdd.Location = new System.Drawing.Point(6, 100);
            this.lblAgeAdd.Name = "lblAgeAdd";
            this.lblAgeAdd.Size = new System.Drawing.Size(38, 20);
            this.lblAgeAdd.TabIndex = 2;
            this.lblAgeAdd.Text = "Age";
            // 
            // lblLastNameAdd
            // 
            this.lblLastNameAdd.AutoSize = true;
            this.lblLastNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameAdd.Location = new System.Drawing.Point(6, 70);
            this.lblLastNameAdd.Name = "lblLastNameAdd";
            this.lblLastNameAdd.Size = new System.Drawing.Size(86, 20);
            this.lblLastNameAdd.TabIndex = 1;
            this.lblLastNameAdd.Text = "Last Name";
            // 
            // lblFirstNameAdd
            // 
            this.lblFirstNameAdd.AutoSize = true;
            this.lblFirstNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameAdd.Location = new System.Drawing.Point(6, 32);
            this.lblFirstNameAdd.Name = "lblFirstNameAdd";
            this.lblFirstNameAdd.Size = new System.Drawing.Size(86, 20);
            this.lblFirstNameAdd.TabIndex = 0;
            this.lblFirstNameAdd.Text = "First Name";
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxSearch.Controls.Add(this.gbxByMoney);
            this.gbxSearch.Controls.Add(this.gbxByAge);
            this.gbxSearch.Controls.Add(this.tbxCustomerCodeSearch);
            this.gbxSearch.Controls.Add(this.lblCustomerCodeSearch);
            this.gbxSearch.Controls.Add(this.tbxPhoneNumberSearch);
            this.gbxSearch.Controls.Add(this.lblPhoneNumberSearch);
            this.gbxSearch.Controls.Add(this.tbxAddressSearch);
            this.gbxSearch.Controls.Add(this.lblAddressSearch);
            this.gbxSearch.Controls.Add(this.tbxLastNameSearch);
            this.gbxSearch.Controls.Add(this.lblLastNameSearch);
            this.gbxSearch.Controls.Add(this.tbxId);
            this.gbxSearch.Controls.Add(this.lblId);
            this.gbxSearch.Controls.Add(this.tbxFirstNameSearch);
            this.gbxSearch.Controls.Add(this.lblFirstNameSearch);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbxSearch.Location = new System.Drawing.Point(697, 157);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(357, 413);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Searching";
            // 
            // tbxCustomerCodeSearch
            // 
            this.tbxCustomerCodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxCustomerCodeSearch.Location = new System.Drawing.Point(136, 229);
            this.tbxCustomerCodeSearch.Name = "tbxCustomerCodeSearch";
            this.tbxCustomerCodeSearch.Size = new System.Drawing.Size(123, 26);
            this.tbxCustomerCodeSearch.TabIndex = 11;
            this.tbxCustomerCodeSearch.TextChanged += new System.EventHandler(this.tbxCustomerCodeSearch_TextChanged);
            // 
            // lblCustomerCodeSearch
            // 
            this.lblCustomerCodeSearch.AutoSize = true;
            this.lblCustomerCodeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerCodeSearch.Location = new System.Drawing.Point(6, 229);
            this.lblCustomerCodeSearch.Name = "lblCustomerCodeSearch";
            this.lblCustomerCodeSearch.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerCodeSearch.TabIndex = 10;
            this.lblCustomerCodeSearch.Text = "Customer Code";
            // 
            // tbxPhoneNumberSearch
            // 
            this.tbxPhoneNumberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPhoneNumberSearch.Location = new System.Drawing.Point(136, 190);
            this.tbxPhoneNumberSearch.Name = "tbxPhoneNumberSearch";
            this.tbxPhoneNumberSearch.Size = new System.Drawing.Size(123, 26);
            this.tbxPhoneNumberSearch.TabIndex = 9;
            this.tbxPhoneNumberSearch.TextChanged += new System.EventHandler(this.tbxPhoneNumberSearch_TextChanged);
            // 
            // lblPhoneNumberSearch
            // 
            this.lblPhoneNumberSearch.AutoSize = true;
            this.lblPhoneNumberSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumberSearch.Location = new System.Drawing.Point(6, 198);
            this.lblPhoneNumberSearch.Name = "lblPhoneNumberSearch";
            this.lblPhoneNumberSearch.Size = new System.Drawing.Size(115, 20);
            this.lblPhoneNumberSearch.TabIndex = 8;
            this.lblPhoneNumberSearch.Text = "Phone Number";
            // 
            // tbxAddressSearch
            // 
            this.tbxAddressSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxAddressSearch.Location = new System.Drawing.Point(136, 153);
            this.tbxAddressSearch.Name = "tbxAddressSearch";
            this.tbxAddressSearch.Size = new System.Drawing.Size(123, 26);
            this.tbxAddressSearch.TabIndex = 7;
            this.tbxAddressSearch.TextChanged += new System.EventHandler(this.tbxAddressSearch_TextChanged);
            // 
            // lblAddressSearch
            // 
            this.lblAddressSearch.AutoSize = true;
            this.lblAddressSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddressSearch.Location = new System.Drawing.Point(18, 159);
            this.lblAddressSearch.Name = "lblAddressSearch";
            this.lblAddressSearch.Size = new System.Drawing.Size(68, 20);
            this.lblAddressSearch.TabIndex = 6;
            this.lblAddressSearch.Text = "Address";
            // 
            // tbxLastNameSearch
            // 
            this.tbxLastNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastNameSearch.Location = new System.Drawing.Point(136, 118);
            this.tbxLastNameSearch.Name = "tbxLastNameSearch";
            this.tbxLastNameSearch.Size = new System.Drawing.Size(123, 26);
            this.tbxLastNameSearch.TabIndex = 5;
            this.tbxLastNameSearch.TextChanged += new System.EventHandler(this.tbxLastNameSearch_TextChanged);
            // 
            // lblLastNameSearch
            // 
            this.lblLastNameSearch.AutoSize = true;
            this.lblLastNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastNameSearch.Location = new System.Drawing.Point(18, 121);
            this.lblLastNameSearch.Name = "lblLastNameSearch";
            this.lblLastNameSearch.Size = new System.Drawing.Size(82, 20);
            this.lblLastNameSearch.TabIndex = 4;
            this.lblLastNameSearch.Text = "LastName";
            // 
            // tbxId
            // 
            this.tbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxId.Location = new System.Drawing.Point(136, 47);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(123, 26);
            this.tbxId.TabIndex = 3;
            this.tbxId.TextChanged += new System.EventHandler(this.tbxId_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblId.Location = new System.Drawing.Point(18, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // tbxFirstNameSearch
            // 
            this.tbxFirstNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstNameSearch.Location = new System.Drawing.Point(136, 83);
            this.tbxFirstNameSearch.Name = "tbxFirstNameSearch";
            this.tbxFirstNameSearch.Size = new System.Drawing.Size(123, 26);
            this.tbxFirstNameSearch.TabIndex = 1;
            this.tbxFirstNameSearch.TextChanged += new System.EventHandler(this.tbxFirstNameSearch_TextChanged);
            // 
            // lblFirstNameSearch
            // 
            this.lblFirstNameSearch.AutoSize = true;
            this.lblFirstNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstNameSearch.Location = new System.Drawing.Point(18, 89);
            this.lblFirstNameSearch.Name = "lblFirstNameSearch";
            this.lblFirstNameSearch.Size = new System.Drawing.Size(82, 20);
            this.lblFirstNameSearch.TabIndex = 0;
            this.lblFirstNameSearch.Text = "FirstName";
            // 
            // gbxByAge
            // 
            this.gbxByAge.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxByAge.Controls.Add(this.tbxByAgeMax);
            this.gbxByAge.Controls.Add(this.lblByAgeMax);
            this.gbxByAge.Controls.Add(this.tbxByAgeMin);
            this.gbxByAge.Controls.Add(this.lblByAgeMin);
            this.gbxByAge.Location = new System.Drawing.Point(22, 271);
            this.gbxByAge.Name = "gbxByAge";
            this.gbxByAge.Size = new System.Drawing.Size(328, 60);
            this.gbxByAge.TabIndex = 12;
            this.gbxByAge.TabStop = false;
            this.gbxByAge.Text = "Age";
            // 
            // lblByAgeMin
            // 
            this.lblByAgeMin.AutoSize = true;
            this.lblByAgeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByAgeMin.Location = new System.Drawing.Point(26, 28);
            this.lblByAgeMin.Name = "lblByAgeMin";
            this.lblByAgeMin.Size = new System.Drawing.Size(38, 22);
            this.lblByAgeMin.TabIndex = 0;
            this.lblByAgeMin.Text = "Min";
            // 
            // tbxByAgeMin
            // 
            this.tbxByAgeMin.BackColor = System.Drawing.SystemColors.Window;
            this.tbxByAgeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByAgeMin.Location = new System.Drawing.Point(70, 23);
            this.tbxByAgeMin.Name = "tbxByAgeMin";
            this.tbxByAgeMin.Size = new System.Drawing.Size(67, 27);
            this.tbxByAgeMin.TabIndex = 1;
            this.tbxByAgeMin.TextChanged += new System.EventHandler(this.tbxByAgeMin_TextChanged);
            // 
            // lblByAgeMax
            // 
            this.lblByAgeMax.AutoSize = true;
            this.lblByAgeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByAgeMax.Location = new System.Drawing.Point(203, 26);
            this.lblByAgeMax.Name = "lblByAgeMax";
            this.lblByAgeMax.Size = new System.Drawing.Size(43, 22);
            this.lblByAgeMax.TabIndex = 2;
            this.lblByAgeMax.Text = "Max";
            // 
            // tbxByAgeMax
            // 
            this.tbxByAgeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByAgeMax.Location = new System.Drawing.Point(252, 23);
            this.tbxByAgeMax.Name = "tbxByAgeMax";
            this.tbxByAgeMax.Size = new System.Drawing.Size(70, 27);
            this.tbxByAgeMax.TabIndex = 3;
            this.tbxByAgeMax.TextChanged += new System.EventHandler(this.tbxByAgeMax_TextChanged);
            // 
            // gbxByMoney
            // 
            this.gbxByMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxByMoney.Controls.Add(this.tbxByMoneyMax);
            this.gbxByMoney.Controls.Add(this.lblByMoneyMax);
            this.gbxByMoney.Controls.Add(this.tbxByMoneyMin);
            this.gbxByMoney.Controls.Add(this.lblByMoneyMin);
            this.gbxByMoney.Location = new System.Drawing.Point(22, 342);
            this.gbxByMoney.Name = "gbxByMoney";
            this.gbxByMoney.Size = new System.Drawing.Size(329, 61);
            this.gbxByMoney.TabIndex = 13;
            this.gbxByMoney.TabStop = false;
            this.gbxByMoney.Text = "Money";
            // 
            // lblByMoneyMin
            // 
            this.lblByMoneyMin.AutoSize = true;
            this.lblByMoneyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByMoneyMin.Location = new System.Drawing.Point(26, 29);
            this.lblByMoneyMin.Name = "lblByMoneyMin";
            this.lblByMoneyMin.Size = new System.Drawing.Size(38, 22);
            this.lblByMoneyMin.TabIndex = 0;
            this.lblByMoneyMin.Text = "Min";
            // 
            // tbxByMoneyMin
            // 
            this.tbxByMoneyMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByMoneyMin.Location = new System.Drawing.Point(70, 26);
            this.tbxByMoneyMin.Name = "tbxByMoneyMin";
            this.tbxByMoneyMin.Size = new System.Drawing.Size(71, 27);
            this.tbxByMoneyMin.TabIndex = 1;
            this.tbxByMoneyMin.TextChanged += new System.EventHandler(this.tbxByMoneyMin_TextChanged);
            // 
            // lblByMoneyMax
            // 
            this.lblByMoneyMax.AutoSize = true;
            this.lblByMoneyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblByMoneyMax.Location = new System.Drawing.Point(203, 26);
            this.lblByMoneyMax.Name = "lblByMoneyMax";
            this.lblByMoneyMax.Size = new System.Drawing.Size(43, 22);
            this.lblByMoneyMax.TabIndex = 2;
            this.lblByMoneyMax.Text = "Max";
            // 
            // tbxByMoneyMax
            // 
            this.tbxByMoneyMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxByMoneyMax.Location = new System.Drawing.Point(252, 23);
            this.tbxByMoneyMax.Name = "tbxByMoneyMax";
            this.tbxByMoneyMax.Size = new System.Drawing.Size(70, 27);
            this.tbxByMoneyMax.TabIndex = 3;
            this.tbxByMoneyMax.TextChanged += new System.EventHandler(this.tbxByMoneyMax_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1070, 603);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwCustomers);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxByAge.ResumeLayout(false);
            this.gbxByAge.PerformLayout();
            this.gbxByMoney.ResumeLayout(false);
            this.gbxByMoney.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxCustomerCodeUpdate;
        private System.Windows.Forms.Label lblCustomerCodeUpdate;
        private System.Windows.Forms.TextBox tbxMoneyUpdate;
        private System.Windows.Forms.TextBox tbxPhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxAddressUpdate;
        private System.Windows.Forms.TextBox tbxAgeUpdate;
        private System.Windows.Forms.TextBox tbxLastNameUpdate;
        private System.Windows.Forms.TextBox tbxFirstNameUpdate;
        private System.Windows.Forms.Label lblMoneyUpdate;
        private System.Windows.Forms.Label lblPhoneNumberUpdate;
        private System.Windows.Forms.Label lblAddressUpdate;
        private System.Windows.Forms.Label lblAgeUpdate;
        private System.Windows.Forms.Label lblLastNameUpdate;
        private System.Windows.Forms.Label lblFirstNameUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCustomerCodeAdd;
        private System.Windows.Forms.Label lblCustomerCodeAdd;
        private System.Windows.Forms.TextBox tbxMoneyAdd;
        private System.Windows.Forms.TextBox tbxPhoneNumberAdd;
        private System.Windows.Forms.TextBox tbxAddressAdd;
        private System.Windows.Forms.TextBox tbxAgeAdd;
        private System.Windows.Forms.TextBox tbxLastNameAdd;
        private System.Windows.Forms.TextBox tbxFirstNameAdd;
        private System.Windows.Forms.Label lblMoneyAdd;
        private System.Windows.Forms.Label lblPhoneNumberAdd;
        private System.Windows.Forms.Label lblAddressAdd;
        private System.Windows.Forms.Label lblAgeAdd;
        private System.Windows.Forms.Label lblLastNameAdd;
        private System.Windows.Forms.Label lblFirstNameAdd;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxFirstNameSearch;
        private System.Windows.Forms.Label lblFirstNameSearch;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbxLastNameSearch;
        private System.Windows.Forms.Label lblLastNameSearch;
        private System.Windows.Forms.TextBox tbxCustomerCodeSearch;
        private System.Windows.Forms.Label lblCustomerCodeSearch;
        private System.Windows.Forms.TextBox tbxPhoneNumberSearch;
        private System.Windows.Forms.Label lblPhoneNumberSearch;
        private System.Windows.Forms.TextBox tbxAddressSearch;
        private System.Windows.Forms.Label lblAddressSearch;
        private System.Windows.Forms.GroupBox gbxByAge;
        private System.Windows.Forms.TextBox tbxByAgeMax;
        private System.Windows.Forms.Label lblByAgeMax;
        private System.Windows.Forms.TextBox tbxByAgeMin;
        private System.Windows.Forms.Label lblByAgeMin;
        private System.Windows.Forms.GroupBox gbxByMoney;
        private System.Windows.Forms.TextBox tbxByMoneyMax;
        private System.Windows.Forms.Label lblByMoneyMax;
        private System.Windows.Forms.TextBox tbxByMoneyMin;
        private System.Windows.Forms.Label lblByMoneyMin;
    }
}

