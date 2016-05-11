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
    public partial class EmployeeList : Form, IObserver
    {
        private IMainController _controller;
        private EmployeeRepositoryMemory _employeeRepo;

        public EmployeeList(IMainController ctr, EmployeeRepositoryMemory erm)
        {
            _controller = ctr;
            _employeeRepo = erm;
            InitializeComponent();
        }

        private void RefreshView()
        {
            LoadAllData();
            EmployeesList_DataGridView.Refresh();
            EmployeesList_DataGridView.Update();
            employeeBindingSource.ResetBindings(true);
        }

        private void LoadAllData()
        {
            employeeBindingSource.Clear();
            foreach (var item in _employeeRepo.Employees.OrderBy(x => x.FirstName))
            {
                employeeBindingSource.Add(item);
            }
            EmployeesList_DataGridView.AutoGenerateColumns = false;
            EmployeesList_DataGridView.AutoSize = true;
            EmployeesList_DataGridView.DataSource = employeeBindingSource;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            LoadAllData();
            DeleteSelectedEmployee.Enabled = false;
            EditSelectedEmployee.Enabled = false;
            btn_Items.Enabled = false;
        }

        private void AddNewEmployee_Click(object sender, EventArgs e)
        {
            _controller.AddNewEmployee("Employees");
        }

        private void DeleteSelectedEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            try
            {
                _controller.DeleteCurrentEmployee(employee.EmpId);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshView();
        }

        private void EmployeesList_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DeleteSelectedEmployee.Enabled = true;
            EditSelectedEmployee.Enabled = true;
            btn_Items.Enabled = true;

            Employee employee = employeeBindingSource.Current as Employee;
            textBox_Employee.Text = employee.FirstName + " " + employee.LastName;
        }

        private void EditSelectedEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            try
            {
                _controller.EditCurrentEmployee(employee);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshView();
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            Employee employee = employeeBindingSource.Current as Employee;
            _controller.CheckAssignedItemsToEmployee(employee);
        }

        public void UpdateView()
        {
            RefreshView();
        }
    }
}
