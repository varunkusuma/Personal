using System;

class Test{
    static void Main(string[] args){
        int cases = int.Parse(Console.ReadLine());
        for(int i=0;i<cases;i++){
            int length = int.Parse(Console.ReadLine());
            char[] c = Console.ReadLine().ToCharArray();
            for(int j=0;j<length;j++){
                c[j] = replaceChar(c[j]);
            }
            Console.WriteLine(new string(c));
        }
    }
    static char replaceChar(char c){
        int[] prime = {67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127};
        int old = (int)c;
        int left = 0;
        int right =0;
        for(int i=0;i<prime.Length;i++){
            if(old <= 65) return Convert.ToChar(67);
            if(old >= 113) return Convert.ToChar(113);
            if(old >= prime[i]){
                left = prime[i];
            }
            else{
                right = prime[i];
                break;
            }
        }
        switch((old-left).CompareTo(right-old))
        {
            case 0:
                return Convert.ToChar(left);
            case -1:
                return Convert.ToChar(left);
            case 1:
                return Convert.ToChar(right);
            default:
                return '1';
        }

    }
}