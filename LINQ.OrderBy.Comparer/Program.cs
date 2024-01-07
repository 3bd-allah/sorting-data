using LINQTut05.Shared;

namespace LINQ.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();
            var sortedEmps = emps.OrderBy(e => e.EmployeeNo);
            sortedEmps.Print("Sorted Emps");

            IOrderedEnumerable<Employee>sortedEmps01 = emps.OrderBy(
                e => e, new EmployeeComparer());
        }
    }
}