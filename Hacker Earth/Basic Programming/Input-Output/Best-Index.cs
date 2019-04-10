using System;
using System.Linq;
using System.Collections.Generic;

class Test{
    static void Main(string[] args){
        int length = int.Parse(Console.ReadLine());
        IEnumerable<int> data = Console.ReadLine().Split().Select(int.Parse);
        int[] summary = new int[length];
        summary[0] = data.ElementAt(0);
        for(int i=1;i<length;i++)
        {
            summary[i] = summary[i-1]+data.ElementAt(i);
        }

        int _out = int.MinValue;
        
        for(int i=0;i<length;i++)
        {
            int n = (int)(Math.Sqrt(2*(length-(i-1))) - 0.5);
            int max = n*(n+1)/2;
            
            int sum = 0;
            if(i==0){
                sum = summary[i];
            }
            else{
                sum = summary[i+max-1] - summary[i-1];
            }
            if(sum > _out){
                _out = sum;
            }
        }
        
        Console.WriteLine(_out);
    }
}