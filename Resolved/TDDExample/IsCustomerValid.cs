using TDDExample.Model;

namespace TDDExample
{
    internal class IsCustomerValid
    {
        internal static bool IsValid(Customer customer)
        {
            if (customer.Email == "")
            {
                return false;
            }

            return true;
        }
    }
}
