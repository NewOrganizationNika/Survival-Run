using System;
using System.Linq;

namespace Utilities.Extensions
{
    public static class CollectionExtensions
    {
        public static System.Collections.Generic.IEnumerable<T> Shuffle<T>(
            this System.Collections.Generic.IEnumerable<T> array)
        {
            var originalList = array.ToList();
            if (originalList.Count <= 0)
                throw new System.ArgumentOutOfRangeException(nameof(array), "Shuffle: Collection is Empty");
            if (originalList.Count == 1)
                return originalList;
            var shuffledList = new System.Collections.Generic.List<T>();
            var rand = new System.Random();
            for (var i = originalList.Count - 1; i >= 0; i--)
            {
                var randomArrayIndex = rand.Next(i + 1);
                shuffledList.Add(originalList[randomArrayIndex]);
                originalList.RemoveAt(randomArrayIndex);
            }

            array = shuffledList;
            return array;
        }

        public static T RandomElement<T>(this System.Collections.Generic.IEnumerable<T> array)
        {
            var originalList = array.ToList();
            if (originalList.Count <= 0)
                throw new System.ArgumentOutOfRangeException(nameof(array), "RandomElement: Collection is Empty");
            if (originalList.Count == 1)
                return originalList[0];
            var element = originalList[UnityEngine.Random.Range(0, originalList.Count)];
            return element;
        }

        public static T Pop<T>(this System.Collections.Generic.List<T> list)
        {
            if (list.Count <= 0)
                throw new ArgumentNullException(nameof(list),
                                                "Pop: List is empty");
            var lastElementIndex = list.Count - 1;
            var r = list[lastElementIndex];
            list.RemoveAt(lastElementIndex);
            return r;
        }

        public static T PopAt<T>(this System.Collections.Generic.List<T> list, int index)
        {
            if (list.Count <= 0)
                throw new ArgumentNullException(nameof(list),
                                                "PopAt: List is empty");
            if (list.Count <= index)
                throw new ArgumentOutOfRangeException(nameof(list), index,
                                                      "PopAt: Index is outside of List element Count");
            var r = list[index];
            list.RemoveAt(index);
            return r;
        }

        public static T Dequeue<T>(this System.Collections.Generic.List<T> list)
        {
            if (list.Count <= 0)
                throw new ArgumentNullException(nameof(list),
                                                "Dequeue: List is empty");
            var firstElementIndex = list[0];
            list.RemoveAt(0);
            return firstElementIndex;
        }

        public static T Loop<T>(this T[] element, int index) where T : System.IConvertible
        {
            if (index >= element.Length)
                index = 0;
            return element[index];
        }
    }
}