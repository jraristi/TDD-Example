using TDDExample.Model;

namespace TDDExample
{
    public interface ISave
    {
        bool Save(Customer customer);

        Customer Get(int id);
    }
}
