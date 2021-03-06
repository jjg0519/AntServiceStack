namespace AntServiceStack.Common.Consul.Dtos
{

    //[Route("/discovery/registration")]
    //[Exclude(Feature.Metadata | Feature.ServiceDiscovery)]
    public class ServiceRegistration 
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Address { get; set; }
        public string[] Tags { get; set; }
        public decimal Version { get; set; }
        public ServiceHealthCheck[] HealthChecks { get; set; }
        public int? Port { get; set; }
    }

    public class ServiceHealthCheck
    {
        public string Id { get; set; }
        public string ServiceId { get; set; }
        public int IntervalInSeconds { get; set; }
        public string Http { get; set; }
        public string Tcp { get; set; }
        public string Notes { get; set; }
        public int? DeregisterCriticalServiceAfterInMinutes { get; set; }
    }
}