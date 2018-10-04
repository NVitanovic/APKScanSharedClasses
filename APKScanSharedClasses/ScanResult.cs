using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APKScanSharedClasses
{
    public class ScanResult
    {
        public string hash { get; set; }
        public List<string> filename { get; set; } = new List<string>();
        public List<string> upload_ip { get; set; } = new List<string>();
        public Dictionary<string, string> av { get; set; } //av_results
    }
}
