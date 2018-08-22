using System.Collections.Generic;
using System.Linq;
using TDDExample;
using TDDExample.Model;

namespace XUnitTestProject1
{
    public class SaveMock : ISave
    {
        private List<Customer> _customers = new List<Customer>();

        public bool Save(Customer customer)
        {
            _customers.Add(customer);
            return true;
        }

        public Customer Get(int id)
        {
            return _customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
