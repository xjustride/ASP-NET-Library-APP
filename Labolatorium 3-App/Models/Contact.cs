using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Labolatorium_3_App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int id { get; set; }
        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        [StringLength(maximumLength: 50, ErrorMessage = "Zbyt długię imię, max 50 znaków!")]
        public string? Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Musisz podać adres email!")]
        [Display(Name = "Adres e-mail")]
        public string? Email { get; set; }
        [Display(Name = "Numer telefonu")]
        public string? Phone { get; set; } //? pole opcjonalne (?) nullable
        [Display(Name = "Data urodzenia")]
        public DateTime? Birth { get; set; } //? pole opcjonalne (?) nullable
        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
        public int? OrganizationId {get; set;}
        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
        
    }
}
