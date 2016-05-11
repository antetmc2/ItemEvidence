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
    public partial class ItemDetails : Form, IObserver
    {
        private IMainController _controller;
        private ItemRepositoryMemory _itemRepo;
        private Item _item;
        public ItemDetails(IMainController ctr, ItemRepositoryMemory irm, Item item)
        {
            _controller = ctr;
            _itemRepo = irm;
            _item = item;
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshView()
        {
            LoadData();
            dataGridView_AssignedItems.Refresh();
            dataGridView_AssignedItems.Update();
            employeeItemsBindingSource.ResetBindings(true);
        }

        private void LoadData()
        {
            textBox_ItemType.Text = _item.GetType().Name;
            textBox_Name.Text = _item.Name;
            textBox_Description.Text = _item.Description;
            textBox_Author.Text = _item.Author;
            textBox_Quantity.Text = _item.Quantity.ToString();
            Dictionary<int, string> dict = new Dictionary<int, string>();
            foreach (var emp in _itemRepo.ListOfEmployees.OrderBy(t => t.FirstName))
            {
                dict.Add(emp.EmpId, String.Format("{0} {1}", emp.FirstName, emp.LastName));
            }
            ComboBox_Employee.DataSource = new BindingSource(dict, null);
            ComboBox_Employee.DisplayMember = "Value";
            ComboBox_Employee.ValueMember = "Key";

            employeeItemsBindingSource.Clear();
            var itemList = _controller.EmployeesPerItem(_item.ItemId);
            foreach(var i in itemList)
            {
                employeeItemsBindingSource.Add(i);
            }
            dataGridView_AssignedItems.AutoGenerateColumns = false;
            dataGridView_AssignedItems.AutoSize = true;
            dataGridView_AssignedItems.DataSource = employeeItemsBindingSource;
        }

        private void ItemDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            _controller.AssignItemToEmployee(_item.ItemId, ((KeyValuePair<int, string>)ComboBox_Employee.SelectedItem).Key, (int)numericUpDown_Employee.Value);
        }

        public void UpdateView()
        {
            RefreshView();
        }
    }
}
