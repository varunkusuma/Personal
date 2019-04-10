using System;

class text{
    public static void Main(string[] args){
        char[] c = Console.ReadLine().ToCharArray();
        if((int)c[2] == 65 || (int)c[2] == 69 || (int)c[2] == 73 || (int)c[2] == 79 || (int)c[2] == 85
            || (int)c[2] == 89)
        {
            Console.WriteLine("invalid");
            return;
        }
        int[] num = {(int)c[0],(int)c[1],(int)c[3],(int)c[4],(int)c[5],(int)c[7],(int)c[8]};
        if((num[0]+num[1])%2 == 1){
            Console.WriteLine("invalid");
            return;
        }
        else if((num[2]+num[3])%2 == 1){
            Console.WriteLine("invalid");
            return;
        }
        else if((num[3]+num[4])%2 == 1){
            Console.WriteLine("invalid");
            return;
        }
        else if((num[5]+num[6])%2 == 1){
            Console.WriteLine("invalid");
            return;
        }
        else{
            Console.WriteLine("valid");
            return;
        }
    }
}