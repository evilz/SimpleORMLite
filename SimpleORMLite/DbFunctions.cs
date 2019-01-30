using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;

namespace SimpleORMLite
{
    public class DbFunctions
    {
        private readonly OrmLiteConnectionFactory _dbFactory;

        public DbFunctions(OrmLiteConnectionFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }
        public async Task<MyTable> GetById(int id)
        {

            using (var db = _dbFactory.Open())
            {
                if (db.CreateTableIfNotExists<MyTable>())
                {
                    db.Insert(new MyTable { Id = 1, ValueOne = "Seed Data", ValueTwo = 10.255m });
                }

                var result = await db.SingleAsync<MyTable>(1);
                return result;
            }
        }
      
    }
}
