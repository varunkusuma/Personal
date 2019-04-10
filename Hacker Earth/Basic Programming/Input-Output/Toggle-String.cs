using System;

class Test{
    public static void Main(string[] args){
        char[] c = Console.ReadLine().ToCharArray();
        for(int i=0;i<c.Length;i++){
            if((int)c[i] >= 65 && (int)c[i] <= 90){
                c[i] = (char)(c[i]+32);
            }
            else{
                c[i] = (char)(c[i]-32);
            }
        }
        Console.WriteLine(new string(c));
    }
}