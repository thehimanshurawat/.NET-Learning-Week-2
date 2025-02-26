using StudentManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Age = 20, Class = "10th Grade" },
            new Student { Id = 2, Name = "Jane Doe", Age = 22, Class = "12th Grade" }
        };

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await Task.FromResult(_students);
        }

        public async Task<Student> GetStudentById(int id)
        {
            return await Task.FromResult(_students.FirstOrDefault(s => s.Id == id));
        }

        public async Task<Student> AddStudent(Student student)
        {
            student.Id = _students.Max(s => s.Id) + 1;
            _students.Add(student);
            return await Task.FromResult(student);
        }

        public async Task<Student> UpdateStudent(Student student)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Class = student.Class;
            }
            return await Task.FromResult(existingStudent);
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _students.Remove(student);
                return await Task.FromResult(true);
            }
            return await Task.FromResult(false);
        }
    }
}
