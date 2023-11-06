using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Labolatorium_3_App.Models
{
    public enum BookStatus
    {
        [Display(Name = "Niedostępna")] Low = 1,
        [Display(Name = "Na wyczerpaniu")] Normal = 2,
        [Display(Name = "Dostępna")] High = 3,
    }
}
