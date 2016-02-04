using System.Collections.Generic;

namespace Adapter.Common.Adaptee
{
    public static class EmployeeAdaptee
    {
        public static List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Firstname = "Aleksandar",
                    Lastname = "Ristic",
                    Address = new Address
                    {
                        Street = "Fernkorngasse",
                        Hausnumber = "56/1/410",
                        Zip = "1100",
                        City = "Wien",
                        Land = "AT"
                    }
                },
                new Employee
                {
                    Firstname = "Denis",
                    Lastname = "Straus",
                    Address = new Address
                    {
                        Street = "Langobardenstraße",
                        Hausnumber = "128/22/1",
                        Zip = "1220",
                        City = "Wien",
                        Land = "AT"
                    }
                }
            };
        } 
    }
}
