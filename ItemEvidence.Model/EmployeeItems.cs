using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public class EmployeeItems
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _numberOfItems = 0;

        public EmployeeItems(int id, string first, string last, int number)
        {
            _id = id;
            _firstName = first;
            _lastName = last;
            _numberOfItems = number;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public Item item
        {
            get { return item; }
            set { item = value; }
        }

        public int NumberOfItems
        {
            get { return _numberOfItems; }
            set { _numberOfItems = value; }
        }

        public void Add()
        {
            List<string> list = new List<string>();
            list.Add(_firstName);
        }
    }
}
