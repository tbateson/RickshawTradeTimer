using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RickshawTradeTimer {
    public static class Log {
        /*static StreamWriter sw = new StreamWriter("log.log", true);*/

        public static void _(string line) {
            /*sw.WriteLine(line);
            sw.Flush();*/
        }

        public static void Dispose() {
            /*sw.Close();*/
        }
    }
}
