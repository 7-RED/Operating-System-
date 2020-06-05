using System;

namespace Page4KB
{
    
    class Program
    {
        private const int PAGE_4KB = 4096;
        public static uint address;
        private static uint page_number;
        private static uint offset;

        static void Main(string[] args)
        {
            try
            {

                if (args.Length < 2)
                {
                    START:
                    Console.WriteLine("Enter the address: ");
                    string readline = Console.ReadLine();
                    if(uint.TryParse(readline, out address) && address<=4096)
                    {
                        page_number = address / 4096;
                        offset = address % 4096;
                        Console.WriteLine("The address "+address+ " contains:");
                        Console.WriteLine("Page number = "+ page_number/4096);
                        Console.WriteLine("Offset = "+ offset);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("輸入錯誤格式");
                        Console.ReadKey();
                        goto START;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
