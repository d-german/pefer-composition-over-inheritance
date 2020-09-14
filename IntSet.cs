namespace Incidental_Inheritance
{
    /// <summary>
    /// Note: Head() and Tail() are not a valid operations for a set
    ///
    /// If your primary purpose of inheritance is reuse, then inheritance is being used, incidentally.
    /// This “incidental inheritance” could give you troubles if trying to use polymorphically.
    /// This is important because it is polymorphism that helps with your design being
    /// adaptable, maintainable, extendable and testable.
    /// </summary>
    public class IntSet
    {
        private readonly IntList _list = new IntList();

        public int Head()
        {
            return _list.Head();
        }

        public int Tail()
        {
            return _list.Tail();
        }

        public int Count()
        {
            return _list.Count();
        }

        public bool Has(int value)
        {
            return _list.Has(value);
        }

        /// <summary>
        /// Has different semantics than list, would violate LSP if referencing through base (list) class
        /// </summary>
        public void Insert(int value)
        {
            if (!Has(value))
            {
                _list.Insert(value);
            }
        }
    }
}
