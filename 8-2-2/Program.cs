namespace _8_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
                DirectoryInfo directoryInfo = new DirectoryInfo (@"C:\Новая ПапкаС");
                if (!directoryInfo.Exists)
                    directoryInfo.Create();
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

            }
            catch {
            Console.WriteLine("чето не совсем ваушное");
            }




        }
    }
}
