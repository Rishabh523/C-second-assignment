using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the file path
        string filePathname = @"D:\\MyFile.txt";

        try
        {
            // Check if the file exists
            if (File.Exists(filePathname))
            {
                // Delete the file
                File.Delete(filePathname);
                Console.WriteLine("The file has been deleted successfully.");
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadKey();
    }
}
