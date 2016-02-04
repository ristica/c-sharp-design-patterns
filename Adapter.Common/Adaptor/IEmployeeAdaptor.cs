using System.Collections.Generic;
using Adapter.Model;

namespace Adapter.Common.Adaptor
{
    public interface IEmployeeAdaptor
    {
        List<NewEmployee> GetAdaptedEmployees();
    }
}