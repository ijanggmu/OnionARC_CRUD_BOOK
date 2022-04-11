using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OA.Web.Models
{
    public class StudentViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [Display(Name ="StudentName")]
        public string SName { get; set; }
        public string Course { get; set; }

    }
}
