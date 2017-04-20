using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

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
                    FileInfo[] fis = di.GetFiles(filetype, SearchOption.AllDirectories);
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

        public static void RemoveFile(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ClearFolderAttributes(folderPath);
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = @"cmd.exe";
                    p.StartInfo.Arguments = "/c rmdir /s /q \"" + folderPath + "\"";
                    p.Start();
                    p.WaitForExit();
                }
            }
        }

        public static void ClearFolderAttributes(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                string[] folders = Directory.GetDirectories(folderPath);
                foreach (string folder in folders)
                {
                    ClearFolderAttributes(folder);
                }

                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                } 
            }
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

        public static string[] ShowFile(string filePath)
        {
            if (Directory.Exists(filePath))
            {
                string[] subDirs = Directory.GetDirectories(filePath);
                foreach (string subDir in subDirs)
                {
                    ShowFile(subDir);
                }

                string[] files = Directory.GetFiles(filePath);
                return files;
            }

            return null;
        }
    }
}
