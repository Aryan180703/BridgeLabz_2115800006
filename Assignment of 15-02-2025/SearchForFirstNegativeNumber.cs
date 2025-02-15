using System; 
class SearchFirst{
    public int SearchForFirstNegative(int[] arr){
        for(int i = 0 ; i<arr.Length; i++){
            if(arr[i]<0){
                return arr[i];
            }
        }
        return 0;
    }
}
class Program{
    public static void Main(string[] args){
        Console.Write("Enter the size of the Array : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0 ; i<n ; i++){
            Console.Write("Enter "+(i+1)+"th element of the Array : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        SearchFirst s = new SearchFirst();
        int ans = s.SearchForFirstNegative(arr);
        if(ans == 0){
            Console.WriteLine("No negative element");
        }
        else{
            Console.WriteLine("first negative element : "+ ans);
        }
    }
}