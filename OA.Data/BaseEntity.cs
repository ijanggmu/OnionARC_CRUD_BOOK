using System;
using System.ComponentModel.DataAnnotations;

namespace OA.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
