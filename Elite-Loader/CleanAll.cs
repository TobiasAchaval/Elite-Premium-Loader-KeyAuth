using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace BetterCleaner
{
    internal class CleanAll
    {
        public static void CleanUserData()
        {
            string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string username = userProfilePath.Substring(userProfilePath.LastIndexOf('\\') + 1);

            try
            {
                string path = @"C:\Users\" + username + @"\AppData\Local\FiveM\FiveM.app\data";

                Directory.Delete(path, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path1 = @"C:\Users\" + username + @"\AppData\Local\FiveM\FiveM.app\logs";

                Directory.Delete(path1, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path2 = @"C:\Users\" + username + @"\AppData\Local\FiveM\FiveM.app\crashes";

                Directory.Delete(path2, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path3 = @"C:\Users\" + username + @"\AppData\Local\FiveM\FiveM.app\citizen";

                Directory.Delete(path3, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path4 = @"C:\Users\" + username + @"\AppData\Roaming\CitizenFX";

                Directory.Delete(path4, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path5 = @"C:\Users\" + username + @"\AppData\Local\FiveM\FiveM.app";

                Directory.Delete(path5, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------           
            try
            {
                string path6 = @"C:\Users\" + username + @"\AppData\Local\Temp";

                Directory.Delete(path6, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path7 = @"C:\Users\" + username + @"\AppData\Local\DigitalEntitlements";

                Directory.Delete(path7, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            try
            {
                string path8 = @"C:\Windows\Temp";

                Directory.Delete(path8, true);
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName = @"SOFTWARE\Microsoft\MSLicensing";

            string subkeyName = "HardwareID";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                    .OpenSubKey(keyName, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName1 = @"SOFTWARE\Microsoft\MSLicensing";

            string subkeyName1 = "Store";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                    .OpenSubKey(keyName1, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName1);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName2 = @"Software\WinRAR";

            string subkeyName2 = "ArcHistory";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName2, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName2);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName3 = @"SYSTEM\ControlSet001\Services\bam\State\UserSettings";

            string subkeyName3 = "S-1-5-21-1282084573-1681065996-3115981261-1001";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                    .OpenSubKey(keyName3, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName3);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName4 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage";

            string subkeyName4 = "ShowJumpView";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName4, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName4);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName5 = @"Software\Classes\Local Settings\Software\Microsoft\Windows\Shell";

            string subkeyName5 = "MuiCache";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName5, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName5);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName6 = @"Software\WinRAR";

            string subkeyName6 = "ArcHistory";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName6, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName6);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName7 = @"Software\Classes\Local Settings\Software\Microsoft\Windows\Shell";

            string subkeyName7 = "MuiCache";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName7, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName7);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName8 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage";

            string subkeyName8 = "AppSwitched";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName8, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName8);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName9 = @"Local Settings\Software\Microsoft\Windows\Shell";

            string subkeyName9 = "MuiCache";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64)
                    .OpenSubKey(keyName9, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName9);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName10 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage";

            string subkeyName10 = "ShowJumpView";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName10, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName10);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName11 = @"SYSTEM\ControlSet001\Services\bam\State\UserSettings";

            string subkeyName11 = "S-1-5-21-332004695-2829936588-140372829-1002";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                    .OpenSubKey(keyName11, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName11);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName12 = @"Local Settings\Software\Microsoft\Windows\Shell";

            string subkeyName12 = "MuiCache";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64)
                    .OpenSubKey(keyName12, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName12);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName13 = @"Software\Classes\Local Settings\Software\Microsoft\Windows\Shell";

            string subkeyName13 = "MuiCache";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName13, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName13);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName14 = @"Software\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant";

            string subkeyName14 = "Store";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName14, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName14);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName15 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage";

            string subkeyName15 = "AppSwitched";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName15, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName15);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName16 = @"SYSTEM\ControlSet001\Services\bam\State\UserSettings";

            string subkeyName16 = "S-1-5-21-1282084573-1681065996-3115981261-1001";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                    .OpenSubKey(keyName16, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName16);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName17 = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage";

            string subkeyName17 = "AppSwitched";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName17, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName17);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName18 = @"Software\CitizenFX";

            string subkeyName18 = "FiveM";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName18, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName18);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName19 = @"Software\CitizenFX";

            string subkeyName19 = "DownloadCount";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName19, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName19);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName20 = @"Software\CitizenFX";

            string subkeyName20 = "AppID_Catalog";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName20, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName20);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName21 = @"Software\FiveM\Capabilities";

            string subkeyName21 = "URLAssociations";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName21, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName21);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }
            //------------------------------------------------------------------------------------------------------------------------------------
            string keyName22 = @"Software\FiveM\Capabilities";

            string subkeyName22 = "URLAssociations";

            try
            {
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64)
                    .OpenSubKey(keyName22, true);

                if (key != null)
                {
                    key.DeleteSubKey(subkeyName22);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception();
            }

            int finished = 2;
            if (finished == 2)
            {
                
            }
            //------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}