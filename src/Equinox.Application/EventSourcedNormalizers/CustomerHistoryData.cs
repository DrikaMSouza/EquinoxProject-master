namespace Equinox.Application.EventSourcedNormalizers
{
    public class CustomerHistoryData
    {
        public string Action { get; set; }
        public string Id { get; set; }
        public string NameModel { get; set; }
        public int ModelYear { get; set; }
        public int ManifacturingYear { get; set; }
        public string Timestamp { get; set; }
        public string Who { get; set; }
    }
}