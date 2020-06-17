using Newtonsoft.Json;
using System;

namespace io_sdk_csharp_dotnet
{
    public static class Import
    {
        public static string Process(string connectionString)
        {
            string jsonString = String.Empty;

            var config = Config.getData();

            if (!String.IsNullOrWhiteSpace(connectionString))
            {
                var data = Repository.GetMessages(connectionString);

                if (String.IsNullOrWhiteSpace(data.Error))
                {
                    jsonString = JsonConvert.SerializeObject(data.Messages);
                }
                else
                {
                    jsonString = JsonConvert.SerializeObject(data.Error);
                }
                jsonString = "{ \"body\": { \"data\": " + jsonString + " } } ";

            }
            else
            {
                jsonString = Config.getJson();
            }
            return jsonString;
        }
    }
}
