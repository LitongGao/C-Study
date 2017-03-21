using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;

namespace KillApp
{
    class Program
    {
        private static RegistryKey uninstallkey;
        private static RegistryKey UninstallRegistryKey
        {
            get
            {
                if (uninstallkey == null)
                {
                    RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
                    RegistryKey uninstallRoot = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                    if (uninstallRoot != null)
                    {
                        foreach (string subKeyName in uninstallRoot.GetSubKeyNames())
                        {
                            RegistryKey subKey = uninstallRoot.OpenSubKey(subKeyName);
                            string displayName = subKey.GetValue("DisplayName", String.Empty).ToString();
                            if (displayName.Equals("Demandforce Sync Client"))
                            {
                                uninstallkey = subKey;
                                break;
                            }
                        }
                    }
                }
                return uninstallkey;
            }
        }
        static void Main(string[] args)
        {
            //Process pro = new Process();
            //pro.StartInfo.FileName ="DFLinkConfig.exe";
            //pro.Kill();
            //GetProcess();
            RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
            RegistryKey uninstallRoot = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            using (var fs = new StreamWriter(@"E:\test.txt"))
            {
                foreach (string subKeyName in uninstallRoot.GetSubKeyNames())
                {
                    RegistryKey subKey = uninstallRoot.OpenSubKey(subKeyName);
                    string displayName = subKey.GetValue("DisplayName", String.Empty).ToString();
                    Console.SetOut(fs);
                    Console.WriteLine(displayName);
                }
            }

            //Console.WriteLine(UninstallRegistryKey.GetValue("DisplayName", String.Empty).ToString());
            Console.ReadKey();
        }

        public static void GetProcess()
        {
            foreach (Process p in Process.GetProcesses())
            {
                if (p.ProcessName == "DFLinkConfig")
                {
                    p.Kill();
                }
            }
        }


    }
}
