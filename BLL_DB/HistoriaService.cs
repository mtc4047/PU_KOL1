using BLL.DTOModels;
using BLL.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DB
{
    public class HistoriaService : IHistoriaService
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PU_KOL1;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public  ICollection<HistoriaResponseDTO> getHistoria(int strona, int iloscNaStronie)
        {
            var historiaList = new List<HistoriaResponseDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetHistoria", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Strona", strona);
                command.Parameters.AddWithValue("@IloscNaStronie", iloscNaStronie);

                connection.Open();
                using (SqlDataReader reader =command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        historiaList.Add(new HistoriaResponseDTO
                        {
                            Id = reader.GetInt32(0),
                            Imie = reader.GetString(1),
                            Nazwisko = reader.GetString(2),
                            TypAkcji = reader.GetBoolean(3),
                            Data = reader.GetDateTime(4),
                            GrupaNazwa = reader.GetString(5)
                        });
                    }
                }
            }

            return historiaList;
        }
    }
}
