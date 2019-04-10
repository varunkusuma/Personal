using System;

class Test{
    public static void Main(string[] args){
        char[] c = Console.ReadLine().ToCharArray();
        int sum = -1*c.Length*96;
        for(int i=0;i<c.Length;i++){
            sum += (int)c[i];
        }
        Console.WriteLine(sum);
    }
}