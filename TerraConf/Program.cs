using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TerraConf
{
    static class Program
    {

        public static string ConfigPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + Path.DirectorySeparatorChar + "My Games" + Path.DirectorySeparatorChar + "Terraria" + Path.DirectorySeparatorChar + "config.dat";
        
        // Main Settings
        public static int curRelease = 102;
        public static string clientUUID = Guid.NewGuid().ToString();
        public static bool IsFullScreen = false;
        public static byte mouseColor_R = 255;
        public static byte mouseColor_G = 50;
        public static byte mouseColor_B = 95;
        public static float soundVolume = 1f;
        public static float ambientVolume = 0.75f;
        public static float musicVolume = 0.75f;
        public static float caveParallax = 1.0f;
        public static bool fixedTiming = false;
        public static bool screenMaximized = false;
        public static Int32 PreferredBackBufferWidth = 800;
        public static Int32 PreferredBackBufferHeight = 600;
        public static bool autoSave = true;
        public static bool autoPause = false;
        public static bool showItemText = true;
        public static byte lightMode = 0;
        public static byte qaStyle = 0;
        public static bool owBack = true; // display background?
        public static byte lang = 1;
        public static bool mapEnabled = true;
        public static int LightingThreads; // check r/w type
        public static bool SmartToggle = true;

        // Key Bindings
        public static string cUp = "W";
        public static string cDown = "S";
        public static string cLeft = "A";
        public static string cRight = "D";
        public static string cJump = "Space";
        public static string cThrowItem = "T";
        public static string cInv = "Escape";
        public static string cHeal ="H";
        public static string cMana = "J";
        public static string cBuff = "B";
        public static string cHook = "E";
        public static string cTorch = "LeftShift";
        public static string cMapStyle = "Tab";
        public static string cMapFull = "M";
        public static string cMapZoomIn = "Add";
        public static string cMapZoomOut = "Subtract";
        public static string cMapAlphaUp = "PageUp";
        public static string cMapAlphaDown = "PageDown";
        public static string cSmart = "LeftControl";

        public static void SaveConfig()
        {

            bool success = false;

            try
            {
                // backup existing file
                File.Copy(ConfigPath, ConfigPath + ".TConf", true);
                // create new config.dat file
                using (FileStream fileStream = new FileStream(ConfigPath, FileMode.Create))
                {
                    using (BinaryWriter binaryWriter = new BinaryWriter((Stream) fileStream))
                    {
                        binaryWriter.Write(curRelease);
                        binaryWriter.Write(clientUUID);
                        binaryWriter.Write(IsFullScreen);
                        binaryWriter.Write(mouseColor_R);
                        binaryWriter.Write(mouseColor_G);            
                        binaryWriter.Write(mouseColor_B);
                        binaryWriter.Write(soundVolume);
                        binaryWriter.Write(ambientVolume);
                        binaryWriter.Write(musicVolume);
                        binaryWriter.Write(cUp);
                        binaryWriter.Write(cDown);
                        binaryWriter.Write(cLeft);
                        binaryWriter.Write(cRight);
                        binaryWriter.Write(cJump);
                        binaryWriter.Write(cThrowItem);
                        binaryWriter.Write(cInv);
                        binaryWriter.Write(cHeal);
                        binaryWriter.Write(cMana);
                        binaryWriter.Write(cBuff);
                        binaryWriter.Write(cHook);
                        binaryWriter.Write(caveParallax);
                        binaryWriter.Write(fixedTiming);
                        binaryWriter.Write(screenMaximized);
                        binaryWriter.Write(PreferredBackBufferWidth);
                        binaryWriter.Write(PreferredBackBufferHeight);
                        binaryWriter.Write(autoSave);
                        binaryWriter.Write(autoPause);
                        binaryWriter.Write(showItemText);
                        binaryWriter.Write(cTorch);
                        binaryWriter.Write((byte) lightMode);
                        binaryWriter.Write((byte) qaStyle);
                        binaryWriter.Write(owBack);
                        binaryWriter.Write((byte) lang);
                        binaryWriter.Write(mapEnabled);
                        binaryWriter.Write(cMapStyle);
                        binaryWriter.Write(cMapFull);
                        binaryWriter.Write(cMapZoomIn);
                        binaryWriter.Write(cMapZoomOut);
                        binaryWriter.Write(cMapAlphaUp);
                        binaryWriter.Write(cMapAlphaDown);
                        binaryWriter.Write(LightingThreads);
                        binaryWriter.Write(cSmart);
                        binaryWriter.Write(SmartToggle);
                        binaryWriter.Close();
                        success = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            if (success)
                MessageBox.Show("Updated config.dat saved, original saved as config.data.TConf.");

        }

        public static bool IsGameRunning()
        {
            return Process.GetProcesses().Any(p => p.ProcessName.Equals("Terraria"));
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            if (args.Length > 0 && args[0].ToLower() == "default")
            {
                MessageBox.Show("Current config.dat ignored, defaults loaded.");
            }
            else
            {

                try
                {
                    using (FileStream fileStream = new FileStream(ConfigPath, FileMode.Open))
                    {
                        using (BinaryReader cfgFile = new BinaryReader(fileStream))
                        {

                            // TODO:  Add the conditional logic to support multiple versions
                            // currently assumes 1.2.4.1 (curRelease = 102)

                            curRelease = cfgFile.ReadInt32();
                            clientUUID = cfgFile.ReadString();
                            IsFullScreen = cfgFile.ReadBoolean();
                            mouseColor_R = cfgFile.ReadByte();
                            mouseColor_G = cfgFile.ReadByte();
                            mouseColor_B = cfgFile.ReadByte();
                            soundVolume = cfgFile.ReadSingle();
                            ambientVolume = cfgFile.ReadSingle();
                            musicVolume = cfgFile.ReadSingle();
                            cUp = cfgFile.ReadString();
                            cDown = cfgFile.ReadString();
                            cLeft = cfgFile.ReadString();
                            cRight = cfgFile.ReadString();
                            cJump = cfgFile.ReadString();
                            cThrowItem = cfgFile.ReadString();
                            cInv = cfgFile.ReadString();
                            cHeal = cfgFile.ReadString();
                            cMana = cfgFile.ReadString();
                            cBuff = cfgFile.ReadString();
                            cHook = cfgFile.ReadString();
                            caveParallax = cfgFile.ReadSingle();
                            fixedTiming = cfgFile.ReadBoolean();
                            screenMaximized = cfgFile.ReadBoolean();
                            PreferredBackBufferWidth = cfgFile.ReadInt32();
                            PreferredBackBufferHeight = cfgFile.ReadInt32();
                            autoSave = cfgFile.ReadBoolean();
                            autoPause = cfgFile.ReadBoolean();
                            showItemText = cfgFile.ReadBoolean();
                            cTorch = cfgFile.ReadString();
                            lightMode = cfgFile.ReadByte();
                            qaStyle = cfgFile.ReadByte();
                            owBack = cfgFile.ReadBoolean();
                            lang = cfgFile.ReadByte();
                            mapEnabled = cfgFile.ReadBoolean();
                            cMapStyle = cfgFile.ReadString();
                            cMapFull = cfgFile.ReadString();
                            cMapZoomIn = cfgFile.ReadString();
                            cMapZoomOut = cfgFile.ReadString();
                            cMapAlphaUp = cfgFile.ReadString();
                            cMapAlphaDown = cfgFile.ReadString();
                            LightingThreads = cfgFile.ReadInt32();
                            // sanity check
                            if (LightingThreads > Environment.ProcessorCount)
                                LightingThreads = Environment.ProcessorCount - 1;
                            cSmart = cfgFile.ReadString();
                            SmartToggle = cfgFile.ReadBoolean();

                            cfgFile.Close();
                        }

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show("Error reading config.dat: " + ConfigPath + "\n" + e.Message);
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TCForm());
        }
    }
}
