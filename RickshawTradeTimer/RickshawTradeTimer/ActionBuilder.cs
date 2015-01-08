using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Media;


namespace RickshawTradeTimer {    
    public enum BaseAction { Start, End, Checkpoint, Resume, TypeNextStation };

    public class ActionBuilder {
        Thread updateTimeLabel = null;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public bool PauseOnCheckpoint { get; set; }
        public bool PauseOnEnd { get; set; }
        public bool AnnoucerEnabled { get; set; }
        public int AnnoucerVolume { set { synthesizer.Volume = value; }}
        
        public void Track(Label label, Route route) {
            updateTimeLabel = new Thread(() => {
                while(true) {
                    try { 
                        label.BeginInvoke((Action)(() => { label.Text = route.GetCurrentTime().ToString(@"hh\:mm\:ss"); }));
                    } catch(Exception) {
                        break;
                    }
                    Thread.Sleep(10);
                }
            });
            updateTimeLabel.Start();
        }

        public void StopTracking() {
            updateTimeLabel.Abort();
        }

        public void Commit(BaseAction action, Route route, CsvExporter exporter, Label swLabel) {
            switch(action) {
                case BaseAction.Start:
                    Track(swLabel, route);
                    route.Start();                        
                    SpeakAsync("Starting");
                    break;                    
                case BaseAction.End:
                    route.End();
                    SpeakAsync("Ending");
                    exporter.AppendRoute(route);
                    StopTracking();
                    if(!PauseOnEnd) { Commit(BaseAction.Start, route, exporter, swLabel); }
                    break;                    
                case BaseAction.Checkpoint:
                    route.Checkpoint(PauseOnCheckpoint);
                    SpeakAsync("Checkpoint Reached");
                    break;                    
                case BaseAction.TypeNextStation:
                    SendKeys.Send(route.NextStation());
                    break;                    
                case BaseAction.Resume:
                    route.Resume();
                    SpeakAsync("Resuming");
                    break;                    
            }
        }
    
        private void SpeakAsync(string phrase) {
            if(AnnoucerEnabled) {
                synthesizer.SpeakAsync(phrase);
            }
        }
    }
}
