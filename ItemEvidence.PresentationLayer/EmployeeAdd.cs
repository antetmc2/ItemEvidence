using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemEvidence.DAL;
using ItemEvidence.Model;

namespace ItemEvidence.PresentationLayer
{
    public partial class EmployeeAdd : Form
    {
        private IMainController _controller;
        private EmployeeRepositoryMemory _employeeRepo;

        public EmployeeAdd(IMainController ctr, EmployeeRepositoryMemory erm)
        {
            _controller = ctr;
            _employeeRepo = erm;
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee(textBox_FirstName.Text, textBox_LastName.Text);
            _controller.AddNewEmployee(newEmployee);
            //MessageBox.Show("The new employee was succesfully added!", "Add employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.ClearAllTextBoxes();
        }
    }
}
