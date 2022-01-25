using System.ComponentModel.DataAnnotations;

namespace BlazorTestServerAppProject.Data
{
    public class JobApplication
    {
        [Required]
        public string FullName { get; set; }
        [StringLength(500,ErrorMessage="you can not put so many words here")]
        public string Description { get; set; }
        [Required]
        [Range(1000000,50000000,ErrorMessage ="select salary between one million to 50 millions")]
        public int SalaryExpectation { get; set; }
        [Required]
        public bool DoesOpenSource { get; set; }
        [Required]
        public DateTime Availability { get; set; }  



    }
}
