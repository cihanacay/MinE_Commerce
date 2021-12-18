using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Adı")]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        public string Description { get; set; }
        [Display(Name = "Fiyatı")]
        [Required(ErrorMessage = "Boş Geçilemez!")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public bool Deleted { get; set; }
        public virtual Category Category { get; set; }


    }
}
