using BLL.DTOModels;
using BLL.ServiceInterfaces;
using DAL;
using Model;
namespace BLL_EF
{
    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _context;

        public StudentService(DatabaseContext context)
        {
            _context = context;
        }
        public void AddStudent(StudentRequestDTO student)
        {
            _context.Studenci.Add(new Student()
            {
                Imie = student.Imie,
                Nazwisko = student.Nazwisko,
                IdGrupy = student.IdGrupy
            });
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
