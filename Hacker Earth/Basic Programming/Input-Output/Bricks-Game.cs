using System;

class Test{
    public static void Main(string[] args){
        int count = int.Parse(Console.ReadLine());
        int sum = 0;
        for(int i=1;i<int.MaxValue;i++){
            sum += i;
            if(sum >= count){
                Console.WriteLine("Patlu");
                return;
            }
            sum += 2*i;
            if(sum >= count){
                Console.WriteLine("Motu");
                return;
            }
        }
    }
}