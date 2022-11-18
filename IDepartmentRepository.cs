using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyDatabaseUsingDapper
{
    public interface IDepartmentRepository
    {
       public IEnumerable<Department> GetAllDepartments();
    }
}
