using System;

class Test{
    static void Main(string[] args){
        long cases = long.Parse(Console.ReadLine());
        for(long p=0;p<cases;p++){
            char[] word = Console.ReadLine().ToCharArray();
            long sum = 0;
            for(long i=0;i<word.Length;i++){
                if(word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' ||
                   word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U')
                {
                    if(i == 0){
                        sum += word.Length;
                    }
                    else{
                        sum += (word.Length-i) * (i+1);
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}