using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io_sdk_csharp_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = (args != null && args.Length > 0) ? args[0] : null;

            string jsonString = Import.Process(connectionString);

            Console.WriteLine(jsonString);
        }
    }
}
