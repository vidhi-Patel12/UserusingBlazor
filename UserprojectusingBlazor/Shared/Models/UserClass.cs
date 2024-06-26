using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserprojectusingBlazor.Shared.Models
{
    public class UserClass
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password should be minimum 3 characters and a maximum of 100 characters")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string? Address { get; set; }
        [Required(ErrorMessage = "Contact is required")]
        [Range(1000000000, 9999999999, ErrorMessage = "Contact should be a 10-digit number")]
        public Int64? Contact { get; set; }
    }
}
