namespace LINQ.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "sterabery" };

            var reverseOrder = fruits.Reverse();
            foreach ( var fruit in reverseOrder )
            {
                Console.WriteLine(fruit);
            }
        }
    }
}