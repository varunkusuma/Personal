using System;

class Test{
    static void Main(string[] args){
        string[] data = Console.ReadLine().Split();
        string[] arr = Console.ReadLine().Split();
        
        long[] num = new long[long.Parse(data[0])];
        for(long i=0;i<long.Parse(data[0]);i++){
            if(i==0){
                num[i] = long.Parse(arr[i]);
            }
            else{
                num[i] = num[i-1] + long.Parse(arr[i]);
            }
        }
        
        for(long i=0;i<long.Parse(data[1]);i++){
            string[] param = Console.ReadLine().Split();
            long end = long.Parse(param[1])-1;
            long start = long.Parse(param[0])-1;
            Console.WriteLine(Math.Floor((double)(num[end]-num[start]+long.Parse(arr[start]))/(end-start+1)));
        }
    }
}