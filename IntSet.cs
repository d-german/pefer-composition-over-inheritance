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
    public class IntSet : IntList
    {
        /// <summary>
        /// Has different semantics than list, would violate LSP if referencing through base (list) class
        /// </summary>
        public override void Insert(int value)
        {
            if (!Has(value))
            {
                base.Insert(value);
            }
        }
    }
}
