namespace Generics_ConstraintsBoxCache
{
    public class ValueCache<T> where T : struct
    {
        private T? cachedValue;

        public void Set(T value)
        {
            cachedValue = value;
        }

        public bool TryGet(out T? value)
        {
            if (!cachedValue.HasValue)
            {
                value = null;
                return false;
            }

            value = cachedValue;
            return true;
        }
    }
}