using System; 
 
namespace Program { 
 
    class Program{ 
        public static void Main(string[] args) { 
            Console.WriteLine("Enter some string: "); 
            string? word = Console.ReadLine(); 
            int count = 1; 
            int max = 0; 
            for(int i = 0; i < word.Length-1; i++) { 
                while(i < word.Length-1 && word[i] != word[i+1]) { 
                    count++; 
                    i++; 
                } 
                if(max < count) { 
                    max = count; 
                } 
                count = 1; 
 
            } 
            Console.WriteLine(max); 
 
 
        } 
    } 
}
