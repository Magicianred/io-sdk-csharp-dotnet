using io_sdk_csharp_dotnet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace io_sdk_csharp_dotnet
{
    public static class Config
    {
        public static Form getData()
        {
            var data = new Form();
            data.Fields = new List<Field>() {
                new Field() {
                    Type = "message",
                    Name = "note",
                    Description = "Connect to SQLServer db to import messages"
                },
                new Field() {
                    Type = "string",
                    Name = "ConnectionString",
                    Description = "Connection string to SQLServer db",
                    Required = true,
                }
            };
            return data;
        }

        public static string getJson()
        {
            var data = Config.getData();

            var jsonString = JsonConvert.SerializeObject(data.Fields);
            jsonString = "{ \"form\": " + jsonString + " } ";
            Console.WriteLine(jsonString);
            return jsonString;
        }
    }
}
