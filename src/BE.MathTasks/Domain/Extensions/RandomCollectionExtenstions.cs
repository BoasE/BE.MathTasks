using System;
using System.Collections.Generic;
using System.Linq;

namespace BE.MathTasks.Extensions
{
    internal static class RandomCollectionExtenstions
    {
        private static readonly RandomNumbers Random = new RandomNumbers();
        //private static readonly Random Rand = new Random(DateTime.Now.Second);

        public static bool None<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        public static T RandomItem<T>(this ICollection<T> source)
        {
            var pos = Random.Next(0, source.Count - 1);

            return source.ElementAt(pos);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException("source");

            return source.ShuffleIterator();
        }

        private static IEnumerable<T> ShuffleIterator<T>(
            this IEnumerable<T> source)
        {
            var buffer = source.ToList();
            for (var i = 0; i < buffer.Count; i++)
            {
                var j = Random.Next(i, buffer.Count - 1);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}
