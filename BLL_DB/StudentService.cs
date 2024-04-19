using BLL.DTOModels;
using BLL.ServiceInterfaces;
using System.Data;
using System.Data.SqlClient;

namespace BLL_DB
{
    public class StudentService : IStudentService
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PU_KOL1;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
        public void AddStudent(StudentRequestDTO student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AddStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", student.Imie);
                command.Parameters.AddWithValue("@Price", student.Nazwisko);
                command.Parameters.AddWithValue("@GroupId", student.IdGrupy);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<StudentResponseDTO> GetStudents()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(int id, StudentRequestDTO student)
        {
            throw new NotImplementedException();
        }
    }
}
