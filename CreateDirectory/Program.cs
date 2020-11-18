using System.IO;
using System;

namespace CreateDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning Soldier!");
            CreateFolderOne();
            CreateFolderTwo();
        }
        public static void CreateFolderOne()
        {
            string RootPath = @"C:\Users\opilane\Samples";
            string FolderName = "PlayerOne";
            string FullFolderPath = Path.Combine(RootPath, FolderName);
            Console.WriteLine(FullFolderPath);
            if (Directory.Exists(FullFolderPath)) //check if folder exists
            {
                Console.WriteLine("Maybe You Should Use More Of Your Eyes?");
            } else
            {
                Directory.CreateDirectory(FullFolderPath);
            }
        }


        public static void CreateFolderTwo()
        {
            string RootPath = @"C:\Users\opilane\Samples";
            string FolderName = "PlayerTwo";
            string FullFolderPath = Path.Combine(RootPath, FolderName);
            Console.WriteLine(FullFolderPath);
            if (Directory.Exists(FullFolderPath)) //check if folder exists
            {
                Console.WriteLine("Maybe You Should Use More Of Your Eyes?");
            } else
            {
                Directory.CreateDirectory(FullFolderPath);
            }
        }
    }
}
