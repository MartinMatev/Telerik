using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.ExtendingIEnumerable
{
    public static class ExtensionClass
    {

        public static T Sum<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                return default(T);
            }

            T sum = default(T);

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                return default(T);
            }

            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty, could not indicate the min number!");
            }

            T min = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("Collection is empty, could not indicate the min number!");
            }

            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            if (collection.Count() == 0)
            {
                return default(T);
            }

            T sum = Sum(collection);
            return sum / (dynamic)collection.Count();
        }
    }
}
