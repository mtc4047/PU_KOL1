using BLL.DTOModels;
using BLL.ServiceInterfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
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
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Studenci.Single<Student>(x => x.Id == id);
            _context.Studenci.Remove(student);
            _context.SaveChanges();
        }

        public ICollection<StudentResponseDTO> GetStudents()
        {
            var studentsResponse = new List<StudentResponseDTO>();
            foreach(var student in _context.Studenci.Include(x => x.Grupa))
            {
                studentsResponse.Add(new StudentResponseDTO
                {
                    Id = student.Id,
                    Imie = student.Imie,
                    Nazwisko = student.Nazwisko,
                    NazwaGrupy = student.Grupa.Nazwa
                });
            }
            return studentsResponse;
        }

        public void UpdateStudent(int id, StudentRequestDTO student)
        {
            var studentToUpdate = _context.Studenci.Single<Student>(x => x.Id == id);
            studentToUpdate.Imie = student.Imie;
            studentToUpdate.Nazwisko = student.Nazwisko;
            studentToUpdate.IdGrupy = student.IdGrupy;
            _context.SaveChanges();

        }
    }
}
