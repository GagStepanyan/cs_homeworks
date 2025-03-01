/*

Task 3: File Download Simulation
Task: Create a class FileDownload with:
1. Constructor that prints "Download started".
2. Add a destructor that prints "Download completed".
3. In Main(), create an object inside a method and observe when the destructor is called.

*/

using System;

class FileDownload {
    public FileDownload() {
        Console.WriteLine("Download started");
    }

     ~FileDownload() {
        Console.WriteLine("Download completed");
    }
}

class Program {

    static void Main(string[] args) {
        Console.WriteLine("Main method is started");
        DownloadFile();
        Console.WriteLine("Download file method has returned to Main method");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("Main method is about to end");
    }
    static void DownloadFile() {
        Console.WriteLine("DownloadFile method is started");
        FileDownload fileDownload = new FileDownload();
        Console.WriteLine("FileDownload object is created");
        Console.WriteLine("DownloadFile method is about to end");
    }
     
}