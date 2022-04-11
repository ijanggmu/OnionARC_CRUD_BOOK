using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public interface IStudentService
    {
        IEnumerable<StudentList> GetStudents();
        StudentList GetStudent(int id);
        void InsertStudent(StudentList student);
        
        void UpdateStudent(StudentList student);
        void DeleteStudent(int id);
    }
}
