using System;
class Text{
    public static void Main(string[] args){
        int length = int.Parse(Console.ReadLine());
        int iterations = int.Parse(Console.ReadLine());
        for(int i=0;i<iterations;i++){
            string[] data = Console.ReadLine().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            if(a< length || b<length){
                Console.WriteLine("UPLOAD ANOTHER");
            }
            else if(a == b){
                Console.WriteLine("ACCEPTED");
            }
            else{
                Console.WriteLine("CROP IT");
            }
        }
    }
}