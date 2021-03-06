using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BL.ModelViews
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int CarId { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Birth Date is required")]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
