using System;
class Test{
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		int[] sticks = {6,2,5,5,4,5,6,3,7,6};
		for(int j=0;j<number;j++){
		    int sticksUsed = 0;
		    char[] n = Console.ReadLine().ToCharArray();
		    for(int i=0;i<n.Length;i++){
		        sticksUsed += sticks[int.Parse(n[i].ToString())];
		    }
		    string max = "";
		    if(sticksUsed%2 == 0){
		        for(int i=1;i<=sticksUsed/2;i++){
		            max += "1";
		        }
		        Console.WriteLine(max);
		    }
		    else{
		        max += "7";
		        for(int i=1;i<=(sticksUsed-3)/2;i++){
		            max += "1";
		        }
		        Console.WriteLine(max);
		    }
		}
	}
}