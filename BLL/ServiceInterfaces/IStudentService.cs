using BLL.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IStudentService
    {
        public void AddStudent(StudentRequestDTO student);
        public void UpdateStudent(int id,StudentRequestDTO student);
        public void DeleteStudent(int id);
        public ICollection<StudentResponseDTO> GetStudents();
    }
}
