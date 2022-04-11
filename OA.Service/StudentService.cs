using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    
    public class StudentService:IStudentService
    {
        private IRepository<StudentList> _studentRepository;
        public StudentService(IRepository<StudentList> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IEnumerable<StudentList> GetStudents( )
        {
            return _studentRepository.GetAll();
        }
        public StudentList GetStudent(int id)
        {
            return _studentRepository.Get(id);
        }
        public void InsertStudent(StudentList student)
        {
            _studentRepository.Insert(student);
        }
        public void UpdateStudent(StudentList student)
        {
            _studentRepository.Update(student);
        }
        public void DeleteStudent(int id)
        {
            StudentList student = GetStudent(id); 
            _studentRepository.Remove(student);
        }

        public IEnumerable<StudentList> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
