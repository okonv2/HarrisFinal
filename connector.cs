using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarrisFinal.Menu
namespace HarrisFinal
{
    public class connector
    {

        private string connString = "Server=harrisdb.cjyeedaiabwt.us-east-1.rds.amazonaws.com;User ID=admin;Password=;Mally419;Database=harrisdb";
        public List<students> GetStudents()
        {
            List<students> student = new List<Customer>();
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();

                using (var cmd= new MySqlCommand()"CALL sp_getStudents()",conn)
                    using (var reader = cmd.ExecuteReader())
            }
        }
    }
}
