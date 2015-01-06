using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RickshawTradeTimer {
    public static class Settings {
        public static void SaveSettings(string fileOut, string[] settings) {
            StreamWriter sw = new StreamWriter(fileOut);
            foreach(string s in settings) {
                sw.Write(s + ",");
            }
            sw.Close();
        }

        public static string[] LoadSettings(string fileIn) {
            StreamReader sr = new StreamReader(fileIn);
            string properties = sr.ReadToEnd();
            string[] settings = new string[properties.Split(',').Length];
            int index = 0;
            foreach(string p in properties.Split(',')) {
                settings[index] = p;
                index ++;
            }
            sr.Close();
            return settings;
        }
    }
}
