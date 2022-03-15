using System;
using System.Linq;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] vector = new int[k];

            combinations(set, vector, 0, 0);

        }

        private static void combinations(int[] set, int[] vector, int start, int index)
        {
            if (index > vector.Length - 1) {

                Console.WriteLine(string.Join(" ", vector));
                return;

            }
            for (int i = start; i < set.Length; i++)
            {
                vector[index] = set[i];
                combinations(set, vector, i + 1, index + 1);
            }
        }
    }
}
