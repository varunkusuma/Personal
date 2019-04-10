using System;
class Test{
    public static void Main(string[] args){
        int cases = int.Parse(Console.ReadLine());
        for(int i=0;i<cases;i++){
            int seat = int.Parse(Console.ReadLine());
            if((seat%6 < 6) && (seat%12 <= 6) && (seat%12 != 0)){
                int multiplier = seat%6==0?0:6-seat%6;
                Console.Write(seat + multiplier*2 + 1);
            }
            else{
                int multiplier = seat%12==0?5:seat%12-7;
                Console.Write(seat - (multiplier*2 + 1));
            }
            if(seat%6 == 1 || seat%6 == 0){
                Console.Write(" WS");
            }
            else if(seat%3 == 2){
                Console.Write(" MS");
            }
            else{
                Console.Write(" AS");
            }
            Console.WriteLine();
        }
    }
}