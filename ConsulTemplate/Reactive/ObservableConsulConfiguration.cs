using System;

namespace ConsulTemplate.Reactive
{
    public class ObservableConsulConfiguration
    {
        public string Endpoint { get; set; }
        public string Datacenter { get; set; }
        public string GossipToken { get; set; }
        public string AclToken { get; set; }
        public TimeSpan? LongPollMaxWait { get; set; }
    }
}