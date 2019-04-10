using System;
using System.Numerics;

class test{
    static void Main(string[] args){
        int count = int.Parse(Console.ReadLine());
        for(int i=0;i<count;i++){
            string[] data = Console.ReadLine().Split();
            string s = computeGCD(int.Parse(data[0]),int.Parse(data[1]));
            BigInteger _out = 0;
            for(int j=s.Length-1;j>=0;j--){
                _out += (BigInteger)(Convert.ToInt32(s[j].ToString())) * BigInteger.Pow(2,s.Length-j-1);
            }
            Console.WriteLine(_out%(BigInteger.Pow(10,9)+7));
        }
    }
    static string computeGCD(int a, int b)
    {
        if(a%b == 0){
            string _out = "1";
            for(int i=1;i<a;i++){
                _out += "0";
            }
            return _out;
        }
        else{
            return infinite(computeGCD(b,a%b),a);
        }
    }
    static string infinite(string value, int length){
        while(length > value.Length){
            value += value;
        }
        value = value.Substring(0,length);
        return value;
    }
}