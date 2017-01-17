using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APKScanSharedClasses
{
    public enum eTask { rollbackSnapshot, createSnapshot }
    public class RedisProxmox
    {
        public string vm_id { get; set; }
        public eTask task { get; set; }
        public string master_id { get; set; }
        public string auth { get; set; }
    }
    public class RedisProxmoxResult
    {
        public string master_id { get; set; }
        public DateTime lastRun { get; set; }
        public eTask lastTask { get; set; }
        public bool status { get; set; }
    }
}
