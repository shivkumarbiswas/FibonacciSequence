using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciSequence
    {
        public int[] CalculateFibonacciSequence(int[] sequence, int limit)
        {
            if (limit <= sequence.Length)
            {
                return sequence;
            }

            var fibonacciSequence = new int [limit];
            sequence.CopyTo(fibonacciSequence, 0);
            fibonacciSequence[sequence.Length] = sequence.Sum();

            for (int i = sequence.Length + 1; i < limit; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] * 2 - fibonacciSequence[i - sequence.Length - 1];
            }

            return fibonacciSequence;
        }
    }
}
