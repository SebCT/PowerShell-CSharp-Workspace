using System;
using System.Runtime.InteropServices;

class Program
{
    // Best solution for hidden window of a console application is -> Output Type to Windows Application
    // https://stackoverflow.com/a/76131350 - To change the Output type from Console Application to Windows Application when using csc compiler add -target:winexe to the csc.exe command like that: 
    // C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe -out:example.exe -target:winexe example.cs

    //[DllImport("kernel32.dll")]
    //static extern IntPtr GetConsoleWindow(); 
    
    //[DllImport("user32.dll")]
    //static extern bool ShowWindow(IntPtr hWnd, int nCmdShow); // -> Hide console windows: https://stackoverflow.com/questions/34440916/hide-the-console-window-from-a-console-application/34440934#34440934

    [DllImport("user32.dll")]
    public static extern bool SetSysColors(int cElements, int[] lpaElements, int[] lpaRgbValues);

    static void Main(string[] args)
    {
        //const int SW_HIDE = 0;
        //var handle = GetConsoleWindow();

        //ShowWindow(handle, SW_HIDE); // To hide
        
        // Set background color to a specific RGB value
        SetSysColors(1, new int[] { 1 }, new int[] { 0x000001 });
        SetSysColors(1, new int[] { 1 }, new int[] { 0x000000 });

    }
}
