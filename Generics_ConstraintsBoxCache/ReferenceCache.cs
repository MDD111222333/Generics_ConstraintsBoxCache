namespace Generics_ConstraintsBoxCache
{
    public class ReferenceCache<T> where T : class
    {
        private T? cachedValue;
        private bool hasValue;

        public void Set(T value)
        {
            cachedValue = value;
            hasValue = true;
        }

        public bool TryGet(out T? value)
        {
            if (!hasValue)
            {
                value = null;
                return false;
            }

            value = cachedValue;
            return true;
        }
    }
}