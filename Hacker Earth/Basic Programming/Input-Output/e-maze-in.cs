using System;

class Test{
    public static void Main(string[] args){
        string directions = Console.ReadLine();
        int[] position = {0,0};
        for(int i=0;i<directions.Length;i++){
            switch(directions[i].ToString()){
                case "U":{
                    position[1] += 1;
                    break;
                }
                case "R":{
                    position[0] += 1;
                    break;
                }
                case "D":{
                    position[1] -= 1;
                    break;
                }
                case "L":{
                    position[0] -= 1;
                    break;
                }
            }
        }
        for(int i=0;i<position.Length;i++){
            Console.Write(position[i]+" ");
        }
    }
}