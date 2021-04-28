
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgwCustomers.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgwCustomers.Location = new System.Drawing.Point(12, 4);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.Size = new System.Drawing.Size(713, 147);
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
            this.gbxCrud.Size = new System.Drawing.Size(713, 376);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "Crud";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(274, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 33);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.gbxUpdate.Location = new System.Drawing.Point(373, 28);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(295, 303);
            this.gbxUpdate.TabIndex = 1;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(102, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 37);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(102, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 37);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(737, 545);
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
    }
}

