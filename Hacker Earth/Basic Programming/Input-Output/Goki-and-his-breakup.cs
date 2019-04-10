using System;
class Test{
	static void Main(string[] args){
		int number = int.Parse(Console.ReadLine());
		int minSkill = int.Parse(Console.ReadLine());
		for(int i=0;i<number;i++){
		    if(int.Parse(Console.ReadLine()) >= minSkill) Console.WriteLine("YES");
		    else Console.WriteLine("NO");
		}
	}
}