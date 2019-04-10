using System;
 
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] S1;
            int[] S2;
            char[] C1;
            char[] C2;
            int n = Convert.ToInt16(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                S1 = new int[26];
                S2 = new int[26];
                C1 = Console.ReadLine().ToCharArray();
                C2 = Console.ReadLine().ToCharArray();
                int Count = 0;
                for (int i = 0; i < C1.Length; i++)
                    S1[C1[i] - 'a']++;
                for (int i = 0; i < C2.Length; i++)
                    S2[C2[i] - 'a']++;
                for (int i = 0; i < 26; i++)
                    Count += Math.Abs(S1[i] - S2[i]);
                Console.WriteLine(Count);
            }
        }
    }
}