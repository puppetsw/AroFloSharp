using System;

namespace AroFloSharp.Client
{
    public class AroFloSharpOptions
    {
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(1);
        public string SecretKey { get; set; }
        public string UEncode { get; set; }
        public string PEncode { get; set; }
        public string OrgEncode { get; set; }
    }
}
