using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;
class PipedStreamCommunication{
    static AnonymousPipeServerStream pipeServer;
    static AnonymousPipeClientStream pipeClient;
    static void Main(){
        pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);
        pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString());
        Thread writerThread = new Thread(WriteData);
        Thread readerThread = new Thread(ReadData);
        writerThread.Start();
        readerThread.Start();
        writerThread.Join();
        readerThread.Join();
        pipeServer.Dispose();
        pipeClient.Dispose();
    }
    static void WriteData(){
        try{
            using (StreamWriter writer = new StreamWriter(pipeServer)){
                writer.AutoFlush = true;
                for (int i = 1; i <= 5; i++){
                    string message = "Message " + i + " from Writer Thread";
                    Console.WriteLine("Writing : " + message);
                    writer.WriteLine(message);
                    Thread.Sleep(1000);
                }
            }
        }
        catch (IOException ex){
            Console.WriteLine("IOException in Writer Thread : " + ex.Message);
        }
    }

    static void ReadData(){
        try{
            using (StreamReader reader = new StreamReader(pipeClient)){
                string message;
                while ((message = reader.ReadLine()) != null){
                    Console.WriteLine("Reading : " + message);
                }
            }
        }
        catch (IOException ex){
            Console.WriteLine("IOException in Reader Thread : " + ex.Message);
        }
    }
}
