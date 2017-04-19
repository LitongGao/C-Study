using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VerifySpecialFile
{
    public class IOAction
    {
        public static void RemoveFile(string path, string filetype)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    DirectoryInfo di = new DirectoryInfo(path);
                    FileInfo[] fis = di.GetFiles(filetype);
                    foreach (FileInfo fi in fis)
                    {
                        File.SetAttributes(fi.FullName, FileAttributes.Normal);
                        fi.Delete();
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Can not delete the file {0}, and the error is {1}", filetype, e);
            }
        }

        public static void RemoveFile(string filePath)
        {

        }

        public static void CopyFile(string sourcePath, string targetPath, bool isOverWrite=true)
        {
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            //File.Copy(sourcePath, targetPath, true);
            DirectoryInfo di = new DirectoryInfo(sourcePath);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                if (File.Exists(Path.Combine(targetPath, fi.Name)))
                {
                    File.SetAttributes(Path.Combine(targetPath, fi.Name), FileAttributes.Normal);
                }

                try
                {
                    File.Copy(Path.Combine(sourcePath, fi.Name), Path.Combine(targetPath, fi.Name), isOverWrite);
                    Console.WriteLine("Copy file {0}, from {1}", fi.Name, Path.Combine(sourcePath, fi.Name));
                }
                catch (IOException e)
                {

                }
            }
        }
    }
}
