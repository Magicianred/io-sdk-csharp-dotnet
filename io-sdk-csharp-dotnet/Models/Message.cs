using Newtonsoft.Json;
using System;

namespace io_sdk_csharp_dotnet.Models
{
    public class Message
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }

        [JsonProperty("fiscal_code")]
        public string FiscalCode { get; set; }

        [JsonProperty("invalid_after_due_date")]
        public int InvalidAfterDueDate { get; set; }

        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("notice_number")]
        public int NoticeNumber { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }
}
