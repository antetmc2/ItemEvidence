using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public abstract class Item
    {
        private int _id;
        private string _name;
        private string _description;
        private int _quantity;
        private string _author = "";

        public abstract Employee AssignToEmployee(Item item, Employee employee, int quantity);

        public virtual int ItemId
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public virtual int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public virtual string Author
        {
            get { return _author; }
            set { _author = value; }
        }
    }

    public class Monitor : Item
    {
        public Monitor(string name = "", string description = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        public Monitor() { }
        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if (emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 2 || (emp.GetItem(item).NumberAssigned + quantity) > 2) throw new ItemEvidenceException("Ne može se imati više od 2 monitora!");
            }
            emp.AssignItem(item, quantity);
            return emp;
        }
    }

    public class Keyboard : Item
    {
        public Keyboard(string name = "", string description = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }

        public Keyboard() { }
        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if (emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 2 || (emp.GetItem(item).NumberAssigned + quantity) > 2) throw new ItemEvidenceException("Ne može se imati više od 2 tipkovnice!");
            }
            emp.AssignItem(item, quantity);
            return emp;
        }
    }

    public class Mouse : Item
    {
        public Mouse(string name = "", string description = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }
        public Mouse() { }
        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if (emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 5 || (emp.GetItem(item).NumberAssigned + quantity) > 5) throw new ItemEvidenceException("Ne može se imati više od 5 miševa!");
            }
            emp.AssignItem(item, quantity);
            return emp;
        }
    }

    public class Headset : Item
    {
        public Headset(string name = "", string description = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }
        public Headset() { }
        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if(emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 5 || (emp.GetItem(item).NumberAssigned + quantity) > 5) throw new ItemEvidenceException("Ne može se imati više od 5 slušalica!");
            }
            emp.AssignItem(item, quantity);
            return emp;
        }
    }

    public class Laptop : Item
    {
        public Laptop(string name = "", string description = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
        }
        public Laptop() { }
        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if (emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 1 || quantity > 1) throw new ItemEvidenceException("Ne može se imati više od 1 laptopa!");
            }
            if(quantity > 1 ) throw new ItemEvidenceException("Ne može se imati više od 1 laptopa!");
            else emp.AssignItem(item, quantity);
            return emp;
        }
    }

    public class Book : Item
    {

        public Book(string name = "", string description = "", string author = "", int quantity = 0)
        {
            Name = name;
            Description = description;
            Quantity = quantity;
            Author = author;
        }
        public Book() { }

        public override Employee AssignToEmployee(Item item, Employee employee, int quantity)
        {
            Employee emp = employee;
            if (emp.ItemExists(item))
            {
                if (emp.GetItem(item).NumberAssigned >= 10 || (emp.GetItem(item).NumberAssigned + quantity) > 10) throw new ItemEvidenceException("Ne može se imati više od 10 knjiga!");
            }
            emp.AssignItem(item, quantity);
            return emp;
        }
    }
}
