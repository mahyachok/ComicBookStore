﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicBookStore
{
    public partial class frmEmpRegister : Form
    {

        private ComicbookController controller;
        
        public frmEmpRegister()
        {
            InitializeComponent();
            controller = new ComicbookController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || txtPass.Text == "" || txtName.Text == "" || txtSalary.Text == "" || txtStore.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            else if(!double.TryParse(txtSalary.Text, out double salary))
            {
                MessageBox.Show("Please enter a valid salary");
                return;
            }

            else
            {
                Employee newEmployee = controller.MakeEmployee(txtUser.Text, txtPass.Text, txtName.Text, double.Parse(txtSalary.Text) ,txtStore.Text,txtAddress.Text);
                controller.AddEmployeeToDatabase(newEmployee);
                MessageBox.Show("Account succesfully created.");
            }

            
        }

        private void frmEmpRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
