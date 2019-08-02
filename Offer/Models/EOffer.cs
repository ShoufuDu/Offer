using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Offer.Models
{
    public class EOffer
    {
        [BindNever]
        public int Id { get; set; }
        [Required]
        public int CountrId { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Fullname { get; set; }
    }
}
