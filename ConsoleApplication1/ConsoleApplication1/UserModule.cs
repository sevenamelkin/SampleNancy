using System;
using Nancy;

namespace ConsoleApplication1
{
    public sealed class UserModule : NancyModule
    {
        public UserModule()
        {
            Post("/GetSnapshot", x =>
            {
                return new AdapterTagValueDto
                {
                    Value = "GetSnapshot",
                    Quality = "awesome virtual",
                    Timestamp = DateTime.Now
                };
            });
            //Post("/GetArchive", x => { return GetArchive(); });
            Post("/GetArchive", x =>
            {
                return new AdapterTagValueDto
                {
                    Value = "GetArchive",
                    Quality = "awesome virtual",
                    Timestamp = DateTime.Now
                };
            });
        }

        public AdapterTagValueDto GetSnapshot()
        {
            return new AdapterTagValueDto
            {
                Value = "GetSnapshot",
                Quality = "awesome virtual",
                Timestamp = DateTime.Now
            };
        }

        public AdapterTagValueDto GetArchive()
        {
            return new AdapterTagValueDto
            {
                Value = "GetArchive",
                Quality = "awesome virtual",
                Timestamp = DateTime.Now
            };
        }
    }

    public class AdapterTagValueDto
    {
        public string Value { get; set; }

        public string Quality { get; set; }

        public DateTime Timestamp { get; set; }
    }
}