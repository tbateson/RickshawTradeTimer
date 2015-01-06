using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RickshawTradeTimer {
    public class CsvImporter {

        public List<string> Systems = new List<string>();
        public List<string> Stations = new List<string>();
        public List<string> Commodities = new List<string>();
        public List<string> BuyPrices = new List<string>();
        public List<string> SellPrices = new List<string>();
        public string Time;
        public string Tons;
        public string Profit;
        public string PPH;

        CsvExporter exporter = new CsvExporter();

        public CsvImporter(Stream s) {
            StreamReader sr = new StreamReader(s);
            string curln = string.Empty;
            int index = 0;
            while(true) {
                string tmpln = sr.ReadLine();
                if(tmpln == null) break;
                if(index++ == 0) { exporter.SetTopline(tmpln); }
                else  { 
                    exporter.DirectAppend(tmpln);
                    curln = tmpln;
                }
            }
            string[] split = curln.Split(',');
            for(int i=0;i<split.Length-6;i+=6) {
                Systems.Add(split[i+1]);
                Stations.Add(split[i+2]);
                Commodities.Add(split[i+3]);
                BuyPrices.Add(split[i+4]);
                SellPrices.Add(split[i+5]);
            }
            Time = split[split.Length-4];
            Tons = split[split.Length-3];
            Profit = split[split.Length-2];
            PPH = split[split.Length-1];
            sr.Close();
        }

        public CsvExporter ToCsvExporter() {
            return exporter;
        }
    }

   
}
