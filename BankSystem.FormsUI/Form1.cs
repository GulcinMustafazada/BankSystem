using BankSystem.Business.Abstract;
using BankSystem.Business.Concrete;
using BankSystem.DataAccess.Concrete.EntityFramework;
using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.FormsUI
{
    public partial class Form1 : Form
    {
        private ICustomerService _customerService;
        public Form1()
        {
            _customerService = new CustomerManager(new EfCustomerDal());
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            dgwCustomers.DataSource = _customerService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _customerService.Add(new Customer
            {
                FirstName=tbxFirstNameAdd.Text,
                LastName=tbxLastNameAdd.Text,
                Age = Convert.ToInt32(tbxAgeAdd.Text),
                Address =tbxAddressAdd.Text,
                PhoneNumber = tbxPhoneNumberAdd.Text,
                Money=Convert.ToDecimal(tbxMoneyAdd.Text),
                CustomerCode = tbxCustomerCodeAdd.Text,

            });
            LoadCustomers();
            MessageBox.Show("Customer added!", "Message:");
            ClearTextboxs();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerService.Update(new Customer
            {
                Id = (int)dgwCustomers.CurrentRow.Cells[0].Value,
                FirstName = tbxFirstNameUpdate.Text,
                LastName = tbxLastNameUpdate.Text,
                Age = Convert.ToInt32(tbxAgeUpdate.Text),
                Address = tbxAddressUpdate.Text,
                PhoneNumber = tbxPhoneNumberUpdate.Text,
                Money = Convert.ToDecimal(tbxMoneyUpdate.Text),
                CustomerCode = tbxCustomerCodeUpdate.Text,
            });
            LoadCustomers();
            MessageBox.Show("Customer updated!", "Message:");
            ClearTextboxs();
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var cells = dgwCustomers.CurrentRow.Cells;
            tbxFirstNameUpdate.Text = cells[1].Value.ToString();
            tbxLastNameUpdate.Text = cells[2].Value.ToString();
            tbxAgeUpdate.Text = cells[3].Value.ToString();
            tbxAddressUpdate.Text = cells[4].Value.ToString();
            tbxPhoneNumberUpdate.Text = cells[5].Value.ToString();
            tbxMoneyUpdate.Text = cells[6].Value.ToString();
            tbxCustomerCodeUpdate.Text = cells[7].Value.ToString();
           
            
                
        }
        private void ClearTextboxs()
        {
            tbxFirstNameAdd.Text = "";
            tbxLastNameAdd.Text = "";
            tbxAddressAdd.Text = "";
            tbxAgeAdd.Text = "";
            tbxCustomerCodeAdd.Text = "";
            tbxMoneyAdd.Text = "";
            tbxPhoneNumberAdd.Text = "";
            tbxFirstNameUpdate.Text = "";
            tbxLastNameUpdate.Text = "";
            tbxAddressUpdate.Text = "";
            tbxAgeUpdate.Text = "";
            tbxCustomerCodeUpdate.Text = "";
            tbxMoneyUpdate.Text = "";
            tbxPhoneNumberUpdate.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerService.Delete(new Customer
            {
                Id = (int)dgwCustomers.CurrentRow.Cells[0].Value
            });
            LoadCustomers();
            MessageBox.Show("Customer deleted!", "Message:");
            ClearTextboxs();
        }

        private void tbxId_TextChanged(object sender, EventArgs e)
        {
            var text = tbxId.Text;

            if (!String.IsNullOrEmpty(text))
            {
                List<Customer> results = new List<Customer>();
                results.Add(_customerService.GetById(Convert.ToInt32(tbxId.Text)));
                dgwCustomers.DataSource = results;

            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxFirstNameSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxFirstNameSearch.Text;
            if(!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetByLastName(text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxLastNameSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxLastNameSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetByLastName(text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxAddressSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxAddressSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetAddress(text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxPhoneNumberSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxPhoneNumberSearch.Text;
            if(!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetPhoneNumber(text);
            }
            else
            {
                LoadCustomers();
            }
        }

        private void tbxCustomerCodeSearch_TextChanged(object sender, EventArgs e)
        {
            var text = tbxCustomerCodeSearch.Text;
            if (!String.IsNullOrEmpty(text))
            {
                dgwCustomers.DataSource = _customerService.GetCustomerCode(text);
            }
            else
            {
                LoadCustomers();
            }
        }
    }
}

