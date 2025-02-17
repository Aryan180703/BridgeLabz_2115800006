using System;
using System.Text;
class StringConcatenationPerformance{
    public static void Main(){
        int count1k = 1000;
        int count10k = 10000;
        int count1m = 1000000;
        var start = DateTime.Now;
        string resultString = "";
        for (int i = 0; i < count1k; i++){
            resultString += "test";
        }
        var stringTime1k = DateTime.Now - start;
        start = DateTime.Now;
        StringBuilder resultStringBuilder = new StringBuilder();
        for (int i = 0; i < count1k; i++){
            resultStringBuilder.Append("test");
        }
        var stringBuilderTime1k = DateTime.Now - start;
        start = DateTime.Now;
        StringBuffer resultStringBuffer = new StringBuffer();
        for (int i = 0; i < count1k; i++){
            resultStringBuffer.Append("test");
        }
        var stringBufferTime1k = DateTime.Now - start;
        Console.WriteLine("String (1000) : " + stringTime1k.TotalMilliseconds );
        Console.WriteLine("StringBuilder (1000) : " + stringBuilderTime1k.TotalMilliseconds );
        Console.WriteLine("StringBuffer (1000) : " + stringBufferTime1k.TotalMilliseconds );
        start = DateTime.Now;
        resultString = "";
        for (int i = 0; i < count10k; i++){
            resultString += "test";
        }
        var stringTime10k = DateTime.Now - start;
        start = DateTime.Now;
        resultStringBuilder = new StringBuilder();
        for (int i = 0; i < count10k; i++){
            resultStringBuilder.Append("test");
        }
        var stringBuilderTime10k = DateTime.Now - start;
        start = DateTime.Now;
        resultStringBuffer = new StringBuffer();
        for (int i = 0; i < count10k; i++){
            resultStringBuffer.Append("test");
        }
        var stringBufferTime10k = DateTime.Now - start;
        Console.WriteLine("String (10000) : " + stringTime10k.TotalMilliseconds + " ms");
        Console.WriteLine("StringBuilder (10000) : " + stringBuilderTime10k.TotalMilliseconds + " ms");
        Console.WriteLine("StringBuffer (10000) : " + stringBufferTime10k.TotalMilliseconds + " ms");
        start = DateTime.Now;
        resultString = "";
        for (int i = 0; i < count1m; i++){
            resultString += "test";
        }
        var stringTime1m = DateTime.Now - start;
        start = DateTime.Now;
        resultStringBuilder = new StringBuilder();
        for (int i = 0; i < count1m; i++){
            resultStringBuilder.Append("test");
        }
        var stringBuilderTime1m = DateTime.Now - start;
        start = DateTime.Now;
        resultStringBuffer = new StringBuffer();
        for (int i = 0; i < count1m; i++){
            resultStringBuffer.Append("test");
        }
        var stringBufferTime1m = DateTime.Now - start;
        Console.WriteLine("String (1000000) : " + stringTime1m.TotalMilliseconds);
        Console.WriteLine("StringBuilder (1000000) : " + stringBuilderTime1m.TotalMilliseconds ");
        Console.WriteLine("StringBuffer (1000000) : " + stringBufferTime1m.TotalMilliseconds");
    }
}
class StringBuffer{
    private StringBuilder sb;
    public StringBuffer(){
        sb = new StringBuilder();
    }
    public void Append(string value){
        sb.Append(value);
    }
    public string ToString(){
        return sb.ToString();
    }
}
