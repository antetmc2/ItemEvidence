using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public interface IItemRepository
    {
        int Add(Item item);
        int OrderMoreItems(int itemID, int quantity);
        int Update(int itemID, Item item);
        int Delete(int itemID);
        int ReturnSomeItems(int itemID, int number);
        int ReturnAllItems(int itemID);
        int AssignToEmployee(int itemID, int emplID, int quantity);
        int TakeAllFromEmployee(int itemID, int emplID);
        int TakeFromEployee(int itemID, int emplID, int quantity);
        List<EmployeeItems> EmployeesPerItem(int itemID);

        Item Get(int itemID);
    }

    public class ItemEvidenceException : Exception
    {
        private string _msg;
        public ItemEvidenceException(string msg)
        {
            _msg = msg;
        }

        public string Msg
        {
            get { return _msg; }
            set { _msg = value; }
        }
    }
}
