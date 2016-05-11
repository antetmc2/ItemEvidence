using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public interface IMainController
    {
        #region General
        void LoadData();
        #endregion
        #region Employees
        void ListAllEmployees();
        void AddNewEmployee(string sender = "");
        void AddNewEmployee(Employee emp);
        void EditCurrentEmployee(Employee employee);
        void SaveEditedChanges(Employee employee);
        void DeleteCurrentEmployee(int id);
        void CheckAssignedItemsToEmployee(Employee employee);
        #endregion
        #region Items
        void ListAllItems();
        void AddNewItem(string sender = "");
        void AddNewItem(ItemTypes type, string name, string description, int quantity, string author = "");
        void EditCurrentItem(Item item);
        void SaveEditedChanges(Item item);
        void DeleteCurrentItem(int id);
        void OrderMoreItems(int id, int number);
        void ReturnSomeItems(int id, int number);
        void ReturnAllItems(int id);
        void ItemDetails(Item item);
        Item GetItemDetails(int id);
        void AssignItemToEmployee(int itemID, int emplID, int quantity);
        void TakeItemFromEmployee(int itemID, int emplID, int quantity);
        void TakeItemFromEmployee(int itemID, int emplID);
        List<EmployeeItems> EmployeesPerItem(int id);
        #endregion
    }
}
