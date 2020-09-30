using System.Collections.Generic;

namespace Ziggeo
{
    public class LogModel
    {
        public long Timestamp { get; }
        public string Name { get; }
        public string Details { get; }

        public LogModel(long timestamp, string name, string details = null)
        {
            Timestamp = timestamp;
            Name = name;
            Details = details;
        }
    }
}