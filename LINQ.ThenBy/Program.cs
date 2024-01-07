using LINQTut05.Shared;

namespace LINQ.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var sortedEmps = emps.OrderBy(e => e.Name).ThenBy(e => e.Salary);
            sortedEmps.Print("sorting emps by name then by salary");


            var sortedEmps01 = emps.OrderByDescending(e => e.Name).ThenByDescending(e => e.Salary);
            sortedEmps01.Print("sorting emps desending by name then by salary");
        }
    }
}