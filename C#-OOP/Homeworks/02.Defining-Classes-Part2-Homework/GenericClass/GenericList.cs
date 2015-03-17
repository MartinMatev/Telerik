namespace GenericClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    class GenericList<T> where T : IComparable<T>
    {
        // fields
        private const int DEFAULT_CAPACITY = 32; 
        private T[] genericArray;
        private int count = 0;
        
        // properties
        public int Capacity { get; private set; }

        public int Count 
        {
            get
            {
                return this.count;
            }
        }

        // constructors
        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.genericArray = new T[capacity];
        }

        public GenericList()
            : this(DEFAULT_CAPACITY)
        {

        }

        // Required methods

        // Returns the element corresponding to the passed index
        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException("Incorrect index");
                }

                T result = genericArray[index];
                return result;
            }
        }

        // Returns the index of the given element
        public int IndexOfElement(T element)
        {
            for (int i = 0; i < this.Capacity; i++)
            {
                if (this.genericArray[i].Equals(element))
                {
                    return i;
                }
            }

            throw new ArgumentOutOfRangeException("The element which index you requested is not present in the list!");
        }

        // Add elements at the end of the list
        public void AddElement(T element)
        {
            if (count >= genericArray.Length)
            {
                throw new IndexOutOfRangeException("Out of range");
            }

            this.genericArray[count] = element;
            this.count++;
        }

        // Add element at given index
        public void AddElementAtIndex(T element, int index)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range !");
            }

            this.count++;
            if (this.count == this.genericArray.Length)
            {
                Resize();
            }
            Array.Copy(this.genericArray, index, this.genericArray, index + 1, this.Count - index - 1);
            this.genericArray[index] = element;
        }

        // Remove element at given index
        public void RemoveElementAtIndex(int index)
        {
            if (index > this.count || index < 0)
            {
                throw new IndexOutOfRangeException("Index out of range !");
            }

            for (int i = index + 1; i < this.count; i++)
            {
                this.genericArray[i - 1] = this.genericArray[i];
            }
            this.count--;
        }

        // Removes last element of the list
        public void RemoveElement()
        {
            this.count--;
        }

        // Find the MIN element of the collection
        public T Min(GenericList<T> collection)
        {
            T minVaue = collection[0];

            for (int i = 0; i < collection.Count; i++)
            {
                if (minVaue.CompareTo(collection[i]) > 0)
                {
                    minVaue = collection[i];
                }
            }
            return minVaue;
        }

        // Find the MAX element of the collection
        public T Max(GenericList<T> collection)
        {
            T maxValue = collection[0];

            for (int i = 0; i < collection.Count; i++)
            {
                if (maxValue.CompareTo(collection[i]) < 0)
                {
                    maxValue = collection[i];
                }
            }
            return maxValue;
        }

        // Clear the generic list
        public void Clear()
        {
            this.genericArray = new T[DEFAULT_CAPACITY];
            this.count = 0;
            this.Capacity = DEFAULT_CAPACITY;
        }

        // Double the generic list lenght (size)
        private void Resize()
        {
            this.Capacity = Capacity * 2;
            Array.Resize(ref this.genericArray, this.Capacity);
        }

        // Print the content of the generic list
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(genericArray[i]).Append(' ');
            }

            return result.ToString();
        }
    }
}
