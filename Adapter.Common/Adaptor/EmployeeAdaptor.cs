using System.Collections.Generic;
using System.Linq;
using Adapter.Common.Adaptee;
using Adapter.Model;

namespace Adapter.Common.Adaptor
{
    public class EmployeeAdaptor : IEmployeeAdaptor
    {
        public List<NewEmployee> GetAdaptedEmployees()
        {
            var oldEmployees = EmployeeAdaptee.GetAllEmployees();

            return oldEmployees.Select(e => new NewEmployee
            {
                Name = string.Format("{0} {1}", e.Firstname, e.Lastname), 
                Address = string.Format("{0} {1}, {2} {3} - {4}", e.Address.Street, e.Address.Hausnumber, e.Address.Zip, e.Address.City, e.Address.Land)
            }).ToList();
        } 
    }
}
