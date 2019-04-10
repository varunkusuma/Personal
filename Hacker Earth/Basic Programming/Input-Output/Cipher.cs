using System;

class Test{
    static void Main(string[] args){
        char[] data = Console.ReadLine().ToCharArray();
        int key = int.Parse(Console.ReadLine());
        
        for(int i=0;i<data.Length;i++){
            int n = (int)data[i];
            if(n>= 48 && n<=57){
                int ckey = key%10;
                if(n+ckey>57){
                    data[i] = Convert.ToChar(48+n+ckey-57-1);
                }
                else{
                    data[i] = Convert.ToChar(n+ckey);
                }
            }
            else if(n>= 65 && n<=90){
                int ckey = key%26;
                if(n+ckey>90){
                    data[i] = Convert.ToChar(65+n+ckey-90-1);
                }
                else{
                    data[i] = Convert.ToChar(n+ckey);
                }
            }
            else if(n>= 97 && n<=122){
                int ckey = key%26;
                if(n+ckey>122){
                    data[i] = Convert.ToChar(97+n+ckey-122-1);
                }
                else{
                    data[i] = Convert.ToChar(n+ckey);
                }
            }
        }
        Console.WriteLine(new String(data));
    }
}