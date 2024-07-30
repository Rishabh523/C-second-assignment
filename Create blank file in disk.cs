class Program
{
    static void Main()
    {
        string filePathname = @"D:\\BlankFile.txt";

        try
        {
            if (File.Exists(filePathname))
            {
                File.Delete(filePathname);
                Console.WriteLine("Existing file deleted.");
            }

            using (FileStream fs = File.Create(filePathname))
            {
            }

            Console.WriteLine("A new blank file has been created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        Console.ReadKey();
    }
}
