using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemEvidence.Model;
using ItemEvidence.PresentationLayer;
using ItemEvidence.DAL;

namespace ItemEvidence.Controllers
{
    public class MainController : IMainController
    {
        static private EmployeeRepositoryMemory employeeRepo = new EmployeeRepositoryMemory();
        static private ItemRepositoryMemory itemRepo = new ItemRepositoryMemory(employeeRepo);

        private void StartForm(Form form)
        {
            //form.MdiParent = this;
            form.Show();
        }

        private bool isOpened(string text)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Text == text) return true;
            }
            return false;
        }

        public void LoadData()
        {
            //employeeRepo.Load();
            //itemRepo.Load();
            Employee empl1 = new Employee("Ante", "Tomić");
            Employee empl2 = new Employee("Ana", "Anić");
            Employee empl3 = new Employee("Pero", "Perić");
            Employee empl4 = new Employee("Ines", "Inesić");
            Employee empl5 = new Employee("Krumpiruša", "Šunka");
            empl1.EmpId = 1; empl2.EmpId = 2; empl3.EmpId = 3; empl4.EmpId = 4;
            employeeRepo.Add(empl1); employeeRepo.Add(empl2); employeeRepo.Add(empl3);
            employeeRepo.Add(empl4); employeeRepo.Add(empl5);

            Item item1 = ItemFactory.OrderItem(ItemTypes.Laptop, "Dell Inspiron 5558", "Odličan laptop za faks i programiranje!", 10);
            Item item2 = ItemFactory.OrderItem(ItemTypes.Book, "Objektno oblikovanje", "Must-have knjiga!", 50, "Zvonimir Vanjak");
            Item item3 = ItemFactory.OrderItem(ItemTypes.Monitor, "Philips monitor", "24 inča, full HD", 5);
            Item item4 = ItemFactory.OrderItem(ItemTypes.Mouse, "Genius miš", "Potreban za rad!", 30);
            Item item5 = ItemFactory.OrderItem(ItemTypes.Keyboard, "Genius bežična tipkovnica", "Veoma potrebna za rad!", 30);
            Item item6 = ItemFactory.OrderItem(ItemTypes.Headset, "Sony bežične slušalice", "Puno pomaže, izdržljive!", 20);
            Item item7 = ItemFactory.OrderItem(ItemTypes.Book, "Stranac", "Malo književnosti", 40, "Albert Camus");
            Item item8 = ItemFactory.OrderItem(ItemTypes.Laptop, "Toshiba Satellite L850-1V6", "Užas od laptopa", 1);
            itemRepo.Add(item1); itemRepo.Add(item2); itemRepo.Add(item3); itemRepo.Add(item4);
            itemRepo.Add(item5); itemRepo.Add(item6); itemRepo.Add(item7); itemRepo.Add(item8);

            itemRepo.AssignToEmployee(item1.ItemId, empl1.EmpId, 1);
            itemRepo.AssignToEmployee(item1.ItemId, empl2.EmpId, 1);
            itemRepo.AssignToEmployee(item1.ItemId, empl3.EmpId, 1);
            itemRepo.AssignToEmployee(item1.ItemId, empl4.EmpId, 1);
            itemRepo.AssignToEmployee(item2.ItemId, empl1.EmpId, 4);
            itemRepo.AssignToEmployee(item3.ItemId, empl1.EmpId, 2);
        }

        public void ListAllEmployees()
        {
            if (!isOpened("Employees"))
            {
                EmployeeList employeeList = new EmployeeList(this, employeeRepo);

                employeeRepo.Attach(employeeList);

                StartForm(employeeList);
            }
        }

        public void AddNewEmployee(string sender = "")
        {
            if (!isOpened("Add Employee"))
            {
                if (sender != "" && sender == "Employees")
                {
                    EmployeeAdd employeeAdd = new EmployeeAdd(this, employeeRepo);

                    employeeAdd.ShowDialog();
                }

                else StartForm(new EmployeeAdd(this, employeeRepo));
            }
        }

        public void AddNewEmployee(Employee emp)
        {
            employeeRepo.Add(emp);
        }

        public void ListAllItems()
        {
            if (!isOpened("Items"))
            {
                ItemList itemList = new ItemList(this, itemRepo);

                itemRepo.Attach(itemList);

                StartForm(itemList);
            }
        }

        public void AddNewItem(string sender = "")
        {
            if (!isOpened("Add New Item"))
            {
                if(sender != "" && sender == "Items")
                {
                    ItemAdd itemAdd = new ItemAdd(this, itemRepo);

                    itemAdd.ShowDialog();
                }

                else StartForm(new ItemAdd(this, itemRepo));
            }
        }

        public void AddNewItem(ItemTypes type, string name, string description, int quantity, string author = "")
        {
            Item newItem = ItemFactory.OrderItem(type, name, description, quantity, author);
            itemRepo.Add(newItem);
        }

        public void EditCurrentItem(Item item)
        {
            ItemEdit itemEdit = new ItemEdit(this, itemRepo, item);

            itemEdit.ShowDialog();
        }

        public void SaveEditedChanges(Item item)
        {
            itemRepo.Update(item.ItemId, item);
        }

        public void DeleteCurrentItem(int id)
        {
            try
            {
                itemRepo.Delete(id);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditCurrentEmployee(Employee employee)
        {
            EmployeeEdit employeeEdit = new EmployeeEdit(this, employeeRepo, employee);

            employeeEdit.ShowDialog();
        }

        public void SaveEditedChanges(Employee employee)
        {
            employeeRepo.Update(employee.EmpId, employee);
        }

        public void DeleteCurrentEmployee(int id)
        {
            try
            {
                employeeRepo.Delete(id);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OrderMoreItems(int id, int number)
        {
            itemRepo.OrderMoreItems(id, number);
        }

        public void ReturnSomeItems(int id, int number)
        {
            itemRepo.ReturnSomeItems(id, number);
        }

        public void ReturnAllItems(int id)
        {
            itemRepo.ReturnAllItems(id);
        }

        public void ItemDetails(Item item)
        {
            ItemDetails itemDetails = new ItemDetails(this, itemRepo, item);

            itemRepo.Attach(itemDetails);

            itemDetails.ShowDialog();
        }

        public Item GetItemDetails(int id)
        {
            return itemRepo.Get(id);
        }

        public void AssignItemToEmployee(int itemID, int emplID, int quantity)
        {
            try
            {
                itemRepo.AssignToEmployee(itemID, emplID, quantity);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CheckAssignedItemsToEmployee(Employee employee)
        {
            EmployeeAssignedItems employeeItems = new EmployeeAssignedItems(this, itemRepo, employee);

            employeeRepo.Attach(employeeItems);

            employeeItems.ShowDialog();
        }

        public void TakeItemFromEmployee(int itemID, int emplID, int quantity)
        {
            try
            {
                itemRepo.TakeFromEployee(itemID, emplID, quantity);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TakeItemFromEmployee(int itemID, int emplID)
        {
            try
            {
                itemRepo.TakeAllFromEmployee(itemID, emplID);
            }
            catch (ItemEvidenceException exc)
            {
                MessageBox.Show(exc.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<EmployeeItems> EmployeesPerItem(int id)
        {
            return itemRepo.EmployeesPerItem(id);
        }
    }
}
