using System;

class text{
    public static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(factorial(number));
    }
    static int factorial(int n){
        if(n == 0 || n ==1){
            return 1;
        }
        else{
            return n * factorial(n-1);
        }
    }
}