using System;

class text{
    public static void Main(string[] args){
        string[] data = Console.ReadLine().Split();
        int count = 0;
        int quotient = int.Parse(data[2]);
        for(int i = int.Parse(data[0]);i <= int.Parse(data[1]); i++){
            if(i%quotient == 0){
                ++count;
            }
        }
        Console.Write(count);
    }
}