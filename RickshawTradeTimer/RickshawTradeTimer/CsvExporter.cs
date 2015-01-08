using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

//TODO: Prompt user when they exit without saving the csv file

namespace RickshawTradeTimer {
    public class CsvExporter {
        const string ToplineStart = "Date";
        const string ToplineBase = ",System,Station,Commodity,Buy Price,Sell Price";
        const string ToplineCheckpoint = ",Checkpoint";
        const string ToplineEnd = ",Time,Tons,Profit,Profit Per Hour";
        string Topline = ToplineStart + ToplineBase + ToplineEnd;

        public bool NeedToSave { get; private set; }
        List<string> routeCsvs = new List<string>();

        public CsvExporter() {
            routeCsvs.Add(Topline);
        }

        public CsvExporter(Route route) {
            SetTopline(route);
            routeCsvs.Add(Topline);
        }

        public CsvExporter(List<string> routeCsvs) {
            this.routeCsvs = routeCsvs;
        }

        private void SetTopline(Route route) {
            string newTopline = ToplineStart;
            for(int i=0;i<route.Stations.Count;i++) {
                newTopline += ToplineBase;
                if(i+1 < route.Stations.Count) { 
                    newTopline += ToplineCheckpoint;
                }
            }
            newTopline += ToplineEnd;
            Topline = newTopline;
        }

        public void SetTopline(string s) {
            Topline = s;
            if(routeCsvs.Count > 0) routeCsvs[0] = Topline;
        }

        public void DirectAppend(string s) {
            routeCsvs.Add(s);
        }

        public void AppendRoute(Route route) {
            string routeCsv = DateTime.Now.ToString();
            for(int i=0;i<route.Stations.Count;i++) {
                routeCsv += ("," + route.Systems[i] + "," + route.Stations[i] + "," + route.Commodities[i] + "," + route.BuyPrices[i] + "," + route.SellPrices[i]);
                if(i+1 < route.Stations.Count) {
                    routeCsv += ("," + route.CheckpointTimes(i));
                }
            }
            routeCsv += ("," + route.Time + "," + route.Tons + "," + route.Profit() + "," + route.ProfitPerHour());
            routeCsvs.Add(routeCsv);
            NeedToSave = true;
        }

        public void LoadDataGridView(DataGridView dgv) {
            dgv.Invoke((Action)(() => {
                string[] splitTop = Topline.Split(',');
                dgv.Columns.Clear();
                for(int i=0;i<splitTop.Length;i++) {
                    DataGridViewColumn dgvc = new DataGridViewTextBoxColumn();
                    dgv.Columns.Add(dgvc);
                    dgv.Columns[i].Frozen = false;
                    dgv.Columns[i].HeaderText = splitTop[i];
                    if(splitTop[i] == "Date") { dgv.Columns[i].Width = 130; }
                }
                if(routeCsvs.Count - 1 > dgv.Rows.Count) {
                    dgv.Rows.Add(routeCsvs.Count - 1 - dgv.Rows.Count);
                }
                for(int i=1;i<routeCsvs.Count;i++) {
                    string[] rowData = routeCsvs[i].Split(',');
                    for(int j=0;j<rowData.Length && j<dgv.Rows[i-1].Cells.Count;j++) {
                        dgv.Rows[i-1].Cells[j].Value = rowData[j];
                    }                    
                }
            }));
        }

        public void Export(Stream s) {
            StreamWriter sw = new StreamWriter(s);
            foreach(string routeCsv in routeCsvs) {
                sw.WriteLine(routeCsv);
            }
            sw.Close();
            NeedToSave = false;
        }
    }
}
