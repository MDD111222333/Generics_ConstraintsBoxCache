namespace Generics_ConstraintsBoxCache
{
    public class ValueBox<T> where T : struct
    {
        private T? item;

        public void Set(T newItem)
        {
            item = newItem;
        }

        public bool IsEmpty => !item.HasValue;

        public T? Get()
        {
            return item;
        }
    }
}