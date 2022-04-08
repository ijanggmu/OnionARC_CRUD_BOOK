using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Data
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<BookList> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name);
            entityBuilder.Property(t => t.Author);
            entityBuilder.Property(t => t.ISBN);
        }
    }
}
