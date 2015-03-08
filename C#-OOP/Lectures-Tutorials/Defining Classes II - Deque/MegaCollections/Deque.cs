namespace MegaCollections
{
    using System;

    public class Deque<T>
    {
        // fields
        private const int INITIAL_SIZE = 16;

        private T[] data;
        private int frontIndex;
        private int backIndex;

        // constructors
        public Deque() : this(INITIAL_SIZE)
        {

        }

        public Deque(uint initialSize)
        {
            if (initialSize < 2)
            {
                throw new IndexOutOfRangeException("Initial size of the Deque ,ust be bigger than 2.");
            }

            this.data = new T[initialSize];
            this.frontIndex = this.Capacity / 2 - 1;
            this.backIndex = this.Capacity / 2;
        }

        // properties
        public int Count 
        {
            get
            {
                return (this.backIndex - this.frontIndex - 1);
            }
        }

        public int Capacity 
        {
            get
            {
                return this.data.Length;
            }
        }

        public void AddFront(T element)
        {
            if (this.frontIndex < 0)
            {
                this.ResizeData();
            }

            this.data[this.frontIndex] = element;
            this.frontIndex--;
        }

        public void AddBack(T element)
        {
            if (this.backIndex > this.Capacity - 1)
            {
                this.ResizeData();
            }

            this.data[this.backIndex] = element;
            this.backIndex++;
        }

        public T RemoveFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            this.frontIndex++;
            return this.data[frontIndex];
        }

        public T RemoveBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            this.backIndex--;
            return this.data[backIndex];
        }

        public T PeekFront()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            return this.data[frontIndex + 1];
        }

        public T PeekBack()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            return this.data[backIndex - 1];
        }

        private void ResizeData()
        {
            int newSize = this.Capacity * 2;
            T[] newData = new T[newSize];

            int currentFrontIndex = this.Capacity / 2 - 1;  // reset the current front index to half - 1 position
            int currentBackIndex = this.Capacity / 2;   // reset the current back index position to half position

            int newFrontIndex = newSize / 2 - 1;    // set the new front index the same as the current index
            int newBackIndex = newSize / 2; //set the new back index the same as the current back index

            while (true)
            {
                if (currentFrontIndex <= this.frontIndex &&
                    currentBackIndex >= this.backIndex)
                {
                    break;
                }

                // Until the current index reaches the actual front index, -- it, and copy its value to the new array
                if (currentFrontIndex > this.frontIndex)
                {
                    newData[newFrontIndex] = this.data[currentFrontIndex];
                    newFrontIndex--;
                }

                // Until the current back index reaches the actual back index, ++ it and copy its value
                if (currentBackIndex < this.backIndex)
                {
                    newData[newBackIndex] = this.data[currentBackIndex];
                    newBackIndex++;
                }

                currentFrontIndex--;
                currentBackIndex++;
            }

            this.data = newData;
            this.frontIndex = newFrontIndex;
            this.backIndex = newBackIndex;
        }
    }
}
