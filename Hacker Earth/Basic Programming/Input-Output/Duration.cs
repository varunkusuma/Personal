using System;

class Test{
    public static void Main(string[] args){
        int tasks = int.Parse(Console.ReadLine());
        for(int i=0;i<tasks;i++){
            long minutes = 0;
            string[] data = Console.ReadLine().Split();
            minutes += int.Parse(data[2])*60 + int.Parse(data[3]) - int.Parse(data[0])*60 - int.Parse(data[1]);
            Console.Write(Math.Floor((double)minutes/60)+" ");
            Console.Write(minutes%60);
            Console.WriteLine();
        }
    }
}