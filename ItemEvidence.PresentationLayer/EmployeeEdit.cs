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
    public partial class EmployeeEdit : Form
    {
        private IMainController _controller;
        private EmployeeRepositoryMemory _employeeRepo;
        private Employee _employee;

        public EmployeeEdit(IMainController ctr, EmployeeRepositoryMemory erm, Employee employee)
        {
            _controller = ctr;
            _employeeRepo = erm;
            _employee = employee;
            InitializeComponent();
        }

        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            textBox_FirstName.Text = _employee.FirstName;
            textBox_LastName.Text = _employee.LastName;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            _employee.FirstName = textBox_FirstName.Text;
            _employee.LastName = textBox_LastName.Text;
            _controller.SaveEditedChanges(_employee);
            this.Close();
        }
    }
}
