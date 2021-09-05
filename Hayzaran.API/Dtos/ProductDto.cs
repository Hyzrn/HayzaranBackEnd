using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hayzaran.API.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage = "{0} alanı geçerli bir sayı olmaldır.")]
        public int Stock { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "{0} alanı geçerli bir sayı olmaldır.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
