using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private IList<EmployeeItemsList> _items = new List<EmployeeItemsList>();

        public Employee()
        {

        }

        public Employee(string firstName = "", string lastName = "")
        {
            if(firstName != "" && lastName != "")
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }

        public virtual int EmpId
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public virtual string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public virtual IList<EmployeeItemsList> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public virtual void AssignItem(Item item, int quantity)
        {
            if (ItemExists(item))
            {
                var oldItem = GetItem(item);
                var newItem = GetItem(item);
                newItem.NumberAssigned += quantity;
            }

            else _items.Add(new EmployeeItemsList(this, item, quantity));
        }

        public virtual void TakeAllItems(Item item)
        {
            if (!ItemExists(item)) throw new ItemEvidenceException("Korisnik nema pridružen navedeni proizvod!");
            var chosenItem = GetItem(item);
            _items.Remove(chosenItem);
        }

        public virtual void TakeItems(Item item, int quantity)
        {
            if (!ItemExists(item)) throw new ItemEvidenceException("Korisnik nema pridružen navedeni proizvod!");
            var oldItem = GetItem(item);
            var chosenItem = GetItem(item);
            if (quantity > chosenItem.NumberAssigned) throw new ItemEvidenceException("Zaposlenik nema toliku količinu proizvoda!");
            else if (chosenItem.NumberAssigned == quantity) TakeAllItems(item);
            else
            {
                chosenItem.NumberAssigned -= quantity;
                UpdateItem(oldItem.Item, chosenItem.Item);
            }
        }

        public virtual void UpdateItem(Item oldItem, Item newItem)
        {
            var itemFromList = GetItem(oldItem);
            int quantity = itemFromList.NumberAssigned;
            _items.Remove(itemFromList);
            _items.Add(new EmployeeItemsList(this, newItem, quantity));
        }

        public virtual EmployeeItemsList GetItem(Item item)
        {
            foreach (var i in _items)
            {
                if (i.Item.ItemId == item.ItemId) return i;
            }
            throw new ItemEvidenceException("Oprema ne postoji kod odabranog zaposlenika!");
        }

        public virtual bool ItemExists(Item item)
        {
            foreach (var i in _items)
            {
                if (i.Item.ItemId == item.ItemId) return true;
            }
            return false;
        }
    }

    public class EmployeeItemsList
    {
        private int _id;
        private Employee _employee;
        private Item _item;
        private int _numberAssigned;

        public EmployeeItemsList(Employee employee, Item item, int numb)
        {
            _employee = employee;
            _item = item;
            _numberAssigned = numb;
        }

        public EmployeeItemsList()
        {

        }

        public virtual int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual Employee Employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        public virtual Item Item
        {
            get { return _item; }
            set { _item = value; }
        }

        public virtual int NumberAssigned
        {
            get { return _numberAssigned; }
            set { _numberAssigned = value; }
        }
    }
}
