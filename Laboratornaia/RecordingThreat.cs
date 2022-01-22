using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaia
{
    public class RecordingThreat
    {
        public List<object> values;

        public event PropertyChangedEventHandler PropertyChanged;

        public string ThreatID { get; set; }
        public string Naming { get; set; }

        private string description;
        public string Description
        {
            get => description;
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
            }
        }
        private string source;
        public string Source
        {
            get => source;
            set
            {
                source = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Source)));
            }
        }
        private string target;
        public string Target
        {
            get => target;
            set
            {
                target = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Target)));
            }
        }
        public string confidentiality;
        public string Confidentiality
        {
            get => confidentiality;
            set
            {
                _ = value == "1" ? confidentiality = "да" : confidentiality = "нет";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Confidentiality)));
            }
        }
        private string integrity;
        public string Integrity
        {
            get => integrity;
            set
            {
                _ = value == "1" ? integrity = "да" : integrity = "нет";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Integrity)));
            }
        }
        private string accessibility;
        public string Accessibility
        {
            get => accessibility;
            set
            {
                _ = value == "1" ? accessibility = "да" : accessibility = "нет";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accessibility)));
            }
        }



        //Конструктор
        public RecordingThreat(string threatID, string naming, string description, string source, string whichObjectTarget, string confidentiality, string integrity, string accessibility)
        {
            ThreatID = threatID;
            Naming = naming;
            Description = description;
            Source = source;
            Target = whichObjectTarget;
            Confidentiality = confidentiality;
            Integrity = integrity;
            Accessibility = accessibility;
        }
    }
}
