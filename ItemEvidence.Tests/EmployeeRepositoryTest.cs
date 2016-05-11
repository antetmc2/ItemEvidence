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
    public class EmployeeRepositoryTest
    {
        /// <summary>
        /// Provjerava se jednostavno dodavanje zaposlenika.
        /// </summary>
        [Fact]
        public void AddEmployee()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            Employee employee = empRep.Get(emp.EmpId);

            Assert.Equal(emp, employee);
        }

        /// <summary>
        /// Provjerava se dodavanje 2 zaposlenika u popis zaposlenika.
        /// </summary>
        [Fact]
        public void AddTwoEmployees()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            Employee empp = new Employee();
            emp.EmpId = 2;
            emp.FirstName = "Pero";
            emp.LastName = "Perić";

            empRep.Add(empp);

            Assert.Equal(2, empRep.Employees.Count);
        }

        /// <summary>
        /// Provjerava se promjena detalja o zaposleniku.
        /// </summary>
        [Fact]
        public void ChangeEmployeeDetails()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            Employee employee = empRep.Get(emp.EmpId);

            Assert.Equal(emp, employee);

            emp.FirstName = "Ante";
            emp.LastName = "Antić";

            empRep.Update(emp.EmpId, emp);

            employee = empRep.Get(emp.EmpId);

            Assert.Equal(emp.LastName, employee.LastName);
        }

        /// <summary>
        /// Provjerava se jednostavno uklanjanje zaposlenika.
        /// </summary>
        [Fact]
        public void RemoveEmployeeSimple()
        {
            EmployeeRepositoryMemory empRep = new EmployeeRepositoryMemory();

            Employee emp = new Employee();
            emp.EmpId = 1;
            emp.FirstName = "Ante";
            emp.LastName = "Tomić";

            empRep.Add(emp);

            Employee employee = empRep.Get(emp.EmpId);

            Assert.Equal(emp, employee);

            empRep.Delete(emp.EmpId);

            Assert.Equal(0, empRep.Employees.Count);
        }

        /// <summary>
        /// Provjerava se uklanjanje zaposlenika kad postoji neki komad opreme pridružen njemu.
        /// </summary>
        [Fact]
        public void RemoveEmployeeComplex_ItemAssigned()
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
            repo.AssignToEmployee(laptop.ItemId, emp.EmpId, 1);

            Employee employee = empRep.Get(emp.EmpId);

            Assert.Equal(emp, employee);

            var exc = Record.Exception(() => empRep.Delete(emp.EmpId));
            Assert.NotNull(exc);
            Assert.IsType<ItemEvidenceException>(exc);
        }
    }
}
