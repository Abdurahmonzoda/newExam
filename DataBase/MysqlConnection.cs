using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.DataBase
{
    public class MysqlConnection : DbConnection
    {
        public MysqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {

        }
        public override void Close()
        {
            Console.WriteLine("MysqlConnection is Closed");
        }

        public override void Open()
        {
            Console.WriteLine("MysqlConnection is Closed");
        }
    }
}
