using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APKScanSharedClasses;
namespace APKScanSharedClasses
{
    public class SharedConfiguration
    {
        public Redis redis { get; set; }
        public Cassandra cassandra { get; set; }
        public Mongo mongo { get; set; }
        public MySQL mysql { get; set; }
    }
    public class Redis
    {
        public List<string> masters { get; set; }
        public List<string> slaves { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class Cassandra
    {
        public List<string> servers { get; set; }
        public string keyspace { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
    public class MySQL
    {
        public string hostname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string database { get; set; }
        public string otheropt { get; set; }
    }
    public class Mongo
    {
        public List<string> servers { get; set; }
        public string database { get; set; }
        public string replicaset { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
