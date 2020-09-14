using System.Diagnostics;

namespace Incidental_Inheritance
{
    internal static class Program
    {
        private static void Main()
        {
            var intList = new IntSet(); // polymorphism
            intList.Insert(5);
            intList.Insert(5);
            Debug.Assert(intList.Count() == 1); // Should be two if intList "is a" IntList
            Debug.Assert(intList.Head() == 5); // Should not be able to see Head() since it's invalid for a set.
        }
    }
}
