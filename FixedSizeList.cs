namespace Assignment1
{
    class FixedSizeList<T>
    {
        private T[] items;
        private int count = 0;

        public FixedSizeList(int capacity)
        {
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count == items.Length)
                throw new Exception("The list is full, can't add more than " + items.Length + " elements");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index " + index + ", the list has " + count + " elements");

            return items[index];
        }
    }
}
