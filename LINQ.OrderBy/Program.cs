using LINQTut05.Shared;

namespace LINQ.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "sterabery" };

            var sortedFruits = fruits.OrderBy(f => f);
            sortedFruits.Print("Sorting using method syntax");

            var sortedQ = from f in fruits
                          orderby f
                          select f;
            sortedQ.Print("Sorting using query syntax");


            var sortedDesc = fruits.OrderByDescending(f => f);
            sortedDesc.Print("Sorting Desc using method syntax");


            var sortedDesc01 = fruits.OrderBy(f => f.Length);
            sortedDesc01.Print("sorting by length of the word");

        }
    }
}