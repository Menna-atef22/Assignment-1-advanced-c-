namespace Assignment1
{
    class Range<T> where T : IComparable<T>
    {
        public T Min;
        public T Max;

        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            // dynamic because T can't use - directly
            return (T)((dynamic)Max - (dynamic)Min);
        }
    }
}
