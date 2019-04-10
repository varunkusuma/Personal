using System;

class Test{
    public static void Main(string[] args){
        int max = int.Parse(Console.ReadLine());
        SieveOfEratosthenes(max);
    }
    static void SieveOfEratosthenes(int n){
        bool[] prime = new bool[n+1];
        for(int i=0;i<prime.Length;i++){
            prime[i] = true;
        }
        for(int i=2;i*i<=n;i++){
            if(prime[i]){
                for(int j=i*i;j<=n;j+=i){
                    prime[j] = false;
                }
            }
        }
        for(int i=2;i<=n;i++){
            if(prime[i]) Console.Write(i+" ");
        }
    }
}