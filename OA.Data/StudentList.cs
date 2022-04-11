using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class StudentList:BaseEntity
    {
        public string SName { get; set; }
        public string Course { get; set; }
        public virtual BookList BookList { get; set; }
    }
}
