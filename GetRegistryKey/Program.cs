using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace GetRegistryKey
{
    class Program
    {
        private static RegistryKey uninstallKey;
        static void Main(string[] args)
        {
            //Console.WriteLine(UninstallRegistryKey);
            findRegistryKey();
            Console.ReadLine();  
        }
        private static RegistryKey UninstallRegistryKey
        {
            get
            {
                if (uninstallKey == null)
                {
                    RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
                    RegistryKey uninstallRoot = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                    if (uninstallRoot != null)
                    {
                        foreach (string subKeyName in uninstallRoot.GetSubKeyNames())
                        {
                            Console.WriteLine(subKeyName);
                            RegistryKey subKey = uninstallRoot.OpenSubKey(subKeyName);
                            string displayName = subKey.GetValue("DisplayName", String.Empty).ToString();
                            Console.WriteLine(displayName);
                            if (displayName.Equals("Demandforce Sync Client"))
                            {
                                uninstallKey = subKey;
                                break;
                            }
                        }
                    }
                }

                return uninstallKey;
            }
        }

        private static void findRegistryKey()
        {
            RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default);
            RegistryKey uninstallRoot = hklm.OpenSubKey(@"SOFTWARE");
            if (uninstallRoot != null)
            {
                foreach (string subKeyName in uninstallRoot.GetSubKeyNames())
                {
                    Console.WriteLine(subKeyName);
                    RegistryKey subKey = uninstallRoot.OpenSubKey(subKeyName);
                    string displayName = subKey.GetValue("DisplayName", String.Empty).ToString();
                    Console.WriteLine(displayName);
                    if (displayName.Equals("Demandforce Sync Client"))
                    {
                        uninstallKey = subKey;
                        break;
                    }
                }
                Console.WriteLine(uninstallKey);
            }
        }
    }
}
