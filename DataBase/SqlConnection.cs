using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam.DataBase
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {

        }
        public override void Close()
        {
            Console.WriteLine("SqlConnection is Clossed");
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection is Opened");
        }
    }
}
