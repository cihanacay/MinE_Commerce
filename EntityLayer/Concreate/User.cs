using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        public string Name { get; set; }
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
