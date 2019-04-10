using System;

class text{
    public static void Main(string[] args){
        Console.WriteLine(IsPalindrome(Console.ReadLine().ToCharArray()));
        
    }
    static string IsPalindrome(char[] c){
        for(int i=0;i<Math.Floor((float)c.Length/2);i++){
            if(c[i] != c[c.Length-1-i]){
                return "NO";
            }
        }
        return "YES";
    }
}