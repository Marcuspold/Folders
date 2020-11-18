using System;
using System.IO;

namespace ClearFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morning Soldier!");
            DeleteAllFiles();
            string RootPath = @"C:\Users\opilane\Samples";

            DirectoryInfo rootDirectory = new DirectoryInfo(RootPath);
            foreach(DirectoryInfo dir in rootDirectory.GetDirectories())
            {
                DeleteAllFolders(dir.FullName, true);
            }

           
        }

        //a function to delete all the files
        
        public static void DeleteAllFiles()
        {
            string RootPath = @"C:\Users\opilane\Samples";
            DirectoryInfo Directory = new DirectoryInfo(RootPath);

            foreach(FileInfo file in Directory.GetFiles())
            {
                file.Delete();
            }


        }
        //a function to delete all the folders
        public static void DeleteAllFolders(string DirectoryName, bool ifExists)
        {
            if (Directory.Exists(DirectoryName))
            {
                Directory.Delete(DirectoryName, true);
            } else if (ifExists)
            {
                throw new SystemException("NO SUCH DIRECTORY TO DELETE FOOLISH FOOL");
            }

        }
        
            
    }
}
