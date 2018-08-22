using System;
using TDDExample.Model;

namespace TDDExample
{
    public class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer
            {
                Id = 1,
                Name = "John",
                Email = "john@doe.de"
            };

            var repository = new PostgresSave();

            var saveCustomer = new SaveCustomer(repository);

            saveCustomer.SaveAndValidate(customer);

            Console.WriteLine("Hello World!");
        }

        public class SaveCustomer
        {
            private ISave _saveRepo;
            public SaveCustomer(ISave repo)
            {
                _saveRepo = repo;
            }

            public bool SaveAndValidate(Customer customer)
            {
                if (IsCustomerValid.IsValid(customer))
                {
                    return _saveRepo.Save(customer);
                }

                return false;
            }
        }

    }
}
