using Newtonsoft.Json;

namespace Tier3Slit.Communication
{
    public class Message
    {
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Fields Fields { get; set; }

        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        public Message(Fields Fields, string Method, string Resource)
        {
            this.Fields = Fields;
            this.Method = Method;
            this.Resource = Resource;
        }

        public Message(string Resource, string Method, int ResponseCode, string Description)
        {
            Fields = new Fields();
            this.Resource = Resource;
            this.Method = Method;
            Fields.ResponseCode = ResponseCode;
            Fields.ResponseDescription = Description;
        }

        public Message()
        {
        }
    }
}