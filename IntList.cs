using System.Collections.Generic;
using System.Linq;

namespace Incidental_Inheritance
{
    /// <summary>
    /// This class should not be modified
    /// </summary>
    public class IntList
    {
        /// <summary>
        /// This is of type List<int> for convenience.
        /// It it could be anything that persist data. Including an int array or saving to disk.
        /// </summary>
        private readonly List<int> _list = new List<int>();

        public int Head() => _list.First();

        public int Tail() => _list.Last();

        public int Count() => _list.Count;

        public bool Has(int value) => _list.Contains(value);

        public virtual void Insert(int value) => _list.Add(value);
    }
}
