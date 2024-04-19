using BLL.DTOModels;
using BLL.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BLL_DB
{
    public class GrupaService : IGrupaService
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PU_KOL1;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public string getFullGrupaName(int id)
        {
            string fullName = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetPaginatedHistoria", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    fullName = reader.GetString(0);
                }
            }

            return fullName;
        }
    }
}
