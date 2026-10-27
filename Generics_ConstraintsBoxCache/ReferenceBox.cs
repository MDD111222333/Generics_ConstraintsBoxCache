namespace Generics_ConstraintsBoxCache
{
    public class ReferenceBox<T> where T : class
    {
        private T? item;

        public void Set(T newItem)
        {
            item = newItem;
        }

        public bool IsEmpty => item == null;

        public T? Get()
        {
            return item;
        }
    }
}