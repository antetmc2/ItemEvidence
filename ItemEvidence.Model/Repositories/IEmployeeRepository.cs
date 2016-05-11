using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemEvidence.Model
{
    public interface IEmployeeRepository
    {
        int Add(Employee employer);
        int Update(int emplID, Employee employer);
        int Delete(int emplID);

        Employee Get(int emplID);
    }
}
