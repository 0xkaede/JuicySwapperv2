using System;
using DiscordRPC;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Juicy_Swapper_v2.Classes.API.StatusAPI;
using System.Diagnostics;
using System.IO;
using Juicy_Swapper_v2.Properties;
using Juicy_Swapper_v2.Forms.Dialogs;
using System.Media;
using System.Threading.Tasks;

namespace Juicy_Swapper_v2.Classes
{
    class JuicyUtilities
    {
        public static readonly DiscordRpcClient DiscordRPC = new DiscordRpcClient("753411856999121049");

        private static string GetEpicDirectory() => Directory.Exists(@"C:\ProgramData\Epic") ? @"C:\ProgramData\Epic" : Directory.Exists(@"D:\ProgramData\Epic") ? @"D:\ProgramData\Epic" : Directory.Exists(@"E:\ProgramData\Epic") ? @"E:\ProgramData\Epic" : @"F:\ProgramData\Epic";

        private static bool DatFileExists() => File.Exists($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");

        public static void SetRPCLocation(string Location, string ImageKey)
        {
            DiscordRPC.SetPresence(new RichPresence
            {
                Details = "juicyswapper.xyz",
                Timestamps = Timestamps.Now,
                Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"In {Location} Tab" }
            });
        }

        public static void SetRPCAction(string Action, string ImageKey)
        {
            DiscordRPC.SetPresence(new RichPresence
            {
                Details = "juicyswapper.xyz",
                Timestamps = Timestamps.Now,
                Assets = new Assets { LargeImageKey = "mainrpcimg", SmallImageKey = ImageKey, LargeImageText = $"🧃 • Version v{Application.ProductVersion}", SmallImageText = $"{Action}" }
            });
        }

        public static bool IsValidJson(string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) ||
                (strInput.StartsWith("[") && strInput.EndsWith("]")))
            {
                try
                {
                    JToken obj = JToken.Parse(strInput);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void GetStatus()
        {
            var StatusAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/status");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);

            if (StatusResponse.IsOnline == false)
            {
                new OfflineMode().ShowDialog();
            }
            if (StatusResponse.Version != $"{Application.ProductVersion}")
            {
                new Update().ShowDialog();
            }
            if (StatusResponse.MiscTabEnabled == false)
            {
                Settings.Default.miscTabEnabled = false;
            }
            else if (StatusResponse.MiscTabEnabled != false)
            {
                Settings.Default.miscTabEnabled = true;
            }
            if (StatusResponse.SkinTabEnabled == false)
            {
                Settings.Default.skinTabEnabled = false;
            }
            else if (StatusResponse.SkinTabEnabled != false)
            {
                Settings.Default.skinTabEnabled = true;
            }

        }

        public static void ExecuteAsAdmin(string fileName)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = fileName;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
        }

        public static void FindPaks()
        {
            if (DatFileExists())
            {
                string jsonData = File.ReadAllText($@"{GetEpicDirectory()}\UnrealEngineLauncher\LauncherInstalled.dat");
                if (IsValidJson(jsonData))
                {
                    JToken FortnitePath = JsonConvert.DeserializeObject<JToken>(jsonData);
                    if (FortnitePath != null)
                    {
                        JArray installationListArray = FortnitePath["InstallationList"].Value<JArray>();
                        if (installationListArray != null)
                        {
                            foreach (JToken FortnitePathReal in installationListArray)
                            {
                                if (string.Equals(FortnitePathReal["AppName"].Value<string>(), "Fortnite"))
                                {
                                    string path = $@"{FortnitePathReal["InstallLocation"].Value<string>()}\FortniteGame\Content\Paks";
                                    Settings.Default.pakPath = path;
                                    Settings.Default.Save();
                                    Settings.Default.Save();
                                }
                            }
                        }
                    }
                }
            }
        }

        public async static void PlayPreview(UnmanagedMemoryStream Resource, Bunifu.Framework.UI.BunifuFlatButton Button)
        {
            using (var player = new SoundPlayer(Resource))
            {
                Button.Enabled = false;
                await Task.Run(() => { player.Load(); player.PlaySync(); });
                Button.Enabled = true;
            }            
        }

        public static void CloseEpicProcesses()
        {
            Process[] processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_EAC");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteClient-Win64-Shipping_BE");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("EpicGamesLauncher");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("UnrealCEFSubProcess");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("FortniteLauncher");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("EasyAntiCheat");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
            processesByName = Process.GetProcessesByName("umodel");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        public static void AddCustomPak(string URL, string pakNumber, RichTextBox TextBox, Bunifu.Framework.UI.BunifuFlatButton Button)
        {
            TextBox.Clear();
            TextBox.Text += "[LOG] Starting...";

            // If an existing sig was found, delete it.
            if (File.Exists(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.sig"))
            {
                File.Delete(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.sig");
                TextBox.Text += "\n[LOG] Removed old .sig file";
            }

            // If an existing pak was found, delete it.
            if (File.Exists(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.pak"))
            {
                File.Delete(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.pak");
                TextBox.Text += "\n[LOG] Removed old .pak file";
            }

            // Prevent the user from adding more than 2 paks due to technical limitations
            if (Settings.Default.pakCount >= 2)
            {
                TextBox.Text += "\n[LOG] ERROR! Consult error dialog...";
                MessageBox.Show("You currently have 2 items swapped, and we can't currently allow for more than two items.\nIf you'd like to swap a different item, simply revert one of your currently converted items.", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Download the sigs and paks.
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://juicyswapper.xyz/sig", Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.sig");
                    TextBox.Text += "\n[LOG] Added .sig file";
                    client.DownloadFile(URL, Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.pak");
                    TextBox.Text += "\n[LOG] Added .pak file";
                    Settings.Default.pakCount++;
                    Settings.Default.Save();
                    Button.Text = "Revert";
                    TextBox.Text += "\n[LOG] Conversion complete!";
                }
            }
        }

        public static void RemoveCustomPak(string pakNumber, RichTextBox TextBox, Bunifu.Framework.UI.BunifuFlatButton Button)
        {
            // Delete the pak, if found.
            if (File.Exists(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.pak"))
            {
                TextBox.Clear();
                TextBox.Text += "[LOG] Starting...";
                File.Delete(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.pak");
                TextBox.Text += "\n[LOG] Removed .pak file";
            }
            // Delete the sig, if found.
            if (File.Exists(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.sig"))
            {
                File.Delete(Settings.Default.pakPath + "\\pakchunk" + pakNumber + "-WindowsClient.sig");
                TextBox.Text += "\n[LOG] Removed .sig file";
            }
            Settings.Default.pakCount--;
            Settings.Default.Save();
            Button.Text = "Convert";
            TextBox.Text += "\n[LOG] Reversion complete!";
        }
    }
}