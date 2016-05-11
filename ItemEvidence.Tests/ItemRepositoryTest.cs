using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemEvidence.DAL;
using ItemEvidence.Model;
using Xunit;

namespace ItemEvidence.Tests
{
    public class ItemRepositoryTest
    {

        /// <summary>
        /// Provjerava se jednostavno dodavanje jedne opreme i je li spremljena u popis opreme / skladište.
        /// </summary>
        [Fact]
        public void ItemAddedSimple()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
            Assert.Equal(1, repo.Items.Count);
        }

        /// <summary>
        /// Provjerava se jednostavno dodavanje dvije vrste opreme i jesu li sve opreme spremljene u dostupan popis / skladište.
        /// </summary>
        [Fact]
        public void TwoItemsAddedSimple()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Book book = new Book();
            book.ItemId = 2;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            Item item = repo.Get(book.ItemId);
            Assert.Equal(book, item);

            item = repo.Get(laptop.ItemId);
            Assert.Equal(laptop, item);
            Assert.Equal(2, repo.Items.Count);
        }

        /// <summary>
        /// Provjerava se jednostavno dodavanje već postojeće opreme.
        /// </summary>
        [Fact]
        public void ItemAdded_AlreadyExists()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
            Assert.Equal(1, repo.Items.Count);

            Laptop laptopp = new Laptop();
            laptopp.ItemId = 10;
            laptopp.Name = "Dell Inspiron 5558";
            laptopp.Quantity = 10;
            laptopp.Description = "Odličan laptop!";

            var exc = Record.Exception(() => repo.Add(laptopp));
            Assert.NotNull(exc);
            Assert.IsType<ItemEvidenceException>(exc);
        }

        /// <summary>
        /// Provjerava se ponašanje sustava kad se dohvaća nepostojeća oprema (ona koja nije u skladištu)
        /// </summary>
        [Fact]
        public void GetNonExistingItem()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(null, item);
        }

        /// <summary>
        /// Provjerava se ažuriranje opreme.
        /// </summary>
        [Fact]
        public void UpdateItem()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            laptop.Name = "Krumpiruša";

            repo.Update(item.ItemId, laptop);

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
        }

        /// <summary>
        /// Provjerava se ažuriranje nepostojeće opreme.
        /// </summary>
        [Fact]
        public void UpdateNonExistingItem()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            laptop.Name = "Krumpiruša";
            repo.Delete(laptop.ItemId);

            var exc = Record.Exception(() => repo.Update(item.ItemId, laptop));
            Assert.NotNull(exc);
            Assert.IsType<ItemEvidenceException>(exc);
        }

        /// <summary>
        /// Provjerava se dodavanje proizvoda i naručivanje dodatnih komada opreme.
        /// </summary>
        [Fact]
        public void ItemChangeQuantity_Simple()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1; //ne postavlja se ovdje
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.OrderMoreItems(laptop.ItemId, 5);
            laptop.Quantity += 5;

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
        }

        /// <summary>
        /// Provjerava se dodavanje proizvoda, naručivanje i vraćanje dodatnih komada opreme.
        /// </summary>
        [Fact]
        public void ItemChangeQuantity_MoreComplex()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1; //ne postavlja se ovdje
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.ReturnSomeItems(laptop.ItemId, 5);
            laptop.Quantity -= 5;

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.OrderMoreItems(laptop.ItemId, 5);
            laptop.Quantity += 5;

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
        }

        [Fact]
        public void ItemChangeQuantity_WithReturnAll()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.ItemId = 1; //ne postavlja se ovdje
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.OrderMoreItems(laptop.ItemId, 5);
            laptop.Quantity += 5;

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.ReturnAllItems(laptop.ItemId);
            laptop.Quantity = 0;

            item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);
        }

        /// <summary>
        /// Provjerava se jednostavno brisanje proizvoda.
        /// </summary>
        [Fact]
        public void ItemDeleted()
        {
            ItemRepositoryMemory repo = new ItemRepositoryMemory();

            Laptop laptop = new Laptop();
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Item item = repo.Get(laptop.ItemId);

            Assert.Equal(laptop, item);

            repo.Delete(item.ItemId);

            Assert.Equal(0, repo.NumberOfItems);
        }

        /// <summary>
        /// Provjerava se brisanje opreme pridružene zaposleniku.
        /// </summary>
        [Fact]
        public void DeleteAssignedItem()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            ItemRepositoryMemory repo = new ItemRepositoryMemory(empRep);

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Book book = new Book();
            book.ItemId = 2;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            repo.AssignToEmployee(laptop.ItemId, emp.EmpId, 1);

            Employee employee = empRep.Get(emp.EmpId);
            laptop = repo.Get(laptop.ItemId) as Laptop;

            repo.Delete(book.ItemId);
            Assert.Equal(1, repo.Items.Count);

            var exc = Record.Exception(() => repo.Delete(laptop.ItemId));
            Assert.NotNull(exc);
            Assert.IsType<ItemEvidenceException>(exc);
        }

        /// <summary>
        /// Provjerava se pridruživanje opreme zaposleniku.
        /// </summary>
        [Fact]
        public void AssignItemToEmployee()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            ItemRepositoryMemory repo = new ItemRepositoryMemory(empRep);

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Book book = new Book();
            book.ItemId = 2;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            repo.AssignToEmployee(laptop.ItemId, emp.EmpId, 1);

            Employee employee = empRep.Get(emp.EmpId);
            laptop = repo.Get(laptop.ItemId) as Laptop;

            Assert.Equal(1, employee.GetItem(laptop).NumberAssigned);
        }

        /// <summary>
        /// Provjerava se oduzimanje jedne količine opreme zaposleniku.
        /// </summary>
        [Fact]
        public void TakeOneItem()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            ItemRepositoryMemory repo = new ItemRepositoryMemory(empRep);

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Book book = new Book();
            book.ItemId = 2;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            repo.AssignToEmployee(book.ItemId, emp.EmpId, 5);

            book = repo.Get(book.ItemId) as Book;

            Employee employee = empRep.Get(emp.EmpId);

            Assert.True(employee.ItemExists(book));

            repo.TakeFromEployee(book.ItemId, emp.EmpId, 1);
            book = repo.Get(book.ItemId) as Book;

            employee = empRep.Get(emp.EmpId);
            Assert.Equal(4, employee.GetItem(book).NumberAssigned);
        }

        /// <summary>
        /// Provjerava se oduzimanje svih komada opreme zaposleniku.
        /// </summary>
        [Fact]
        public void TakeAllItems()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            ItemRepositoryMemory repo = new ItemRepositoryMemory(empRep);

            Laptop laptop = new Laptop();
            laptop.ItemId = 1;
            laptop.Name = "Dell Inspiron 5558";
            laptop.Quantity = 10;
            laptop.Description = "Odličan laptop!";

            repo.Add(laptop);

            Book book = new Book();
            book.ItemId = 2;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            repo.AssignToEmployee(laptop.ItemId, emp.EmpId, 1);
            repo.AssignToEmployee(book.ItemId, emp.EmpId, 10);

            book = repo.Get(book.ItemId) as Book;

            Employee employee = empRep.Get(emp.EmpId);

            Assert.True(employee.ItemExists(book));

            repo.TakeAllFromEmployee(book.ItemId, employee.EmpId);
            book = repo.Get(book.ItemId) as Book;

            employee = empRep.Get(emp.EmpId);
            Assert.False(employee.ItemExists(book));
        }

        /// <summary>
        /// Provjerava se uređivanje informacija o opremi na kompliciranom primjeru gdje se provjerava i izmjena podataka.
        /// </summary>
        [Fact]
        public void UpdateAssignedItem_Complicated()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            ItemRepositoryMemory repo = new ItemRepositoryMemory(empRep);

            Book book = new Book();
            book.ItemId = 1;
            book.Name = "Objektno oblikovanje";
            book.Author = "Zvonimir Vanjak";
            book.Quantity = 200;
            book.Description = "Knjiga je super!";

            repo.Add(book);

            repo.AssignToEmployee(book.ItemId, emp.EmpId, 5);

            Assert.Equal(1, emp.Items.Count);

            int id = 1;

            repo.OrderMoreItems(id, 20);
            repo.OrderMoreItems(id, 20);

            Item itemE = book;
            Item item = repo.Get(book.ItemId);

            foreach(var key in emp.Items)
            {
                itemE = key.Item;
            }

            Assert.Equal(item, itemE);

            Book boook = new Book();
            boook.ItemId = 1;
            boook.Name = "Objektni dizajn";
            boook.Author = "Zvonimir Vanjak";
            boook.Quantity = 2000; //ne smije se mijenjati količina proizvoda preko update!
            boook.Description = "Knjiga je super!";

            repo.Update(book.ItemId, boook);

            item = boook;
            foreach(var key in emp.Items)
            {
                itemE = key.Item;
            }

            Assert.Equal(235, itemE.Quantity); // količina nije promijenjena
            Assert.Equal(item, itemE);
        }

        [Fact]
        public void EmployeesPerItem_Get()
        {
            EmployeeRepositoryMemory employeeRepo = new EmployeeRepositoryMemory();
            ItemRepositoryMemory itemRepo = new ItemRepositoryMemory(employeeRepo);

            Employee empl1 = new Employee("Ante", "Tomić");
            Employee empl2 = new Employee("Ana", "Anić");
            employeeRepo.Add(empl1);
            employeeRepo.Add(empl2);

            Item item1 = ItemFactory.OrderItem(ItemTypes.Laptop, "Dell Inspiron 5558", "Odličan laptop za faks i programiranje!", 10);
            Item item2 = ItemFactory.OrderItem(ItemTypes.Book, "Objektno oblikovanje", "Must-have knjiga!", 50, "Zvonimir Vanjak");
            Item item3 = ItemFactory.OrderItem(ItemTypes.Monitor, "Philips monitor", "24 inča, full HD", 5);

            itemRepo.Add(item1); itemRepo.Add(item2); itemRepo.Add(item3);

            itemRepo.AssignToEmployee(item1.ItemId, empl1.EmpId, 1);
            itemRepo.AssignToEmployee(item1.ItemId, empl2.EmpId, 1);
            itemRepo.AssignToEmployee(item2.ItemId, empl1.EmpId, 4);
            itemRepo.AssignToEmployee(item3.ItemId, empl1.EmpId, 2);

            List<EmployeeItems> list1 = new List<EmployeeItems>();
            List<EmployeeItems> list2 = new List<EmployeeItems>();

            list1.Add(new EmployeeItems(empl1.EmpId, empl1.FirstName, empl1.LastName, 1));
            list1.Add(new EmployeeItems(empl2.EmpId, empl2.FirstName, empl2.LastName, 1));
            list2.Add(new EmployeeItems(empl1.EmpId, empl1.FirstName, empl1.LastName, 4));

            List<EmployeeItems> empItems1 = itemRepo.EmployeesPerItem(item1.ItemId);
            List<EmployeeItems> empItems2 = itemRepo.EmployeesPerItem(item2.ItemId);

            Assert.Equal(list1.Count, empItems1.Count);
            Assert.Equal(list2.Count, empItems2.Count);
        }

        [Fact]
        public void UpdateItemAssignedToEmployee()
        {
            EmployeeRepositoryMemory employeeRepo = new EmployeeRepositoryMemory();
            ItemRepositoryMemory itemRepo = new ItemRepositoryMemory(employeeRepo);

            Employee empl1 = new Employee("Ante", "Tomić");
            employeeRepo.Add(empl1);

            Item item1 = ItemFactory.OrderItem(ItemTypes.Laptop, "Dell Inspiron 5558", "Odličan laptop za faks i programiranje!", 10);

            itemRepo.Add(item1);

            itemRepo.AssignToEmployee(item1.ItemId, empl1.EmpId, 1);

            Item updateItem = ItemFactory.OrderItem(ItemTypes.Laptop, "Dell Inspiron 5558", "Zakon laptop!", 10);

            itemRepo.Update(item1.ItemId, updateItem);

            updateItem.Quantity = 9;

            Assert.Equal(empl1.GetItem(item1).Item, updateItem);
        }
    }
}
