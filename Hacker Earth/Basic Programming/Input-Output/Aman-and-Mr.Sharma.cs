using System;

class Test{
    static void Main(string[] args){
        long days = int.Parse(Console.ReadLine());
        long sum = 0;
        for(long i=0;i<days;i++){
            string[] data = Console.ReadLine().Split(' ');
            if(100*long.Parse(data[1]) >= ((2*22*long.Parse(data[0]))/7)){
                sum += 1;
            }
        }
        Console.WriteLine(sum);
    }
}