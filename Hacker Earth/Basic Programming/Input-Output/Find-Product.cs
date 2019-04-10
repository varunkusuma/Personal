using System;

class Test{
    public static void Main(string[] args){
        int size = int.Parse(Console.ReadLine());
        string[] data = Console.ReadLine().Split();
        double answer = 1;
        for(int i=0;i<size;i++){
            answer = (answer*(int.Parse(data[i])))%((long)Math.Pow(10,9)+7);
        }
        Console.WriteLine(answer);
    }
}