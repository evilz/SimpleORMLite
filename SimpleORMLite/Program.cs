using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using ServiceStack.Text;

namespace SimpleORMLite
{
    class Program
    {
        private const string CONNECTION_STRING =
            "Server=SH-PA-DSK-012\\SQLEXPRESS;Database=TrucDeFou;Trusted_Connection=True;";
        static void Main(string[] args)
        {
            var dbFactory = new OrmLiteConnectionFactory(
                CONNECTION_STRING,
                SqlServerDialect.Provider);

            var repo = new  DbFunctions(dbFactory);

            var result = repo.GetById(1).GetAwaiter().GetResult();

            Console.WriteLine($"{result.Id} - {result.ValueOne} -{result.ValueTwo}");

        }
    }
}
