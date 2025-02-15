using System; 
class SpecificWordSearch{
    public int NumberOfWords(string sentence){
        int count = 0;
        for(int i = 0 ; i<sentence.Length; i++){
            if(sentence[i] == ' ' || i==sentence.Length-1){
                count++;
            }
        } 
        return count;   
    }
    public string[] wordArray(string str){
        int n = NumberOfWords(str);
        string[] WordArray = new string[n];
        int count = 0;
        string currWord = "";
        for(int i = 0 ; i < str.Length;i++){
            if(str[i]!=' '){
                currWord+=str[i];
            }
            else if(currWord!="" && i==str.Length-1){
                WordArray[count++] = currWord;
            }
            else{
                WordArray[count++] = currWord;
                currWord = "";
            }
        }
        return WordArray;
    }
    public bool SearchInWordArray(string[] wordarray , string findstr){
        for(int i = 0 ; i<wordarray.Length;i++){
            if(findstr == wordarray[i]){
                return true;
            }
        }
        return false;
    }
    public string ContainsWord(string[] sentences , string findstr){
        for(int i = 0 ; i < sentences.Length ; i++){
            string[] wordsofeachsentence = wordArray(sentences[i]);
            if(SearchInWordArray(wordsofeachsentence , findstr)){
                return sentences[i];
            }
        }
        return "There is no sentece that contain the word ";
        
    }
}
class Program{
    public static void Main(string[] args){
        Console.Write("Enter the number of sentences : ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] sentences = new string[n];
        for(int i = 0 ; i < sentences.Length ; i++){
            Console.WriteLine("Enter the "+(i+1) +"th sentence :");
            sentences[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the  word to find : ");
        string findstr = Console.ReadLine();
        SpecificWordSearch s1 = new SpecificWordSearch();
        string ans = s1.ContainsWord(sentences , findstr);
        Console.WriteLine(ans);
    }

}