using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace FormUI
{
   public  class DataAccess
    {

        public List<Door> GetDoor(string Matcod)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
              var output = connection.Query<Door>($"select * from LOGINVENTORY where MATCOD = '{ Matcod }'").ToList();
              return output;
            }
        }
    }
}
