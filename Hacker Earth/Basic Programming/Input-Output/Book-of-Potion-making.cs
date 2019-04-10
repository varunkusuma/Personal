using System;

class Test{
    public static void Main(string[] args){
        char[] number = Console.ReadLine().ToCharArray();
        int sum =0;
        if(number.Length < 10){
            Console.Write("Illegal ISBN");
            return;
        }
        for(int i=1;i<=number.Length;i++){
            sum += i*(int)number[i-1];
        }
        if(sum%11 == 0){
            Console.Write("Legal ISBN");
            return;
        }
        else{
            Console.Write("Illegal ISBN");
            return;
        }
    }
}