using io_sdk_csharp_dotnet;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_sdk_csharp_dotnet_test
{
    public class ImportTests
    {
        [Test]
        public void should_return_error_message()
        {
            // lasciare la connection string errata
            var data = Repository.GetMessages("server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;");

            Assert.IsNotNull(data, "Data deve essere valorizzato");
            Assert.IsNull(data.Messages, "I Messaggi non devono essere presenti");
            Assert.IsNotNull(data.Error, "Data.Error deve essere valorizzato");
        }

        [Test]
        public void should_return_messages() 
        {
            // correggere la connectionstring con i valori corretti del tuo database
            var data = Repository.GetMessages("server=<your_bdHost>;user id=<your_bdUser>;password=<your_dbPass>;database=<your_dbName>;");

            Assert.IsNotNull(data, "Data deve essere valorizzato");
            Assert.IsNull(data.Error, $"Data.Error deve essere Null: {data.Error}");
            Assert.IsNotNull(data.Messages, "I Messaggi devono essere presenti");
            Assert.IsTrue(data.Messages.Count > 0, "I Messaggi devono essere presenti");
        }
    }
}
