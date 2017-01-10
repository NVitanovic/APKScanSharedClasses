using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APKScanSharedClasses
{
    public class RedisReceive : RedisSend
    {
        public string master_id { get; set; }
        public Dictionary<string, string> av_results { get; set; } = new Dictionary<string, string>();
    }
}
