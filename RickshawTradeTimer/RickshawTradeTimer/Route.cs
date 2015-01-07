using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RickshawTradeTimer {
    public class Route {
        int currentlyAt = 1;

        public int NumberOfStations { get; set; }
        public bool ContinuousRuns { get; set; }

        public List<string> Systems = new List<string>();
        public List<string> Stations = new List<string>();
        public List<string> Commodities = new List<string>();
        public List<int> BuyPrices = new List<int>();
        public List<int> SellPrices = new List<int>();

        public string CheckpointTimes(int index) { return MilliToTimeString(m_checkptTimes[index]); }
        public string Time { get { return MilliToTimeString(m_time); }}

        List<long> m_checkptTimes = new List<long>();
        long m_time = 0;

        public int Tons { get; set; }

        Stopwatch sw = new Stopwatch();

        public Route() {

        }

        public TimeSpan GetCurrentTime() {
            return sw.Elapsed;
        }

        public int Phase() {
            return currentlyAt;
        }

        public BaseAction NextAction() {
            if(currentlyAt == 1) {
                return BaseAction.Start;
            } else if(NumberOfStations * 2 <= currentlyAt) {
                return BaseAction.End;
            } else if(currentlyAt % 2 == 0) {
                return BaseAction.Checkpoint;
            } else if(currentlyAt % 2 == 1) {
                return BaseAction.Resume;
            }
            return BaseAction.End;
        }

        public void Start() {
            sw.Restart();
            currentlyAt = 2;
        }

        public void Checkpoint(bool pause) {
            currentlyAt += 1;
            if(pause) { sw.Stop(); } else { currentlyAt += 1; }
            m_checkptTimes.Add(sw.ElapsedMilliseconds);
        }

        public void End() {
            currentlyAt = 1;
            if(!ContinuousRuns)
                sw.Stop();
            m_time = sw.ElapsedMilliseconds;
        }
        
        public void Resume() {
            sw.Start();
            currentlyAt += 1;
        }

        
        public int Profit() {
            int profit = 0;
            for(int i=0;i<SellPrices.Count;i++) {
                profit += SellPrices[i] - BuyPrices[i];
            }
            return profit * Tons;
        }

        public long ProfitPerHour() {
            int profit = Profit();
            long totalTime = m_checkptTimes.Sum() + m_time;
            return (long)Math.Floor( (double)profit / ((double)totalTime / 3600000d) );
        }

        public string NextStation() {
            return Systems[(int)Math.Ceiling((float)currentlyAt / 2f) % Stations.Count];
        }

        public string Transit() {
            int stationIndex = (int)Math.Floor((float)currentlyAt / 2f) + Stations.Count;
            return Stations[(stationIndex - 1) % Stations.Count] + " → " +
            Stations[stationIndex % Stations.Count];
        }

        public static string MilliToTimeString(long milliseconds) {
            return (milliseconds / 3600000).ToString("d")     //hours
                   + ":" + (milliseconds / 60000).ToString("d2")  //minutes
                   + ":" + (milliseconds / 1000).ToString("d2");  //seconds
        }

    }
}
