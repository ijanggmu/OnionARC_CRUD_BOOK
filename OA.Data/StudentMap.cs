using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class StudentMap
    {
        public StudentMap(EntityTypeBuilder<StudentList> entityBuilder)
        {
            entityBuilder.Property(t => t.SName);
            entityBuilder.Property(t => t.Course);
        }
    }
}
