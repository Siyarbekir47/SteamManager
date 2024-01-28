﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Microsoft.VisualBasic.ApplicationServices;
using static SteamManager.MainForm;
using SteamManager;

public static class SteamData
{


    public static String GetCurrentSteamID64()
    {
        string SteamID3 = null;
        string SteamID64 = null;
        string SteamID64_BASE = "76561197960265728";


        try
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam\ActiveProcess"))
            {
                if (key != null)
                {
                    Object o = key.GetValue("ActiveUser");
                    if (o != null)
                    {
                        SteamID3 = o.ToString();
                        if(SteamID3 == "0")
                        {
                            MessageBox.Show("Login to Steam first.");
                            return null;
                        }

                        Int64 SteamID3Int = 0;
                        Int64 SteamID64Int = 0;

                        Int64.TryParse(SteamID3, out SteamID3Int);
                        Int64.TryParse(SteamID64_BASE, out SteamID64Int);


                        return (SteamID3Int + SteamID64Int).ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return null;
    }


}
